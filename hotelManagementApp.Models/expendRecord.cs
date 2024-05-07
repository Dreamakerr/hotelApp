using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.Models
{
    /// <summary>
    /// 消费记录信息
    /// </summary>
    [Table("expendRecord")]
    [PrimaryKey("expendId", autoIncrement = true)]
    public class expendRecord
    {
        public int expendId {  get; set; }
        public string cardNo {  get; set; }
        public string roomNo {  get; set; }
        public decimal expendAmount {  get; set; }
        public decimal payAmount {  get; set; }
        public DateTime expendTime { get; set; }
    }
}
