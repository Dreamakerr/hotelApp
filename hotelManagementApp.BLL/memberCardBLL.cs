using hotelManagementApp.DAL;
using hotelManagementApp.DAL.Base;
using hotelManagementApp.DAL.Helper;
using hotelManagementApp.Models;
using hotelManagementApp.Models.VModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.BLL
{
    public class memberCardBLL
    {
        memberCardDAL memberCardDAL = new memberCardDAL();
        viewMemberCardDAL viewMemberCardDAL = new viewMemberCardDAL();
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

        /// <summary>
        /// 条件查询会员卡列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="cTypeId"></param>
        /// <param name="cardState"></param>
        /// <returns></returns>
        public List<vMemberCard> findMemberCardList(string keywords, int cTypeId, string cardState)
        {
            int state = -1;
            switch (cardState)
            {
                case "已冻结":
                    state = 0;break;
                case "已激活":
                    state = 1; break;
                case "已销卡":
                    state = 2; break;
                default:
                    break;
            }
            return viewMemberCardDAL.findMemberCardList(keywords,cTypeId,state);
        }

        /// <summary>
        /// 会员卡激活 状态0->1
        /// </summary>
        /// <param name="cardId"></param>
        /// <returns></returns>
        public bool activateCard(int cardId)
        {
            return memberCardDAL.activateCard(cardId);
        }

        /// <summary>
        /// 会员卡销卡
        /// </summary>
        /// <param name="cardInfo"></param>
        /// <returns></returns>
        public bool cancelCard(vMemberCard cardInfo)
        {
           return memberCardDAL.cancelCard(cardInfo);
        }

        /// <summary>
        /// 会员卡删除（物理删除）
        /// </summary>
        /// <param name="cardNos"></param>
        /// <returns></returns>
        public bool deleteMemberCards(List<string> cardNos)
        {
            return memberCardDAL.deleteMemberCards(cardNos);
        }

        /// <summary>
        /// 会员卡充值
        /// </summary>
        /// <param name="cardNo"></param>
        /// <param name="amount"></param>
        /// <returns></returns>
        public bool rechargeCard(string cardNo, decimal amount)
        {
            return memberCardDAL.rechargeCard(cardNo, amount);
        }
    }
}
