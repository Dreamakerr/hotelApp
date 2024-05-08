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
    public partial class FrmCheckOut : Form
    {
        public FrmCheckOut()
        {
            InitializeComponent();
        }

        //当前会员的会员卡信息
        vMemberCard vMemberCard = null;
        public FrmCheckOut(vMemberCard VMemberCard)
        {
            InitializeComponent();
            vMemberCard = VMemberCard;
        }
        public event EventHandler<balanceRefreshEventArgs> checkedOut;//退房成功成功后触发事件
        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
