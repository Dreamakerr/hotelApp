using common;
using hotelManagementApp.DAL.Base;
using hotelManagementApp.DAL.Helper;
using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
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
    }
}
