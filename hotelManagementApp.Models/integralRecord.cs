using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity
{
    /// <summary>
    /// 积分记录信息
    /// </summary>
    [Table("integralRecord")]
    [PrimaryKey("integralId", autoIncrement = true)]
    public class integralRecord
    {
        public int integralId {  get; set; }
        public string cardNo {  get; set; }
        public string integralName {  get; set; }
        public int integralValue {  get; set; }
        public DateTime integralTime { get; set; }
    }
}
