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

namespace hotelManagementApp.basicData
{
    public partial class FrmMCardType : Form
    {
        public FrmMCardType()
        {
            InitializeComponent();
        }

        cardTypebusinessLayer cardTypeBLL = new cardTypebusinessLayer();
        int actType = 1;//信息栏提交状态 1-新增 2-修改
        int typeId = 0;//当前修改类型编号
        string oldTName = "";//修改前的类型名称
        List<cardType> allTypeList = new List<cardType>();//存储类型列表数据
        private void FrmMCardType_Load(object sender, EventArgs e)
        {
            //初始化信息栏
            initCtypeInfo();
            //加载会员卡类型列表
            loadAllCTypeList();

        }

        /// <summary>
        /// 加载会员卡类型列表
        /// </summary>
        private void loadAllCTypeList()
        {
            LbTypeList.Items.Clear();//清空列表数据
            //获取会员卡类型列表
            allTypeList = cardTypeBLL.getAllCardTypeList();
            if(allTypeList.Count > 0)
            {
                //加载数据
                foreach(cardType type in allTypeList) 
                { 
                    LbTypeList.Items.Add(type.cTypeId+"\t"+type.cTypeName);
                }
            }
        }

        /// <summary>
        /// 初始化信息栏，提交状态为新增
        /// </summary>
        private void initCtypeInfo()
        {
            txtTypeName.Clear();
            txtDiscount.Clear();
            txtgiveIntegral.Clear();
            txtRemark.Clear();
            actType = 1;//新增
            typeId = 0;
            btnAdd.Text = "新增";
            oldTName = "";
        }

        /// <summary>
        /// 清空
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClean_Click(object sender, EventArgs e)
        {
            //初始化信息栏
            initCtypeInfo();
        }

        /// <summary>
        /// 选择项改变时发生，加载会员卡类型信息至信息栏，提交状态为修改
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void LbtypeList_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(LbTypeList.SelectedItems.Count > 0)
            {
                //获取选择的类型
                string selItem = LbTypeList.SelectedItems[0].ToString();
                //获取id
                int id = int.Parse(selItem.Substring(0, 3));
                //获取该类型信息
                cardType edit = allTypeList.Find(t => t.cTypeId == id);
                if(edit != null)
                {
                    //加载至信息栏
                    txtTypeName.Text = edit.cTypeName;
                    txtRemark.Text = edit.remark;
                    txtDiscount.Text = edit.discount.ToString();
                    txtgiveIntegral.Text = edit.giveIntegral.ToString();
                    oldTName = edit.cTypeName;
                    typeId = id;//当前修改id
                    actType = 2;
                    btnAdd.Text = "修改";
                }
                else
                {
                    MessageHelper.Error("加载类型", "该类型信息不存在。");
                    return;
                }


            }
        }

