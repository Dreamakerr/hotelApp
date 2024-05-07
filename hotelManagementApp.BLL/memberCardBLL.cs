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

        /// <summary>
        /// 添加会员卡信息
        /// </summary>
        /// <param name="cardInfo"></param>
        /// <param name="inteInfo"></param>
        /// <returns></returns>
        /// <exception cref="Exception"></exception>
        public string addCardInfo(memberCard cardInfo, integralRecord inteInfo)
        {
            return memberCardDAL.addCardInfo(cardInfo, inteInfo);
        }

        /// <summary>
        /// 修改会员卡
        /// </summary>
        /// <param name="cardInfo"></param>
        /// <returns></returns>
        public bool editCardInfo(memberCard cardInfo)
        {
            return memberCardDAL.editCardInfo(cardInfo);
        }
    }
}
