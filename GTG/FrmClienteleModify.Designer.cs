namespace GTG
{
    partial class FrmClienteleModify
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
            this.txtCTPhone = new System.Windows.Forms.TextBox();
            this.txtCTAddress = new System.Windows.Forms.TextBox();
            this.txtCTName = new System.Windows.Forms.TextBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.lblCTPhone = new System.Windows.Forms.Label();
            this.lblCTAddress = new System.Windows.Forms.Label();
            this.lblCTName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtCTPhone
            // 
            this.txtCTPhone.Location = new System.Drawing.Point(169, 210);
            this.txtCTPhone.Name = "txtCTPhone";
            this.txtCTPhone.Size = new System.Drawing.Size(176, 21);
            this.txtCTPhone.TabIndex = 25;
            // 
            // txtCTAddress
            // 
            this.txtCTAddress.Location = new System.Drawing.Point(169, 131);
            this.txtCTAddress.Name = "txtCTAddress";
            this.txtCTAddress.Size = new System.Drawing.Size(176, 21);
            this.txtCTAddress.TabIndex = 24;
            // 
            // txtCTName
            // 
            this.txtCTName.Location = new System.Drawing.Point(169, 56);
            this.txtCTName.Name = "txtCTName";
            this.txtCTName.Size = new System.Drawing.Size(176, 21);
            this.txtCTName.TabIndex = 23;
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(169, 306);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 22;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            // 
            // lblCTPhone
            // 
            this.lblCTPhone.AutoSize = true;
            this.lblCTPhone.Location = new System.Drawing.Point(91, 213);
            this.lblCTPhone.Name = "lblCTPhone";
            this.lblCTPhone.Size = new System.Drawing.Size(65, 12);
            this.lblCTPhone.TabIndex = 21;
            this.lblCTPhone.Text = "电话号码：";
            // 
            // lblCTAddress
            // 
            this.lblCTAddress.AutoSize = true;
            this.lblCTAddress.Location = new System.Drawing.Point(91, 134);
            this.lblCTAddress.Name = "lblCTAddress";
            this.lblCTAddress.Size = new System.Drawing.Size(41, 12);
            this.lblCTAddress.TabIndex = 20;
            this.lblCTAddress.Text = "地址：";
            // 
            // lblCTName
            // 
            this.lblCTName.AutoSize = true;
            this.lblCTName.Location = new System.Drawing.Point(91, 59);
            this.lblCTName.Name = "lblCTName";
            this.lblCTName.Size = new System.Drawing.Size(65, 12);
            this.lblCTName.TabIndex = 19;
            this.lblCTName.Text = "客户名称：";
            // 
            // FrmClienteleModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(412, 395);
            this.Controls.Add(this.txtCTPhone);
            this.Controls.Add(this.txtCTAddress);
            this.Controls.Add(this.txtCTName);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblCTPhone);
            this.Controls.Add(this.lblCTAddress);
            this.Controls.Add(this.lblCTName);
            this.Name = "FrmClienteleModify";
            this.Text = "修改客户信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCTPhone;
        private System.Windows.Forms.TextBox txtCTAddress;
        private System.Windows.Forms.TextBox txtCTName;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.Label lblCTPhone;
        private System.Windows.Forms.Label lblCTAddress;
        private System.Windows.Forms.Label lblCTName;
    }
}