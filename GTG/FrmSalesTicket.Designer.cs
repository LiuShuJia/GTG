namespace GTG
{
    partial class FrmSalesTicket
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
            this.lstTable = new System.Windows.Forms.ListView();
            this.STSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STCTID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.txtCName = new System.Windows.Forms.TextBox();
            this.txtSaleName = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.lblTime = new System.Windows.Forms.Label();
            this.lblCName = new System.Windows.Forms.Label();
            this.lblSaleName = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lstTable
            // 
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STSID,
            this.STCTID,
            this.STDate});
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(0, 186);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(397, 303);
            this.lstTable.TabIndex = 0;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            // 
            // STSID
            // 
            this.STSID.Text = "店面名称";
            this.STSID.Width = 108;
            // 
            // STCTID
            // 
            this.STCTID.Text = "客户名称";
            this.STCTID.Width = 131;
            // 
            // STDate
            // 
            this.STDate.Text = "录单日期";
            this.STDate.Width = 151;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(285, 79);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // txtCName
            // 
            this.txtCName.Location = new System.Drawing.Point(109, 81);
            this.txtCName.Name = "txtCName";
            this.txtCName.Size = new System.Drawing.Size(135, 21);
            this.txtCName.TabIndex = 21;
            // 
            // txtSaleName
            // 
            this.txtSaleName.Location = new System.Drawing.Point(109, 40);
            this.txtSaleName.Name = "txtSaleName";
            this.txtSaleName.Size = new System.Drawing.Size(135, 21);
            this.txtSaleName.TabIndex = 20;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(109, 123);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(135, 21);
            this.dtpTime.TabIndex = 19;
            // 
            // lblTime
            // 
            this.lblTime.AutoSize = true;
            this.lblTime.Location = new System.Drawing.Point(27, 129);
            this.lblTime.Name = "lblTime";
            this.lblTime.Size = new System.Drawing.Size(65, 12);
            this.lblTime.TabIndex = 18;
            this.lblTime.Text = "录单日期：";
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(27, 84);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(65, 12);
            this.lblCName.TabIndex = 17;
            this.lblCName.Text = "客户名称：";
            // 
            // lblSaleName
            // 
            this.lblSaleName.AutoSize = true;
            this.lblSaleName.Location = new System.Drawing.Point(27, 43);
            this.lblSaleName.Name = "lblSaleName";
            this.lblSaleName.Size = new System.Drawing.Size(65, 12);
            this.lblSaleName.TabIndex = 16;
            this.lblSaleName.Text = "店面名称：";
            // 
            // FrmSalesTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 489);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtCName);
            this.Controls.Add(this.txtSaleName);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.lblTime);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lblSaleName);
            this.Controls.Add(this.lstTable);
            this.Name = "FrmSalesTicket";
            this.Text = "销售单界面";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ColumnHeader STSID;
        private System.Windows.Forms.ColumnHeader STCTID;
        private System.Windows.Forms.ColumnHeader STDate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.TextBox txtCName;
        private System.Windows.Forms.TextBox txtSaleName;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.Label lblTime;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.Label lblSaleName;
    }
}