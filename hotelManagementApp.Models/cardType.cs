using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.entity
{
    /// <summary>
    /// 会员卡类型实体类
    /// </summary>
    [Table("cardType")]
    [PrimaryKey("cTypeId", autoIncrement = true)]
    public class cardType
    {
        public int cTypeId {  get; set; }
        public string cTypeName { get; set; }
        public int discount { get; set; }
        public int giveIntegral { get; set; }
        public string remark {  get; set; }
       
    }
}
