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
using System.Xml.Linq;

namespace hotelManagementApp.memberInfo
{
    public partial class FrmMemberList : Form
    {
        public FrmMemberList()
        {
            InitializeComponent();
        }
        memberbusinessLayer memberBLL = new memberbusinessLayer();
        memberCardbusinessLayer memberCardBLL = new memberCardbusinessLayer();

        int actType = 1; //信息栏提交状态 1-新增，2-修改
        int memberId = 0;//当前修改的会员编号
        string oldName = "";//修改会员名称+电话
        List<member> allMembers = new List<member>();//所有会员列表


        /// <summary>
        /// 页面加载
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMemberList_Load(object sender, EventArgs e)
        {
            //清空信息栏
            initMember();
            //加载会员列表
            loadMemberList();

        }

        /// <summary>
        /// 加载会员列表
        /// </summary>
        private void loadMemberList()
        {
            lvMemberList.Items.Clear();//清空
            string keywords = txtKeyword.Text.Trim();//关键词
            bool blDel = chkShowDel.Checked;//是否已删除
            allMembers = memberBLL.findMemberList(keywords, blDel);//查询会员列表
            if(allMembers.Count > 0)
            {
                //加载数据到listview
                foreach(member member in allMembers)
                {
                    //把每个会员信息转换成listviewitem
                    ListViewItem li = addItem(member);
                    lvMemberList.Items.Add(li);
                }

                //处理行操作按钮显示
                btnFindCard.Visible = !blDel;
                btnEdit.Visible = !blDel;
                btnDelete.Visible = !blDel;
                btnRecover.Visible = blDel;
                btnRemove.Visible = blDel;

            }


        }

        /// <summary>
        /// 创建ListViewItem项
        /// </summary>
        /// <param name="member"></param>
        /// <returns></returns>
        private ListViewItem addItem(member member)
        {
            ListViewItem li = new ListViewItem();
            li.Text = member.memberId.ToString();
            li.SubItems.Add(member.mName);
            li.SubItems.Add(member.cardNo);
            li.SubItems.Add(member.sex);
            li.SubItems.Add(member.phone);
            string strNew = member.isNew ? "是" : "否";
            li.SubItems.Add(strNew);
            li.SubItems.Add(member.createTime.ToString("yyyy-MM-dd HH:mm:ss"));
            return li;
        }

        /// <summary>
        /// 清空信息栏
        /// </summary>
        private void initMember()
        {
            txtMName.Clear();
            txtCardNo.Clear();
            txtPhone.Clear();
            TxtRemark.Clear();
            cboSex.SelectedIndex = 0;
            cboNew.SelectedIndex = 0;
            actType = 1;
            btnAdd.Text = "新增";
            memberId = 0;
            oldName = "";
            btnAddCard.Visible = true;
        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            loadMemberList();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 清空信息栏，切换至新增
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, EventArgs e)
        {
            initMember();
        }

        /// <summary>
        /// 已删除切换
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void chkShowDel_CheckedChanged(object sender, EventArgs e)
        {
            loadMemberList();
        }

        /// <summary>
        /// 显示添加会员卡信息页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAddCard_Click(object sender, EventArgs e)
        {
            FrmMemberCardInfo frmMemberCardInfo = new FrmMemberCardInfo();
            frmMemberCardInfo.MdiParent = this.MdiParent;
            frmMemberCardInfo.memberCardAdded += FrmMemberCardInfo_memberCardAdded;
            frmMemberCardInfo.Show();

        }

        /// <summary>
        /// 会员卡添加成功后执行处理程序
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMemberCardInfo_memberCardAdded(object sender, utility.mCardEventArgs e)
        {
            if(!string.IsNullOrEmpty(e.cardNo))
            {
                txtCardNo.Text = e.cardNo;
            }
        }

        /// <summary>
        /// 选择会员，打开会员卡修改页面
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFindCard_Click(object sender, EventArgs e)
        {
            if(lvMemberList.SelectedIndices.Count > 0)
            {
                int selIndex = lvMemberList.SelectedIndices[0];//选择的会员
                //会员信息
                member editInfo = allMembers[selIndex];
                string cardNo = editInfo.cardNo;
                if(!string.IsNullOrEmpty(cardNo))
                {
                    //打开修改会员卡页面
                    FrmMemberCardInfo frmMemberCardInfo = new FrmMemberCardInfo(cardNo);
                    frmMemberCardInfo.MdiParent = this.MdiParent;
                    frmMemberCardInfo.Show();
                }
                else
                {
                    MessageHelper.Error("修改会员卡", "该会员还没有办理会员卡！");
                    return;
                }
            }
            else
            {
                MessageHelper.Error("修改会员卡", "请选择会员！");
                return;
            }
        }

