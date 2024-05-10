using hotelManagementApp.DAL.Base;
using hotelManagementApp.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL
{
    public class viewExpendRecord:BQuery<vExpendRecord>
    {
        /// <summary>
        /// 查询当月的所有消费记录
        /// </summary>
        /// <returns></returns>
        public List<vExpendRecord> getThisMonthExpendList()
        {
            string stTime = DateTime.Now.Year + "-" + DateTime.Now.Month.ToString("00") + "-01 00:00:00";
            DateTime et = DateTime.Now.AddMonths(1);
            string etTime = et.Year + "-" + et.Month.ToString("00") + "-01 00:00:00";
            string strWhere = $"isDeleted=0 and expendTime>='{stTime}' and expendTime<'{etTime}'";
            return GetModelList(strWhere, "", "");
        }
    }
}
