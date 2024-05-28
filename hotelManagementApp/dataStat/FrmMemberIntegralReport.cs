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
    public partial class FrmMemberIntegralReport : Form
    {
        public FrmMemberIntegralReport()
        {
            InitializeComponent();
        }

        memberIntegralbusinessLayer memberIntegralBLL = new memberIntegralbusinessLayer();

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMemberIntegralReport_Load(object sender, EventArgs e)
        {
            // 数据加载呈现
            statisticsIntegralData();
        }
        
        /// <summary>
        /// 数据加载呈现
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void statisticsIntegralData()
        {
            lvMemberIntegralList.Items.Clear();
            memberIntegralStat statInfo = memberIntegralBLL.statisticsIntegralData();//获取统计信息
            if(statInfo != null )
            {
                if(statInfo.integralList.Count > 0 )
                {
                    foreach(var inteInfo in statInfo.integralList)
                    {
                        ListViewItem li = addItem(inteInfo);
                        lvMemberIntegralList.Items.Add(li);
                    }
                }
                lblMaxIntegral.Text = statInfo.maxIntegralVal.ToString();
                lblMinIntegral.Text = statInfo.minIntegralVal.ToString();
                lblTotalMaxIntegral.Text = statInfo.maxTotalIntegralValue.ToString();
                lblTotalMinIntegral.Text = statInfo.minTotalIntegralValue.ToString();
            }
        }

        /// <summary>
        /// 创建ListViewItem项
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private ListViewItem addItem(vMemberIntegral info)
        {
            ListViewItem li = new ListViewItem();
            li.Text = info.mCardId.ToString();
            li.SubItems.Add(info.cardNo);
            li.SubItems.Add(info.mName);
            li.SubItems.Add(info.integralValue.ToString());
            li.SubItems.Add(info.integralTotal.ToString());
            li.SubItems.Add(info.usedIntegral.ToString());
            return li;
        }

        /// <summary>
        /// 重新统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnStatistics_Click(object sender, EventArgs e)
        {
            statisticsIntegralData();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        
        /// <summary>
        /// 查询具体会员积分信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            lvMemberIntegralList.Items.Clear();
            string keywords = txtKeyword.Text.Trim();
            var integralList = memberIntegralBLL.statisticsMemberIntegralData(keywords);
            if(integralList != null)
            {
                foreach(var inteInfo in integralList)
                {
                    ListViewItem li = addItem(inteInfo);
                    lvMemberIntegralList.Items.Add(li);
                }
            }
        }
    }
}
