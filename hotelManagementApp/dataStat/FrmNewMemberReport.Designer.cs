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
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            "1001",
            "张三",
            "2024042900001",
            "男",
            "普通会员",
            "13533665594",
            "2024-04-29"}, -1);
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmNewMemberReport));
            this.label1 = new System.Windows.Forms.Label();
            this.lblTotalCount = new System.Windows.Forms.Label();
            this.lblComCount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblSilverCount = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.lblGoldCount = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.lblDiamondCount = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.lvNewMemberList = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCardNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colType = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCreateDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnStatistics = new System.Windows.Forms.Button();
            this.lblOtherCount = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.label1.Location = new System.Drawing.Point(45, 121);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(182, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "新增会员统计：";
            // 
            // lblTotalCount
            // 
            this.lblTotalCount.AutoSize = true;
            this.lblTotalCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblTotalCount.ForeColor = System.Drawing.Color.Brown;
            this.lblTotalCount.Location = new System.Drawing.Point(233, 124);
            this.lblTotalCount.Name = "lblTotalCount";
            this.lblTotalCount.Size = new System.Drawing.Size(59, 31);
            this.lblTotalCount.TabIndex = 1;
            this.lblTotalCount.Text = "100";
            // 
            // lblComCount
            // 
            this.lblComCount.AutoSize = true;
            this.lblComCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblComCount.ForeColor = System.Drawing.Color.DimGray;
            this.lblComCount.Location = new System.Drawing.Point(214, 194);
            this.lblComCount.Name = "lblComCount";
            this.lblComCount.Size = new System.Drawing.Size(44, 31);
            this.lblComCount.TabIndex = 3;
            this.lblComCount.Text = "20";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.label4.Location = new System.Drawing.Point(68, 194);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(134, 31);
            this.label4.TabIndex = 2;
            this.label4.Text = "普通会员：";
            // 
            // lblSilverCount
            // 
            this.lblSilverCount.AutoSize = true;
            this.lblSilverCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblSilverCount.ForeColor = System.Drawing.Color.DarkBlue;
            this.lblSilverCount.Location = new System.Drawing.Point(473, 194);
            this.lblSilverCount.Name = "lblSilverCount";
            this.lblSilverCount.Size = new System.Drawing.Size(44, 31);
            this.lblSilverCount.TabIndex = 5;
            this.lblSilverCount.Text = "15";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.label6.Location = new System.Drawing.Point(333, 194);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(134, 31);
            this.label6.TabIndex = 4;
            this.label6.Text = "银卡会员：";
            // 
            // lblGoldCount
            // 
            this.lblGoldCount.AutoSize = true;
            this.lblGoldCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblGoldCount.ForeColor = System.Drawing.Color.Orange;
            this.lblGoldCount.Location = new System.Drawing.Point(710, 194);
            this.lblGoldCount.Name = "lblGoldCount";
            this.lblGoldCount.Size = new System.Drawing.Size(44, 31);
            this.lblGoldCount.TabIndex = 7;
            this.lblGoldCount.Text = "50";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.label8.Location = new System.Drawing.Point(570, 194);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(134, 31);
            this.label8.TabIndex = 6;
            this.label8.Text = "金卡会员：";
            // 
            // lblDiamondCount
            // 
            this.lblDiamondCount.AutoSize = true;
            this.lblDiamondCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblDiamondCount.ForeColor = System.Drawing.Color.DeepPink;
            this.lblDiamondCount.Location = new System.Drawing.Point(961, 194);
            this.lblDiamondCount.Name = "lblDiamondCount";
            this.lblDiamondCount.Size = new System.Drawing.Size(44, 31);
            this.lblDiamondCount.TabIndex = 9;
            this.lblDiamondCount.Text = "13";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label10.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.label10.Location = new System.Drawing.Point(828, 194);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(134, 31);
            this.label10.TabIndex = 8;
            this.label10.Text = "钻卡会员：";
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
            this.lvNewMemberList.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvNewMemberList.FullRowSelect = true;
            this.lvNewMemberList.HideSelection = false;
            this.lvNewMemberList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvNewMemberList.Location = new System.Drawing.Point(28, 279);
            this.lvNewMemberList.Name = "lvNewMemberList";
            this.lvNewMemberList.Size = new System.Drawing.Size(1255, 463);
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
            // colType
            // 
            this.colType.Text = "会员卡类型";
            this.colType.Width = 131;
            // 
            // colPhone
            // 
            this.colPhone.Text = "手机号码";
            this.colPhone.Width = 163;
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
            this.btnStatistics.Location = new System.Drawing.Point(1126, 115);
            this.btnStatistics.Name = "btnStatistics";
            this.btnStatistics.Size = new System.Drawing.Size(132, 37);
            this.btnStatistics.TabIndex = 41;
            this.btnStatistics.Text = "重新统计";
            this.btnStatistics.UseVisualStyleBackColor = false;
            this.btnStatistics.Click += new System.EventHandler(this.btnStatistics_Click);
            // 
            // lblOtherCount
            // 
            this.lblOtherCount.AutoSize = true;
            this.lblOtherCount.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblOtherCount.ForeColor = System.Drawing.Color.MediumPurple;
            this.lblOtherCount.Location = new System.Drawing.Point(1136, 194);
            this.lblOtherCount.Name = "lblOtherCount";
            this.lblOtherCount.Size = new System.Drawing.Size(44, 31);
            this.lblOtherCount.TabIndex = 43;
            this.lblOtherCount.Text = "13";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(50)))), ((int)(((byte)(79)))), ((int)(((byte)(199)))));
            this.label3.Location = new System.Drawing.Point(1044, 194);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 31);
            this.label3.TabIndex = 42;
            this.label3.Text = "其他：";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.textBox2);
            this.panel1.Controls.Add(this.btnStatistics);
            this.panel1.Controls.Add(this.pictureBox2);
            this.panel1.Controls.Add(this.lblOtherCount);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.lblSilverCount);
            this.panel1.Controls.Add(this.lblGoldCount);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.lblDiamondCount);
            this.panel1.Controls.Add(this.lblComCount);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label10);
            this.panel1.Controls.Add(this.lblTotalCount);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(13, 13);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1295, 759);
            this.panel1.TabIndex = 44;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Transparent;
            this.button1.FlatAppearance.BorderSize = 0;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.button1.ForeColor = System.Drawing.Color.DarkBlue;
            this.button1.Location = new System.Drawing.Point(1245, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(50, 50);
            this.button1.TabIndex = 56;
            this.button1.Text = "X";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExit
            // 
            this.btnExit.BackColor = System.Drawing.Color.Transparent;
            this.btnExit.FlatAppearance.BorderSize = 0;
            this.btnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExit.Font = new System.Drawing.Font("微软雅黑", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExit.ForeColor = System.Drawing.Color.DarkBlue;
            this.btnExit.Location = new System.Drawing.Point(622, 354);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(50, 50);
            this.btnExit.TabIndex = 74;
            this.btnExit.Text = "X";
            this.btnExit.UseVisualStyleBackColor = false;
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(249)))), ((int)(((byte)(255)))));
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox2.Font = new System.Drawing.Font("微软雅黑", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox2.Location = new System.Drawing.Point(551, 13);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(227, 48);
            this.textBox2.TabIndex = 73;
            this.textBox2.Text = "新增会员分析";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(452, 0);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(75, 75);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 72;
            this.pictureBox2.TabStop = false;
            // 
            // FrmNewMemberReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(1320, 796);
            this.Controls.Add(this.lvNewMemberList);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmNewMemberReport";
            this.Text = "新增会员报表";
            this.Load += new System.EventHandler(this.FrmNewMemberReport_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

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
        private System.Windows.Forms.Label lblDiamondCount;
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
        private System.Windows.Forms.Label lblOtherCount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnExit;
    }
}