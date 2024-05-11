using hotelManagementApp.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.Models.UIModels
{
    public class memberIntegralStat
    {
        //积分列表
        public List<vMemberIntegral> integralList { get; set; }
        //最高积分
        public int maxIntegralVal { get; set; }
        //最低积分
        public int minIntegralVal { get; set; }
        //最高总积分
        public int maxTotalIntegralValue { get; set; }
        //最低总积分
        public int minTotalIntegralValue { get;set; }


    }
}
