using hotelManagementApp.DAL.Base;
using hotelManagementApp.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.DAL
{
    public class viewMemberDAL:BQuery<vMember>
    {
        /// <summary>
        /// 查询所有新增会员信息
        /// </summary>
        /// <returns></returns>
        public List<vMember> getNewMemberList()
        {
            string strWhere = "isDeleted=0 and isNew=1";
            return GetModelList(strWhere, "", "");
        }
    }
}
