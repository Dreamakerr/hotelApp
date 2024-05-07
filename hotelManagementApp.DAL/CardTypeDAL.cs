using hotelManagementApp.DAL.Base;
using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL
{
    public class CardTypeDAL:BaseDAL<cardType>
    {
        /// <summary>
        /// 添加会员卡类型
        /// </summary>
        /// <param name="type"></param>
        /// <returns>生成的id值</returns>
        public int addCardTypeInfo(cardType type)
        {
            return Add(type, "cTypeName,remark", 1);
        }

        /// <summary>
        /// 判断类型名称是否存在
        /// </summary>
        /// <param name="typeName"></param>
        /// <returns></returns>
        public bool existCardType(string typeName)
        {
            return ExistsByName("cTypeName", typeName);
        }

        /// <summary>
        /// 批量删除多个类型信息（逻辑删除）
        /// </summary>
        /// <param name="typeIds"></param>
        /// <returns></returns>
        public bool deleteCardTypes(List<int> typeIds)
        {
            return DeleteList(typeIds, 0, 1);
        }


    }
}
