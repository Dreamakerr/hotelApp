using hotelManagementApp.BLL;
using hotelManagementApp.Models;
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

        memberCardBLL memberCardBLL = new memberCardBLL();
        memberCard editInfo = null;//要修改的会员卡信息
        /// <summary>
        /// 通过会员卡号，创建会员卡信息
        /// </summary>
        /// <param name="cardNo"></param>
        public FrmMemberCardInfo(string cardNo)
        {
            InitializeComponent();
            editInfo = memberCardBLL.GetMemberCard(cardNo);
        }

        //会员卡信息添加成功后触发事件，事件参数传递会员卡号到会员管理页面
        public event EventHandler<mCardEventArgs> memberCardAdded;

        private void FrmMemberCardInfo_Load(object sender, EventArgs e)
        {

        }
    }
}
