namespace GTG
{
    partial class FrmClerkDelete
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
            this.btnDetermine = new System.Windows.Forms.Button();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCSex = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCPhone1 = new System.Windows.Forms.Label();
            this.lblCSex1 = new System.Windows.Forms.Label();
            this.lblCName1 = new System.Windows.Forms.Label();
            this.lblCCardID1 = new System.Windows.Forms.Label();
            this.lblCCardID = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(161, 293);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 15;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(250, 235);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(17, 12);
            this.lblCPhone.TabIndex = 14;
            this.lblCPhone.Text = "11";
            // 
            // lblCSex
            // 
            this.lblCSex.AutoSize = true;
            this.lblCSex.Location = new System.Drawing.Point(250, 114);
            this.lblCSex.Name = "lblCSex";
            this.lblCSex.Size = new System.Drawing.Size(17, 12);
            this.lblCSex.TabIndex = 13;
            this.lblCSex.Text = "11";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(250, 58);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(17, 12);
            this.lblCName.TabIndex = 12;
            this.lblCName.Text = "11";
            // 
            // lblCPhone1
            // 
            this.lblCPhone1.AutoSize = true;
            this.lblCPhone1.Location = new System.Drawing.Point(115, 235);
            this.lblCPhone1.Name = "lblCPhone1";
            this.lblCPhone1.Size = new System.Drawing.Size(65, 12);
            this.lblCPhone1.TabIndex = 11;
            this.lblCPhone1.Text = "联系电话：";
            // 
            // lblCSex1
            // 
            this.lblCSex1.AutoSize = true;
            this.lblCSex1.Location = new System.Drawing.Point(115, 114);
            this.lblCSex1.Name = "lblCSex1";
            this.lblCSex1.Size = new System.Drawing.Size(41, 12);
            this.lblCSex1.TabIndex = 10;
            this.lblCSex1.Text = "性别：";
            // 
            // lblCName1
            // 
            this.lblCName1.AutoSize = true;
            this.lblCName1.Location = new System.Drawing.Point(115, 58);
            this.lblCName1.Name = "lblCName1";
            this.lblCName1.Size = new System.Drawing.Size(65, 12);
            this.lblCName1.TabIndex = 9;
            this.lblCName1.Text = "店员名称：";
            // 
            // lblCCardID1
            // 
            this.lblCCardID1.AutoSize = true;
            this.lblCCardID1.Location = new System.Drawing.Point(115, 174);
            this.lblCCardID1.Name = "lblCCardID1";
            this.lblCCardID1.Size = new System.Drawing.Size(77, 12);
            this.lblCCardID1.TabIndex = 16;
            this.lblCCardID1.Text = "身份证号码：";
            // 
            // lblCCardID
            // 
            this.lblCCardID.AutoSize = true;
            this.lblCCardID.Location = new System.Drawing.Point(250, 174);
            this.lblCCardID.Name = "lblCCardID";
            this.lblCCardID.Size = new System.Drawing.Size(17, 12);
            this.lblCCardID.TabIndex = 17;
            this.lblCCardID.Text = "11";
            // 
            // FrmClerkDelete
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(372, 357);
            this.Controls.Add(this.lblCCardID);
            this.Controls.Add(this.lblCCardID1);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblCPhone);
            this.Controls.Add(this.lblCSex);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblCPhone1);
            this.Controls.Add(this.lblCSex1);
            this.Controls.Add(this.lblCName1);
            this.Name = "FrmClerkDelete";
            this.Text = "删除店员信息";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCSex;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCPhone1;
        private System.Windows.Forms.Label lblCSex1;
        private System.Windows.Forms.Label lblCName1;
        private System.Windows.Forms.Label lblCCardID1;
        private System.Windows.Forms.Label lblCCardID;
    }
}