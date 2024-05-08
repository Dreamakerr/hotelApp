using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.utility
{
    /// <summary>
    /// 会员卡余额刷新事件参数
    /// </summary>
    public class balanceRefreshEventArgs:EventArgs
    {
        //增加或减少的余额
        public decimal balance { get; set; }
        //积分
        public int integralValue {  get; set; }

        public balanceRefreshEventArgs(decimal Balance, int IntegralValue)
        {
            balance = Balance; 
            integralValue = IntegralValue;
        }

    }
}
