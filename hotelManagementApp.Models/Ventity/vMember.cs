using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity.Ventity
{
    /// <summary>
    /// 视图view_Member实体类
    /// </summary>
    [Table("view_Member")]
    [PrimaryKey("memberId")]
    public class vMember
    {
        public int memberId {  get; set; }
        public string mName { get; set; }
        public string cardNo { get; set; }
        public string sex { get; set; }
        public string phone { get; set; }
        public DateTime createTime { get; set; }
        public string cTypeName { get; set; }
    }
}
