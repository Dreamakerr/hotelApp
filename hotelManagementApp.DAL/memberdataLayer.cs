using hotelManagementApp.dataLayer.Base;
using hotelManagementApp.dataLayer.Helper;
using hotelManagementApp.entity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer
{
    public class memberdataLayer: BasedataLayer<member>
    {
        /// <summary>
        /// 关键词查询会员信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public List<member> findMemberList(string keywords, int isDeleted)
        {
            string strWhere = $"isDeleted={isDeleted}";
            if(!string.IsNullOrEmpty(keywords))
            {
                strWhere += " and(cardNo like @keywords or mName like @keywords or phone like @keywords)";
            }
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            return GetModelList(strWhere, "", "", para);
        }

        /// <summary>
        /// 添加会员信息
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public int addMember(member member)
        {
            //列字符串
            string cols = CreateSql.GetColNames<member>("memberId");
            return Add(member, cols, 1);
        }

        /// <summary>
        /// 修改会员信息
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public bool editMember(member member)
        {
            //列字符串
            string cols = CreateSql.GetColNames<member>("createTime");
            return Update(member, cols);
        }

        /// <summary>
        /// 判断会员是否已存在
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool existMember(string mName, string phone)
        {
            string strWhere = "isDeleted=0 and mName=@mName and phone=@phone";
            SqlParameter[] paras =
            {
                new SqlParameter("@mName", mName),
                new SqlParameter("@phone", phone)
            };
            return Exists(strWhere, paras);
        }

        /// <summary>
        /// 会员信息删除（一个或多个）会员、会员卡、积分信息、消费信息、充值信息一起处理
        /// </summary>
        /// <param name="memberIds"></param>
        /// <param name="delType"></param>
        /// <param name="isDeleted"></param>
        /// <returns></returns>
        public bool deleteMemberList(List<int> memberIds, int delType, int isDeleted)
        {
            List<string> sqlList = new List<string>();
            foreach(int id in memberIds)
            {
                if(delType == 0)
                {
                    sqlList.Add($"update member set isDeleted={isDeleted} where memberId={id}");
                    string strWhere = $"cardNo=(select cardNo from member where isDeleted=0 and memberId={id})";//子查询
                    sqlList.Add($"update memberCard set isDeleted={isDeleted} where {strWhere}");
                    sqlList.Add($"update rechargeRecord set isDeleted={isDeleted} where {strWhere}");
                    sqlList.Add($"update integralRecord set isDeleted={isDeleted} where {strWhere}");
                    sqlList.Add($"update expendRecord set isDeleted={isDeleted} where {strWhere}");
                }
                else
                {
                    sqlList.Add($"delete from member where memberId={id}");
                    string strWhere = $"cardNo=(select cardNo from member where isDeleted=0 and memberId={id})";//子查询
                    sqlList.Add($"delete from memberCard where {strWhere}");
                    sqlList.Add($"delete from rechargeRecord where {strWhere}");
                    sqlList.Add($"delete from integralRecord where {strWhere}");
                    sqlList.Add($"delete from expendRecord where {strWhere}");
                }
            }
            return sqlHelper.ExecuteTrans(sqlList);
        }
    }
}
