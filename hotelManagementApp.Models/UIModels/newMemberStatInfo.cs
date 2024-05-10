using hotelManagementApp.Models.VModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hotelManagementApp.Models.UIModels
{
    /// <summary>
    /// 新会员统计类
    /// </summary>
    public class newMemberStatInfo
    {
        /// <summary>
        /// 新会员列表
        /// </summary>
        public List<vMember> newMemberList { get; set; }
        //新会员总数
        public int totalNewCount { get; set; }
        //普通卡数量
        public int comCardCount { get; set; }
        //银卡数量
        public int silverCardCount { get; set; }
        //金卡数量
        public int goldCardCount { get; set; }
        //钻卡数量
        public int diamondCardCount {  get; set; }
        //其他数量
        public int otherCardCount {  get; set; }


    }
}
