namespace GTG
{
    partial class FrmStoreFront
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
            this.msStrip = new System.Windows.Forms.MenuStrip();
            this.tsmiSalesStore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientele = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBillOfLading = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalesTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClerk = new System.Windows.Forms.ToolStripMenuItem();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblSaleName = new System.Windows.Forms.Label();
            this.lblAddress = new System.Windows.Forms.Label();
            this.cmbSaleName = new System.Windows.Forms.ComboBox();
            this.lstTable = new System.Windows.Forms.ListView();
            this.SaleName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SAddress = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SManagerName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SPhone = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.ctmsStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiDelete = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiModify = new System.Windows.Forms.ToolStripMenuItem();
            this.lblSManagerName = new System.Windows.Forms.Label();
            this.cmbSManagerName = new System.Windows.Forms.ComboBox();
            this.cmbAddress = new System.Windows.Forms.ComboBox();
            this.msStrip.SuspendLayout();
            this.ctmsStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // msStrip
            // 
            this.msStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalesStore,
            this.tsmiClientele,
            this.tsmiBillOfLading,
            this.tsmiSalesTicket,
            this.tsmiClerk});
            this.msStrip.Location = new System.Drawing.Point(0, 0);
            this.msStrip.Name = "msStrip";
            this.msStrip.Size = new System.Drawing.Size(487, 25);
            this.msStrip.TabIndex = 0;
            // 
            // tsmiSalesStore
            // 
            this.tsmiSalesStore.Name = "tsmiSalesStore";
            this.tsmiSalesStore.Size = new System.Drawing.Size(68, 21);
            this.tsmiSalesStore.Text = "店面信息";
         //   this.tsmiSalesStore.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // tsmiClientele
            // 
            this.tsmiClientele.Name = "tsmiClientele";
            this.tsmiClientele.Size = new System.Drawing.Size(80, 21);
            this.tsmiClientele.Text = "客户信息表";
            this.tsmiClientele.Click += new System.EventHandler(this.tsmiClientele_Click);
            // 
            // tsmiBillOfLading
            // 
            this.tsmiBillOfLading.Name = "tsmiBillOfLading";
            this.tsmiBillOfLading.Size = new System.Drawing.Size(92, 21);
            this.tsmiBillOfLading.Text = "提货单信息表";
            this.tsmiBillOfLading.Click += new System.EventHandler(this.tsmiBillOfLading_Click);
            // 
            // tsmiSalesTicket
            // 
            this.tsmiSalesTicket.Name = "tsmiSalesTicket";
            this.tsmiSalesTicket.Size = new System.Drawing.Size(92, 21);
            this.tsmiSalesTicket.Text = "销售单信息表";
            this.tsmiSalesTicket.Click += new System.EventHandler(this.tsmiSalesTicket_Click);
            // 
            // tsmiClerk
            // 
            this.tsmiClerk.Name = "tsmiClerk";
            this.tsmiClerk.Size = new System.Drawing.Size(68, 21);
            this.tsmiClerk.Text = "店员信息";
            this.tsmiClerk.Click += new System.EventHandler(this.tsmiClerk_Click_1);
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(359, 56);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(359, 114);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblSaleName
            // 
            this.lblSaleName.AutoSize = true;
            this.lblSaleName.Location = new System.Drawing.Point(43, 46);
            this.lblSaleName.Name = "lblSaleName";
            this.lblSaleName.Size = new System.Drawing.Size(65, 12);
            this.lblSaleName.TabIndex = 5;
            this.lblSaleName.Text = "店面名称：";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Location = new System.Drawing.Point(67, 92);
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(41, 12);
            this.lblAddress.TabIndex = 6;
            this.lblAddress.Text = "地址：";
            // 
            // cmbSaleName
            // 
            this.cmbSaleName.FormattingEnabled = true;
            this.cmbSaleName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbSaleName.Location = new System.Drawing.Point(114, 43);
            this.cmbSaleName.Name = "cmbSaleName";
            this.cmbSaleName.Size = new System.Drawing.Size(195, 20);
            this.cmbSaleName.TabIndex = 8;
            this.cmbSaleName.Enter += new System.EventHandler(this.cmbSaleName_Enter);
            this.cmbSaleName.Leave += new System.EventHandler(this.cmbSaleName_Leave);
            // 
            // lstTable
            // 
            this.lstTable.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.SaleName,
            this.SAddress,
            this.SManagerName,
            this.SPhone});
            this.lstTable.ContextMenuStrip = this.ctmsStrip;
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(0, 184);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(487, 311);
            this.lstTable.TabIndex = 14;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            // 
            // SaleName
            // 
            this.SaleName.Text = "店面名称";
            this.SaleName.Width = 110;
            // 
            // SAddress
            // 
            this.SAddress.Text = "地址";
            this.SAddress.Width = 117;
            // 
            // SManagerName
            // 
            this.SManagerName.Text = "店长姓名";
            this.SManagerName.Width = 139;
            // 
            // SPhone
            // 
            this.SPhone.Text = "联系电话";
            this.SPhone.Width = 134;
            // 
            // ctmsStrip
            // 
            this.ctmsStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiDelete,
            this.tsmiModify});
            this.ctmsStrip.Name = "ctmsStrip";
            this.ctmsStrip.Size = new System.Drawing.Size(153, 70);
            // 
            // tsmiDelete
            // 
            this.tsmiDelete.Name = "tsmiDelete";
            this.tsmiDelete.Size = new System.Drawing.Size(152, 22);
            this.tsmiDelete.Text = "删除";
            this.tsmiDelete.Click += new System.EventHandler(this.tsmiDelete_Click);
            // 
            // tsmiModify
            // 
            this.tsmiModify.Name = "tsmiModify";
            this.tsmiModify.Size = new System.Drawing.Size(152, 22);
            this.tsmiModify.Text = "修改";
            this.tsmiModify.Click += new System.EventHandler(this.tsmiModify_Click);
            // 
            // lblSManagerName
            // 
            this.lblSManagerName.AutoSize = true;
            this.lblSManagerName.Location = new System.Drawing.Point(43, 141);
            this.lblSManagerName.Name = "lblSManagerName";
            this.lblSManagerName.Size = new System.Drawing.Size(65, 12);
            this.lblSManagerName.TabIndex = 16;
            this.lblSManagerName.Text = "店长姓名：";
            // 
            // cmbSManagerName
            // 
            this.cmbSManagerName.FormattingEnabled = true;
            this.cmbSManagerName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbSManagerName.Location = new System.Drawing.Point(114, 138);
            this.cmbSManagerName.Name = "cmbSManagerName";
            this.cmbSManagerName.Size = new System.Drawing.Size(195, 20);
            this.cmbSManagerName.TabIndex = 17;
            this.cmbSManagerName.Leave += new System.EventHandler(this.cmbSManagerName_Leave);
            // 
            // cmbAddress
            // 
            this.cmbAddress.FormattingEnabled = true;
            this.cmbAddress.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbAddress.Location = new System.Drawing.Point(114, 89);
            this.cmbAddress.Name = "cmbAddress";
            this.cmbAddress.Size = new System.Drawing.Size(195, 20);
            this.cmbAddress.TabIndex = 18;
            this.cmbAddress.Leave += new System.EventHandler(this.cmbAddress_Leave);
            // 
            // FrmStoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(487, 495);
            this.Controls.Add(this.cmbAddress);
            this.Controls.Add(this.cmbSManagerName);
            this.Controls.Add(this.lblSManagerName);
            this.Controls.Add(this.lstTable);
            this.Controls.Add(this.cmbSaleName);
            this.Controls.Add(this.lblAddress);
            this.Controls.Add(this.lblSaleName);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.msStrip);
            this.MainMenuStrip = this.msStrip;
            this.Name = "FrmStoreFront";
            this.Text = "店面销售界面";
            this.Load += new System.EventHandler(this.FrmStoreFront_Load);
            this.msStrip.ResumeLayout(false);
            this.msStrip.PerformLayout();
            this.ctmsStrip.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip msStrip;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalesStore;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientele;
        private System.Windows.Forms.ToolStripMenuItem tsmiBillOfLading;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalesTicket;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblSaleName;
        private System.Windows.Forms.Label lblAddress;
        private System.Windows.Forms.ComboBox cmbSaleName;
        private System.Windows.Forms.ToolStripMenuItem tsmiClerk;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.ColumnHeader SaleName;
        private System.Windows.Forms.ColumnHeader SAddress;
        private System.Windows.Forms.ColumnHeader SManagerName;
        private System.Windows.Forms.ColumnHeader SPhone;
        private System.Windows.Forms.ContextMenuStrip ctmsStrip;
        private System.Windows.Forms.Label lblSManagerName;
        private System.Windows.Forms.ComboBox cmbSManagerName;
        private System.Windows.Forms.ToolStripMenuItem tsmiDelete;
        private System.Windows.Forms.ToolStripMenuItem tsmiModify;
        private System.Windows.Forms.ComboBox cmbAddress;
    }
}