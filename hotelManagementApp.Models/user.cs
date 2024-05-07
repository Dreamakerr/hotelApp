using common.CustAttributes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.Models
{

    /// <summary>
    /// 用户信息实体类
    /// </summary>
    [Table("users")]
    [PrimaryKey("userId", autoIncrement = true)]
    public class user
    {
        public int Id { get; set; }
        public string userName { get; set; }
        public string password { get; set; }

    }
}