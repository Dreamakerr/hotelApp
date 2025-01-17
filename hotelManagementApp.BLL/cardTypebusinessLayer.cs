﻿using hotelManagementApp.dataLayer;
using hotelManagementApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.businessLayer
{
    public class cardTypebusinessLayer
    {

        CardTypedataLayer cardTypeDAL = new CardTypedataLayer();
        memberCarddataLayer memberCardDAL = new memberCarddataLayer();

        /// <summary>
        /// 获取所有会员卡类型列表
        /// </summary>
        /// <returns></returns>
        public List<cardType> getAllCardTypeList()
        {
            return cardTypeDAL.GetAllModelList("", "", 0);
        }

        /// <summary>
        /// 获取指定的类别信息
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public cardType getCardType(int id)
        {
            return cardTypeDAL.GetById(id, "");
        }

        /// <summary>
        /// 添加会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        /// <returns></returns>
        public int addCardType(cardType cardType)
        {
            return cardTypeDAL.addCardTypeInfo(cardType);
        }

        /// <summary>
        /// 修改会员卡类型
        /// </summary>
        /// <param name="cardType"></param>
        /// <returns></returns>
        public bool editCardType(cardType cardType)
        {
            return cardTypeDAL.Update(cardType, "");
        }

        /// <summary>
        /// 判断会员卡类型是否已存在
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public bool existCardType(string typeName)
        {
            return cardTypeDAL.existCardType(typeName);
        }

        /// <summary>
        /// 删除指定会员卡类型
        /// </summary>
        /// <param name="typeIds"></param>
        /// <returns></returns>
        public bool deleteCardTypes(List<int> typeIds)
        {
            return cardTypeDAL.deleteCardTypes(typeIds);
        }

        /// <summary>
        /// 判断指定类型下是否已有会员卡
        /// </summary>
        /// <param name="typeId"></param>
        /// <returns></returns>
        public bool hasMemberCards(int typeId)
        {
            int count = memberCardDAL.getMemberCardsByType(typeId);
            return count > 0;
        }
    }
}
