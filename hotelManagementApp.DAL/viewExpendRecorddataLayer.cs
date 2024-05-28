using hotelManagementApp.dataLayer.Base;
using hotelManagementApp.entity.Ventity;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer
{
    public class viewExpendRecorddataLayer:BQuery<vExpendRecord>
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

        /// <summary>
        /// 查询具体会员消费信息
        /// </summary>
        /// <param name="keywords"></param>
        /// <returns></returns>
        public List<vExpendRecord> statisticsMemberExpendData(string keywords)
        {
            string strWhere = $"";
            if (!string.IsNullOrEmpty(keywords))
                strWhere += "mName like @keywords or cardNo like @keywords or roomNo like @keywords";
            SqlParameter para = new SqlParameter("@keywords", $"%{keywords}%");
            return GetModelList(strWhere, "", "", para);
        }
    }
}
