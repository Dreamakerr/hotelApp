using hotelManagementApp.DAL.Base;
using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL
{
    /// <summary>
    /// 用户信息数据访问类
    /// </summary>
    public class userDAL:BaseDAL<user>
    {
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
            string strWhere = "userName=@username and password=@password and isDeleted=0";
            SqlParameter[] paras =
            {
                new SqlParameter("@username", username),
                new SqlParameter("@password", password)
            };
            return Exists(strWhere, paras);
        }
    }
}
