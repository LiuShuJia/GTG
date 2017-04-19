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
            this.chexkShow = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // lbloldpassword
            // 
            this.lbloldpassword.AutoSize = true;
            this.lbloldpassword.Location = new System.Drawing.Point(51, 42);
            this.lbloldpassword.Name = "lbloldpassword";
            this.lbloldpassword.Size = new System.Drawing.Size(53, 12);
            this.lbloldpassword.TabIndex = 0;
            this.lbloldpassword.Text = "旧密码：";
            // 
            // lblnewpassword
            // 
            this.lblnewpassword.AutoSize = true;
            this.lblnewpassword.Location = new System.Drawing.Point(51, 96);
            this.lblnewpassword.Name = "lblnewpassword";
            this.lblnewpassword.Size = new System.Drawing.Size(53, 12);
            this.lblnewpassword.TabIndex = 1;
            this.lblnewpassword.Text = "新密码：";
            // 
            // lblsureNewpassword
            // 
            this.lblsureNewpassword.AutoSize = true;
            this.lblsureNewpassword.Location = new System.Drawing.Point(27, 154);
            this.lblsureNewpassword.Name = "lblsureNewpassword";
            this.lblsureNewpassword.Size = new System.Drawing.Size(77, 12);
            this.lblsureNewpassword.TabIndex = 2;
            this.lblsureNewpassword.Text = "确定新密码：";
            // 
            // txtoldpassword
            // 
            this.txtoldpassword.Location = new System.Drawing.Point(110, 39);
            this.txtoldpassword.Name = "txtoldpassword";
            this.txtoldpassword.PasswordChar = '*';
            this.txtoldpassword.Size = new System.Drawing.Size(70, 21);
            this.txtoldpassword.TabIndex = 3;
            this.txtoldpassword.Leave += new System.EventHandler(this.txtoldpassword_Leave);
            // 
            // txtnewpassword
            // 
            this.txtnewpassword.Location = new System.Drawing.Point(110, 96);
            this.txtnewpassword.Name = "txtnewpassword";
            this.txtnewpassword.PasswordChar = '*';
            this.txtnewpassword.Size = new System.Drawing.Size(70, 21);
            this.txtnewpassword.TabIndex = 4;
            // 
            // txtsureNewpassword
            // 
            this.txtsureNewpassword.Location = new System.Drawing.Point(110, 151);
            this.txtsureNewpassword.Name = "txtsureNewpassword";
            this.txtsureNewpassword.PasswordChar = '*';
            this.txtsureNewpassword.Size = new System.Drawing.Size(70, 21);
            this.txtsureNewpassword.TabIndex = 5;
            // 
            // btnModify
            // 
            this.btnModify.Location = new System.Drawing.Point(25, 211);
            this.btnModify.Name = "btnModify";
            this.btnModify.Size = new System.Drawing.Size(75, 23);
            this.btnModify.TabIndex = 6;
            this.btnModify.Text = "修改";
            this.btnModify.UseVisualStyleBackColor = true;
            this.btnModify.Click += new System.EventHandler(this.btnModify_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // chexkShow
            // 
            this.chexkShow.AutoSize = true;
            this.chexkShow.Location = new System.Drawing.Point(118, 216);
            this.chexkShow.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.chexkShow.Name = "chexkShow";
            this.chexkShow.Size = new System.Drawing.Size(72, 16);
            this.chexkShow.TabIndex = 7;
            this.chexkShow.Text = "显示密码";
            this.chexkShow.UseVisualStyleBackColor = true;
            this.chexkShow.CheckedChanged += new System.EventHandler(this.chexkShow_CheckedChanged);
            // 
            // FrmUpdateUserKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(232, 266);
            this.Controls.Add(this.chexkShow);
            this.Controls.Add(this.btnModify);
            this.Controls.Add(this.txtsureNewpassword);
            this.Controls.Add(this.txtnewpassword);
            this.Controls.Add(this.txtoldpassword);
            this.Controls.Add(this.lblsureNewpassword);
            this.Controls.Add(this.lblnewpassword);
            this.Controls.Add(this.lbloldpassword);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateUserKey";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.CheckBox chexkShow;
    }
}