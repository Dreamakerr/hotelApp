using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity
{
    /// <summary>
    /// 会员信息
    /// </summary>
    [Table("member")]
    [PrimaryKey("memberId", autoIncrement = true)]
    public class member
    {
        public int memberId { get; set; }
        public string cardNo { get; set; }
        public string mName {  get; set; }
        public string sex {  get; set; }
        public string phone { get; set; }
        public bool isNew { get; set; }
        public DateTime createTime { get; set; }
        public string remark {  get; set; }

    }
}
