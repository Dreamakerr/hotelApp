using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.utility
{
    /// <summary>
    /// 会员卡修改后刷新事件参数类
    /// </summary>
    public class mCardEditEventArgs:EventArgs
    {
        public memberCard UpdateCardInfo { get; set; }
        public mCardEditEventArgs(memberCard updatedCardInfo)
        {
            UpdateCardInfo = updatedCardInfo;
        }

    }
}
