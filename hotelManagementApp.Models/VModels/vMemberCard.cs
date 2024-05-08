using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.Models.VModels
{
    /// <summary>
    /// 视图view_MemberCard实体类
    /// </summary>
    [Table("view_MemberCard")]
    [PrimaryKey("mCardId")]
    public class vMemberCard:memberCard
    {
        public int memberId {  get; set; }
        public string mName { get; set; }
        public string cTypeName {  get; set; }
    }
}
