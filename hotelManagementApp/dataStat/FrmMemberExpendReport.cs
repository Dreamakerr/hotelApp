using common;
using hotelManagementApp.businessLayer;
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
    public partial class FrmMemberExpendReport : Form
    {
        public FrmMemberExpendReport()
        {
            InitializeComponent();
        }

        memberExpendbusinessLayer expendBLL = new memberExpendbusinessLayer();

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMemberExpendReport_Load(object sender, EventArgs e)
        {
            //统计数据加载呈现
            statisticsExpendData();
        }

        /// <summary>
        /// 统计数据加载呈现
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void statisticsExpendData()
        {
            lvMemberExpendList.Items.Clear();
            //统计信息获取
            memberExpendStat statInfo = expendBLL.statisticsThisMonthExpendData();
            if (statInfo != null)
            {
                //会员列表的加载
                if (statInfo.expendList.Count > 0)
                {
                    var expendList = statInfo.expendList;
                    foreach (var record in expendList)
                    {
                        ListViewItem li = addItem(record);
                        lvMemberExpendList.Items.Add(li);
                    }
                }
                //各数据显示
                lblTotalAmount.Text = statInfo.thisMonthTotalExpendAmount.ToString();
                lblMaxAmount.Text = statInfo.thisMonthMaxDayAmount.ToString();
                lblMinAmount.Text = statInfo.thisMonthMinDayAmount.ToString();
                lblAvgAmount.Text = statInfo.thisMonthAvgDayAmount.ToString("0.00");
                lblSuperName.Text = statInfo.superMemberName;
            }
        }


        /// <summary>
        /// 创建ListViewItem项
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private ListViewItem addItem(vExpendRecord info)
        {
            ListViewItem li = new ListViewItem();
            li.Text = info.expendId.ToString();
            li.SubItems.Add(info.mName);
            li.SubItems.Add(info.cardNo);
            li.SubItems.Add(info.roomNo);
            li.SubItems.Add(info.expendAmount.ToString("0.00"));
            li.SubItems.Add(info.payAmount.ToString("0.00"));
            li.SubItems.Add(info.expendTime.ToString("yyyy-MM-dd HH:mm:ss"));
            return li;
        }

        /// <summary>
        /// 重新统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            statisticsExpendData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /// <summary>
        /// 查询具体会员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            lvMemberExpendList.Items.Clear();
            string keywords = txtKeyword.Text.Trim();
            var expendList = expendBLL.statisticsMemberExpendData(keywords);
            if(expendList != null)
            {
                foreach(var record in expendList)
                {
                    ListViewItem li = addItem(record);
                    lvMemberExpendList.Items.Add(li);
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void txtKeyword_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }
    }
}
  
