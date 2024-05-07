namespace hotelManagementApp.dataStat
{
    partial class FrmMemberExpendReport
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
            System.Windows.Forms.ListViewItem listViewItem2 = new System.Windows.Forms.ListViewItem(new string[] {
            "1001",
            "张三",
            "2024042900001",
            "3-3301",
            "680.00",
            "650.00",
            "2024-04-29 13:33:00"}, -1);
            this.colExpendTime = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPayAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colRoomNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCardNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lvMemberExpendList = new System.Windows.Forms.ListView();
            this.colExpendAmount = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lblSuperName = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lblAvgAmount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblMaxAmount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblMinAmount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblTotalAmount = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // colExpendTime
            // 
            this.colExpendTime.Text = "消费时间";
            this.colExpendTime.Width = 217;
            // 
            // colPayAmount
            // 
            this.colPayAmount.Text = "实付金额";
            this.colPayAmount.Width = 163;
            // 
            // colRoomNo
            // 
            this.colRoomNo.Text = "房间号";
            this.colRoomNo.Width = 132;
            // 
            // colCardNo
            // 
            this.colCardNo.Text = "卡号";
            this.colCardNo.Width = 182;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            this.colName.Width = 100;
            // 
            // colId
            // 
            this.colId.Text = "编号";
            // 
            // lvMemberExpendList
            // 
            this.lvMemberExpendList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvMemberExpendList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colCardNo,
            this.colRoomNo,
            this.colExpendAmount,
            this.colPayAmount,
            this.colExpendTime});
            this.lvMemberExpendList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvMemberExpendList.FullRowSelect = true;
            this.lvMemberExpendList.HideSelection = false;
            this.lvMemberExpendList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvMemberExpendList.Location = new System.Drawing.Point(30, 179);
            this.lvMemberExpendList.Name = "lvMemberExpendList";
            this.lvMemberExpendList.Size = new System.Drawing.Size(1023, 547);
            this.lvMemberExpendList.TabIndex = 29;
            this.lvMemberExpendList.UseCompatibleStateImageBehavior = false;
            this.lvMemberExpendList.View = System.Windows.Forms.View.Details;
            // 
            // colExpendAmount
            // 
            this.colExpendAmount.Text = "消费金额";
            this.colExpendAmount.Width = 158;
            // 
            // lblSuperName
            // 
            this.lblSuperName.AutoSize = true;
            this.lblSuperName.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSuperName.ForeColor = System.Drawing.Color.DeepPink;
            this.lblSuperName.Location = new System.Drawing.Point(940, 116);
            this.lblSuperName.Name = "lblSuperName";
            this.lblSuperName.Size = new System.Drawing.Size(54, 28);
            this.lblSuperName.TabIndex = 28;
            this.lblSuperName.Text = "张三";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(775, 116);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(159, 28);
            this.label10.TabIndex = 27;
            this.label10.Text = "最高消费会员：";
            // 
            // lblAvgAmount
            // 
            this.lblAvgAmount.AutoSize = true;
            this.lblAvgAmount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblAvgAmount.ForeColor = System.Drawing.Color.MediumBlue;
            this.lblAvgAmount.Location = new System.Drawing.Point(554, 116);
            this.lblAvgAmount.Name = "lblAvgAmount";
            this.lblAvgAmount.Size = new System.Drawing.Size(96, 28);
            this.lblAvgAmount.TabIndex = 26;
            this.lblAvgAmount.Text = "1000.00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(410, 116);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(138, 28);
            this.label8.TabIndex = 25;
            this.label8.Text = "平均日消费：";
            // 
            // lblMaxAmount
            // 
            this.lblMaxAmount.AutoSize = true;
            this.lblMaxAmount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMaxAmount.ForeColor = System.Drawing.Color.Red;
            this.lblMaxAmount.Location = new System.Drawing.Point(554, 55);
            this.lblMaxAmount.Name = "lblMaxAmount";
            this.lblMaxAmount.Size = new System.Drawing.Size(96, 28);
            this.lblMaxAmount.TabIndex = 24;
            this.lblMaxAmount.Text = "5000.00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(410, 55);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(138, 28);
            this.label6.TabIndex = 23;
            this.label6.Text = "最高日消费：";
            // 
            // lblMinAmount
            // 
            this.lblMinAmount.AutoSize = true;
            this.lblMinAmount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblMinAmount.ForeColor = System.Drawing.Color.DimGray;
            this.lblMinAmount.Location = new System.Drawing.Point(227, 116);
            this.lblMinAmount.Name = "lblMinAmount";
            this.lblMinAmount.Size = new System.Drawing.Size(83, 28);
            this.lblMinAmount.TabIndex = 22;
            this.lblMinAmount.Text = "500.00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(83, 116);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(138, 28);
            this.label4.TabIndex = 21;
            this.label4.Text = "最低日消费：";
            // 
            // lblTotalAmount
            // 
            this.lblTotalAmount.AutoSize = true;
            this.lblTotalAmount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalAmount.ForeColor = System.Drawing.Color.Brown;
            this.lblTotalAmount.Location = new System.Drawing.Point(227, 55);
            this.lblTotalAmount.Name = "lblTotalAmount";
            this.lblTotalAmount.Size = new System.Drawing.Size(122, 28);
            this.lblTotalAmount.TabIndex = 20;
            this.lblTotalAmount.Text = "500000.00";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(41, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(180, 28);
            this.label1.TabIndex = 19;
            this.label1.Text = "本月会员总消费：";
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Maroon;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatistics.Location = new System.Drawing.Point(877, 51);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(132, 37);
            this.btnStatistics.TabIndex = 41;
            this.btnStatistics.Text = "重新统计";
            this.btnStatistics.UseVisualStyleBackColor = false;
            // 
            // FrmMemberexpendReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1078, 781);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.lvMemberExpendList);
            this.Controls.Add(this.lblSuperName);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblAvgAmount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblMaxAmount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblMinAmount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalAmount);
            this.Controls.Add(this.label1);
            this.Name = "FrmMemberexpendReport";
            this.ShowIcon = false;
            this.Text = "会员消费报表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ColumnHeader colExpendTime;
        private System.Windows.Forms.ColumnHeader colPayAmount;
        private System.Windows.Forms.ColumnHeader colRoomNo;
        private System.Windows.Forms.ColumnHeader colCardNo;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ListView lvMemberExpendList;
        private System.Windows.Forms.ColumnHeader colExpendAmount;
        private System.Windows.Forms.Label lblSuperName;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblAvgAmount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblMaxAmount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblMinAmount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblTotalAmount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnStatistics;
    }
}