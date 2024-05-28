using hotelManagementApp.dataLayer.Base;
using hotelManagementApp.entity.Ventity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer
{
    /// <summary>
    /// vMemberCard的数据访问类
    /// </summary>
    public class viewMemberCarddataLayer:BQuery<vMemberCard>
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
                strWhere += " and (cardNo like @keywords or mName like @keywords)";
            if (cTypeId > 0)
                strWhere += " and cTypeId=" + cTypeId;
            if (cardState >= 0 && cardState <= 2)
                strWhere += " and cardState=" + cardState;
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            return GetModelList(strWhere, "", "", para);
        }

        /// <summary>
        /// 条件查询会员卡积分列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="stInteVal"></param>
        /// <param name="etInteVal"></param>
        /// <returns></returns>
        public List<vMemberCard> findMemberIntegralList(string keywords, int stInteVal, int etInteVal)
        {
            string strWhere = $"isDeleted=0";
            if (!string.IsNullOrEmpty(keywords))
                strWhere += " and (cardNo like @keywords or mName like @keywords)";
            if (stInteVal > 0)
                strWhere += " and integralValue >=" + stInteVal;
            if (etInteVal >  0)
                strWhere += " and integralValue<=" + etInteVal;
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            return GetModelList(strWhere, "mCardId,cardNo,mName,integralValue,cardState", "", para);
        }

    }
}
