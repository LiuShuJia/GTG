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
            this.components = new System.ComponentModel.Container();
            this.lbloldpassword = new System.Windows.Forms.Label();
            this.lblnewpassword = new System.Windows.Forms.Label();
            this.lblsureNewpassword = new System.Windows.Forms.Label();
            this.txtoldpassword = new System.Windows.Forms.TextBox();
            this.txtnewpassword = new System.Windows.Forms.TextBox();
            this.txtsureNewpassword = new System.Windows.Forms.TextBox();
            this.btnModify = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloldpassword
            // 
            this.lbloldpassword.AutoSize = true;
            this.lbloldpassword.Location = new System.Drawing.Point(68, 53);
            this.lbloldpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbloldpassword.Name = "lbloldpassword";
            this.lbloldpassword.Size = new System.Drawing.Size(67, 15);
            this.lbloldpassword.TabIndex = 0;
            this.lbloldpassword.Text = "旧密码：";
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Location = new System.Drawing.Point(68, 120);
            this.lblnewpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(67, 15);
            this.lblnewpassword.TabIndex = 1;
            this.lblnewpassword.Text = "新密码：";
            // 
            // lblsureNewpassword
            // 
            this.lblsureNewpassword.AutoSize = true;
            this.lblsureNewpassword.Location = new System.Drawing.Point(36, 193);
            this.lblsureNewpassword.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblsureNewpassword.Name = "lblsureNewpassword";
            this.lblsureNewpassword.Size = new System.Drawing.Size(97, 15);
            this.lblsureNewpassword.TabIndex = 2;
            this.lblsureNewpassword.Text = "确定新密码：";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(146, 49);
            this.txtoldpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.PasswordChar = '*';
            this.txtoldpassword.Size = new System.Drawing.Size(92, 25);
            this.txtoldpassword.TabIndex = 3;
            this.txtoldpassword.Leave += new System.EventHandler(this.txtoldpassword_Leave);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(146, 120);
            this.txtnewpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.PasswordChar = '*';
            this.txtnewpassword.Size = new System.Drawing.Size(92, 25);
            this.txtnewpassword.TabIndex = 4;
            // 
            // txtsureNewpassword
            // 
            this.txtsureNewpassword.Location = new System.Drawing.Point(146, 189);
            this.txtsureNewpassword.Margin = new System.Windows.Forms.Padding(4);
            this.txtsureNewpassword.Name = "txtsureNewpassword";
            this.txtsureNewpassword.PasswordChar = '*';
            this.txtsureNewpassword.Size = new System.Drawing.Size(92, 25);
            this.txtsureNewpassword.TabIndex = 5;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(90, 260);
            this.btnModify.Margin = new System.Windows.Forms.Padding(4);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(100, 29);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUpdateUserKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(310, 332);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtsureNewpassword);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.lblsureNewpassword);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.lbloldpassword);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateUserKey";
            this.Text = "修改用户密码";
            this.Load += new System.EventHandler(this.FrmUpdateUserKey_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbloldpassword;
        private System.Windows.Forms.Label lblnewpassword;
        private System.Windows.Forms.Label lblsureNewpassword;
        private System.Windows.Forms.TextBox txtoldpassword;
        private System.Windows.Forms.TextBox txtnewpassword;
        private System.Windows.Forms.TextBox txtsureNewpassword;
        private System.Windows.Forms.Button btnModify;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}