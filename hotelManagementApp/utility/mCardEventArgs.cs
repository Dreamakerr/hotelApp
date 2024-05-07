using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.utility
{
    /// <summary>
    /// 会员卡添加后事件参数
    /// </summary>
    public class mCardEventArgs:EventArgs
    {
        /// <summary>
        /// 会员卡号
        /// </summary>
        public string cardNo {  get; set; }
        public mCardEventArgs(string CardNo)
        {
            cardNo = CardNo;
        }
    }
}
