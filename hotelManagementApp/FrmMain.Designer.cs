namespace hotelManagementApp
{
    partial class FrmMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.miBasicInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miCardType = new System.Windows.Forms.ToolStripMenuItem();
            this.miMemberManage = new System.Windows.Forms.ToolStripMenuItem();
            this.miMemberInfo = new System.Windows.Forms.ToolStripMenuItem();
            this.miMemberCard = new System.Windows.Forms.ToolStripMenuItem();
            this.miIntegral = new System.Windows.Forms.ToolStripMenuItem();
            this.miDataStat = new System.Windows.Forms.ToolStripMenuItem();
            this.miNewMemberStat = new System.Windows.Forms.ToolStripMenuItem();
            this.miMemberExpendStat = new System.Windows.Forms.ToolStripMenuItem();
            this.miMemberIntegralStat = new System.Windows.Forms.ToolStripMenuItem();
            this.miExit = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnExit = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.menuStrip1.Dock = System.Windows.Forms.DockStyle.None;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBasicInfo,
            this.miMemberManage,
            this.miDataStat,
            this.miExit});
            this.menuStrip1.Location = new System.Drawing.Point(3, 74);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1776, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miBasicInfo
            // 
            this.miBasicInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCardType});
            this.miBasicInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miBasicInfo.Name = "miBasicInfo";
            this.miBasicInfo.Size = new System.Drawing.Size(126, 46);
            this.miBasicInfo.Text = "基础信息";
            // 
            // miCardType
            // 
            this.miCardType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miCardType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miCardType.Name = "miCardType";
            this.miCardType.Size = new System.Drawing.Size(270, 34);
            this.miCardType.Text = "会员卡类型管理";
            this.miCardType.Click += new System.EventHandler(this.miCardType_Click);
            // 
            // miMemberManage
            // 
            this.miMemberManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMemberInfo,
            this.miMemberCard,
            this.miIntegral});
            this.miMemberManage.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miMemberManage.Name = "miMemberManage";
            this.miMemberManage.Size = new System.Drawing.Size(126, 46);
            this.miMemberManage.Text = "会员管理";
            // 
            // miMemberInfo
            // 
            this.miMemberInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miMemberInfo.Name = "miMemberInfo";
            this.miMemberInfo.Size = new System.Drawing.Size(224, 34);
            this.miMemberInfo.Text = "会员档案管理";
            this.miMemberInfo.Click += new System.EventHandler(this.miMemberInfo_Click);
            // 
            // miMemberCard
            // 
            this.miMemberCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberCard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miMemberCard.Name = "miMemberCard";
            this.miMemberCard.Size = new System.Drawing.Size(224, 34);
            this.miMemberCard.Text = "会员卡操作";
            this.miMemberCard.Click += new System.EventHandler(this.miMemberCard_Click);
            // 
            // miIntegral
            // 
            this.miIntegral.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miIntegral.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miIntegral.Name = "miIntegral";
            this.miIntegral.Size = new System.Drawing.Size(224, 34);
            this.miIntegral.Text = "积分管理";
            this.miIntegral.Click += new System.EventHandler(this.miIntegral_Click);
            // 
            // miDataStat
            // 
            this.miDataStat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewMemberStat,
            this.miMemberExpendStat,
            this.miMemberIntegralStat});
            this.miDataStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miDataStat.Name = "miDataStat";
            this.miDataStat.Size = new System.Drawing.Size(126, 46);
            this.miDataStat.Text = "数据分析";
            // 
            // miNewMemberStat
            // 
            this.miNewMemberStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miNewMemberStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miNewMemberStat.Name = "miNewMemberStat";
            this.miNewMemberStat.Size = new System.Drawing.Size(224, 34);
            this.miNewMemberStat.Text = "新增会员分析";
            this.miNewMemberStat.Click += new System.EventHandler(this.miNewMemberStat_Click);
            // 
            // miMemberExpendStat
            // 
            this.miMemberExpendStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberExpendStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miMemberExpendStat.Name = "miMemberExpendStat";
            this.miMemberExpendStat.Size = new System.Drawing.Size(224, 34);
            this.miMemberExpendStat.Text = "消费行为分析";
            this.miMemberExpendStat.Click += new System.EventHandler(this.miMemberExpendStat_Click);
            // 
            // miMemberIntegralStat
            // 
            this.miMemberIntegralStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberIntegralStat.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miMemberIntegralStat.Name = "miMemberIntegralStat";
            this.miMemberIntegralStat.Size = new System.Drawing.Size(224, 34);
            this.miMemberIntegralStat.Text = "积分使用分析";
            this.miMemberIntegralStat.Click += new System.EventHandler(this.miMemberIntegralStat_Click);
            // 
            // miExit
            // 
            this.miExit.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(126, 46);
            this.miExit.Text = "退出系统";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.menuStrip1);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1679, 1049);
            this.panel1.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.Location = new System.Drawing.Point(721, 15);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(300, 48);
            this.textBox1.TabIndex = 56;
            this.textBox1.Text = "旅悦会";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(626, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(76, 71);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 55;
            this.pictureBox1.TabStop = false;
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Location = new System.Drawing.Point(1628, 0);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 52;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("华文彩云", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(199)))));
            this.label7.Location = new System.Drawing.Point(1340, 952);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(200, 46);
            this.label7.TabIndex = 60;
            this.label7.Text = "舒适传延";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("华文彩云", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(922, 952);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(200, 46);
            this.label6.TabIndex = 59;
            this.label6.Text = "精益求精";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("华文彩云", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(199)))));
            this.label5.Location = new System.Drawing.Point(504, 952);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 46);
            this.label5.TabIndex = 58;
            this.label5.Text = "服务当先";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("华文彩云", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(78)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(86, 952);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(200, 46);
            this.label4.TabIndex = 57;
            this.label4.Text = "客户心间";
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1705, 1076);
            this.Controls.Add(this.panel1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "酒店会员管理系统主页";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem miBasicInfo;
        private System.Windows.Forms.ToolStripMenuItem miCardType;
        private System.Windows.Forms.ToolStripMenuItem miMemberManage;
        private System.Windows.Forms.ToolStripMenuItem miMemberInfo;
        private System.Windows.Forms.ToolStripMenuItem miMemberCard;
        private System.Windows.Forms.ToolStripMenuItem miIntegral;
        private System.Windows.Forms.ToolStripMenuItem miDataStat;
        private System.Windows.Forms.ToolStripMenuItem miExit;
        private System.Windows.Forms.ToolStripMenuItem miNewMemberStat;
        private System.Windows.Forms.ToolStripMenuItem miMemberExpendStat;
        private System.Windows.Forms.ToolStripMenuItem miMemberIntegralStat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

