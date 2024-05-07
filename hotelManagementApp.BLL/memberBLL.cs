using hotelManagementApp.DAL;
using hotelManagementApp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.BLL
{
    public class memberBLL
    {
        memberDAL memberDAL = new memberDAL();

        /// <summary>
        /// 关键词查询会员列表
        /// </summary>
        /// <param name="keywords"></param>
        /// <param name="blDel"></param>
        /// <returns></returns>
        public List<member> findMemberList(string keywords, bool blDel)
        {
            int isDeleted = blDel ? 1 : 0;
            return memberDAL.findMemberList(keywords, isDeleted);
        }

        /// <summary>
        /// 判断会员是否已存在
        /// </summary>
        /// <param name="mName"></param>
        /// <param name="phone"></param>
        /// <returns></returns>
        public bool existMember(string mName, string phone)
        {
            return memberDAL.existMember(mName, phone);
        }

        /// <summary>
        /// 添加会员信息
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public int addMember(member member)
        {
            return memberDAL.addMember(member);
        }

        /// <summary>
        /// 修改会员信息
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        public bool editMember(member member)
        {
            return memberDAL.editMember(member);
        }

        /// <summary>
        /// 删除会员信息（逻辑删除）
        /// </summary>
        /// <param name="memberIds"></param>
        /// <returns></returns>
        public bool deleteMember(List<int> memberIds)
        {
            return memberDAL.deleteMemberList(memberIds, 0, 1);
        }

        /// <summary>
        /// 恢复会员信息
        /// </summary>
        /// <param name="memberIds"></param>
        /// <returns></returns>
        public bool recoverMember(List<int> memberIds)
        {
            return memberDAL.deleteMemberList(memberIds, 0, 0);
        }

        /// <summary>
        /// 移除会员信息（物理删除）
        /// </summary>
        /// <param name="memberIds"></param>
        /// <returns></returns>
        public bool removeMember(List<int> memberIds)
        {
            return memberDAL.deleteMemberList(memberIds, 1, 2);
        }
    }
}
