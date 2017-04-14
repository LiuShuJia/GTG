namespace GTG
{
    partial class FrmUpdateUserInfo
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
            this.txtIDcard = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtrealname = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnMofidy = new System.Windows.Forms.Button();
            this.cbosex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtIDcard
            // 
            this.txtIDcard.Location = new System.Drawing.Point(137, 130);
            this.txtIDcard.Name = "txtIDcard";
            this.txtIDcard.Size = new System.Drawing.Size(100, 21);
            this.txtIDcard.TabIndex = 3;
            this.txtIDcard.Leave += new System.EventHandler(this.txtIDcard_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(67, 40);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 2;
            this.label2.Text = "真实姓名：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(75, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(41, 12);
            this.label3.TabIndex = 4;
            this.label3.Text = "性别：";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(67, 133);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 12);
            this.label4.TabIndex = 6;
            this.label4.Text = "身份证号：";
            // 
            // txtrealname
            // 
            this.txtrealname.Location = new System.Drawing.Point(137, 37);
            this.txtrealname.Name = "txtrealname";
            this.txtrealname.Size = new System.Drawing.Size(104, 21);
            this.txtrealname.TabIndex = 9;
            this.txtrealname.Leave += new System.EventHandler(this.txtrealname_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(66, 187);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(65, 12);
            this.label5.TabIndex = 8;
            this.label5.Text = "联系方式：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(137, 184);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // btnMofidy
            // 
            this.btnMofidy.Location = new System.Drawing.Point(110, 261);
            this.btnMofidy.Name = "btnMofidy";
            this.btnMofidy.Size = new System.Drawing.Size(75, 23);
            this.btnMofidy.TabIndex = 12;
            this.btnMofidy.Text = "修改";
            this.btnMofidy.UseVisualStyleBackColor = true;
            this.btnMofidy.Click += new System.EventHandler(this.btnMofidy_Click);
            // 
            // cbosex
            // 
            this.cbosex.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbosex.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.cbosex.FormattingEnabled = true;
            this.cbosex.Items.AddRange(new object[] {
            "男",
            "女"});
            this.cbosex.Location = new System.Drawing.Point(137, 82);
            this.cbosex.Name = "cbosex";
            this.cbosex.Size = new System.Drawing.Size(104, 20);
            this.cbosex.TabIndex = 13;
            // 
            // FrmUpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 296);
            this.Controls.Add(this.cbosex);
            this.Controls.Add(this.btnMofidy);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtrealname);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtIDcard);
            this.Controls.Add(this.label2);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateUserInfo";
            this.Text = "修改用户信息";
            this.Load += new System.EventHandler(this.FrmUpdateUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDcard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtrealname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnMofidy;
        private System.Windows.Forms.ComboBox cbosex;
    }
}