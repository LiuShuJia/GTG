namespace GTG
{
    partial class FrmClienteleDelete
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
            this.lblCTName1 = new System.Windows.Forms.Label();
            this.lblCTAddress1 = new System.Windows.Forms.Label();
            this.lblCTPhone1 = new System.Windows.Forms.Label();
            this.lblCTName = new System.Windows.Forms.Label();
            this.lblCTAddress = new System.Windows.Forms.Label();
            this.lblCTPhone = new System.Windows.Forms.Label();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblCTName1
            // 
            this.lblCTName1.AutoSize = true;
            this.lblCTName1.Location = new System.Drawing.Point(93, 45);
            this.lblCTName1.Name = "lblCTName1";
            this.lblCTName1.Size = new System.Drawing.Size(65, 12);
            this.lblCTName1.TabIndex = 0;
            this.lblCTName1.Text = "客户名称：";
            // 
            // lblCTAddress1
            // 
            this.lblCTAddress1.AutoSize = true;
            this.lblCTAddress1.Location = new System.Drawing.Point(93, 117);
            this.lblCTAddress1.Name = "lblCTAddress1";
            this.lblCTAddress1.Size = new System.Drawing.Size(41, 12);
            this.lblCTAddress1.TabIndex = 1;
            this.lblCTAddress1.Text = "住址：";
            // 
            // lblCTPhone1
            // 
            this.lblCTPhone1.AutoSize = true;
            this.lblCTPhone1.Location = new System.Drawing.Point(93, 181);
            this.lblCTPhone1.Name = "lblCTPhone1";
            this.lblCTPhone1.Size = new System.Drawing.Size(65, 12);
            this.lblCTPhone1.TabIndex = 3;
            this.lblCTPhone1.Text = "联系电话：";
            // 
            // lblCTName
            // 
            this.lblCTName.AutoSize = true;
            this.lblCTName.Location = new System.Drawing.Point(228, 45);
            this.lblCTName.Name = "lblCTName";
            this.lblCTName.Size = new System.Drawing.Size(17, 12);
            this.lblCTName.TabIndex = 4;
            this.lblCTName.Text = "11";
            // 
            // lblCTAddress
            // 
            this.lblCTAddress.AutoSize = true;
            this.lblCTAddress.Location = new System.Drawing.Point(228, 117);
            this.lblCTAddress.Name = "lblCTAddress";
            this.lblCTAddress.Size = new System.Drawing.Size(17, 12);
            this.lblCTAddress.TabIndex = 5;
            this.lblCTAddress.Text = "11";
            // 
            // lblCTPhone
            // 
            this.lblCTPhone.AutoSize = true;
            this.lblCTPhone.Location = new System.Drawing.Point(228, 181);
            this.lblCTPhone.Name = "lblCTPhone";
            this.lblCTPhone.Size = new System.Drawing.Size(17, 12);
            this.lblCTPhone.TabIndex = 7;
            this.lblCTPhone.Text = "11";
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(144, 253);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 8;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // FrmClienteleDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 345);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblCTPhone);
            this.Controls.Add(this.lblCTAddress);
            this.Controls.Add(this.lblCTName);
            this.Controls.Add(this.lblCTPhone1);
            this.Controls.Add(this.lblCTAddress1);
            this.Controls.Add(this.lblCTName1);
            this.Name = "FrmClienteleDelete";
            this.Text = "删除客户信息";
            this.Load += new System.EventHandler(this.FrmClienteleDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblCTName1;
        private System.Windows.Forms.Label lblCTAddress1;
        private System.Windows.Forms.Label lblCTPhone1;
        private System.Windows.Forms.Label lblCTName;
        private System.Windows.Forms.Label lblCTAddress;
        private System.Windows.Forms.Label lblCTPhone;
        private System.Windows.Forms.Button btnDetermine;
    }
}