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
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.AutoSize = false;
            this.menuStrip1.BackColor = System.Drawing.Color.GhostWhite;
            this.menuStrip1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miBasicInfo,
            this.miMemberManage,
            this.miDataStat,
            this.miExit});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1433, 50);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // miBasicInfo
            // 
            this.miBasicInfo.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miCardType});
            this.miBasicInfo.Name = "miBasicInfo";
            this.miBasicInfo.Size = new System.Drawing.Size(112, 46);
            this.miBasicInfo.Text = "基础信息";
            // 
            // miCardType
            // 
            this.miCardType.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miCardType.Name = "miCardType";
            this.miCardType.Size = new System.Drawing.Size(238, 34);
            this.miCardType.Text = "会员卡类型维护";
            this.miCardType.Click += new System.EventHandler(this.miCardType_Click);
            // 
            // miMemberManage
            // 
            this.miMemberManage.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miMemberInfo,
            this.miMemberCard,
            this.miIntegral});
            this.miMemberManage.Name = "miMemberManage";
            this.miMemberManage.Size = new System.Drawing.Size(112, 46);
            this.miMemberManage.Text = "会员管理";
            // 
            // miMemberInfo
            // 
            this.miMemberInfo.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberInfo.Name = "miMemberInfo";
            this.miMemberInfo.Size = new System.Drawing.Size(220, 34);
            this.miMemberInfo.Text = "会员信息管理";
            this.miMemberInfo.Click += new System.EventHandler(this.miMemberInfo_Click);
            // 
            // miMemberCard
            // 
            this.miMemberCard.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberCard.Name = "miMemberCard";
            this.miMemberCard.Size = new System.Drawing.Size(220, 34);
            this.miMemberCard.Text = "会员卡管理";
            this.miMemberCard.Click += new System.EventHandler(this.miMemberCard_Click);
            // 
            // miIntegral
            // 
            this.miIntegral.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miIntegral.Name = "miIntegral";
            this.miIntegral.Size = new System.Drawing.Size(220, 34);
            this.miIntegral.Text = "会员积分管理";
            this.miIntegral.Click += new System.EventHandler(this.miIntegral_Click);
            // 
            // miDataStat
            // 
            this.miDataStat.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.miNewMemberStat,
            this.miMemberExpendStat,
            this.miMemberIntegralStat});
            this.miDataStat.Name = "miDataStat";
            this.miDataStat.Size = new System.Drawing.Size(112, 46);
            this.miDataStat.Text = "数据统计";
            // 
            // miNewMemberStat
            // 
            this.miNewMemberStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miNewMemberStat.Name = "miNewMemberStat";
            this.miNewMemberStat.Size = new System.Drawing.Size(220, 34);
            this.miNewMemberStat.Text = "新增会员统计";
            this.miNewMemberStat.Click += new System.EventHandler(this.miNewMemberStat_Click);
            // 
            // miMemberExpendStat
            // 
            this.miMemberExpendStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberExpendStat.Name = "miMemberExpendStat";
            this.miMemberExpendStat.Size = new System.Drawing.Size(220, 34);
            this.miMemberExpendStat.Text = "会员消费统计";
            this.miMemberExpendStat.Click += new System.EventHandler(this.miMemberExpendStat_Click);
            // 
            // miMemberIntegralStat
            // 
            this.miMemberIntegralStat.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.miMemberIntegralStat.Name = "miMemberIntegralStat";
            this.miMemberIntegralStat.Size = new System.Drawing.Size(220, 34);
            this.miMemberIntegralStat.Text = "会员积分统计";
            this.miMemberIntegralStat.Click += new System.EventHandler(this.miMemberIntegralStat_Click);
            // 
            // miExit
            // 
            this.miExit.Name = "miExit";
            this.miExit.Size = new System.Drawing.Size(112, 46);
            this.miExit.Text = "退出系统";
            this.miExit.Click += new System.EventHandler(this.miExit_Click);
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 807);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmMain";
            this.ShowIcon = false;
            this.Text = "酒店会员管理系统主页";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FrmMain_FormClosing);
            this.Load += new System.EventHandler(this.FrmMain_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
    }
}

