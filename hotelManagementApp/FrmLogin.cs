using hotelManagementApp.BLL;
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

namespace hotelManagementApp
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            //清空
            txtUserName.Clear();
            txtPassword.Clear();
            txtUserName.Focus();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 登录
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnLogin_Click(object sender, EventArgs e)
        {
            //获取帐号密码
            string username = txtUserName.Text.Trim();
            string password = txtPassword.Text.Trim();
            //检查信息是否为空
            if(string.IsNullOrEmpty(username) )
            {
                MessageHelper.Error("登录提示", "帐号不能为空！");
                txtUserName.Focus();
                return;
            }
            if (string.IsNullOrEmpty(password))
            {
                MessageHelper.Error("登录提示", "密码不能为空！");
                txtPassword.Focus();
                return;
            }

            //登录
            bool flag = false;
            userBLL userBLL = new userBLL();
            //调用登录方法
            flag = userBLL.Login(username, password);

            if(flag)
            {
                FrmMain frmMain = new FrmMain();
                frmMain.Show();
                this.Hide();
            }
            else
            {
                MessageHelper.Error("登录提示", "用户名或密码错误！");
                return;
            }
        }
    }
}
