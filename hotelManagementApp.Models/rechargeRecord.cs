using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity
{
    /// <summary>
    /// 充值记录信息
    /// </summary>
    [Table("rechargeRecord")]
    [PrimaryKey("recordId", autoIncrement = true)]
    public class rechargeRecord
    {
        public int recordId {  get; set; }
        public string cardNo {  get; set; }
        public decimal rechargeAmount {  get; set; }
        public DateTime rechargeTime { get; set; }

    }
}
