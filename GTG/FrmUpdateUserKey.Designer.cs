namespace GTG
{
    partial class FrmUpdateUserKey
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txttwopassword = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(53, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "旧密码：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(53, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(53, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "新密码：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 159);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(77, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "确定新密码：";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(112, 44);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.Size = new System.Drawing.Size(100, 21);
            this.txtoldpassword.TabIndex = 3;
            this.txtoldpassword.Leave += new System.EventHandler(this.txtoldpassword_Leave);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(112, 101);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.Size = new System.Drawing.Size(100, 21);
            this.txtnewpassword.TabIndex = 4;
            // 
            // txttwopassword
            // 
            this.txttwopassword.Location = new System.Drawing.Point(112, 156);
            this.txttwopassword.Name = "txttwopassword";
            this.txttwopassword.Size = new System.Drawing.Size(100, 21);
            this.txttwopassword.TabIndex = 5;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(90, 216);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // FrmUpdateUserKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 259);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txttwopassword);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmUpdateUserKey";
            this.Text = "修改用户密码";
            this.Load += new System.EventHandler(this.FrmUpdateUserKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txttwopassword;
        private System.Windows.Forms.Button btnModify;
    }
}