using common;
using hotelManagementApp.BLL;
using hotelManagementApp.Models;
using hotelManagementApp.Models.VModels;
using hotelManagementApp.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelManagementApp.memberInfo
{
    public partial class FrmIntegralExchange : Form
    {
        public FrmIntegralExchange()
        {
            InitializeComponent();
        }

        public event EventHandler<integralRefreshEventArgs> integralExchanged;//积分兑换成功后触发
        public vMemberCard cardInfo = null;//要兑换积分的会员卡信息
        memberIntegralBLL memberIntegralBLL = new memberIntegralBLL();

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmIntegralExchange_Load(object sender, EventArgs e)
        {
            txtCardNo.Text = cardInfo.cardNo;
            txtMName.Text = cardInfo.mName;
            txtIntegralValue.Text = cardInfo.integralValue.ToString();
        }

        /// <summary>
        /// 兑换功能
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            //接收信息
            string giftName = txtGiftName.Text.Trim();
            int expendIntegralVal = txtExchangeIntegral.Text.GetInt();
            string msgTitle = "积分兑换";
            //检查信息
            if (string.IsNullOrEmpty(giftName) )
            {
                MessageHelper.Error(msgTitle, "请输入要兑换的礼品！");
                txtGiftName.Focus();
                return;
            }
            if(expendIntegralVal <= 0)
            {
                MessageHelper.Error(msgTitle, "请输入兑换的积分值！");
                txtExchangeIntegral.Focus();
                return;
            }
            else if(expendIntegralVal > cardInfo.integralValue) {
                MessageHelper.Error(msgTitle, "可用积分不足，不能兑换礼品！");
                txtExchangeIntegral.Focus();
                return;
            }
            //封装积分记录信息
            string inteName = "兑换礼品：" + giftName;
            integralRecord inteInfo = new integralRecord()
            {
                integralName = inteName,
                integralValue = -expendIntegralVal,
                cardNo = cardInfo.cardNo
            };
            //兑换调用
            bool blExchange = memberIntegralBLL.integralExchange(inteInfo);
            if(blExchange)
            {
                MessageHelper.Info(msgTitle, "礼品兑换成功！");
                //调用事件
                integralExchanged?.Invoke(this, new integralRefreshEventArgs(expendIntegralVal));
                this.Close();
            }
            else
            {
                MessageHelper.Error(msgTitle, "礼品兑换失败！");
                return;
            }

        }
    }
}
