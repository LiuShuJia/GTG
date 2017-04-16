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
            this.lblSex = new System.Windows.Forms.Label();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.lstTable = new System.Windows.Forms.ListView();
            this.Name = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Sex = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.CardID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.Phone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbCName = new System.Windows.Forms.ComboBox();
            this.lblName = new System.Windows.Forms.Label();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSaleName = new System.Windows.Forms.Label();
            this.cmbSaleName = new System.Windows.Forms.ComboBox();
            this.ctmsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(49, 119);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(41, 12);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "性别：";
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "查询全部",
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(108, 116);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(183, 20);
            this.cmbSex.TabIndex = 14;
            // 
            // lstTable
            // 
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.Name,
            this.Sex,
            this.CardID,
            this.Phone,
            this.SaleName});
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
            // Name
            // 
            this.Name.DisplayIndex = 1;
            this.Name.Text = "姓名";
            this.Name.Width = 61;
            // 
            // Sex
            // 
            this.Sex.DisplayIndex = 2;
            this.Sex.Text = "性别";
            this.Sex.Width = 77;
            // 
            // CardID
            // 
            this.CardID.DisplayIndex = 3;
            this.CardID.Text = "身份证号码";
            this.CardID.Width = 104;
            // 
            // Phone
            // 
            this.Phone.DisplayIndex = 4;
            this.Phone.Text = "电话号码";
            this.Phone.Width = 112;
            // 
            // SaleName
            // 
            this.SaleName.DisplayIndex = 0;
            this.SaleName.Text = "店面名称";
            this.SaleName.Width = 82;
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
            this.cmbCName.Location = new System.Drawing.Point(108, 73);
            this.cmbCName.Name = "cmbCName";
            this.cmbCName.Size = new System.Drawing.Size(183, 20);
            this.cmbCName.TabIndex = 19;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(49, 76);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 18;
            this.lblName.Text = "姓名：";
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
            // lblSaleName
            // 
            this.lblSaleName.AutoSize = true;
            this.lblSaleName.Location = new System.Drawing.Point(25, 28);
            this.lblSaleName.Name = "lblSaleName";
            this.lblSaleName.Size = new System.Drawing.Size(65, 12);
            this.lblSaleName.TabIndex = 22;
            this.lblSaleName.Text = "店面名称：";
            // 
            // cmbSaleName
            // 
            this.cmbSaleName.FormattingEnabled = true;
            this.cmbSaleName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbSaleName.Location = new System.Drawing.Point(108, 25);
            this.cmbSaleName.Name = "cmbSaleName";
            this.cmbSaleName.Size = new System.Drawing.Size(183, 20);
            this.cmbSaleName.TabIndex = 23;
            // 
            // FrmClerk
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 448);
            this.Controls.Add(this.cmbSaleName);
            this.Controls.Add(this.lblSaleName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.cmbCName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lstTable);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.lblSex);
            this.Name = "FrmClerk";
            this.Text = "店员信息界面";
            this.Load += new System.EventHandler(this.FrmClerk_Load);
            this.ctmsStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ComboBox cmbCName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.ColumnHeader Name;
        private System.Windows.Forms.ColumnHeader Sex;
        private System.Windows.Forms.ColumnHeader CardID;
        private System.Windows.Forms.ColumnHeader Phone;
        private System.Windows.Forms.ContextMenuStrip ctmsStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiModify;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ColumnHeader SaleName;
        private System.Windows.Forms.Label lblSaleName;
        private System.Windows.Forms.ComboBox cmbSaleName;
    }
}