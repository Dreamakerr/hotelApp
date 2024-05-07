namespace hotelManagementApp.memberInfo
{
    partial class FrmIntegralExchange
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
            this.txtExchangeIntegral = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtIntegralValue = new System.Windows.Forms.TextBox();
            this.txtGiftName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCardNo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnOK = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtMName = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtExchangeIntegral
            // 
            this.txtExchangeIntegral.Location = new System.Drawing.Point(336, 347);
            this.txtExchangeIntegral.Name = "txtExchangeIntegral";
            this.txtExchangeIntegral.Size = new System.Drawing.Size(414, 28);
            this.txtExchangeIntegral.TabIndex = 57;
            this.txtExchangeIntegral.TextChanged += new System.EventHandler(this.txtExchangeIntegral_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(213, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(117, 28);
            this.label6.TabIndex = 56;
            this.label6.Text = "兑换积分：";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtIntegralValue
            // 
            this.txtIntegralValue.Location = new System.Drawing.Point(336, 197);
            this.txtIntegralValue.Name = "txtIntegralValue";
            this.txtIntegralValue.ReadOnly = true;
            this.txtIntegralValue.Size = new System.Drawing.Size(414, 28);
            this.txtIntegralValue.TabIndex = 55;
            this.txtIntegralValue.TextChanged += new System.EventHandler(this.txtDiscount_TextChanged);
            // 
            // txtGiftName
            // 
            this.txtGiftName.Location = new System.Drawing.Point(336, 273);
            this.txtGiftName.Name = "txtGiftName";
            this.txtGiftName.Size = new System.Drawing.Size(414, 28);
            this.txtGiftName.TabIndex = 53;
            this.txtGiftName.TextChanged += new System.EventHandler(this.txtGiftName_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(213, 273);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 28);
            this.label3.TabIndex = 52;
            this.label3.Text = "兑换礼品：";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtCardNo
            // 
            this.txtCardNo.Location = new System.Drawing.Point(336, 121);
            this.txtCardNo.Name = "txtCardNo";
            this.txtCardNo.ReadOnly = true;
            this.txtCardNo.Size = new System.Drawing.Size(414, 28);
            this.txtCardNo.TabIndex = 51;
            this.txtCardNo.TextChanged += new System.EventHandler(this.txtCardNo_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(213, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 28);
            this.label2.TabIndex = 50;
            this.label2.Text = "会员卡号：";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // btnOK
            // 
            this.btnOK.BackColor = System.Drawing.Color.RoyalBlue;
            this.btnOK.FlatAppearance.BorderSize = 0;
            this.btnOK.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnOK.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnOK.ForeColor = System.Drawing.SystemColors.Control;
            this.btnOK.Location = new System.Drawing.Point(454, 422);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(121, 59);
            this.btnOK.TabIndex = 49;
            this.btnOK.Text = "兑换";
            this.btnOK.UseVisualStyleBackColor = false;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(213, 197);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 28);
            this.label1.TabIndex = 47;
            this.label1.Text = "可用积分：";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtMName
            // 
            this.txtMName.Location = new System.Drawing.Point(336, 45);
            this.txtMName.Name = "txtMName";
            this.txtMName.ReadOnly = true;
            this.txtMName.Size = new System.Drawing.Size(414, 28);
            this.txtMName.TabIndex = 46;
            this.txtMName.TextChanged += new System.EventHandler(this.txtMName_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("微软雅黑", 10.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(213, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(117, 28);
            this.label4.TabIndex = 45;
            this.label4.Text = "会员姓名：";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // FrmIntegralExchange
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 533);
            this.Controls.Add(this.txtExchangeIntegral);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtIntegralValue);
            this.Controls.Add(this.txtGiftName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtCardNo);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtMName);
            this.Controls.Add(this.label4);
            this.Name = "FrmIntegralExchange";
            this.ShowIcon = false;
            this.Text = "积分兑换";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtExchangeIntegral;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtIntegralValue;
        private System.Windows.Forms.TextBox txtGiftName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCardNo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtMName;
        private System.Windows.Forms.Label label4;
    }
}