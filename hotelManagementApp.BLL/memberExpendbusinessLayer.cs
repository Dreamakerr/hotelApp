using hotelManagementApp.dataLayer;
using hotelManagementApp.dataLayer.Base;
using hotelManagementApp.dataLayer.Helper;
using hotelManagementApp.entity;
using hotelManagementApp.entity.UIentity;
using hotelManagementApp.entity.Ventity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.businessLayer
{
    public class memberExpendbusinessLayer
    {
        memberExpenddataLayer memberExpendDAL = new memberExpenddataLayer();
        viewExpendRecorddataLayer viewExpendRecord = new viewExpendRecorddataLayer();

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

        /// <summary>
        /// 会员本月消费统计
        /// </summary>
        /// <returns></returns>
        public memberExpendStat statisticsThisMonthExpendData()
        {
            memberExpendStat statInfo = new memberExpendStat();
            statInfo.expendList = viewExpendRecord.getThisMonthExpendList();
            if(statInfo.expendList != null)
            {
                if (statInfo.expendList.Count > 0)
                {
                    var expendList = statInfo.expendList;
                    //本月消费总金额
                    statInfo.thisMonthTotalExpendAmount = expendList.Sum(r => r.expendAmount);
                    //筛选所有日期
                    List<string> listDates = expendList.Select(r => r.expendTime.ToString("yyyy-MM-dd")).Distinct().ToList();
                    //存储每天的消费总金额
                    List<decimal> listDatesAmount = new List<decimal>();
                    listDates.ForEach(d =>
                    {
                        decimal dayTotal = expendList.Where(r => r.expendTime.ToString("yyyy-MM-dd") == d).Sum(r => r.expendAmount);
                        listDatesAmount.Add(dayTotal);
                    });
                    statInfo.thisMonthMaxDayAmount = listDatesAmount.Max();//最高日消费金额
                    statInfo.thisMonthMinDayAmount = listDatesAmount.Min();//最低日消费金额
                    //当月天数
                    int days = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);
                    //当月的平均日消费
                    statInfo.thisMonthAvgDayAmount = statInfo.thisMonthTotalExpendAmount / days;
                    //最高消费会员
                    List<string> names = expendList.Select(r => r.mName+"-" + r.cardNo).Distinct().ToList();
                    //存储会员-总消费金额
                    Dictionary<string,decimal> dicList = new Dictionary<string, decimal>();
                    //统计每个会员的总消费金额
                    names.ForEach(name =>
                    {
                        decimal memberTotal = expendList.Where(r => r.mName + "-" + r.cardNo == name).Sum(r => r.expendAmount);
                        dicList.Add(name, memberTotal);
                    });
                    decimal max = dicList.Values.Max();//会员最高消费金额
                    int index = dicList.Values.ToList().IndexOf(max);//最高金额的索引
                    statInfo.superMemberName = dicList.Keys.ToList()[index].Split('-')[0];//最高消费会员名字
                }
            }
            return statInfo;
        }

        /// <summary>
        /// 查询具体会员消费信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public List<vExpendRecord> statisticsMemberExpendData(string keywords)
        {
            return viewExpendRecord.statisticsMemberExpendData(keywords);
        }

    }
}
