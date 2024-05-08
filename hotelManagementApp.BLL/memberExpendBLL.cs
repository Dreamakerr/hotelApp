using hotelManagementApp.DAL;
using hotelManagementApp.DAL.Base;
using hotelManagementApp.DAL.Helper;
using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.BLL
{
    public class memberExpendBLL
    {
        memberExpendDAL memberExpendDAL = new memberExpendDAL();

        /// <summary>
        /// 会员退房
        /// </summary>
        /// <param name="expendInfo"></param>
        /// <param name="integralInfo"></param>
        /// <returns></returns>
        public bool memberChechOut(expendRecord expendInfo, integralRecord inteInfo)
        {

            return memberExpendDAL.memberChechOut(expendInfo, inteInfo);
        }
    }
}
