using common;
using hotelManagementApp.businessLayer;
using hotelManagementApp.entity;
using hotelManagementApp.entity.Ventity;
using hotelManagementApp.utility;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace hotelManagementApp.memberInfo
{
    public partial class FrmCheckOut : Form
    {
        public FrmCheckOut()
        {
            InitializeComponent();
        }
        memberExpendbusinessLayer memberExpendBLL = new memberExpendbusinessLayer();
        //当前会员的会员卡信息
        vMemberCard cardInfo = null;
        public FrmCheckOut(vMemberCard VMemberCard)
        {
            InitializeComponent();
            cardInfo = VMemberCard;
        }
        public event EventHandler<balanceRefreshEventArgs> checkedOut;//退房成功成功后触发事件
        private void label4_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCheckOut_Load(object sender, EventArgs e)
        {
            if(cardInfo != null)
            {
                txtCardNo.Text = cardInfo.cardNo;
                txtMName.Text = cardInfo.mName;
                txtDiscount.Text = cardInfo.discount.ToString();
            }
        }

        /// <summary>
        /// 退房提交处理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnOK_Click(object sender, EventArgs e)
        {
            string msgTitle = "退房提示";
            //接收信息
            string roomNo = txtRoomNo.Text.Trim();
            decimal expendAmount = txtExpendAmount.Text.GetDecimal();
            decimal payAmount = txtPayAmount.Text.GetDecimal();
            //信息检查
            if (string.IsNullOrEmpty(roomNo))
            {
                MessageHelper.Error(msgTitle, "请输入房间号！");
                txtRoomNo.Focus();
                return;
            }
            if(expendAmount <= 0)
            {
                MessageHelper.Error(msgTitle, "请输入消费金额！");
                txtExpendAmount.Focus();
                return;
            }
            if(payAmount <= 0)
            {
                decimal d = (decimal)cardInfo.discount / (decimal)100;
                payAmount = ((decimal)expendAmount * d).ToString("0.00").GetDecimal();
            }
            if(cardInfo.balance < payAmount)
            {
                MessageHelper.Error(msgTitle, "当前会员卡中的余额不足！");
                return;
            }

            //信息封装：消费信息、积分信息
            expendRecord expendInfo = new expendRecord()
            {
                cardNo = cardInfo.cardNo,
                roomNo = roomNo,
                expendAmount = expendAmount,
                payAmount = payAmount
            };
            //积分信息
            int inteVal = (int)expendAmount / 100;
            integralRecord inteInfo = new integralRecord()
            {
                integralName = "退房结算累计积分",
                integralValue = inteVal,
                cardNo = cardInfo.cardNo
            };
            //退房及响应
            bool blCheckedOut = memberExpendBLL.memberChechOut(expendInfo, inteInfo);
            if(blCheckedOut)
            {
                MessageHelper.Info(msgTitle, $"退房成功！支付金额为：{payAmount}元。");
                checkedOut?.Invoke(this, new balanceRefreshEventArgs(payAmount,inteVal));
                this.Close();
            }
            else
            {
                MessageHelper.Error(msgTitle, "退房失败！");
                return;
            }

        }

        /// <summary>
        /// 消费金额输入结束，按enter后触发
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void txtExpendAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(e.KeyChar == 13)//enter
            {
                //自动计算实付金额
                txtPayAmount.Text = (decimal.Parse(txtExpendAmount.Text) * (decimal.Parse(txtDiscount.Text) / 100)).ToString("0.00");

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
