using hotelManagementApp.DAL;
using hotelManagementApp.DAL.Base;
using hotelManagementApp.DAL.Helper;
using hotelManagementApp.Models;
using hotelManagementApp.Models.UIModels;
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
        viewMemberIntegralDAL vMemberIntegralDAL = new viewMemberIntegralDAL();

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
                    integralValue = -dicInteList[cardNo]
                };
                inteList.Add(inteInfo);
            }
            if (inteList.Count > 0)
            {
                return memberIntegralDAL.clearCardIntegralValue(inteList);

            }
            else return false;

        }

        /// <summary>
        /// 积分兑换
        /// </summary>
        /// <param name="inteInfo"></param>
        /// <returns></returns>
        public bool integralExchange(integralRecord inteInfo)
        {
            if (inteInfo != null)
            {
                return memberIntegralDAL.integralExchange(inteInfo);

            }
            else return false;
        }

        /// <summary>
        /// 积分统计
        /// </summary>
        /// <returns></returns>
        public memberIntegralStat statisticsIntegralData()
        {
            memberIntegralStat statInfo = new memberIntegralStat();
            statInfo.integralList = vMemberIntegralDAL.getAllMemberIntegralList();//获取积分列表
            if(statInfo.integralList.Count > 0)
            {
                var inteList = statInfo.integralList;
                statInfo.maxIntegralVal = inteList.Max(i => i.integralValue);
                statInfo.minIntegralVal = inteList.Min(i => i.integralValue);
                statInfo.maxTotalIntegralValue = inteList.Max(i => i.integralTotal);
                statInfo.minTotalIntegralValue = inteList.Min(i => i.integralTotal);
            }
            return statInfo;
        }
    }
}
