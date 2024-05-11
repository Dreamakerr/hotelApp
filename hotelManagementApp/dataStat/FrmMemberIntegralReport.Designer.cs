namespace hotelManagementApp.dataStat
{
    partial class FrmMemberIntegralReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "01",
            "2024042900001",
            "张三",
            "2000",
            "3000",
            "-1000"}, -1);
            this.lvMemberIntegralList = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCardNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIntegralValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTotalIntegralValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colUsedIntegralValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblTotalMaxIntegral = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMaxIntegral = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalMinIntegral = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMinIntegral = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lvMemberIntegralList
            // 
            this.lvMemberIntegralList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMemberIntegralList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colCardNo,
            this.colName,
            this.colIntegralValue,
            this.colTotalIntegralValue,
            this.colUsedIntegralValue});
            this.lvMemberIntegralList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvMemberIntegralList.FullRowSelect = true;
            this.lvMemberIntegralList.HideSelection = false;
            this.lvMemberIntegralList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvMemberIntegralList.Location = new System.Drawing.Point(45, 141);
            this.lvMemberIntegralList.Name = "lvMemberIntegralList";
            this.lvMemberIntegralList.Size = new System.Drawing.Size(1327, 680);
            this.lvMemberIntegralList.TabIndex = 30;
            this.lvMemberIntegralList.UseCompatibleStateImageBehavior = false;
            this.lvMemberIntegralList.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "编号";
            this.colId.Width = 80;
            // 
            // colCardNo
            // 
            this.colCardNo.Text = "卡号";
            this.colCardNo.Width = 182;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            this.colName.Width = 117;
            // 
            // colIntegralValue
            // 
            this.colIntegralValue.Text = "可用积分";
            this.colIntegralValue.Width = 100;
            // 
            // colTotalIntegralValue
            // 
            this.colTotalIntegralValue.Text = "总积分";
            this.colTotalIntegralValue.Width = 100;
            // 
            // colUsedIntegralValue
            // 
            this.colUsedIntegralValue.Text = "已用积分";
            this.colUsedIntegralValue.Width = 100;
            // 
            // lblTotalMaxIntegral
            // 
            this.lblTotalMaxIntegral.AutoSize = true;
            this.lblTotalMaxIntegral.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalMaxIntegral.ForeColor = System.Drawing.Color.Red;
            this.lblTotalMaxIntegral.Location = new System.Drawing.Point(803, 80);
            this.lblTotalMaxIntegral.Name = "lblTotalMaxIntegral";
            this.lblTotalMaxIntegral.Size = new System.Drawing.Size(77, 28);
            this.lblTotalMaxIntegral.TabIndex = 34;
            this.lblTotalMaxIntegral.Text = "15000";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(396, 80);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 33;
            this.label6.Text = "最低积分：";
            // 
            // lblMaxIntegral
            // 
            this.lblMaxIntegral.AutoSize = true;
            this.lblMaxIntegral.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaxIntegral.ForeColor = System.Drawing.Color.Brown;
            this.lblMaxIntegral.Location = new System.Drawing.Point(189, 80);
            this.lblMaxIntegral.Name = "lblMaxIntegral";
            this.lblMaxIntegral.Size = new System.Drawing.Size(64, 28);
            this.lblMaxIntegral.TabIndex = 32;
            this.lblMaxIntegral.Text = "8000";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(66, 80);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 31;
            this.label1.Text = "最高积分：";
            // 
            // lblTotalMinIntegral
            // 
            this.lblTotalMinIntegral.AutoSize = true;
            this.lblTotalMinIntegral.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalMinIntegral.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblTotalMinIntegral.Location = new System.Drawing.Point(1083, 80);
            this.lblTotalMinIntegral.Name = "lblTotalMinIntegral";
            this.lblTotalMinIntegral.Size = new System.Drawing.Size(51, 28);
            this.lblTotalMinIntegral.TabIndex = 38;
            this.lblTotalMinIntegral.Text = "800";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(939, 80);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 28);
            this.label8.TabIndex = 37;
            this.label8.Text = "最低总积分：";
            // 
            // lblMinIntegral
            // 
            this.lblMinIntegral.AutoSize = true;
            this.lblMinIntegral.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMinIntegral.ForeColor = System.Drawing.Color.DimGray;
            this.lblMinIntegral.Location = new System.Drawing.Point(519, 80);
            this.lblMinIntegral.Name = "lblMinIntegral";
            this.lblMinIntegral.Size = new System.Drawing.Size(51, 28);
            this.lblMinIntegral.TabIndex = 36;
            this.lblMinIntegral.Text = "500";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(659, 80);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 35;
            this.label4.Text = "最高总积分：";
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Maroon;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatistics.Location = new System.Drawing.Point(1165, 76);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(132, 37);
            this.btnStatistics.TabIndex = 40;
            this.btnStatistics.Text = "重新统计";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // FrmMemberIntegralReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1407, 848);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.lblTotalMinIntegral);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMinIntegral);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalMaxIntegral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMaxIntegral);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lvMemberIntegralList);
            this.Name = "FrmMemberIntegralReport";
            this.ShowIcon = false;
            this.Text = "会员积分报表";
            this.Load += new System.EventHandler(this.FrmMemberIntegralReport_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lvMemberIntegralList;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCardNo;
        private System.Windows.Forms.ColumnHeader colIntegralValue;
        private System.Windows.Forms.ColumnHeader colTotalIntegralValue;
        private System.Windows.Forms.ColumnHeader colUsedIntegralValue;
        private System.Windows.Forms.Label lblTotalMaxIntegral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMaxIntegral;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalMinIntegral;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMinIntegral;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btnStatistics;
    }
}