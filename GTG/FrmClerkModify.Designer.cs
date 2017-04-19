namespace GTG
{
    partial class FrmClerkModify
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
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.lblCardID = new System.Windows.Forms.Label();
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCSex = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCSex = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.cmbSID = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(137, 167);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(176, 21);
            this.txtCardID.TabIndex = 36;
            this.txtCardID.Leave += new System.EventHandler(this.txtCardID_Leave);
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(59, 170);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(77, 12);
            this.lblCardID.TabIndex = 35;
            this.lblCardID.Text = "身份证号码：";
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(137, 218);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(176, 21);
            this.txtCPhone.TabIndex = 34;
            this.txtCPhone.Leave += new System.EventHandler(this.txtCPhone_Leave);
            // 
            // txtCSex
            // 
            this.txtCSex.Location = new System.Drawing.Point(137, 118);
            this.txtCSex.Name = "txtCSex";
            this.txtCSex.Size = new System.Drawing.Size(176, 21);
            this.txtCSex.TabIndex = 33;
            this.txtCSex.Leave += new System.EventHandler(this.txtCSex_Leave);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(137, 69);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(176, 21);
            this.txtCName.TabIndex = 32;
            this.txtCName.Leave += new System.EventHandler(this.txtCName_Leave);
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(137, 284);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 31;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(59, 221);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(65, 12);
            this.lblCPhone.TabIndex = 30;
            this.lblCPhone.Text = "电话号码：";
            // 
            // lblCSex
            // 
            this.lblCSex.AutoSize = true;
            this.lblCSex.Location = new System.Drawing.Point(59, 121);
            this.lblCSex.Name = "lblCSex";
            this.lblCSex.Size = new System.Drawing.Size(41, 12);
            this.lblCSex.TabIndex = 29;
            this.lblCSex.Text = "性别：";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(59, 72);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(65, 12);
            this.lblCName.TabIndex = 28;
            this.lblCName.Text = "店员名称：";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(59, 26);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(65, 12);
            this.lblSName.TabIndex = 37;
            this.lblSName.Text = "店面编号：";
            // 
            // cmbSID
            // 
            this.cmbSID.FormattingEnabled = true;
            this.cmbSID.Location = new System.Drawing.Point(137, 23);
            this.cmbSID.Name = "cmbSID";
            this.cmbSID.Size = new System.Drawing.Size(176, 20);
            this.cmbSID.TabIndex = 38;
            // 
            // FrmClerkModify
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(376, 345);
            this.Controls.Add(this.cmbSID);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtCSex);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblCPhone);
            this.Controls.Add(this.lblCSex);
            this.Controls.Add(this.lblCName);
            this.Name = "FrmClerkModify";
            this.Text = "修改店员信息";
            this.Load += new System.EventHandler(this.FrmClerkModify_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCardID;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCSex;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCSex;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.ComboBox cmbSID;
    }
}