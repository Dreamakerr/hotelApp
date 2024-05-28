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
    public class memberIntegraldataLayer
    {
        /// <summary>
        /// 清空会员卡积分（多个操作）
        /// </summary>
        /// <param name="dicInteList">会员卡号——积分值键值对</param>
        /// <returns></returns>
        public bool clearCardIntegralValue(List<integralRecord> inteList)
        {
            List<commandInfo> comList = new List<commandInfo>();
            foreach (integralRecord inte in inteList)
            {
                //更新会员卡积分值->0
                comList.Add(new commandInfo()
                {
                    commandText = $"update memberCard set integralValue=0 where cardNo='{inte.cardNo}'",
                    IsProc = false
                });
                //添加积分减少记录
                string cols = "cardNo,integralName,integralValue";
                sqlModel inteModel = CreateSql.CreateInsertSql(inte, cols, 0);
                comList.Add(new commandInfo()
                {
                    commandText = inteModel.Sql,
                    IsProc = false,
                    Paras = inteModel.Paras
                });
            }
            return sqlHelper.ExecuteTrans(comList);
        }

        /// <summary>
        /// 积分兑换
        /// </summary>
        /// <param name="inteInfo"></param>
        /// <returns></returns>
        public bool integralExchange(integralRecord inteInfo)
        {
            List<commandInfo> comList = new List<commandInfo>();
            //修改会员卡可用积分
            comList.Add(new commandInfo()
            {
                commandText = $"update memberCard set integralValue=integralValue-{Math.Abs(inteInfo.integralValue)} where cardNo='{inteInfo.cardNo}'",
                IsProc = false
            });
            //添加积分记录
            string cols = "cardNo,integralName,integralValue";
            sqlModel inteModel = CreateSql.CreateInsertSql(inteInfo, cols, 0);
            comList.Add(new commandInfo()
            {
                commandText = inteModel.Sql,
                IsProc = false,
                Paras = inteModel.Paras
            });
            return sqlHelper.ExecuteTrans(comList);
        }


    }
}
