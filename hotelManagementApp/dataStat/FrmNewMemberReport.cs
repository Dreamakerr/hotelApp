using hotelManagementApp.businessLayer;
using hotelManagementApp.entity;
using hotelManagementApp.entity.UIentity;
using hotelManagementApp.entity.Ventity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelManagementApp.dataStat
{
    public partial class FrmNewMemberReport : Form
    {
        public FrmNewMemberReport()
        {
            InitializeComponent();
        }
        memberbusinessLayer memberBLL = new memberbusinessLayer();


        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmNewMemberReport_Load(object sender, EventArgs e)
        {
            statisticsNewMembers();
        }

        private void statisticsNewMembers()
        {
            lvNewMemberList.Items.Clear();
            //统计信息获取
            newMemberStatInfo statInfo = memberBLL.statisticsNewMembers();
            if(statInfo != null)
            {
                //会员列表的加载
                if(statInfo.newMemberList.Count > 0)
                {
                    var memberList = statInfo.newMemberList;
                    foreach(var member in memberList)
                    {
                        ListViewItem li = addItem(member);
                        lvNewMemberList.Items.Add(li);
                    }
                }
                //各数据显示
                lblTotalCount.Text = statInfo.totalNewCount.ToString();
                lblComCount.Text = statInfo.comCardCount.ToString();
                lblSilverCount.Text = statInfo.silverCardCount.ToString();
                lblGoldCount.Text = statInfo.goldCardCount.ToString();
                lblDiamondCount.Text = statInfo.diamondCardCount.ToString();
                lblOtherCount.Text = statInfo.otherCardCount.ToString();

            }
        }

        /// <summary>
        /// 创建ListViewItem项
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private ListViewItem addItem(vMember mInfo)
        {
            ListViewItem li = new ListViewItem();
            li.Text = mInfo.memberId.ToString();
            li.SubItems.Add(mInfo.mName);
            li.SubItems.Add(mInfo.cardNo);
            li.SubItems.Add(mInfo.sex);
            li.SubItems.Add(mInfo.cTypeName);
            li.SubItems.Add(mInfo.phone);
            li.SubItems.Add(mInfo.createTime.ToString("yyyy-MM-dd"));
            return li;
        }

        /// <summary>
        /// 重新统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            statisticsNewMembers();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
