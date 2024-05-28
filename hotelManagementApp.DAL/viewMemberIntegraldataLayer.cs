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
    public class viewMemberIntegraldataLayer:BQuery<vMemberIntegral>
    {
        /// <summary>
        /// 查询所有会员的积分列表
        /// </summary>
        /// <returns></returns>
        public List<vMemberIntegral> getAllMemberIntegralList()
        {
            return GetModelList("", "", "");
        }

        /// <summary>
        /// 查询具体会员积分消费信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public List<vMemberIntegral> statisticsMemberIntegralData(string keywords)
        {
            string strWhere = $"";
            if (!string.IsNullOrEmpty(keywords))
                strWhere += "cardNo like @keywords or mName like @keywords";
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            return GetModelList(strWhere, "", "", para);
        }

    }
}
