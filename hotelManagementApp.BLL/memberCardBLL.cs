using hotelManagementApp.DAL;
using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.BLL
{
    public class memberCardBLL
    {
        memberCardDAL memberCardDAL = new memberCardDAL();

        /// <summary>
        /// 获取指定的会员卡信息
        /// </summary>
        /// <param name="cardNo">会员卡号</param>
        /// <returns></returns>
        public memberCard GetMemberCard(string cardNo)
        {
            return memberCardDAL.GetMemberCard(cardNo);
        }
    }
}
