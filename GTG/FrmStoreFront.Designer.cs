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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.tsmiSalesStore = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClerk = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiClientele = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiBillOfLading = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiSalesTicket = new System.Windows.Forms.ToolStripMenuItem();
            this.lstTable = new System.Windows.Forms.ListView();
            this.btnSelect = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.lblText1 = new System.Windows.Forms.Label();
            this.lblText2 = new System.Windows.Forms.Label();
            this.cmbName = new System.Windows.Forms.ComboBox();
            this.lblDay = new System.Windows.Forms.Label();
            this.lblSex = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.dtpTime = new System.Windows.Forms.DateTimePicker();
            this.cmbSex = new System.Windows.Forms.ComboBox();
            this.txtCardID = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiSalesStore,
            this.tsmiClientele,
            this.tsmiBillOfLading,
            this.tsmiSalesTicket});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(479, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiSalesStore
            // 
            this.tsmiSalesStore.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiClerk});
            this.tsmiSalesStore.Name = "tsmiSalesStore";
            this.tsmiSalesStore.Size = new System.Drawing.Size(68, 21);
            this.tsmiSalesStore.Text = "店铺信息";
            this.tsmiSalesStore.Click += new System.EventHandler(this.tsmi_Click);
            // 
            // tsmiClerk
            // 
            this.tsmiClerk.Name = "tsmiClerk";
            this.tsmiClerk.Size = new System.Drawing.Size(152, 22);
            this.tsmiClerk.Text = "店员信息";
            this.tsmiClerk.Click += new System.EventHandler(this.tsmiClerk_Click);
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
            // lstTable
            // 
            this.lstTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.lstTable.FullRowSelect = true;
            this.lstTable.GridLines = true;
            this.lstTable.Location = new System.Drawing.Point(0, 25);
            this.lstTable.Name = "lstTable";
            this.lstTable.Size = new System.Drawing.Size(479, 268);
            this.lstTable.TabIndex = 1;
            this.lstTable.UseCompatibleStateImageBehavior = false;
            this.lstTable.View = System.Windows.Forms.View.Details;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(381, 358);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(75, 23);
            this.btnSelect.TabIndex = 2;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(381, 452);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 3;
            this.btnAdd.Text = "增加";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // lblText1
            // 
            this.lblText1.AutoSize = true;
            this.lblText1.Location = new System.Drawing.Point(74, 323);
            this.lblText1.Name = "lblText1";
            this.lblText1.Size = new System.Drawing.Size(77, 12);
            this.lblText1.TabIndex = 5;
            this.lblText1.Text = "按名称查询：";
            // 
            // lblText2
            // 
            this.lblText2.AutoSize = true;
            this.lblText2.Location = new System.Drawing.Point(74, 369);
            this.lblText2.Name = "lblText2";
            this.lblText2.Size = new System.Drawing.Size(77, 12);
            this.lblText2.TabIndex = 6;
            this.lblText2.Text = "按地址查询：";
            // 
            // cmbName
            // 
            this.cmbName.FormattingEnabled = true;
            this.cmbName.Items.AddRange(new object[] {
            "查询全部"});
            this.cmbName.Location = new System.Drawing.Point(157, 320);
            this.cmbName.Name = "cmbName";
            this.cmbName.Size = new System.Drawing.Size(159, 20);
            this.cmbName.TabIndex = 8;
            // 
            // lblDay
            // 
            this.lblDay.AutoSize = true;
            this.lblDay.Location = new System.Drawing.Point(74, 413);
            this.lblDay.Name = "lblDay";
            this.lblDay.Size = new System.Drawing.Size(77, 12);
            this.lblDay.TabIndex = 9;
            this.lblDay.Text = "按日期查询：";
            // 
            // lblSex
            // 
            this.lblSex.AutoSize = true;
            this.lblSex.Location = new System.Drawing.Point(74, 452);
            this.lblSex.Name = "lblSex";
            this.lblSex.Size = new System.Drawing.Size(77, 12);
            this.lblSex.TabIndex = 10;
            this.lblSex.Text = "按性别查询：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 494);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(113, 12);
            this.label3.TabIndex = 11;
            this.label3.Text = "按身份证号码查询：";
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(157, 366);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(159, 21);
            this.txtAddress.TabIndex = 12;
            // 
            // dtpTime
            // 
            this.dtpTime.Location = new System.Drawing.Point(157, 407);
            this.dtpTime.Name = "dtpTime";
            this.dtpTime.Size = new System.Drawing.Size(159, 21);
            this.dtpTime.TabIndex = 13;
            // 
            // cmbSex
            // 
            this.cmbSex.FormattingEnabled = true;
            this.cmbSex.Items.AddRange(new object[] {
            "查询全部",
            "男",
            "女"});
            this.cmbSex.Location = new System.Drawing.Point(157, 449);
            this.cmbSex.Name = "cmbSex";
            this.cmbSex.Size = new System.Drawing.Size(159, 20);
            this.cmbSex.TabIndex = 14;
            // 
            // txtCardID
            // 
            this.txtCardID.Location = new System.Drawing.Point(157, 491);
            this.txtCardID.Name = "txtCardID";
            this.txtCardID.Size = new System.Drawing.Size(159, 21);
            this.txtCardID.TabIndex = 16;
            // 
            // FrmStoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(479, 526);
            this.Controls.Add(this.txtCardID);
            this.Controls.Add(this.cmbSex);
            this.Controls.Add(this.dtpTime);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lblSex);
            this.Controls.Add(this.lblDay);
            this.Controls.Add(this.cmbName);
            this.Controls.Add(this.lblText2);
            this.Controls.Add(this.lblText1);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.lstTable);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStoreFront";
            this.Text = "店面销售界面";
            this.Load += new System.EventHandler(this.FrmStoreFront_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalesStore;
        private System.Windows.Forms.ToolStripMenuItem tsmiClerk;
        private System.Windows.Forms.ToolStripMenuItem tsmiClientele;
        private System.Windows.Forms.ToolStripMenuItem tsmiBillOfLading;
        private System.Windows.Forms.ToolStripMenuItem tsmiSalesTicket;
        private System.Windows.Forms.ListView lstTable;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label lblText1;
        private System.Windows.Forms.Label lblText2;
        private System.Windows.Forms.ComboBox cmbName;
        private System.Windows.Forms.Label lblDay;
        private System.Windows.Forms.Label lblSex;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.DateTimePicker dtpTime;
        private System.Windows.Forms.ComboBox cmbSex;
        private System.Windows.Forms.TextBox txtCardID;
    }
}