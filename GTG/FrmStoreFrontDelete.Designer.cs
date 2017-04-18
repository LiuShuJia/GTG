namespace GTG
{
    partial class FrmStoreFrontDelete
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
            this.lblSmanagerName = new System.Windows.Forms.Label();
            this.lblSmanagerName1 = new System.Windows.Forms.Label();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.lblSPhone = new System.Windows.Forms.Label();
            this.lblSAddress = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.lblSPhone1 = new System.Windows.Forms.Label();
            this.lblSAddress1 = new System.Windows.Forms.Label();
            this.lblSName1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblSmanagerName
            // 
            this.lblSmanagerName.AutoSize = true;
            this.lblSmanagerName.Location = new System.Drawing.Point(217, 155);
            this.lblSmanagerName.Name = "lblSmanagerName";
            this.lblSmanagerName.Size = new System.Drawing.Size(17, 12);
            this.lblSmanagerName.TabIndex = 26;
            this.lblSmanagerName.Text = "11";
            // 
            // lblSmanagerName1
            // 
            this.lblSmanagerName1.AutoSize = true;
            this.lblSmanagerName1.Location = new System.Drawing.Point(82, 155);
            this.lblSmanagerName1.Name = "lblSmanagerName1";
            this.lblSmanagerName1.Size = new System.Drawing.Size(65, 12);
            this.lblSmanagerName1.TabIndex = 25;
            this.lblSmanagerName1.Text = "店长名称：";
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(128, 274);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 24;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // lblSPhone
            // 
            this.lblSPhone.AutoSize = true;
            this.lblSPhone.Location = new System.Drawing.Point(217, 216);
            this.lblSPhone.Name = "lblSPhone";
            this.lblSPhone.Size = new System.Drawing.Size(17, 12);
            this.lblSPhone.TabIndex = 23;
            this.lblSPhone.Text = "11";
            // 
            // lblSAddress
            // 
            this.lblSAddress.AutoSize = true;
            this.lblSAddress.Location = new System.Drawing.Point(217, 95);
            this.lblSAddress.Name = "lblSAddress";
            this.lblSAddress.Size = new System.Drawing.Size(17, 12);
            this.lblSAddress.TabIndex = 22;
            this.lblSAddress.Text = "11";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(217, 39);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(17, 12);
            this.lblSName.TabIndex = 21;
            this.lblSName.Text = "11";
            // 
            // lblSPhone1
            // 
            this.lblSPhone1.AutoSize = true;
            this.lblSPhone1.Location = new System.Drawing.Point(82, 216);
            this.lblSPhone1.Name = "lblSPhone1";
            this.lblSPhone1.Size = new System.Drawing.Size(65, 12);
            this.lblSPhone1.TabIndex = 20;
            this.lblSPhone1.Text = "联系电话：";
            // 
            // lblSAddress1
            // 
            this.lblSAddress1.AutoSize = true;
            this.lblSAddress1.Location = new System.Drawing.Point(82, 95);
            this.lblSAddress1.Name = "lblSAddress1";
            this.lblSAddress1.Size = new System.Drawing.Size(41, 12);
            this.lblSAddress1.TabIndex = 19;
            this.lblSAddress1.Text = "地址：";
            // 
            // lblSName1
            // 
            this.lblSName1.AutoSize = true;
            this.lblSName1.Location = new System.Drawing.Point(82, 39);
            this.lblSName1.Name = "lblSName1";
            this.lblSName1.Size = new System.Drawing.Size(65, 12);
            this.lblSName1.TabIndex = 18;
            this.lblSName1.Text = "店面名称：";
            // 
            // FrmStoreFrontDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 356);
            this.Controls.Add(this.lblSmanagerName);
            this.Controls.Add(this.lblSmanagerName1);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblSPhone);
            this.Controls.Add(this.lblSAddress);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.lblSPhone1);
            this.Controls.Add(this.lblSAddress1);
            this.Controls.Add(this.lblSName1);
            this.Name = "FrmStoreFrontDelete";
            this.Text = "删除店面信息";
            this.Load += new System.EventHandler(this.FrmStoreFrontDelete_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSmanagerName;
        private System.Windows.Forms.Label lblSmanagerName1;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.Label lblSPhone;
        private System.Windows.Forms.Label lblSAddress;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.Label lblSPhone1;
        private System.Windows.Forms.Label lblSAddress1;
        private System.Windows.Forms.Label lblSName1;
    }
}