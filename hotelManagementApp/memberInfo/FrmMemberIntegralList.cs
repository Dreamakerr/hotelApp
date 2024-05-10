using common;
using hotelManagementApp.BLL;
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
    public partial class FrmMemberIntegralList : Form
    {
        public FrmMemberIntegralList()
        {
            InitializeComponent();
        }

        memberIntegralBLL memberIntegralBLL = new memberIntegralBLL();
        List<vMemberCard> allList = new List<vMemberCard>();//存储所有列表


        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmMemberIntegralList_Load(object sender, EventArgs e)
        {
            findMemberIntegralList();
        }

        /// <summary>
        /// 查询会员积分列表
        /// </summary>
        /// <exception cref="NotImplementedException"></exception>
        private void findMemberIntegralList()
        {
            string msgTitle = "会员积分查询";
            lvMemberIntegralList.Items.Clear();
            //条件获取
            string keywords = txtKeyword.Text.Trim();
            int stInteVal = txtStIntegralValue.Text.GetInt();
            int etInteVal = txtEtIntegralValue.Text.GetInt();
            if(etInteVal > 0 && stInteVal > 0 && etInteVal < stInteVal)
            {
                MessageHelper.Error(msgTitle, "积分范围有误，请重新输入！");
                return;
            }
            //查询积分列表
            allList = memberIntegralBLL.findMemberIntegralList(keywords, stInteVal, etInteVal);
            if(allList.Count > 0)
            {
                //加载数据
                foreach(vMemberCard card in allList)
                {
                    ListViewItem li = addItem(card);
                    lvMemberIntegralList.Items.Add(li);
                }
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
            li.SubItems.Add(cardInfo.integralValue.ToString());
            li.SubItems.Add(formUtility.getStateName(cardInfo.cardState));
            return li;
        }

        /// <summary>
        /// 查询
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnFind_Click(object sender, EventArgs e)
        {
            findMemberIntegralList();
        }

        /// <summary>
        /// 清空积分
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnClear_Click(object sender, EventArgs e)
        {
            string msgTitle = "清空积分";
            if(lvMemberIntegralList.SelectedIndices.Count > 0)
            {
                //存储会员卡号-积分值的键值对
                Dictionary<string, int> dicInteList = new Dictionary<string, int>();
                //存储要清空积分的项的索引
                List<int> indexes = new List<int>();
                foreach(int index in lvMemberIntegralList.SelectedIndices)
                {
                    vMemberCard cardInfo = allList[index];
                    if(cardInfo.integralValue > 0)
                    {
                        indexes.Add(index);
                        dicInteList.Add(cardInfo.cardNo, cardInfo.integralValue);
                    }
                }
                if(indexes.Count > 0)
                {
                    if(MessageHelper.Confirm(msgTitle,"你确定要将选择的会员卡积分清空吗？") == DialogResult.OK)
                    {
                        bool blClear = memberIntegralBLL.clearCardIntegralValue(dicInteList);
                        if(blClear)
                        {
                            MessageHelper.Info(msgTitle, "会员卡积分清空成功！");
                            //刷新列表
                            foreach(int index in indexes)
                            {
                                allList[index].integralValue = 0;
                                //此项数据在列表中显示信息刷新
                                ListViewItem li = lvMemberIntegralList.Items[index];
                                li.SubItems[3].Text = "0";
                            }
                        }
                        else
                        {
                            MessageHelper.Error(msgTitle, "选择的会员卡积分清空失败！");
                            return;
                        }
                    }
                }
                else
                {
                    MessageHelper.Error(msgTitle, "没有符合清空条件的会员卡！");
                    return;
                }
            }
            else
            {
                MessageHelper.Error(msgTitle, "请选择要清空积分的会员卡！");
                return;
            }
        }
    }
}
