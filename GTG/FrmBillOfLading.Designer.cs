namespace GTG
{
    partial class FrmBillOfLading
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
            this.btnSelect = new System.Windows.Forms.Button();
            this.lblSaleName = new System.Windows.Forms.Label();
            this.lblWName = new System.Windows.Forms.Label();
            this.lstTable = new System.Windows.Forms.ListView();
            this.WName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SaleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.BSubDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.cmbWName = new System.Windows.Forms.ComboBox();
            this.cmbSaleName = new System.Windows.Forms.ComboBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.ctmsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(296, 30);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 15;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // lblSaleName
            // 
            this.lblSaleName.AutoSize = true;
            this.lblSaleName.Location = new System.Drawing.Point(45, 82);
            this.lblSaleName.Name = "lblSaleName";
            this.lblSaleName.Size = new System.Drawing.Size(65, 12);
            this.lblSaleName.TabIndex = 10;
            this.lblSaleName.Text = "店面名称：";
            // 
            // lblWName
            // 
            this.lblWName.AutoSize = true;
            this.lblWName.Location = new System.Drawing.Point(45, 35);
            this.lblWName.Name = "lblWName";
            this.lblWName.Size = new System.Drawing.Size(65, 12);
            this.lblWName.TabIndex = 9;
            this.lblWName.Text = "仓库名称：";
            // 
            // lstTable
            // 
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WName,
            this.SaleName,
            this.BSubDate});
            this.lstTable.ContextMenuStrip = this.ctmsStrip;
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(0, 135);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(403, 211);
            this.lstTable.TabIndex = 8;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            // 
            // WName
            // 
            this.WName.Text = "仓库名称";
            this.WName.Width = 111;
            // 
            // SaleName
            // 
            this.SaleName.Text = "店面名称";
            this.SaleName.Width = 145;
            // 
            // BSubDate
            // 
            this.BSubDate.Text = "提单日期";
            this.BSubDate.Width = 142;
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
            // cmbWName
            // 
            this.cmbWName.FormattingEnabled = true;
            this.cmbWName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbWName.Location = new System.Drawing.Point(127, 32);
            this.cmbWName.Name = "cmbWName";
            this.cmbWName.Size = new System.Drawing.Size(135, 20);
            this.cmbWName.TabIndex = 16;
            this.cmbWName.Leave += new System.EventHandler(this.cmbWName_Leave);
            // 
            // cmbSaleName
            // 
            this.cmbSaleName.FormattingEnabled = true;
            this.cmbSaleName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbSaleName.Location = new System.Drawing.Point(127, 79);
            this.cmbSaleName.Name = "cmbSaleName";
            this.cmbSaleName.Size = new System.Drawing.Size(135, 20);
            this.cmbSaleName.TabIndex = 17;
            this.cmbSaleName.Leave += new System.EventHandler(this.cmbSaleName_Leave);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(296, 77);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 18;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            // 
            // FrmBillOfLading
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(403, 346);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.cmbSaleName);
            this.Controls.Add(this.cmbWName);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lblSaleName);
            this.Controls.Add(this.lblWName);
            this.Controls.Add(this.lstTable);
            this.Name = "FrmBillOfLading";
            this.Text = "提货单界面";
            this.Load += new System.EventHandler(this.FrmBillOfLading_Load);
            this.ctmsStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Label lblSaleName;
        private System.Windows.Forms.Label lblWName;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ColumnHeader WName;
        private System.Windows.Forms.ColumnHeader SaleName;
        private System.Windows.Forms.ColumnHeader BSubDate;
        private System.Windows.Forms.ContextMenuStrip ctmsStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiModify;
        private System.Windows.Forms.ComboBox cmbWName;
        private System.Windows.Forms.ComboBox cmbSaleName;
        private System.Windows.Forms.Button btnAdd;
    }
}