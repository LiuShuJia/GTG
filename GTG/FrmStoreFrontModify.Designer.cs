namespace GTG
{
    partial class FrmStoreFrontModify
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
            this.txtSPhone = new System.Windows.Forms.TextBox();
            this.txtSManagerName = new System.Windows.Forms.TextBox();
            this.txtSAddress = new System.Windows.Forms.TextBox();
            this.txtSName = new System.Windows.Forms.TextBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.lblPhone = new System.Windows.Forms.Label();
            this.lblSManagerName = new System.Windows.Forms.Label();
            this.lblSAddress = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txtSPhone
            // 
            this.txtSPhone.Location = new System.Drawing.Point(136, 206);
            this.txtSPhone.Name = "txtSPhone";
            this.txtSPhone.Size = new System.Drawing.Size(176, 21);
            this.txtSPhone.TabIndex = 18;
            this.txtSPhone.Enter += new System.EventHandler(this.txtPhone_Enter);
            this.txtSPhone.Leave += new System.EventHandler(this.txtPhone_Leave);
            // 
            // txtSManagerName
            // 
            this.txtSManagerName.Location = new System.Drawing.Point(136, 152);
            this.txtSManagerName.Name = "txtSManagerName";
            this.txtSManagerName.Size = new System.Drawing.Size(176, 21);
            this.txtSManagerName.TabIndex = 17;
            this.txtSManagerName.Enter += new System.EventHandler(this.txtSManagerName_Enter);
            this.txtSManagerName.Leave += new System.EventHandler(this.txtSManagerName_Leave);
            // 
            // txtSAddress
            // 
            this.txtSAddress.Location = new System.Drawing.Point(136, 101);
            this.txtSAddress.Name = "txtSAddress";
            this.txtSAddress.Size = new System.Drawing.Size(176, 21);
            this.txtSAddress.TabIndex = 16;
            this.txtSAddress.Enter += new System.EventHandler(this.txtSAddress_Enter);
            this.txtSAddress.Leave += new System.EventHandler(this.txtSAddress_Leave);
            // 
            // txtSName
            // 
            this.txtSName.Location = new System.Drawing.Point(136, 52);
            this.txtSName.Name = "txtSName";
            this.txtSName.Size = new System.Drawing.Size(176, 21);
            this.txtSName.TabIndex = 15;
            this.txtSName.Enter += new System.EventHandler(this.txtSName_Enter);
            this.txtSName.Leave += new System.EventHandler(this.txtSName_Leave);
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(136, 280);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 14;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Location = new System.Drawing.Point(58, 209);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(65, 12);
            this.lblPhone.TabIndex = 13;
            this.lblPhone.Text = "电话号码：";
            // 
            // lblSManagerName
            // 
            this.lblSManagerName.AutoSize = true;
            this.lblSManagerName.Location = new System.Drawing.Point(58, 155);
            this.lblSManagerName.Name = "lblSManagerName";
            this.lblSManagerName.Size = new System.Drawing.Size(65, 12);
            this.lblSManagerName.TabIndex = 12;
            this.lblSManagerName.Text = "店长名称：";
            // 
            // lblSAddress
            // 
            this.lblSAddress.AutoSize = true;
            this.lblSAddress.Location = new System.Drawing.Point(58, 104);
            this.lblSAddress.Name = "lblSAddress";
            this.lblSAddress.Size = new System.Drawing.Size(41, 12);
            this.lblSAddress.TabIndex = 11;
            this.lblSAddress.Text = "地址：";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(58, 55);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(65, 12);
            this.lblSName.TabIndex = 10;
            this.lblSName.Text = "店面名称：";
            // 
            // FrmStoreFrontModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 349);
            this.Controls.Add(this.txtSPhone);
            this.Controls.Add(this.txtSManagerName);
            this.Controls.Add(this.txtSAddress);
            this.Controls.Add(this.txtSName);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.lblSManagerName);
            this.Controls.Add(this.lblSAddress);
            this.Controls.Add(this.lblSName);
            this.Name = "FrmStoreFrontModify";
            this.Text = "修改店面信息";
            this.Load += new System.EventHandler(this.FrmStoreFrontModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtSPhone;
        private System.Windows.Forms.TextBox txtSManagerName;
        private System.Windows.Forms.TextBox txtSAddress;
        private System.Windows.Forms.TextBox txtSName;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.Label lblPhone;
        private System.Windows.Forms.Label lblSManagerName;
        private System.Windows.Forms.Label lblSAddress;
        private System.Windows.Forms.Label lblSName;
    }
}