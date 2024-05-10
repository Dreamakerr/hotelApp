using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.utility
{
    /// <summary>
    /// 积分刷新事件参数：积分
    /// </summary>
    public class integralRefreshEventArgs:EventArgs
    {
        //兑换积分值
        public int integralValue {  get; set; }
        public integralRefreshEventArgs(int IntegralValue)
        {
            integralValue = IntegralValue;
        }
    }
}
