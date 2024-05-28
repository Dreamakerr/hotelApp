using hotelManagementApp.dataLayer.Base;
using hotelManagementApp.dataLayer.Helper;
using hotelManagementApp.entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer
{
    public class memberExpenddataLayer
    {
        /// <summary>
        /// 会员退房
        /// </summary>
        /// <param name="expendInfo"></param>
        /// <param name="integralInfo"></param>
        /// <returns></returns>
        public bool memberChechOut(expendRecord expendInfo, integralRecord inteInfo)
        {
            List<commandInfo> comList = new List<commandInfo>();
            //添加消费记录
            string expendCols = CreateSql.GetColNames<expendRecord>("expendId,expendTime");
            sqlModel expendModel = CreateSql.CreateInsertSql(expendInfo, expendCols, 0);
            comList.Add(new commandInfo()
            {
                commandText = expendModel.Sql,
                IsProc = false,
                Paras = expendModel.Paras
            });

            //添加积分记录
            string inteCols = CreateSql.GetColNames<integralRecord>("integralId,integralTime");
            sqlModel inteModel = CreateSql.CreateInsertSql(inteInfo, inteCols, 0);
            comList.Add(new commandInfo()
            {
                commandText = inteModel.Sql,
                IsProc = false,
                Paras = inteModel.Paras
            });

            //更新会员卡的余额和积分
            comList.Add(new commandInfo()
            {
                commandText = $"update memberCard set balance=balance-{expendInfo.payAmount},integralValue=integralValue+{inteInfo.integralValue} where cardNo='{expendInfo.cardNo}'",
                IsProc = false,
            });
            return sqlHelper.ExecuteTrans(comList);
        }
    }
}