        /// <summary>
        /// 选择会员卡，加载该会员信息，提交状态为修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if (lvMemberList.SelectedIndices.Count > 0)
            {
                int selIndex = lvMemberList.SelectedIndices[0];//选择的会员
                //会员信息
                member editInfo = allMembers[selIndex];
                txtMName.Text = editInfo.mName;
                txtCardNo.Text = editInfo.cardNo;
                txtPhone.Text = editInfo.phone;
                TxtRemark.Text = editInfo.remark;
                cboSex.Text = editInfo.sex;
                cboNew.Text = editInfo.isNew ? "是" : "否";
                memberId = editInfo.memberId;
                actType = 2;//修改
                btnAdd.Text = "修改";
                oldName = editInfo.mName + editInfo.phone;
                if(!string.IsNullOrEmpty(editInfo.cardNo))
                {
                    btnAddCard.Visible = false;
                } else
                {
                    btnAddCard.Visible = true;
                }
            }
            else
            {
                MessageHelper.Error("修改会员", "请选择要修改的会员！");
                return;
            }
        }

        /// <summary>
        /// 会员信息提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //接收信息
            string mName = txtMName.Text.Trim();
            string cardNo = txtCardNo.Text.Trim();
            string sex = cboSex.Text.Trim();
            bool isNew = cboNew.Text.Trim() == "是"? true: false;
            string phone = txtPhone.Text.Trim();
            string remark = TxtRemark.Text.Trim();
            if(string.IsNullOrEmpty(cardNo))
                cardNo = null;
            string actName = actType == 1 ? "新增" : "修改";
            string msgTitle = $"会员{actName}";//消息框标题

            //信息检查
            if (string.IsNullOrEmpty(mName))
            {
                MessageHelper.Error(msgTitle, "会员姓名不能为空！");
                txtMName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(phone))
            {
                MessageHelper.Error(msgTitle, "会员手机号不能为空！");
                txtPhone.Focus();
                return;
            }
            //检查会员是否存在
            if(memberId == 0 || (actType == 2 && mName + phone != oldName))
            {
                if(memberBLL.existMember(mName, phone))
                {
                    MessageHelper.Error(msgTitle, "该会员信息已存在！");
                    txtMName.Focus();
                    return;
                }
            }
            //信息封装
            member memberInfo = new member()
            {
                memberId = memberId,
                mName = mName,
                cardNo = cardNo,
                sex = sex,
                phone = phone,
                isNew = isNew,
                remark = remark,
            };

            if (actType == 1)
            {
                memberInfo.createTime = DateTime.Now;
            }

