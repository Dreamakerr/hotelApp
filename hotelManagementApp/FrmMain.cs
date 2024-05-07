using hotelManagementApp.basicData;
using hotelManagementApp.dataStat;
using hotelManagementApp.memberInfo;
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
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// 会员卡类型维护
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miCardType_Click(object sender, EventArgs e)
        {
            showForm<FrmMCardType>();
        }

        /// <summary>
        /// 会员信息管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miMemberInfo_Click(object sender, EventArgs e)
        {
            showForm<FrmMemberList>();
        }

        /// <summary>
        /// 会员卡管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miMemberCard_Click(object sender, EventArgs e)
        {
            showForm<FrmMemberCardList>();
        }

        /// <summary>
        /// 会员积分管理
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miIntegral_Click(object sender, EventArgs e)
        {
            showForm<FrmMemberIntegralList>();
        }

        /// <summary>
        /// 新增会员统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miNewMemberStat_Click(object sender, EventArgs e)
        {
            showForm<FrmNewMemberReport>();
        }

        /// <summary>
        /// 会员消费统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miMemberExpendStat_Click(object sender, EventArgs e)
        {
            showForm<FrmMemberExpendReport>();
        }

        /// <summary>
        /// 会员积分统计
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miMemberIntegralStat_Click(object sender, EventArgs e)
        {
            showForm<FrmMemberIntegralReport>();
        }

        /// <summary>
        /// 退出系统
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void miExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        /// <summary>
        /// 打开Form
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void showForm<T>() where T : Form
        {
            //反射技术
            //检查当前类型的form是否已打开，如果已打开，直接找到该Form对象，激活；未打开，创建Form对象，打开
            Type type = typeof(T);
            Form form = GetForm<T>();
            if (form == null)
            {
                //创建新form
                form = (Form)Activator.CreateInstance(type);
                if (form != null)
                {
                    form.MdiParent = this;
                    form.StartPosition = FormStartPosition.CenterScreen;
                    form.Show();//调用show方法
                }
            }
            else //已打开
            {
                form.Activate();
            }
        }

        /// <summary>
        /// 获取已打开的Form对象
        /// </summary>
        /// <typeparam name="T"></typeparam>
        /// <returns></returns>
        private Form GetForm<T>() where T:class
        {
            Type type = typeof(T);
            foreach(Form f in Application.OpenForms)
            {
                //找到Form
                if(f.GetType().Name == type.Name)
                {
                    return f;
                }
            }
            //未找到
            return null;
        }

        /// <summary>
        /// 关闭窗体
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void FrmMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Application.Exit();
            if (MessageHelper.Confirm("系统退出", "你是否要退出酒店会员管理系统？") == DialogResult.OK)
            {
                Application.ExitThread();
            }
            else
            {
                e.Cancel = true;//取消关闭
            }
        }
    }
}
