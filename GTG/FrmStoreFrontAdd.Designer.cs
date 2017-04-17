namespace GTG
{
    partial class FrmStoreFrontAdd
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
            this.lblSName = new System.Windows.Forms.Label();
            this.lblSAddress = new System.Windows.Forms.Label();
            this.lblSManagerName = new System.Windows.Forms.Label();
            this.lblPhone = new System.Windows.Forms.Label();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtSManagerName = new System.Windows.Forms.TextBox();
            this.txtPhone = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(50, 38);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(65, 12);
            this.lblSName.TabIndex = 0;
            this.lblSName.Text = "店面名称：";
            // 
            // lblSAddress
            // 
            this.lblSAddress.AutoSize = true;
            this.lblSAddress.Location = new System.Drawing.Point(50, 87);
            this.lblSAddress.Name = "lblSAddress";
            this.lblSAddress.Size = new System.Drawing.Size(41, 12);
            this.lblSAddress.TabIndex = 1;
            this.lblSAddress.Text = "地址：";
            // 
            // lblSManagerName
            // 
            this.lblSManagerName.AutoSize = true;
            this.lblSManagerName.Location = new System.Drawing.Point(50, 138);
            this.lblSManagerName.Name = "lblSManagerName";
            this.lblSManagerName.Size = new System.Drawing.Size(65, 12);
            this.lblSManagerName.TabIndex = 2;
            this.lblSManagerName.Text = "店长名称：";
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(50, 192);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 3;
            this.lblPhone.Text = "电话号码：";
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(128, 263);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 5;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(128, 35);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(176, 21);
            this.txtSName.TabIndex = 6;
            this.txtSName.Enter += new System.EventHandler(this.txtSName_Enter);
            this.txtSName.Leave += new System.EventHandler(this.txtSName_Leave);
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(128, 84);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(176, 21);
            this.txtSAddress.TabIndex = 7;
            this.txtSAddress.Enter += new System.EventHandler(this.txtSAddress_Enter);
            this.txtSAddress.Leave += new System.EventHandler(this.txtSAddress_Leave);
            // 
            // txtSManagerName
            // 
            this.txtSManagerName.Location = new System.Drawing.Point(128, 135);
            this.txtSManagerName.Name = "txtSManagerName";
            this.txtSManagerName.Size = new System.Drawing.Size(176, 21);
            this.txtSManagerName.TabIndex = 8;
            this.txtSManagerName.Enter += new System.EventHandler(this.txtSManagerName_Enter);
            this.txtSManagerName.Leave += new System.EventHandler(this.txtSManagerName_Leave);
            // 
            // txtPhone
            // 
            this.txtPhone.Location = new System.Drawing.Point(128, 189);
            this.txtPhone.Name = "txtPhone";
            this.txtPhone.Size = new System.Drawing.Size(176, 21);
            this.txtPhone.TabIndex = 9;
            this.txtPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // FrmStoreFrontAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(338, 336);
            this.Controls.Add(this.txtPhone);
            this.Controls.Add(this.txtSManagerName);
            this.Controls.Add(this.txtSAddress);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSManagerName);
            this.Controls.Add(this.lblSAddress);
            this.Controls.Add(this.lblSName);
            this.Name = "FrmStoreFrontAdd";
            this.Text = "增加店面信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSAddress;
        private System.Windows.Forms.Label lblSManagerName;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtSManagerName;
        private System.Windows.Forms.TextBox txtPhone;
    }
}