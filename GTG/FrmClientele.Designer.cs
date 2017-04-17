namespace GTG
{
    partial class FrmClientele
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
            this.lblCTAddress = new System.Windows.Forms.Label();
            this.lblCTName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lstTable = new System.Windows.Forms.ListView();
            this.CTName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CTPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCTName = new System.Windows.Forms.ComboBox();
            this.cmbCTAddress = new System.Windows.Forms.ComboBox();
            this.ctmsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCTAddress
            // 
            this.lblCTAddress.AutoSize = true;
            this.lblCTAddress.Location = new System.Drawing.Point(28, 100);
            this.lblCTAddress.Name = "lblCTAddress";
            this.lblCTAddress.Size = new System.Drawing.Size(65, 12);
            this.lblCTAddress.TabIndex = 11;
            this.lblCTAddress.Text = "客户住址：";
            // 
            // lblCTName
            // 
            this.lblCTName.AutoSize = true;
            this.lblCTName.Location = new System.Drawing.Point(28, 37);
            this.lblCTName.Name = "lblCTName";
            this.lblCTName.Size = new System.Drawing.Size(65, 12);
            this.lblCTName.TabIndex = 10;
            this.lblCTName.Text = "客户姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(291, 95);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 9;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(291, 32);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 8;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lstTable
            // 
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.CTName,
            this.CTAddress,
            this.CTPhone});
            this.lstTable.ContextMenuStrip = this.ctmsStrip;
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(0, 159);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(399, 254);
            this.lstTable.TabIndex = 7;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            // 
            // CTName
            // 
            this.CTName.Text = "客户姓名";
            this.CTName.Width = 118;
            // 
            // CTAddress
            // 
            this.CTAddress.Text = "住址";
            this.CTAddress.Width = 142;
            // 
            // CTPhone
            // 
            this.CTPhone.Text = "联系电话";
            this.CTPhone.Width = 134;
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
            this.tsmiDelete.Size = new System.Drawing.Size(100, 22);
            this.tsmiDelete.Text = "删除";
            // 
            // tsmiModify
            // 
            this.tsmiModify.Name = "tsmiModify";
            this.tsmiModify.Size = new System.Drawing.Size(100, 22);
            this.tsmiModify.Text = "修改";
            // 
            // cmbCTName
            // 
            this.cmbCTName.FormattingEnabled = true;
            this.cmbCTName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbCTName.Location = new System.Drawing.Point(99, 35);
            this.cmbCTName.Name = "cmbCTName";
            this.cmbCTName.Size = new System.Drawing.Size(161, 20);
            this.cmbCTName.TabIndex = 14;
            this.cmbCTName.Leave += new System.EventHandler(this.cmbCTName_Leave);
            // 
            // cmbCTAddress
            // 
            this.cmbCTAddress.FormattingEnabled = true;
            this.cmbCTAddress.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbCTAddress.Location = new System.Drawing.Point(99, 97);
            this.cmbCTAddress.Name = "cmbCTAddress";
            this.cmbCTAddress.Size = new System.Drawing.Size(161, 20);
            this.cmbCTAddress.TabIndex = 15;
            this.cmbCTAddress.Leave += new System.EventHandler(this.cmbCTAddress_Leave);
            // 
            // FrmClientele
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(399, 413);
            this.Controls.Add(this.cmbCTAddress);
            this.Controls.Add(this.cmbCTName);
            this.Controls.Add(this.lblCTAddress);
            this.Controls.Add(this.lblCTName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstTable);
            this.Name = "FrmClientele";
            this.Text = "客户信息界面";
            this.Load += new System.EventHandler(this.FrmClientele_Load);
            this.ctmsStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCTAddress;
        private System.Windows.Forms.Label lblCTName;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ColumnHeader CTName;
        private System.Windows.Forms.ColumnHeader CTAddress;
        private System.Windows.Forms.ColumnHeader CTPhone;
        private System.Windows.Forms.ContextMenuStrip ctmsStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiModify;
        private System.Windows.Forms.ComboBox cmbCTName;
        private System.Windows.Forms.ComboBox cmbCTAddress;
    }
}