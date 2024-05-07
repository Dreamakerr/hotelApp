namespace hotelManagementApp.memberInfo
{
    partial class FrmMemberIntegralList
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
            "200",
            "已激活"}, -1);
            this.label5 = new System.Windows.Forms.Label();
            this.btnFind = new System.Windows.Forms.Button();
            this.txtKeyword = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtStIntegralValue = new System.Windows.Forms.TextBox();
            this.txtEtIntegralValue = new System.Windows.Forms.TextBox();
            this.btnExchange = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.lvMemberIntegralList = new System.Windows.Forms.ListView();
            this.colId = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colCardNo = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colIntegralValue = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colState = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label5.Location = new System.Drawing.Point(564, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(117, 28);
            this.label5.TabIndex = 42;
            this.label5.Text = "积分范围：";
            // 
            // btnFind
            // 
            this.btnFind.BackColor = System.Drawing.Color.Maroon;
            this.btnFind.FlatAppearance.BorderSize = 0;
            this.btnFind.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFind.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnFind.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFind.Location = new System.Drawing.Point(1133, 64);
            this.btnFind.Name = "btnFind";
            this.btnFind.Size = new System.Drawing.Size(95, 37);
            this.btnFind.TabIndex = 39;
            this.btnFind.Text = "查询";
            this.btnFind.UseVisualStyleBackColor = false;
            // 
            // txtKeyword
            // 
            this.txtKeyword.Location = new System.Drawing.Point(198, 68);
            this.txtKeyword.Name = "txtKeyword";
            this.txtKeyword.Size = new System.Drawing.Size(312, 28);
            this.txtKeyword.TabIndex = 41;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label7.Location = new System.Drawing.Point(87, 68);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(96, 28);
            this.label7.TabIndex = 40;
            this.label7.Text = "关键字：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(872, 68);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(28, 28);
            this.label1.TabIndex = 46;
            this.label1.Text = "~";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtStIntegralValue
            // 
            this.txtStIntegralValue.Location = new System.Drawing.Point(687, 68);
            this.txtStIntegralValue.Name = "txtStIntegralValue";
            this.txtStIntegralValue.Size = new System.Drawing.Size(170, 28);
            this.txtStIntegralValue.TabIndex = 47;
            // 
            // txtEtIntegralValue
            // 
            this.txtEtIntegralValue.Location = new System.Drawing.Point(918, 68);
            this.txtEtIntegralValue.Name = "txtEtIntegralValue";
            this.txtEtIntegralValue.Size = new System.Drawing.Size(170, 28);
            this.txtEtIntegralValue.TabIndex = 48;
            // 
            // btnExchange
            // 
            this.btnExchange.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnExchange.BackColor = System.Drawing.Color.DarkGreen;
            this.btnExchange.FlatAppearance.BorderSize = 0;
            this.btnExchange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExchange.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnExchange.ForeColor = System.Drawing.SystemColors.Control;
            this.btnExchange.Location = new System.Drawing.Point(946, 152);
            this.btnExchange.Name = "btnExchange";
            this.btnExchange.Size = new System.Drawing.Size(130, 37);
            this.btnExchange.TabIndex = 50;
            this.btnExchange.Text = "积分兑换";
            this.btnExchange.UseVisualStyleBackColor = false;
            // 
            // btnClear
            // 
            this.btnClear.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnClear.BackColor = System.Drawing.Color.Crimson;
            this.btnClear.FlatAppearance.BorderSize = 0;
            this.btnClear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClear.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnClear.ForeColor = System.Drawing.SystemColors.Control;
            this.btnClear.Location = new System.Drawing.Point(1101, 152);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(130, 37);
            this.btnClear.TabIndex = 49;
            this.btnClear.Text = "清空积分";
            this.btnClear.UseVisualStyleBackColor = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label8.Location = new System.Drawing.Point(48, 166);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(159, 28);
            this.label8.TabIndex = 54;
            this.label8.Text = "会员积分列表：";
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
            this.colState});
            this.lvMemberIntegralList.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lvMemberIntegralList.FullRowSelect = true;
            this.lvMemberIntegralList.HideSelection = false;
            this.lvMemberIntegralList.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.lvMemberIntegralList.Location = new System.Drawing.Point(35, 210);
            this.lvMemberIntegralList.Name = "lvMemberIntegralList";
            this.lvMemberIntegralList.Size = new System.Drawing.Size(1196, 591);
            this.lvMemberIntegralList.TabIndex = 53;
            this.lvMemberIntegralList.UseCompatibleStateImageBehavior = false;
            this.lvMemberIntegralList.View = System.Windows.Forms.View.Details;
            // 
            // colId
            // 
            this.colId.Text = "编号";
            // 
            // colCardNo
            // 
            this.colCardNo.Text = "会员卡号";
            this.colCardNo.Width = 182;
            // 
            // colName
            // 
            this.colName.Text = "姓名";
            this.colName.Width = 100;
            // 
            // colIntegralValue
            // 
            this.colIntegralValue.Text = "可用积分";
            this.colIntegralValue.Width = 120;
            // 
            // colState
            // 
            this.colState.Text = "卡状态";
            this.colState.Width = 135;
            // 
            // FrmMemberIntegralList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1266, 831);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.lvMemberIntegralList);
            this.Controls.Add(this.btnExchange);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.txtEtIntegralValue);
            this.Controls.Add(this.txtStIntegralValue);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.btnFind);
            this.Controls.Add(this.txtKeyword);
            this.Controls.Add(this.label7);
            this.Name = "FrmMemberIntegralList";
            this.ShowIcon = false;
            this.Text = "会员积分管理";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnFind;
        private System.Windows.Forms.TextBox txtKeyword;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtStIntegralValue;
        private System.Windows.Forms.TextBox txtEtIntegralValue;
        private System.Windows.Forms.Button btnExchange;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ListView lvMemberIntegralList;
        private System.Windows.Forms.ColumnHeader colId;
        private System.Windows.Forms.ColumnHeader colCardNo;
        private System.Windows.Forms.ColumnHeader colName;
        private System.Windows.Forms.ColumnHeader colIntegralValue;
        private System.Windows.Forms.ColumnHeader colState;
    }
}