using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer.Helper
{
    public class commandInfo
    {
        public string commandText;//sql或存储过程名
        public SqlParameter[] Paras; //参数列表
        public bool IsProc; //是否是存储过程

        public commandInfo() { }
        public commandInfo(string comText, bool isProc)
        {
            this.commandText = comText;
            this.IsProc = isProc;
        }

        public commandInfo(string sqlText, bool isProc, SqlParameter[] para)
        {
            this.commandText = sqlText;
            this.Paras = para;
            this.IsProc = isProc;
        }
    }
}
