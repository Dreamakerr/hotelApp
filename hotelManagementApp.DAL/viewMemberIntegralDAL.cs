using hotelManagementApp.DAL.Base;
using hotelManagementApp.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL
{
    public class viewMemberIntegralDAL:BQuery<vMemberIntegral>
    {
        /// <summary>
        /// 查询所有会员的积分列表
        /// </summary>
        /// <returns></returns>
        public List<vMemberIntegral> getAllMemberIntegralList()
        {
            return GetModelList("", "", "");
        }
    }
}
