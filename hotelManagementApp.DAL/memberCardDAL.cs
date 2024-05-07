using common;
using hotelManagementApp.DAL.Base;
using hotelManagementApp.DAL.Helper;
using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL
{
    public class memberCardDAL:BaseDAL<memberCard>
    {
        /// <summary>
        /// 获取指定会员卡类型下已添加的会员卡数量
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public int getMemberCardsByType(int typeId)
        {
            string sql = "select count(1) from memberCard where isDeleted=0 and cTypeId=" + typeId;
            object oCount = sqlHelper.ExecuteScalar(sql, 1);
            if(oCount != null && oCount.ToString() != "")
            {
                return oCount.GetInt();
            }
            return 0;
        }

        /// <summary>
        /// 获取指定的会员卡信息
        /// </summary>
        /// <param name="cardNo">会员卡号</param>
        /// <returns></returns>
        public memberCard GetMemberCard(string cardNo)
        {
            string strWhere = $"cardNo='{cardNo}' and isDeleted=0";
            return GetModel(strWhere, "");
        }

        /// <summary>
        /// 添加会员卡信息
        /// </summary>
        /// <param name="cardInfo"></param>
        /// <param name="inteInfo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string addCardInfo(memberCard cardInfo, integralRecord inteInfo)
        {
            string cols = CreateSql.GetColNames<memberCard>("mCardId,createDate");
            //会员卡信息、积分信息
            return sqlHelper.ExecuteTrans<string>(cmd =>
            {
                string reCardNo = "";
                try
                {
                    cmd.CommandText = "createcardNo";
                    cmd.CommandType = CommandType.StoredProcedure;//执行存储过程
                    object oNo = cmd.ExecuteScalar();
                    if(oNo != null && oNo.ToString() != "")
                    {
                        reCardNo = oNo.ToString();
                        cardInfo.cardNo = reCardNo;//会员卡号
                        //入库会员卡信息
                        sqlModel cardModel = CreateSql.CreateInsertSql(cardInfo, cols, 0);
                        cmd.CommandText = cardModel.Sql;
                        cmd.CommandType = CommandType.Text;//sql语句
                        cmd.Parameters.Clear();
                        cmd.Parameters.AddRange(cardModel.Paras);
                        cmd.ExecuteNonQuery();
                        //添加积分记录
                        string inteCols = "cardNo,integralName,integralValue";
                        if(inteInfo != null)
                        {
                            inteInfo.cardNo = reCardNo;
                            sqlModel inteModel = CreateSql.CreateInsertSql(inteInfo, inteCols, 0);
                            cmd.CommandText = inteModel.Sql;
                            cmd.CommandType = CommandType.Text;//sql语句
                            cmd.Parameters.Clear();
                            cmd.Parameters.AddRange(inteModel.Paras);
                            cmd.ExecuteNonQuery();
                        }
                        cmd.Transaction.Commit();//提交事务
                    }
                }
                catch (Exception ex)
                {
                    cmd.Transaction.Rollback();//回滚
                    throw new Exception("添加会员卡执行事务出现异常！");
                }

                return reCardNo;
            });
        }

        /// <summary>
        /// 修改会员卡
        /// </summary>
        /// <param name="cardInfo"></param>
        /// <returns></returns>
        public bool editCardInfo(memberCard cardInfo)
        {
            string cols = CreateSql.GetColNames<memberCard>("cardNo,createDate");
            return Update(cardInfo, cols);
        }
    }
}