            //提交与响应
            if(actType == 1)//新增成功，转成修改状态
            {
                int reId = 0;
                reId = memberBLL.addMember(memberInfo);
                if(reId > 0)
                {
                    MessageHelper.Info(msgTitle, $"会员：{mName}{actName}成功！");
                    memberInfo.memberId = reId;
                    allMembers.Add(memberInfo);//添加信息到所有会员列表
                    lvMemberList.Items.Add(addItem(memberInfo));//将新增会员添加到列表视图中
                    if (!string.IsNullOrEmpty(cardNo))
                        btnAddCard.Visible = false;
                    else 
                        btnAddCard.Visible = true;
                    actType = 2;
                    btnAdd.Text = "修改";
                    oldName = mName + phone;
                }
                else
                {
                    MessageHelper.Error(msgTitle, $"会员：{mName}{actName}失败！");
                    return;
                }
            }
            else//修改
            {
                bool blEdit = memberBLL.editMember(memberInfo);
                if(blEdit)
                {
                    MessageHelper.Info(msgTitle, $"会员：{mName}{actName}成功！");
                    //替换原来的信息
                    int index = allMembers.FindIndex(m => m.memberId == memberId);
                    memberInfo.createTime = allMembers[index].createTime;
                    lvMemberList.Items[index] = addItem(memberInfo);
                    allMembers[index] = memberInfo;
                    oldName = mName + phone;
                }
                else
                {
                    MessageHelper.Error(msgTitle, $"会员：{mName}{actName}失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 会员信息删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msgTitle = "删除会员";
            if(lvMemberList.SelectedIndices.Count > 0)
            {
                List<int> delIds = new List<int>();//要删除的会员编号
                string hasUsedName = "";//会员卡处理激活状态下的会员姓名
                List<int> delIndexes = new List<int>();//选择的会员信息所在的索引集合
                foreach(int index in lvMemberList.SelectedIndices)
                {
                    member memberInfo = allMembers[index];
                    int memberId = memberInfo.memberId;
                    if (!string.IsNullOrEmpty(memberInfo.cardNo))
                    {
                        //会员卡信息
                        memberCard memberCard = memberCardBLL.GetMemberCard(memberInfo.cardNo);
                        if(memberCard != null && memberCard.cardState == 1) //不能删除
                        {
                            if (hasUsedName.Length > 0) hasUsedName += ",";
                            hasUsedName += memberInfo.mName;
                        }
                        else
                        {
                            delIds.Add(memberId);
                            delIndexes.Add(index);
                        }
                    }
                    else
                    {
                        delIds.Add(memberId);
                        delIndexes.Add(index);
                    }
                }
                if(hasUsedName.Length > 0)
                {
                    MessageHelper.Error(msgTitle, $"选择会员中，会员：{hasUsedName}的会员卡仍处于激活状态，不能删除！");
                }
                if(delIds.Count > 0)
                {
                    if(MessageHelper.Confirm(msgTitle, "你确定要删除选择的会员信息吗？删除信息包括会员卡信息、积分信息、消费记录、充值记录等。") == DialogResult.OK)
                    {
                        bool blDel = memberBLL.deleteMember(delIds);
                        if(blDel)
                        {
                            MessageHelper.Info(msgTitle, "选择会员信息删除成功！");
                            //刷新界面
                            var delLsit = allMembers.Where(m=>delIds.Contains(m.memberId)).ToList();
                            delLsit.ForEach(m =>
                            {
                                allMembers.Remove(m);
                            });
                            //移除界面上的列表
                            delIndexes.Reverse();//翻转，从尾部删除
                            foreach(int index in delIndexes)
                            {
                                lvMemberList.Items.RemoveAt(index);//移除已删除的数据
                            }
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, "选择会员信息删除失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要删除的会员信息！");
                return;
            }
        }

        /// <summary>
        /// 恢复会员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRecover_Click(object sender, EventArgs e)
        {
            string msgTitle = "恢复会员";
            if (lvMemberList.SelectedIndices.Count > 0)
            {
                List<int> delIds = new List<int>();//要恢复的会员编号
                List<int> delIndexes = new List<int>();//选择的会员信息所在的索引集合
                foreach (int index in lvMemberList.SelectedIndices)
                {
                    member memberInfo = allMembers[index];
                    int memberId = memberInfo.memberId;
                    delIds.Add(memberId);
                    delIndexes.Add(index);
                }
                if (delIds.Count > 0)
                {
                    if (MessageHelper.Confirm(msgTitle, "你确定要恢复选择的会员信息吗？恢复信息包括会员卡信息、积分信息、消费记录、充值记录等。") == DialogResult.OK)
                    {
                        bool blRecover = memberBLL.recoverMember(delIds);
                        if (blRecover)
                        {
                            MessageHelper.Info(msgTitle, "选择会员信息恢复成功！");
                            //刷新界面
                            var delLsit = allMembers.Where(m => delIds.Contains(m.memberId)).ToList();
                            delLsit.ForEach(m =>
                            {
                                allMembers.Remove(m);
                            });
                            //移除界面上的列表
                            delIndexes.Reverse();//翻转，从尾部删除
                            foreach (int index in delIndexes)
                            {
                                lvMemberList.Items.RemoveAt(index);//移除已删除的数据
                            }
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, "选择会员信息恢复失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要恢复的会员信息！");
                return;
            }
        }

        /// <summary>
        /// 移除会员信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnRemove_Click(object sender, EventArgs e)
        {
            string msgTitle = "移除会员";
            if (lvMemberList.SelectedIndices.Count > 0)
            {
                List<int> delIds = new List<int>();//要移除的会员编号
                List<int> delIndexes = new List<int>();//选择的会员信息所在的索引集合
                foreach (int index in lvMemberList.SelectedIndices)
                {
                    member memberInfo = allMembers[index];
                    int memberId = memberInfo.memberId;
                    delIds.Add(memberId);
                    delIndexes.Add(index);
                }
                if (delIds.Count > 0)
                {
                    if (MessageHelper.Confirm(msgTitle, "你确定要移除选择的会员信息吗？移除信息包括会员卡信息、积分信息、消费记录、充值记录等。") == DialogResult.OK)
                    {
                        bool blRemove = memberBLL.removeMember(delIds);
                        if (blRemove)
                        {
                            MessageHelper.Info(msgTitle, "选择会员信息移除成功！");
                            //刷新界面
                            var delLsit = allMembers.Where(m => delIds.Contains(m.memberId)).ToList();
                            delLsit.ForEach(m =>
                            {
                                allMembers.Remove(m);
                            });
                            //移除界面上的列表
                            delIndexes.Reverse();//翻转，从尾部删除
                            foreach (int index in delIndexes)
                            {
                                lvMemberList.Items.RemoveAt(index);//移除已删除的数据
                            }
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, "选择会员信息移除失败！");
                            return;
                        }
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要移除的会员信息！");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
