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
            this.components = new System.ComponentModel.Container();
            this.lstTable = new System.Windows.Forms.ListView();
            this.STSID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STCTID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.STDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblCTName = new System.Windows.Forms.Label();
            this.lblSName = new System.Windows.Forms.Label();
            this.cmbSName = new System.Windows.Forms.ComboBox();
            this.cmbCTName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ctmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.ctmsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstTable
            // 
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.STSID,
            this.STCTID,
            this.STDate});
            this.lstTable.ContextMenuStrip = this.ctmsStrip;
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(0, 112);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(397, 255);
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
            this.btnSelect.Location = new System.Drawing.Point(279, 21);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 22;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblCTName
            // 
            this.lblCTName.AutoSize = true;
            this.lblCTName.Location = new System.Drawing.Point(25, 67);
            this.lblCTName.Name = "lblCTName";
            this.lblCTName.Size = new System.Drawing.Size(65, 12);
            this.lblCTName.TabIndex = 17;
            this.lblCTName.Text = "客户名称：";
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(25, 26);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(65, 12);
            this.lblSName.TabIndex = 16;
            this.lblSName.Text = "店面名称：";
            // 
            // cmbSName
            // 
            this.cmbSName.FormattingEnabled = true;
            this.cmbSName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbSName.Location = new System.Drawing.Point(107, 23);
            this.cmbSName.Name = "cmbSName";
            this.cmbSName.Size = new System.Drawing.Size(146, 20);
            this.cmbSName.TabIndex = 23;
            this.cmbSName.Leave += new System.EventHandler(this.cmbSName_Leave);
            // 
            // cmbCTName
            // 
            this.cmbCTName.FormattingEnabled = true;
            this.cmbCTName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbCTName.Location = new System.Drawing.Point(107, 64);
            this.cmbCTName.Name = "cmbCTName";
            this.cmbCTName.Size = new System.Drawing.Size(146, 20);
            this.cmbCTName.TabIndex = 24;
            this.cmbCTName.Leave += new System.EventHandler(this.cmbCTName_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(279, 62);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 25;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // ctmsStrip
            // 
            this.ctmsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiModify});
            this.ctmsStrip.Name = "ctmsStrip";
            this.ctmsStrip.Size = new System.Drawing.Size(101, 48);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // tsmiModify
            // 
            this.tsmiModify.Name = "tsmiModify";
            this.tsmiModify.Size = new System.Drawing.Size(152, 22);
            this.tsmiModify.Text = "修改";
            // 
            // FrmSalesTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 367);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbCTName);
            this.Controls.Add(this.cmbSName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblCTName);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.lstTable);
            this.Name = "FrmSalesTicket";
            this.Text = "销售单界面";
            this.Load += new System.EventHandler(this.FrmSalesTicket_Load);
            this.ctmsStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ColumnHeader STSID;
        private System.Windows.Forms.ColumnHeader STCTID;
        private System.Windows.Forms.ColumnHeader STDate;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblCTName;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.ComboBox cmbSName;
        private System.Windows.Forms.ComboBox cmbCTName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.ContextMenuStrip ctmsStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiModify;
    }
}