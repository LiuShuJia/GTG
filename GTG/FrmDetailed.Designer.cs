namespace GTG
{
    partial class FrmDetailed
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
            this.cboName = new System.Windows.Forms.ComboBox();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblWarehouseList = new System.Windows.Forms.Label();
            this.lstPurchaseList = new System.Windows.Forms.ListView();
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstWarehouseList = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // cboName
            // 
            this.cboName.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "显示所有"});
            this.cboName.Location = new System.Drawing.Point(44, 21);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 20);
            this.cboName.TabIndex = 18;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(193, 19);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click_1);
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(1, 24);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 12);
            this.lblName.TabIndex = 14;
            this.lblName.Text = "商品名:";
            // 
            // lblWarehouseList
            // 
            this.lblWarehouseList.AutoSize = true;
            this.lblWarehouseList.Location = new System.Drawing.Point(1, 56);
            this.lblWarehouseList.Name = "lblWarehouseList";
            this.lblWarehouseList.Size = new System.Drawing.Size(77, 12);
            this.lblWarehouseList.TabIndex = 12;
            this.lblWarehouseList.Text = "出库详细表：";
            // 
            // lstPurchaseList
            // 
            this.lstPurchaseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7,
            this.columnHeader8});
            this.lstPurchaseList.Location = new System.Drawing.Point(3, 266);
            this.lstPurchaseList.Name = "lstPurchaseList";
            this.lstPurchaseList.Size = new System.Drawing.Size(298, 149);
            this.lstPurchaseList.TabIndex = 23;
            this.lstPurchaseList.UseCompatibleStateImageBehavior = false;
            this.lstPurchaseList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "入库单编号";
            this.columnHeader5.Width = 81;
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "商品名";
            this.columnHeader6.Width = 71;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "数量";
            this.columnHeader7.Width = 86;
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "日期";
            // 
            // lstWarehouseList
            // 
            this.lstWarehouseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3,
            this.columnHeader4});
            this.lstWarehouseList.Location = new System.Drawing.Point(3, 71);
            this.lstWarehouseList.Name = "lstWarehouseList";
            this.lstWarehouseList.Size = new System.Drawing.Size(298, 149);
            this.lstWarehouseList.TabIndex = 22;
            this.lstWarehouseList.UseCompatibleStateImageBehavior = false;
            this.lstWarehouseList.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "出库单编号";
            this.columnHeader1.Width = 81;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名";
            this.columnHeader2.Width = 71;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "数量";
            this.columnHeader3.Width = 86;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "日期";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(1, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 12);
            this.label1.TabIndex = 21;
            this.label1.Text = "入库详细表：";
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(308, 414);
            this.Controls.Add(this.lstPurchaseList);
            this.Controls.Add(this.lstWarehouseList);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblWarehouseList);
            this.Name = "FrmDetailed";
            this.Text = "出库入库详情";
            this.Load += new System.EventHandler(this.FrmDetailed_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblWarehouseList;
        private System.Windows.Forms.ListView lstPurchaseList;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ListView lstWarehouseList;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.Label label1;
    }
}