        /// <summary>
        /// 会员卡类型提交
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnAdd_Click(object sender, EventArgs e)
        {
            //接受信息
            string typeName = txtTypeName.Text.Trim();
            string remark = txtRemark.Text.Trim();
            int discount = txtDiscount.Text.GetInt();
            int giveIntegral = txtgiveIntegral.Text.GetInt();
            //操作
            string actName = actType == 1 ? "新增" : "修改";
            //提示消息框
            string msgTitle = $"会员卡类型{actName}";
            
            //信息检查
            if(string.IsNullOrEmpty(typeName))
            {
                MessageHelper.Error(msgTitle, "会员卡类型名称不能为空。");
                txtTypeName.Focus();
                return;
            }

            //判断折扣是否合法
            if(discount < 0 || discount > 100)
            {
                MessageHelper.Error(msgTitle, "折扣不合法。");
                txtDiscount.Focus();
                return;
            }

            //判断赠送积分是否合法
            if (giveIntegral < 0)
            {
                MessageHelper.Error(msgTitle, "赠送积分不合法。");
                txtgiveIntegral.Focus();
                return;
            }

            //判断名称是否已存在（新增、修改状态下类型名修改）
            if (typeId == 0 || (actType == 2 && typeName != oldTName))
            {
                if (cardTypeBLL.existCardType(typeName))
                {
                    MessageHelper.Error(msgTitle, "会员卡类型名称已存在。");
                    txtTypeName.Focus();
                    return;
                }
            }


            //封装会员卡类型信息
            cardType cardType = new cardType()
            {
                cTypeId = typeId,
                cTypeName = typeName,
                discount = discount,
                giveIntegral = giveIntegral,
                remark = remark
            };

            //响应处理：新增-成功后转到修改状态，修改-成功后认为修改；刷新
            //提交信息
            if (actType == 1)//新增
            {
                int reTypeId = 0;
                reTypeId = cardTypeBLL.addCardType(cardType);
                if(reTypeId > 0)
                {
                    MessageHelper.Info(msgTitle, $"会员卡类型：{typeName} {actName}成功！");
                    allTypeList.Add(cardType);//添加新增类型信息到会员卡类型列表
                    LbTypeList.Items.Add(reTypeId + "\t" + typeName);//将新增类型添加到列表框中
                    typeId = reTypeId;
                    actType = 2;//状态转为修改
                    cardType.cTypeId = reTypeId;
                    oldTName = typeName;
                    btnAdd.Text = "修改";
                }
                else
                {
                    MessageHelper.Error(msgTitle, $"会员卡类型：{typeName} {actName}失败！");
                    return;
                }
            }
            else//修改提交
            {
                bool bledit = cardTypeBLL.editCardType(cardType);//修改提交
                if(bledit)
                {
                    MessageHelper.Info(msgTitle, $"会员卡类型：{typeName} {actName}成功！");
                    //替换原来的信息
                    int index = allTypeList.FindIndex(t=> t.cTypeId == typeId);//找到要替换的信息索引
                    LbTypeList.Items[index] = cardType.cTypeId + "\t" + typeName;//替换信息
                    allTypeList[index] = cardType;//替换类型列表中的信息
                    oldTName= typeName;//修改前的类型名称
                    txtTypeName.Text = typeName;
                    txtRemark.Text = remark;
                    txtDiscount.Text = discount.ToString();
                    txtgiveIntegral.Text = giveIntegral.ToString();
                }
                else
                {
                    MessageHelper.Error(msgTitle, $"会员卡类型：{typeName} {actName}失败！");
                    return;
                }
            }
        }

        /// <summary>
        /// 会员卡类型信息删除
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnDelete_Click(object sender, EventArgs e)
        {
            string msgTitle = "删除会员卡类型";
            var selIndexes = LbTypeList.SelectedIndices;//选择项索引集合

            if( selIndexes.Count == 0 )
            {
                MessageHelper.Error(msgTitle, "请选择要删除的会员卡类型！");
                return;
            }

            List<int> delTypeIds = new List<int>();//可以删除的类别编号
            string hasNames = "";
            foreach (int index in selIndexes)
            {
                int id = allTypeList[index].cTypeId;

                if(id == 101 || id == 102 || id == 103 || id == 104)
                {
                    MessageHelper.Error(msgTitle, "基础类型不得删除！");
                    return;
                }

                if (cardTypeBLL.hasMemberCards(id))
                {
                    if (hasNames.Length > 0)
                        hasNames += ",";
                    hasNames += allTypeList[index].cTypeName;//存储已有会员卡类型名
                    selIndexes.Remove(index);
                }
                else
                {
                    delTypeIds.Add(id);
                }
            }
            if (hasNames.Length > 0)
            {
                MessageHelper.Error(msgTitle, $"会员卡类型：{hasNames}已有会员卡，不能删除！");
            }
            if (delTypeIds.Count > 0)
            {
                if (MessageHelper.Confirm(msgTitle, "已选类型中有符合删除条件的，确定要删除选择的类型吗？") == DialogResult.OK)
                {
                    //删除选择的类型信息
                    bool blDelete = cardTypeBLL.deleteCardTypes(delTypeIds);
                    if (blDelete)
                    {
                        MessageHelper.Info(msgTitle, "会员卡类型删除成功");
                        foreach (int index in selIndexes)
                        {
                            allTypeList.RemoveAt(index);
                            LbTypeList.Items.RemoveAt(index);
                        }
                        if (txtTypeName.Text.Length > 0)//清空信息栏信息
                        {
                            initCtypeInfo();
                        }
                    }
                    else
                    {
                        MessageHelper.Error(msgTitle, "会员卡类型删除失败！");
                        return;
                    }
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "没有符合删除的会员卡类型信息！");
                return;
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
