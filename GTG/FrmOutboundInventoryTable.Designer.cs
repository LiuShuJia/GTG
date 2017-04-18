namespace GTG
{
    partial class FrmOutboundInventoryTable
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
            this.lblWarehouseList = new System.Windows.Forms.Label();
            this.lblPurchaseList = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.btnQuery = new System.Windows.Forms.Button();
            this.cboName = new System.Windows.Forms.ComboBox();
            this.lstPurchaseList = new System.Windows.Forms.ListView();
            this.PID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.PInDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.lstWarehouseList = new System.Windows.Forms.ListView();
            this.WLID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WWname = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.WLDate = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // lblWarehouseList
            // 
            this.lblWarehouseList.AutoSize = true;
            this.lblWarehouseList.Location = new System.Drawing.Point(3, 67);
            this.lblWarehouseList.Name = "lblWarehouseList";
            this.lblWarehouseList.Size = new System.Drawing.Size(53, 12);
            this.lblWarehouseList.TabIndex = 2;
            this.lblWarehouseList.Text = "出库表：";
            // 
            // lblPurchaseList
            // 
            this.lblPurchaseList.AutoSize = true;
            this.lblPurchaseList.Location = new System.Drawing.Point(3, 263);
            this.lblPurchaseList.Name = "lblPurchaseList";
            this.lblPurchaseList.Size = new System.Drawing.Size(53, 12);
            this.lblPurchaseList.TabIndex = 3;
            this.lblPurchaseList.Text = "入库表：";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 29);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(47, 12);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "仓库名:";
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(193, 24);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "显示所有"});
            this.cboName.Location = new System.Drawing.Point(56, 26);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 20);
            this.cboName.TabIndex = 9;
            // 
            // lstPurchaseList
            // 
            this.lstPurchaseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.PID,
            this.WName,
            this.PInDate});
            this.lstPurchaseList.Location = new System.Drawing.Point(5, 289);
            this.lstPurchaseList.Name = "lstPurchaseList";
            this.lstPurchaseList.Size = new System.Drawing.Size(263, 149);
            this.lstPurchaseList.TabIndex = 23;
            this.lstPurchaseList.UseCompatibleStateImageBehavior = false;
            this.lstPurchaseList.View = System.Windows.Forms.View.Details;
            // 
            // PID
            // 
            this.PID.Text = "入库单编号";
            this.PID.Width = 81;
            // 
            // WName
            // 
            this.WName.Text = "仓库名";
            this.WName.Width = 71;
            // 
            // PInDate
            // 
            this.PInDate.Text = "日期";
            // 
            // lstWarehouseList
            // 
            this.lstWarehouseList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.WLID,
            this.WWname,
            this.WLDate});
            this.lstWarehouseList.Location = new System.Drawing.Point(5, 95);
            this.lstWarehouseList.Name = "lstWarehouseList";
            this.lstWarehouseList.Size = new System.Drawing.Size(263, 150);
            this.lstWarehouseList.TabIndex = 22;
            this.lstWarehouseList.UseCompatibleStateImageBehavior = false;
            this.lstWarehouseList.View = System.Windows.Forms.View.Details;
            // 
            // WLID
            // 
            this.WLID.Text = "出库单编号";
            this.WLID.Width = 81;
            // 
            // WWname
            // 
            this.WWname.Text = "仓库名";
            this.WWname.Width = 71;
            // 
            // WLDate
            // 
            this.WLDate.Text = "日期";
            // 
            // FrmOutboundInventoryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 449);
            this.Controls.Add(this.lstPurchaseList);
            this.Controls.Add(this.lstWarehouseList);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPurchaseList);
            this.Controls.Add(this.lblWarehouseList);
            this.Name = "FrmOutboundInventoryTable";
            this.Text = "出库入库单表";
            this.Load += new System.EventHandler(this.FrmOutboundInventoryTable_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblWarehouseList;
        private System.Windows.Forms.Label lblPurchaseList;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.ListView lstPurchaseList;
        private System.Windows.Forms.ColumnHeader PID;
        private System.Windows.Forms.ColumnHeader WName;
        private System.Windows.Forms.ColumnHeader PInDate;
        private System.Windows.Forms.ListView lstWarehouseList;
        private System.Windows.Forms.ColumnHeader WLID;
        private System.Windows.Forms.ColumnHeader WWname;
        private System.Windows.Forms.ColumnHeader WLDate;
    }
}