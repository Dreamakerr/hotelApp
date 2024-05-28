using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity.Ventity
{
    /// <summary>
    /// 视图view_MemberIntegral的实体类
    /// </summary>
    [Table("view_MemberIntegral")]
    [PrimaryKey("mCardId")]
    public class vMemberIntegral
    {
        public int mCardId {  get; set; }
        public string cardNo { get; set; }
        public string mName {  get; set; }
        public int integralValue {  get; set; }
        public int integralTotal { get; set; }
        public int usedIntegral {  get; set; }


    }
}
