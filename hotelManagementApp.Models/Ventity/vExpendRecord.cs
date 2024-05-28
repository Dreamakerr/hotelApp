using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity.Ventity
{
    /// <summary>
    /// 视图view_ExpendRecord的实体类
    /// </summary>
    [Table("view_ExpendRecord")]
    [PrimaryKey("expendId")]
    public class vExpendRecord
    {
        public int expendId { get; set; }
        public string mName { get; set; }
        public string cardNo { get; set; }
        public string roomNo { get; set; }
        public decimal expendAmount { get; set; }
        public decimal payAmount { get; set; }
        public DateTime expendTime { get; set; }
    }
}
