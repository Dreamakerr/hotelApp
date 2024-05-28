using common;
using hotelManagementApp.businessLayer;
using hotelManagementApp.entity;
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
    public partial class FrmMemberCardInfo : Form
    {
        public FrmMemberCardInfo()
        {
            InitializeComponent();
        }

        cardTypebusinessLayer cTypeBLL = new cardTypebusinessLayer();
        memberCardbusinessLayer memberCardBLL = new memberCardbusinessLayer();
        memberCard editInfo = null;//要修改的会员卡信息
        int cardId = 0;//要修改的会员卡编号
        int actType = 1;//页面提交状态
        int giveIntegral = 0;//赠送积分
        List<cardType> typeList = new List<cardType>();


        /// <summary>
        /// 通过会员卡号，创建会员卡信息
        /// </summary>
        /// <param name="cardNo"></param>
        public FrmMemberCardInfo(string cardNo)
        {
            InitializeComponent();
            editInfo = memberCardBLL.GetMemberCard(cardNo);
        }

        //会员卡信息添加成功后触发事件，事件参数传递会员卡号到会员档案管理页面
        public event EventHandler<mCardEventArgs> memberCardAdded;
        //会员卡信息修改成功后触发事件，事件参数传递会员信息到会员卡操作页面
        public event EventHandler<mCardEditEventArgs> memberCardEdited;

        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMemberCardInfo_Load(object sender, EventArgs e)
        {
            //加载卡类型下拉框
            loadMCardTypes();

            //加载会员卡信息（修改）
            initCardInfo();

        }

        /// <summary>
        /// 页面初始化
        /// </summary>
        private void initCardInfo()
        {
            if (editInfo != null)//修改
            {
                cardId = editInfo.mCardId;
                txtCardNo.Text = editInfo.cardNo;
                txtBalance.Text = editInfo.balance.ToString();
                txtCreateDate.Text = editInfo.createDate.ToString("yyyy-MM-dd");
                cboCTypes.SelectedValue = editInfo.cTypeId;//卡类型
                txtDiscount.Text = editInfo.discount.ToString();
                txtIntegralValue.Text = editInfo.integralValue.ToString();
                string state = "";
                switch(editInfo.cardState)
                {
                    case 0:
                        state = "已冻结"; break;
                    case 1:
                        state = "已激活"; break;
                    case 2:
                        state = "已销卡"; break;
                }
                cboState.Text = state;
                txtBalance.ReadOnly = true;//余额不能修改
                btnAdd.Text = "修改";
                actType = 2;
            }
            else//新增
            {
                cboCTypes.SelectedIndex = 0;
                cboState.SelectedIndex = 1;
                txtBalance.Text = "0.00";
                txtDiscount.Text = "100";
                txtIntegralValue.Text = "0";
                btnAdd.Text = "新增";
                actType = 1;
            }
        }

        /// <summary>
        /// 加载卡类型下拉框
        /// </summary>
        private void loadMCardTypes()
        {
            cboCTypes.Items.Clear();
            typeList = cTypeBLL.getAllCardTypeList();
            if(typeList.Count > 0)
            {
                cboCTypes.DisplayMember = "cTypeName";
                cboCTypes.ValueMember = "cTypeId";
                cboCTypes.DataSource = typeList;
                cboCTypes.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 选择不同的类型，自动显示对应折扣和赠送积分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void cboCTypes_SelectedIndexChanged(object sender, EventArgs e)
        {
            string typeName = cboCTypes.Text.Trim();//类型名
            int discount = 100;
            foreach(cardType type in typeList)
            {
                if(typeName.Equals(type.cTypeName))
                {
                    discount = type.discount;
                    giveIntegral = type.giveIntegral;
                    break;
                }
            }
            txtDiscount.Text = discount.ToString();
        }

        /// <summary>
        /// 会员卡信息提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //信息接收
            string cardNo = txtCardNo.Text.Trim();
            string typeName = cboCTypes.Text.Trim();
            int cTypeId = cboCTypes.SelectedValue.GetInt();
            int discount = txtDiscount.Text.GetInt();
            int integralVal = txtIntegralValue.Text.GetInt();
            decimal balance = txtBalance.Text.GetDecimal();
            string strState = cboState.Text.Trim();//状态名
            int state = 0;
            switch(strState)
            {
                case "已冻结":
                    state = 0; break;
                case "已激活":
                    state = 1; break;
                case "已销卡":
                    state = 2; break;
            }
            if (actType == 1)
                integralVal = giveIntegral;
            string actName = actType == 1 ? "新增" : "修改";
            string msgTitle = $"会员卡{actName}";//消息框标题

            //检查
            if(balance < 0)
            {
                MessageHelper.Error(msgTitle, "会员卡余额不能小于0！");
                return;
            }

            //封装：会员卡信息、积分信息
            memberCard cardInfo = new memberCard()
            {
                cardNo = cardNo,
                balance = balance,
                cTypeId = cTypeId,
                discount = discount,
                cardState = state,
                integralValue = integralVal,
            };

            //提交与响应
            //将会员卡信息添加入或更新入库
            if (actType == 1)
            {
                
                //积分记录
                integralRecord inteInfo = new integralRecord()
                {
                    cardNo = cardNo,
                    integralName = "办理" + typeName + "赠送积分",
                    integralValue = giveIntegral
                };
                string reCardNo = memberCardBLL.addCardInfo(cardInfo, inteInfo);
                if(reCardNo != "")
                {
                    MessageHelper.Info(msgTitle, "会员卡添加成功！");
                    txtCardNo.Text = reCardNo;
                    //把会员卡号传到会员管理页面
                    mCardEventArgs arg = new mCardEventArgs(reCardNo);
                    memberCardAdded?.Invoke(this, arg);//调用事件
                    this.Close();
                }
                else
                {
                    MessageHelper.Error(msgTitle, "会员卡添加失败！");
                    return;
                }
            }
            else//修改
            {
                cardInfo.mCardId = cardId;
                bool blEdit = memberCardBLL.editCardInfo(cardInfo);
                if (blEdit)
                {
                    MessageHelper.Info(msgTitle, "会员卡修改成功！");
                    memberCardEdited?.Invoke(this, new mCardEditEventArgs(cardInfo));
                    this.Close();
                }
            }
        }

        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
