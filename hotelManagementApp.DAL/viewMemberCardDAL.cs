using hotelManagementApp.DAL.Base;
using hotelManagementApp.Models.VModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL
{
    /// <summary>
    /// vMemberCard的数据访问类
    /// </summary>
    public class viewMemberCardDAL:BQuery<vMemberCard>
    {
        /// <summary>
        /// 条件查询会员卡列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="cTypeId"></param>
        /// <param name="cardState"></param>
        /// <returns></returns>
        public List<vMemberCard> findMemberCardList(string keywords, int cTypeId, int cardState)
        {
            string strWhere = $"isDeleted=0";
            if (!string.IsNullOrEmpty(keywords))
                keywords += " and (cardNo like @keywords or mName like @keywords)";
            if (cTypeId > 0)
                keywords += " and cTypeId=" + cTypeId;
            if (cardState >= 0 && cardState <= 2)
                strWhere += " and cardState=" + cardState;
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            return GetModelList(strWhere, "", "", para);
        }
    }
}
