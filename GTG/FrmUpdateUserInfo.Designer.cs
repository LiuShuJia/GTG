﻿namespace GTG
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
            this.lblrealName = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblIDcard = new System.Windows.Forms.Label();
            this.txtrealname = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnMofidy = new System.Windows.Forms.Button();
            this.cbosex = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtIDcard
            // 
            this.txtIDcard.Location = new System.Drawing.Point(146, 157);
            this.txtIDcard.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtIDcard.Name = "txtIDcard";
            this.txtIDcard.Size = new System.Drawing.Size(132, 25);
            this.txtIDcard.TabIndex = 3;
            this.txtIDcard.Leave += new System.EventHandler(this.txtIDcard_Leave);
            // 
            // lblrealName
            // 
            this.lblrealName.AutoSize = true;
            this.lblrealName.Location = new System.Drawing.Point(52, 45);
            this.lblrealName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblrealName.Name = "lblrealName";
            this.lblrealName.Size = new System.Drawing.Size(82, 15);
            this.lblrealName.TabIndex = 2;
            this.lblrealName.Text = "真实姓名：";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(63, 101);
            this.lblsex.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(52, 15);
            this.lblsex.TabIndex = 4;
            this.lblsex.Text = "性别：";
            // 
            // lblIDcard
            // 
            this.lblIDcard.AutoSize = true;
            this.lblIDcard.Location = new System.Drawing.Point(52, 161);
            this.lblIDcard.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblIDcard.Name = "lblIDcard";
            this.lblIDcard.Size = new System.Drawing.Size(82, 15);
            this.lblIDcard.TabIndex = 6;
            this.lblIDcard.Text = "身份证号：";
            // 
            // txtrealname
            // 
            this.txtrealname.Location = new System.Drawing.Point(146, 41);
            this.txtrealname.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtrealname.Name = "txtrealname";
            this.txtrealname.Size = new System.Drawing.Size(137, 25);
            this.txtrealname.TabIndex = 9;
            this.txtrealname.Leave += new System.EventHandler(this.txtrealname_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(51, 229);
            this.lblPhone.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(82, 15);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "联系方式：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(146, 225);
            this.txtPhone.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(132, 25);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // btnMofidy
            // 
            this.btnMofidy.Location = new System.Drawing.Point(146, 296);
            this.btnMofidy.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnMofidy.Name = "btnMofidy";
            this.btnMofidy.Size = new System.Drawing.Size(132, 29);
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
            this.cbosex.Location = new System.Drawing.Point(146, 97);
            this.cbosex.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbosex.Name = "cbosex";
            this.cbosex.Size = new System.Drawing.Size(137, 23);
            this.cbosex.TabIndex = 13;
            // 
            // FrmUpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(366, 366);
            this.Controls.Add(this.cbosex);
            this.Controls.Add(this.btnMofidy);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtrealname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblIDcard);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtIDcard);
            this.Controls.Add(this.lblrealName);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateUserInfo";
            this.Text = "修改用户信息";
            this.Load += new System.EventHandler(this.FrmUpdateUserInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIDcard;
        private System.Windows.Forms.Label lblrealName;
        private System.Windows.Forms.Label lblsex;
        private System.Windows.Forms.Label lblIDcard;
        private System.Windows.Forms.TextBox txtrealname;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.TextBox txtPhone;
        private System.Windows.Forms.Button btnMofidy;
        private System.Windows.Forms.ComboBox cbosex;
    }
}