﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.dataLayer.Base
{
    /// <summary>
    /// 生成的Sql语句实体（Insert/Update语句生成的内容）
    /// </summary>
    public class sqlModel
    {
        public string Sql { get; set; }
        public SqlParameter[] Paras { get; set; }
    }
}
