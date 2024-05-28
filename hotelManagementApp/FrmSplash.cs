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
    public partial class FrmSplash : Form
    {
        public FrmSplash()
        {
            InitializeComponent();
        }

        int startpos = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            startpos += 4;
            myProgress.Value = startpos;
            lbPercentage.Text = startpos + "%";
            if(myProgress.Value == 100)
            {
                myProgress.Value = 0;
                timer1.Stop();
                FrmLogin login = new FrmLogin();
                this.Hide();
                login.Show();
                
            }
        }

        private void Frmsplash_Load(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
