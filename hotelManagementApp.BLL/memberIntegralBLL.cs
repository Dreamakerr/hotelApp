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
    public class memberIntegralBLL
    {
        viewMemberCardDAL vMemberDAL = new viewMemberCardDAL();
        memberIntegralDAL memberIntegralDAL = new memberIntegralDAL();

        /// <summary>
        /// 条件查询会员卡积分列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="stInteVal"></param>
        /// <param name="etInteVal"></param>
        /// <returns></returns>
        public List<vMemberCard> findMemberIntegralList(string keywords, int stInteVal, int etInteVal)
        {
            return vMemberDAL.findMemberIntegralList(keywords, stInteVal, etInteVal);
        }

        /// <summary>
        /// 清空会员卡积分（多个操作）
        /// </summary>
        /// <param name="dicInteList">会员卡号——积分信息键值对</param>
        /// <returns></returns>
        public bool clearCardIntegralValue(Dictionary<string, int> dicInteList)
        {
            List<integralRecord> inteList = new List<integralRecord>();
            foreach (string cardNo in dicInteList.Keys)
            {
                integralRecord inteInfo = new integralRecord()
                {
                    cardNo = cardNo,
                    integralName = "清空积分",
                    integralValue = dicInteList[cardNo]
                };
                inteList.Add(inteInfo);
            }
            if(inteList.Count > 0)
            {
                return memberIntegralDAL.clearCardIntegralValue(inteList);

            }
            else return false;

        }
}
