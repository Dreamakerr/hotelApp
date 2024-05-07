namespace hotelManagementApp.dataStat
{
    partial class FrmNewMemberReport
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
            "男",
            "普通会员",
            "13533665594",
            "2024-04-29"}, -1);
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblComCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSilverCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGoldCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblSuperCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvNewMemberList = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCardNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStatistics = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(47, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(159, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增会员统计：";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.Brown;
            this.lblTotalCount.Location = new System.Drawing.Point(212, 68);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(51, 28);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "100";
            // 
            // lblComCount
            // 
            this.lblComCount.AutoSize = true;
            this.lblComCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblComCount.Location = new System.Drawing.Point(212, 147);
            this.lblComCount.Name = "lblComCount";
            this.lblComCount.Size = new System.Drawing.Size(38, 28);
            this.lblComCount.TabIndex = 3;
            this.lblComCount.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(89, 147);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 2;
            this.label4.Text = "普通会员：";
            // 
            // lblSilverCount
            // 
            this.lblSilverCount.AutoSize = true;
            this.lblSilverCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSilverCount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSilverCount.Location = new System.Drawing.Point(477, 147);
            this.lblSilverCount.Name = "lblSilverCount";
            this.lblSilverCount.Size = new System.Drawing.Size(38, 28);
            this.lblSilverCount.TabIndex = 5;
            this.lblSilverCount.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(354, 147);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 4;
            this.label6.Text = "银卡会员：";
            // 
            // lblGoldCount
            // 
            this.lblGoldCount.AutoSize = true;
            this.lblGoldCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoldCount.ForeColor = System.Drawing.Color.Orange;
            this.lblGoldCount.Location = new System.Drawing.Point(797, 147);
            this.lblGoldCount.Name = "lblGoldCount";
            this.lblGoldCount.Size = new System.Drawing.Size(38, 28);
            this.lblGoldCount.TabIndex = 7;
            this.lblGoldCount.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(674, 147);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(117, 28);
            this.label8.TabIndex = 6;
            this.label8.Text = "金卡会员：";
            // 
            // lblSuperCount
            // 
            this.lblSuperCount.AutoSize = true;
            this.lblSuperCount.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSuperCount.ForeColor = System.Drawing.Color.DeepPink;
            this.lblSuperCount.Location = new System.Drawing.Point(1092, 147);
            this.lblSuperCount.Name = "lblSuperCount";
            this.lblSuperCount.Size = new System.Drawing.Size(38, 28);
            this.lblSuperCount.TabIndex = 9;
            this.lblSuperCount.Text = "13";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.Location = new System.Drawing.Point(978, 147);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(108, 28);
            this.label10.TabIndex = 8;
            this.label10.Text = "超级VIP：";
            // 
            // lvNewMemberList
            // 
            this.lvNewMemberList.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lvNewMemberList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colId,
            this.colName,
            this.colCardNo,
            this.colSex,
            this.colType,
            this.colPhone,
            this.colCreateDate});
            this.lvNewMemberList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvNewMemberList.FullRowSelect = true;
            this.lvNewMemberList.HideSelection = false;
            this.lvNewMemberList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem2});
            this.lvNewMemberList.Location = new System.Drawing.Point(28, 214);
            this.lvNewMemberList.Name = "lvNewMemberList";
            this.lvNewMemberList.Size = new System.Drawing.Size(1255, 420);
            this.lvNewMemberList.TabIndex = 18;
            this.lvNewMemberList.UseCompatibleStateImageBehavior = false;
            this.lvNewMemberList.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "编号";
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            this.colName.Width = 100;
            // 
            // colCardNo
            // 
            this.colCardNo.Text = "卡号";
            this.colCardNo.Width = 182;
            // 
            // colSex
            // 
            this.colSex.Text = "性别";
            this.colSex.Width = 64;
            // 
            // colPhone
            // 
            this.colPhone.Text = "手机号码";
            this.colPhone.Width = 163;
            // 
            // colType
            // 
            this.colType.Text = "会员类型";
            this.colType.Width = 100;
            // 
            // colCreateDate
            // 
            this.colCreateDate.Text = "创建日期";
            this.colCreateDate.Width = 135;
            // 
            // btnStatistics
            // 
            this.btnStatistics.BackColor = System.Drawing.Color.Maroon;
            this.btnStatistics.FlatAppearance.BorderSize = 0;
            this.btnStatistics.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnStatistics.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnStatistics.ForeColor = System.Drawing.SystemColors.Control;
            this.btnStatistics.Location = new System.Drawing.Point(1135, 68);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(132, 37);
            this.btnStatistics.TabIndex = 41;
            this.btnStatistics.Text = "重新统计";
            this.btnStatistics.UseVisualStyleBackColor = false;
            // 
            // FrmNewMemberReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1320, 688);
            this.Controls.Add(this.btnStatistics);
            this.Controls.Add(this.lvNewMemberList);
            this.Controls.Add(this.lblSuperCount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.lblGoldCount);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lblSilverCount);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.lblComCount);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lblTotalCount);
            this.Controls.Add(this.label1);
            this.Name = "FrmNewMemberReport";
            this.ShowIcon = false;
            this.Text = "新增会员报表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblTotalCount;
        private System.Windows.Forms.Label lblComCount;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblSilverCount;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblGoldCount;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label lblSuperCount;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ListView lvNewMemberList;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colCardNo;
        private System.Windows.Forms.ColumnHeader colSex;
        private System.Windows.Forms.ColumnHeader colType;
        private System.Windows.Forms.ColumnHeader colPhone;
        private System.Windows.Forms.ColumnHeader colCreateDate;
        private System.Windows.Forms.Button btnStatistics;
    }
}