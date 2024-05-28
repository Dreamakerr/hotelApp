using hotelManagementApp.dataLayer;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.businessLayer
{
    public class userbusinessLayer
    {
        private userdataLayer userDAL = new userdataLayer();
        /// <summary>
        /// 用户登录
        /// </summary>
        /// <param name="username"></param>
        /// <param name="password"></param>
        /// <returns></returns>
        public bool Login(string username, string password)
        {
           return userDAL.Login(username, password);
        }



    }
}
