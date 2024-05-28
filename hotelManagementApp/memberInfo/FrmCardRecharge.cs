using common;
using hotelManagementApp.businessLayer;
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
    public partial class FrmCardRecharge : Form
    {
        public FrmCardRecharge()
        {
            InitializeComponent();
        }
        memberCardbusinessLayer memberCardBLL = new memberCardbusinessLayer();
        public string cardNo;//要充值的会员卡号
        public event EventHandler<balanceRefreshEventArgs> cardRecharged;//会员卡充值成功后触发事件

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCardRecharge_Load(object sender, EventArgs e)
        {
            txtCardNo.Text = cardNo;
            txtAmount.Text = "0.00";
        }

        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            string msgTitle = "会员卡充值";
            decimal amount = txtAmount.Text.GetDecimal();
            //检查
            if(amount <= 0)
            {
                MessageHelper.Error(msgTitle, "充值金额必须大于0！");
                txtAmount.Focus();
                return;
            }
            //充值
            bool blRecharge = memberCardBLL.rechargeCard(cardNo, amount);
            if(blRecharge)
            {
                MessageHelper.Info(msgTitle, "充值成功！");
                int inteVal = (int)amount / 100;
                cardRecharged?.Invoke(this,new balanceRefreshEventArgs(amount, inteVal));//执行事件
                this.Close();
            }
            else
            {
                MessageHelper.Error(msgTitle, "充值失败");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {

        }

        private void btnExit_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
