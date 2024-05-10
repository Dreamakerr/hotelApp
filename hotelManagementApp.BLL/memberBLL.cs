using hotelManagementApp.DAL;
using hotelManagementApp.Models;
using hotelManagementApp.Models.UIModels;
using hotelManagementApp.Models.VModels;
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
        viewMemberDAL viewMemberDAL = new viewMemberDAL();

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

        /// <summary>
        /// 新增会员统计
        /// </summary>
        /// <returns></returns>
        public newMemberStatInfo statisticsNewMembers()
        {
            newMemberStatInfo statInfo = new newMemberStatInfo();
            statInfo.newMemberList = viewMemberDAL.getNewMemberList();
            if(statInfo.newMemberList.Count > 0)
            {
                statInfo.totalNewCount = statInfo.newMemberList.Count;
                //筛选出所有的类型
                List<string> types = statInfo.newMemberList.Select(m => m.cTypeName).Distinct().ToList();
                foreach(vMember m in statInfo.newMemberList)
                {
                    switch(m.cTypeName)
                    {
                        case "普通卡":
                            statInfo.comCardCount += 1;
                            break;
                        case "银卡":
                            statInfo.silverCardCount += 1;
                            break;
                        case "金卡":
                            statInfo.goldCardCount += 1;
                            break;
                        case "钻卡":
                            statInfo.diamondCardCount += 1;
                            break;
                        default:
                            statInfo.otherCardCount += 1;
                            break;
                    }

                }
            }

            return statInfo;
        }

    }
}
