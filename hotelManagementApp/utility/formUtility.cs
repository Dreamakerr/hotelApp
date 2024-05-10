using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.utility
{
    public class formUtility
    {
        /// <summary>
        /// 将状态值转换为状态名称
        /// </summary>
        /// <param name="state"></param>
        /// <returns></returns>
        public static string getStateName(int state)
        {
            string stateName = "";
            switch (state)
            {
                case 0:
                    stateName = "已冻结"; break;
                case 1:
                    stateName = "已激活"; break;
                case 2:
                    stateName = "已销卡"; break;
                default:
                    break;
            }
            return stateName;
        }
    }
}
