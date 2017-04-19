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
            this.components = new System.ComponentModel.Container();
            this.txtIDcard = new System.Windows.Forms.TextBox();
            this.lblrealName = new System.Windows.Forms.Label();
            this.lblsex = new System.Windows.Forms.Label();
            this.lblIDcard = new System.Windows.Forms.Label();
            this.txtrealname = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.btnMofidy = new System.Windows.Forms.Button();
            this.rdoMan = new System.Windows.Forms.RadioButton();
            this.rdoFamale = new System.Windows.Forms.RadioButton();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtIDcard
            // 
            this.txtIDcard.Location = new System.Drawing.Point(110, 126);
            this.txtIDcard.Name = "txtIDcard";
            this.txtIDcard.Size = new System.Drawing.Size(100, 21);
            this.txtIDcard.TabIndex = 3;
            this.txtIDcard.Leave += new System.EventHandler(this.txtIDcard_Leave);
            // 
            // lblrealName
            // 
            this.lblrealName.AutoSize = true;
            this.lblrealName.Location = new System.Drawing.Point(39, 36);
            this.lblrealName.Name = "lblrealName";
            this.lblrealName.Size = new System.Drawing.Size(65, 12);
            this.lblrealName.TabIndex = 2;
            this.lblrealName.Text = "真实姓名：";
            // 
            // lblsex
            // 
            this.lblsex.AutoSize = true;
            this.lblsex.Location = new System.Drawing.Point(47, 81);
            this.lblsex.Name = "lblsex";
            this.lblsex.Size = new System.Drawing.Size(41, 12);
            this.lblsex.TabIndex = 4;
            this.lblsex.Text = "性别：";
            // 
            // lblIDcard
            // 
            this.lblIDcard.AutoSize = true;
            this.lblIDcard.Location = new System.Drawing.Point(39, 129);
            this.lblIDcard.Name = "lblIDcard";
            this.lblIDcard.Size = new System.Drawing.Size(65, 12);
            this.lblIDcard.TabIndex = 6;
            this.lblIDcard.Text = "身份证号：";
            // 
            // txtrealname
            // 
            this.txtrealname.Location = new System.Drawing.Point(110, 33);
            this.txtrealname.Name = "txtrealname";
            this.txtrealname.Size = new System.Drawing.Size(100, 21);
            this.txtrealname.TabIndex = 9;
            this.txtrealname.Leave += new System.EventHandler(this.txtrealname_Leave);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(38, 183);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 8;
            this.lblPhone.Text = "联系方式：";
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(110, 180);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(100, 21);
            this.txtPhone.TabIndex = 11;
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // btnMofidy
            // 
            this.btnMofidy.Location = new System.Drawing.Point(70, 237);
            this.btnMofidy.Name = "btnMofidy";
            this.btnMofidy.Size = new System.Drawing.Size(99, 23);
            this.btnMofidy.TabIndex = 12;
            this.btnMofidy.Text = "修改";
            this.btnMofidy.UseVisualStyleBackColor = true;
            this.btnMofidy.Click += new System.EventHandler(this.btnMofidy_Click);
            // 
            // rdoMan
            // 
            this.rdoMan.AutoSize = true;
            this.rdoMan.Location = new System.Drawing.Point(110, 81);
            this.rdoMan.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoMan.Name = "rdoMan";
            this.rdoMan.Size = new System.Drawing.Size(35, 16);
            this.rdoMan.TabIndex = 13;
            this.rdoMan.TabStop = true;
            this.rdoMan.Text = "男";
            this.rdoMan.UseVisualStyleBackColor = true;
            // 
            // rdoFamale
            // 
            this.rdoFamale.AutoSize = true;
            this.rdoFamale.Location = new System.Drawing.Point(176, 81);
            this.rdoFamale.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rdoFamale.Name = "rdoFamale";
            this.rdoFamale.Size = new System.Drawing.Size(35, 16);
            this.rdoFamale.TabIndex = 14;
            this.rdoFamale.TabStop = true;
            this.rdoFamale.Text = "女";
            this.rdoFamale.UseVisualStyleBackColor = true;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // FrmUpdateUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(274, 293);
            this.Controls.Add(this.rdoFamale);
            this.Controls.Add(this.rdoMan);
            this.Controls.Add(this.btnMofidy);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtrealname);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblIDcard);
            this.Controls.Add(this.lblsex);
            this.Controls.Add(this.txtIDcard);
            this.Controls.Add(this.lblrealName);
            this.MaximizeBox = false;
            this.Name = "FrmUpdateUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "修改用户信息";
            this.Load += new System.EventHandler(this.FrmUpdateUserInfo_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
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
        private System.Windows.Forms.RadioButton rdoMan;
        private System.Windows.Forms.RadioButton rdoFamale;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}