using common;
using hotelManagementApp.dataLayer.Base;
using hotelManagementApp.dataLayer.Helper;
using hotelManagementApp.entity;
using hotelManagementApp.entity.Ventity;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer
{
    public class memberCarddataLayer: BasedataLayer<memberCard>
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

        /// <summary>
        /// 会员卡激活 状态0->1
        /// </summary>
        /// <param name="cardId"></param>
        /// <returns></returns>
        public bool activateCard(int cardId)
        {
            string sql = $"update memberCard set cardState=1 where mCardId= {cardId}";
            return sqlHelper.ExecuteNonQuery(sql, 1) > 0; //1代表sql语句
        }

        /// <summary>
        /// 会员卡销卡
        /// </summary>
        /// <param name="cardInfo"></param>
        /// <returns></returns>
        public bool cancelCard(vMemberCard cardInfo)
        {
            List<commandInfo> comList = new List<commandInfo>();
            //更新会员卡状态、余额、积分
            string sqlUpdateCard = $"update memberCard set balance=0, cardState=2,integralValue=0 where mCardId={cardInfo.mCardId}";
            comList.Add(new commandInfo()
            {
                commandText = sqlUpdateCard,
                IsProc = false,//非存储过程
            });
            //逻辑删除会员
            string sqlUpdateMember = $"update member set isDeleted=1 where memberId={cardInfo.memberId}";
            comList.Add(new commandInfo()
            {
                commandText = sqlUpdateMember,
                IsProc = false,
            });
            //添加积分变动记录
            if(cardInfo.integralValue > 0)
            {
                int inteVal = -cardInfo.integralValue;
                integralRecord inteInfo = new integralRecord()
                {
                    cardNo = cardInfo.cardNo,
                    integralValue = inteVal,
                    integralName = "销卡清空积分"
                };
                string cols = "cardNo,integralValue,integralName";
                sqlModel inteModel = CreateSql.CreateInsertSql(inteInfo, cols, 0);
                comList.Add(new commandInfo()
                {
                    commandText = inteModel.Sql,
                    IsProc = false,
                    Paras=inteModel.Paras
                });
            }
            return sqlHelper.ExecuteTrans(comList);
        }

        /// <summary>
        /// 会员卡删除（物理删除）
        /// </summary>
        /// <param name="cardNos"></param>
        /// <returns></returns>
        public bool deleteMemberCards(List<string> cardNos)
        {
            List<string> sqlList = new List<string>();
            string strNos = string.Join(",", cardNos);//串联会员卡号
            sqlList.Add($"update member set isDeleted=1 where cardNo in ({strNos})");
            sqlList.Add($"delete from memberCard where cardNo in ({strNos})");
            sqlList.Add($"delete from rechargeRecord where cardNo in ({strNos})");
            sqlList.Add($"delete from integralRecord where cardNo in ({strNos})");
            sqlList.Add($"delete from expendRecord where cardNo in ({strNos})");
            return sqlHelper.ExecuteTrans(sqlList);
        }

        /// <summary>
        /// 会员卡充值
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool rechargeCard(string cardNo, decimal amount)
        {
            List<string> sqlList = new List<string>();
            //添加充值记录
            sqlList.Add($"insert into rechargeRecord (cardNo,rechargeAmount) values ('{cardNo}',{amount})");
            //插入积分记录
            int inteVal = (int)amount / 100;//积分值
            string inteName = "充值送积分";
            sqlList.Add($"insert into integralRecord (cardNo,integralName,integralValue) values ('{cardNo}','{inteName}','{inteVal}')");
            //更新会员卡的余额和积分
            sqlList.Add($"update memberCard set balance=balance+{amount},integralValue=integralValue+{inteVal} where cardNo={cardNo}");
            return sqlHelper.ExecuteTrans(sqlList);
        }
    }
}
