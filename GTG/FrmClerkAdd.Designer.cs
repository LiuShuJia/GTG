namespace GTG
{
    partial class FrmClerkAdd
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
            this.txtCPhone = new System.Windows.Forms.TextBox();
            this.txtCSex = new System.Windows.Forms.TextBox();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.btnDetermine = new System.Windows.Forms.Button();
            this.lblCPhone = new System.Windows.Forms.Label();
            this.lblCSex = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblCardID = new System.Windows.Forms.Label();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtCPhone
            // 
            this.txtCPhone.Location = new System.Drawing.Point(129, 225);
            this.txtCPhone.Name = "txtCPhone";
            this.txtCPhone.Size = new System.Drawing.Size(176, 21);
            this.txtCPhone.TabIndex = 25;
            this.txtCPhone.Enter += new System.EventHandler(this.txtCPhone_Enter);
            this.txtCPhone.Leave += new System.EventHandler(this.txtCPhone_Leave);
            // 
            // txtCSex
            // 
            this.txtCSex.Location = new System.Drawing.Point(129, 122);
            this.txtCSex.Name = "txtCSex";
            this.txtCSex.Size = new System.Drawing.Size(176, 21);
            this.txtCSex.TabIndex = 24;
            this.txtCSex.Enter += new System.EventHandler(this.txtCSex_Enter);
            this.txtCSex.Leave += new System.EventHandler(this.txtCSex_Leave);
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(129, 71);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(176, 21);
            this.txtCName.TabIndex = 23;
            this.txtCName.Enter += new System.EventHandler(this.txtCName_Enter);
            this.txtCName.Leave += new System.EventHandler(this.txtCName_Leave);
            // 
            // btnDetermine
            // 
            this.btnDetermine.Location = new System.Drawing.Point(129, 270);
            this.btnDetermine.Name = "btnDetermine";
            this.btnDetermine.Size = new System.Drawing.Size(75, 23);
            this.btnDetermine.TabIndex = 22;
            this.btnDetermine.Text = "确定";
            this.btnDetermine.UseVisualStyleBackColor = true;
            this.btnDetermine.Click += new System.EventHandler(this.btnDetermine_Click);
            // 
            // lblCPhone
            // 
            this.lblCPhone.AutoSize = true;
            this.lblCPhone.Location = new System.Drawing.Point(51, 228);
            this.lblCPhone.Name = "lblCPhone";
            this.lblCPhone.Size = new System.Drawing.Size(65, 12);
            this.lblCPhone.TabIndex = 21;
            this.lblCPhone.Text = "电话号码：";
            // 
            // lblCSex
            // 
            this.lblCSex.AutoSize = true;
            this.lblCSex.Location = new System.Drawing.Point(75, 125);
            this.lblCSex.Name = "lblCSex";
            this.lblCSex.Size = new System.Drawing.Size(41, 12);
            this.lblCSex.TabIndex = 20;
            this.lblCSex.Text = "性别：";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(51, 74);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(65, 12);
            this.lblCName.TabIndex = 19;
            this.lblCName.Text = "店员名称：";
            // 
            // lblCardID
            // 
            this.lblCardID.AutoSize = true;
            this.lblCardID.Location = new System.Drawing.Point(51, 174);
            this.lblCardID.Name = "lblCardID";
            this.lblCardID.Size = new System.Drawing.Size(77, 12);
            this.lblCardID.TabIndex = 26;
            this.lblCardID.Text = "身份证号码：";
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(129, 171);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(176, 21);
            this.txtCardID.TabIndex = 27;
            this.txtCardID.Enter += new System.EventHandler(this.txtCardID_Enter);
            this.txtCardID.Leave += new System.EventHandler(this.txtCardID_Leave);
            // 
            // FrmClerkAdd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 329);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.lblCardID);
            this.Controls.Add(this.txtCPhone);
            this.Controls.Add(this.txtCSex);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.btnDetermine);
            this.Controls.Add(this.lblCPhone);
            this.Controls.Add(this.lblCSex);
            this.Controls.Add(this.lblCName);
            this.Name = "FrmClerkAdd";
            this.Text = "增加店员信息";
            this.Load += new System.EventHandler(this.FrmClerkAdd_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtCPhone;
        private System.Windows.Forms.TextBox txtCSex;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.Button btnDetermine;
        private System.Windows.Forms.Label lblCPhone;
        private System.Windows.Forms.Label lblCSex;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblCardID;
        private System.Windows.Forms.TextBox txtCardID;
    }
}