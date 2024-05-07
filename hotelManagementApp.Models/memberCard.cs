using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.Models
{
    /// <summary>
    /// 会员卡信息
    /// </summary>
    [Table("memberCard")]
    [PrimaryKey("mCardId", autoIncrement = true)]
    public class memberCard
    {
        public int mCardId {  get; set; }
        public string cardNo {  get; set; }
        public decimal balance {  get; set; }
        public int cTypeId {  get; set; }
        public int discount {  get; set; }
        public int cardState {  get; set; }
        public DateTime createDate { get; set; }
        public int integralValue {  get; set; }

    }
}
