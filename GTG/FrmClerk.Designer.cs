namespace GTG
{
    partial class FrmClerk
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
            this.lblCSex = new System.Windows.Forms.Label();
            this.cmbCSex = new System.Windows.Forms.ComboBox();
            this.lstTable = new System.Windows.Forms.ListView();
            this.SName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CSex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CCardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCName = new System.Windows.Forms.ComboBox();
            this.lblCName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSName = new System.Windows.Forms.Label();
            this.cmbSName = new System.Windows.Forms.ComboBox();
            this.ctmsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblCSex
            // 
            this.lblCSex.AutoSize = true;
            this.lblCSex.Location = new System.Drawing.Point(49, 119);
            this.lblCSex.Name = "lblCSex";
            this.lblCSex.Size = new System.Drawing.Size(41, 12);
            this.lblCSex.TabIndex = 10;
            this.lblCSex.Text = "性别：";
            // 
            // cmbCSex
            // 
            this.cmbCSex.FormattingEnabled = true;
            this.cmbCSex.Items.AddRange(new object[] {
            "查询全部",
            "男",
            "女"});
            this.cmbCSex.Location = new System.Drawing.Point(108, 116);
            this.cmbCSex.Name = "cmbCSex";
            this.cmbCSex.Size = new System.Drawing.Size(183, 20);
            this.cmbCSex.TabIndex = 14;
            this.cmbCSex.Leave += new System.EventHandler(this.cmbCSex_Leave);
            // 
            // lstTable
            // 
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SName,
            this.CName,
            this.CSex,
            this.CCardID,
            this.CPhone});
            this.lstTable.ContextMenuStrip = this.ctmsStrip;
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(0, 170);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(435, 278);
            this.lstTable.TabIndex = 17;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            // 
            // SName
            // 
            this.SName.Text = "店面名称";
            this.SName.Width = 95;
            // 
            // CName
            // 
            this.CName.Text = "店员名称";
            this.CName.Width = 78;
            // 
            // CSex
            // 
            this.CSex.Text = "性别";
            this.CSex.Width = 66;
            // 
            // CCardID
            // 
            this.CCardID.Text = "身份证号码";
            this.CCardID.Width = 98;
            // 
            // CPhone
            // 
            this.CPhone.Text = "电话号码";
            this.CPhone.Width = 93;
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
            // cmbCName
            // 
            this.cmbCName.FormattingEnabled = true;
            this.cmbCName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbCName.Location = new System.Drawing.Point(108, 69);
            this.cmbCName.Name = "cmbCName";
            this.cmbCName.Size = new System.Drawing.Size(183, 20);
            this.cmbCName.TabIndex = 19;
            this.cmbCName.Leave += new System.EventHandler(this.cmbCName_Leave);
            // 
            // lblCName
            // 
            this.lblCName.AutoSize = true;
            this.lblCName.Location = new System.Drawing.Point(49, 72);
            this.lblCName.Name = "lblCName";
            this.lblCName.Size = new System.Drawing.Size(41, 12);
            this.lblCName.TabIndex = 18;
            this.lblCName.Text = "姓名：";
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(338, 97);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 21;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(338, 43);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 20;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSName
            // 
            this.lblSName.AutoSize = true;
            this.lblSName.Location = new System.Drawing.Point(25, 28);
            this.lblSName.Name = "lblSName";
            this.lblSName.Size = new System.Drawing.Size(65, 12);
            this.lblSName.TabIndex = 22;
            this.lblSName.Text = "店面名称：";
            // 
            // cmbSName
            // 
            this.cmbSName.FormattingEnabled = true;
            this.cmbSName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbSName.Location = new System.Drawing.Point(108, 25);
            this.cmbSName.Name = "cmbSName";
            this.cmbSName.Size = new System.Drawing.Size(183, 20);
            this.cmbSName.TabIndex = 23;
            this.cmbSName.Leave += new System.EventHandler(this.cmbSName_Leave);
            // 
            // FrmClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 448);
            this.Controls.Add(this.cmbSName);
            this.Controls.Add(this.lblSName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbCName);
            this.Controls.Add(this.lblCName);
            this.Controls.Add(this.lstTable);
            this.Controls.Add(this.cmbCSex);
            this.Controls.Add(this.lblCSex);
            this.Name = "FrmClerk";
            this.Text = "店员信息界面";
            this.Load += new System.EventHandler(this.FrmClerk_Load);
            this.ctmsStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblCSex;
        private System.Windows.Forms.ComboBox cmbCSex;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ComboBox cmbCName;
        private System.Windows.Forms.Label lblCName;
        private System.Windows.Forms.ContextMenuStrip ctmsStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSName;
        private System.Windows.Forms.ComboBox cmbSName;
        private System.Windows.Forms.ColumnHeader SName;
        private System.Windows.Forms.ColumnHeader CName;
        private System.Windows.Forms.ColumnHeader CSex;
        private System.Windows.Forms.ColumnHeader CCardID;
        private System.Windows.Forms.ColumnHeader CPhone;
    }
}