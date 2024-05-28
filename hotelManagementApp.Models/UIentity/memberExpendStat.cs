using hotelManagementApp.entity.Ventity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity.UIentity
{
    /// <summary>
    /// 会员消费统计
    /// </summary>
    public class memberExpendStat
    {
        //会员本月消费记录
        public List<vExpendRecord> expendList {  get; set; }
        //本月总消费金额
        public decimal thisMonthTotalExpendAmount {  get; set; }
        //本月最高日消费
        public decimal thisMonthMaxDayAmount { get; set; }
        //本月最低日消费
        public decimal thisMonthMinDayAmount { get; set; }
        //本月平均日消费
        public decimal thisMonthAvgDayAmount { get; set; }
        //消费top会员
        public string superMemberName {  get; set; }


    }
}
