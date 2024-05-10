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
    public partial class FrmMemberCardList : Form
    {
        public FrmMemberCardList()
        {
            InitializeComponent();
        }

        cardTypeBLL cardTypeBLL = new cardTypeBLL();
        memberCardBLL memberCardBLL = new memberCardBLL();
        List<vMemberCard> allCards = new List<vMemberCard>();//存储查询的会员卡列表
        int selIndex = -1;//存储选择行的第一行的索引

        private void FrmMemberCardList_Load(object sender, EventArgs e)
        {
            //加载会员卡类型下拉框
            loadMCardTypes();
            cboState.SelectedIndex = 0;//默认选择：请选择
            //加载会员卡列表
            findMemberCardList();
        }

        /// <summary>
        /// 查询会员卡列表——加载列表
        /// </summary>
        private void findMemberCardList()
        {
            lvMemberCardList.Items.Clear();
            string keywords = txtKeyword.Text.Trim();
            int ctypeId = cboCType.SelectedValue.GetInt();
            string strState = cboState.Text.Trim();
            //调用查询方法
            allCards = memberCardBLL.findMemberCardList(keywords, ctypeId, strState);
            if (allCards.Count > 0)
            {
                //加载数据
                foreach(vMemberCard item in allCards)
                {
                    ListViewItem li = addItem(item);
                    lvMemberCardList.Items.Add(li);
                }

                //设置按钮可用性
                setBtnsEnabled(strState);

            }
            else
            {
                //按钮不可用
                btnActivate.Enabled = false;
                btnRecharge.Enabled = false;
                btnCheckOut.Enabled = false;
                btnEdit.Enabled = false;
                btnDelete.Enabled = false;
                btnRemove.Enabled = false;
            }
        }

        /// <summary>
        /// 设置按钮可用性
        /// </summary>
        /// <param name="strState"></param>
        private void setBtnsEnabled(string strState)
        {
            switch (strState)
            {
                case "已冻结":
                    btnActivate.Enabled = true;
                    btnRecharge.Enabled = false;
                    btnCheckOut.Enabled = false;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnRemove.Enabled = true;
                    break;
                case "已激活":
                    btnActivate.Enabled = false;
                    btnRecharge.Enabled = true;
                    btnCheckOut.Enabled = true;
                    btnEdit.Enabled = true;
                    btnDelete.Enabled = false;
                    btnRemove.Enabled = true;
                    break;
                case "已销卡":
                    btnActivate.Enabled = false;
                    btnRecharge.Enabled = false;
                    btnCheckOut.Enabled = false;
                    btnEdit.Enabled = false;
                    btnDelete.Enabled = true;
                    btnRemove.Enabled = false;
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// 创建ListViewItem项
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private ListViewItem addItem(vMemberCard cardInfo)
        {
            ListViewItem li = new ListViewItem();
            li.Text = cardInfo.mCardId.ToString();
            li.SubItems.Add(cardInfo.cardNo);
            li.SubItems.Add(cardInfo.mName);
            li.SubItems.Add(cardInfo.cTypeName);
            li.SubItems.Add(cardInfo.discount.ToString());
            li.SubItems.Add(cardInfo.balance.ToString());
            li.SubItems.Add(cardInfo.createDate.ToString("yyyy-MM-dd"));
            li.SubItems.Add(cardInfo.integralValue.ToString());
            li.SubItems.Add(formUtility.getStateName(cardInfo.cardState));
            return li;
        }


        /// <summary>
        /// 加载会员卡类型下拉框
        /// </summary>
        private void loadMCardTypes()
        {
            cboCType.Items.Clear();
            List<cardType> typeList = cardTypeBLL.getAllCardTypeList();
            typeList.Insert(0, new cardType()
            {
                cTypeId = 0,
                cTypeName = "请选择"
            });
            if(typeList.Count > 0 )
            {
                cboCType.DisplayMember = "cTypeName";
                cboCType.ValueMember = "cTypeId";
                cboCType.DataSource = typeList;
                cboCType.SelectedIndex = 0;
            }
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            findMemberCardList();
        }

        /// <summary>
        /// 选择项，设置按钮的可用性
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void lvMemberCardList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lvMemberCardList.SelectedIndices.Count > 0 )
            {
                selIndex = lvMemberCardList.SelectedIndices[0];
                vMemberCard cardInfo = allCards[selIndex];//选择的第一行的卡信息
                int state = cardInfo.cardState;//状态
                setBtnsEnabled(formUtility.getStateName(state));//设置按钮的可用性



            }
        }

        /// <summary>
        /// 修改的响应
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(selIndex > -1)//选择行
            {
                string cardNo = allCards[selIndex].cardNo;
                FrmMemberCardInfo frmMemberCardInfo = new FrmMemberCardInfo(cardNo);
                frmMemberCardInfo.memberCardEdited += FrmMemberCardInfo_memberCardEdited;
                frmMemberCardInfo.MdiParent = this.MdiParent;
                frmMemberCardInfo.Show();
            }
            else
            {
                MessageHelper.Error("修改会员卡", "请选择要修改的会员卡信息！");
                return;
            }
        }

        /// <summary>
        /// 修改成功后执行，刷新会员卡信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMemberCardInfo_memberCardEdited(object sender, utility.mCardEditEventArgs e)
        {
            if(e.UpdateCardInfo != null)
            {
                memberCard memberCard = e.UpdateCardInfo;
                //替换原来行中的会员卡信息
                vMemberCard vMemberCard = allCards[selIndex];
                vMemberCard.cTypeId = memberCard.cTypeId;
                vMemberCard.cTypeName = cardTypeBLL.getCardType(memberCard.cTypeId).cTypeName;
                vMemberCard.cardState = memberCard.cardState;
                vMemberCard.balance = memberCard.balance;
                vMemberCard.discount = memberCard.discount;
                vMemberCard.integralValue = memberCard.integralValue;
                //替换界面上的列表中的数据
                lvMemberCardList.Items[selIndex] = addItem(vMemberCard);
            }
        }

        /// <summary>
        /// 将选择的会员卡信息删除（物理删除）
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            List<string> cardNos = new List<string>();//存储删除的会员卡号
            List<int> indexes = new List<int>();//存储删除的索引集合
            string strCardNos = "";//存储不能删除的会员卡号
            foreach(int index in lvMemberCardList.SelectedIndices)
            {
                vMemberCard cardInfo = allCards[index];
                if(cardInfo.cardState != 2)
                {
                    if(strCardNos.Length > 0)
                        strCardNos += ",";
                    strCardNos += cardInfo.cardNo;
                }
                else
                {
                    cardNos.Add(cardInfo.cardNo);
                    indexes.Add(index);
                }
            }
            string msgTitle = "会员卡删除";
            if(strCardNos.Length > 0)
            {
                MessageHelper.Error(msgTitle, $"会员卡号：{strCardNos}并未销卡，不能删除！");
            }
            if(cardNos.Count > 0)
            {
                if(MessageHelper.Confirm(msgTitle,"选择的会员卡有符合删除条件的，删除将包括会员卡的相关信息，是否删除？") == DialogResult.OK)
                {
                    bool blDelete = memberCardBLL.deleteMemberCards(cardNos);//删除会员卡
                    if (blDelete)
                    {
                        MessageHelper.Info(msgTitle, "选择的会员信息删除成功！");
                        //刷新——移除数据列表和列表视图中的数据
                        var delList = allCards.Where(c => cardNos.Contains(c.cardNo)).ToList();
                        delList.ForEach(c => allCards.Remove(c));
                        //索引集合翻转，从末尾删除
                        indexes.ForEach(index => lvMemberCardList.Items.RemoveAt(index));
                    }
                    else
                    {
                        MessageHelper.Error(msgTitle, "选择的会员卡信息删除失败！");
                        return;
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "没有符合删除条件的会员卡信息！");
                return;
            }
        }

        /// <summary>
        /// 会员卡激活——单卡操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnActivate_Click(object sender, EventArgs e)
        {
            string msgTitle = "会员卡激活";
            if(selIndex > -1)
            {
                vMemberCard cardInfo = allCards[selIndex];
                if(MessageHelper.Confirm(msgTitle, "你确定要激活该会员卡吗？") == DialogResult.OK)
                {
                    bool blActivate = memberCardBLL.activateCard(cardInfo.mCardId);//激活
                    if (blActivate)
                    {
                        MessageHelper.Info(msgTitle, "该会员卡激活成功！");
                        cardInfo.cardState = 1;
                        ListViewItem li = lvMemberCardList.Items[selIndex];
                        li.SubItems[8].Text = "已激活";
                    }
                    else
                    {
                        MessageHelper.Error(msgTitle, "会员卡激活失败！");
                        return;
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要激活的会员卡！");
                return;
            }
        }

        /// <summary>
        /// 会员卡销卡——单卡操作
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string msgTitle = "会员卡销卡";
            if (selIndex > -1)
            {
                vMemberCard cardInfo = allCards[selIndex];
                if (MessageHelper.Confirm(msgTitle, "你确定要将该会员卡销卡吗？") == DialogResult.OK)
                {
                    bool blActivate = memberCardBLL.cancelCard(cardInfo);//销卡
                    if (blActivate)
                    {
                        MessageHelper.Info(msgTitle, "该会员卡销卡成功！");
                        cardInfo.cardState = 2;
                        cardInfo.balance = 0.00M;
                        cardInfo.integralValue = 0;
                        ListViewItem li = lvMemberCardList.Items[selIndex];
                        li.SubItems[8].Text = "已销卡";
                        li.SubItems[5].Text = "0.00";
                        li.SubItems[7].Text = "0";
                    }
                    else
                    {
                        MessageHelper.Error(msgTitle, "会员卡销卡失败！");
                        return;
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要销卡的会员卡！");
                return;
            }
        }

        /// <summary>
        /// 退房
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnCheckOut_Click(object sender, EventArgs e)
        {
            string msgTitle = "会员卡退房";
            if (selIndex > -1)
            {
                vMemberCard cardInfo = allCards[selIndex];
                if (MessageHelper.Confirm(msgTitle, "你确定要退房吗？") == DialogResult.OK)
                {
                    string cardNo = cardInfo.cardNo;
                    FrmCheckOut frmCheckOut = new FrmCheckOut(cardInfo);
                    frmCheckOut.checkedOut += FrmCheckOut_checkedOut;//订阅事件
                    frmCheckOut.MdiParent = this.MdiParent;
                    frmCheckOut.Show();
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要退房的会员卡！");
                return;
            }
        }

        /// <summary>
        /// 退房成功后刷新余额和积分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmCheckOut_checkedOut(object sender, balanceRefreshEventArgs e)
        {
            if (e.balance > 0 && e.integralValue > 0)
            {
                vMemberCard cardInfo = allCards[selIndex];
                cardInfo.balance -= e.balance;//充值——余额减少
                cardInfo.integralValue += e.integralValue;//积分增加
                ListViewItem li = lvMemberCardList.Items[selIndex];//获取当前项
                li.SubItems[5].Text = cardInfo.balance.ToString();
                li.SubItems[7].Text = cardInfo.integralValue.ToString();
            }
        }

        /// <summary>
        /// 充值
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecharge_Click(object sender, EventArgs e)
        {
            string msgTitle = "会员卡充值";
            if (selIndex > -1)
            {
                vMemberCard cardInfo = allCards[selIndex];
                string cardNo = cardInfo.cardNo;
                FrmCardRecharge frmRecharge = new FrmCardRecharge();
                frmRecharge.cardNo = cardNo;
                frmRecharge.cardRecharged += FrmRecharge_cardRecharged;//订阅事件
                frmRecharge.MdiParent = this.MdiParent;
                frmRecharge.Show();
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要充值的会员卡！");
                return;
            }
        }

        //充值成功后刷新会员卡信息（余额和积分）
        private void FrmRecharge_cardRecharged(object sender, balanceRefreshEventArgs e)
        {
            if(e.balance > 0 && e.integralValue > 0)
            {
                vMemberCard cardInfo = allCards[selIndex];
                cardInfo.balance += e.balance;//充值——余额增加
                cardInfo.integralValue += e.integralValue;//积分增加
                ListViewItem li = lvMemberCardList.Items[selIndex];//获取当前项
                li.SubItems[5].Text = cardInfo.balance.ToString();
                li.SubItems[7].Text = cardInfo.integralValue.ToString();
            }
        }
    }
}
