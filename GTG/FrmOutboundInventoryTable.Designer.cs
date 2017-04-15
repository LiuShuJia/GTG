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
            this.dvgWarehouseList = new System.Windows.Forms.DataGridView();
            this.dvgPurchaseList = new System.Windows.Forms.DataGridView();
            this.lblWarehouseList = new System.Windows.Forms.Label();
            this.lblPurchaseList = new System.Windows.Forms.Label();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblName = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.btnQuery = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dvgWarehouseList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPurchaseList)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgWarehouseList
            // 
            this.dvgWarehouseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgWarehouseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3});
            this.dvgWarehouseList.Location = new System.Drawing.Point(5, 119);
            this.dvgWarehouseList.Name = "dvgWarehouseList";
            this.dvgWarehouseList.RowTemplate.Height = 23;
            this.dvgWarehouseList.Size = new System.Drawing.Size(346, 159);
            this.dvgWarehouseList.TabIndex = 0;
            // 
            // dvgPurchaseList
            // 
            this.dvgPurchaseList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPurchaseList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.dvgPurchaseList.Location = new System.Drawing.Point(5, 363);
            this.dvgPurchaseList.Name = "dvgPurchaseList";
            this.dvgPurchaseList.RowTemplate.Height = 23;
            this.dvgPurchaseList.Size = new System.Drawing.Size(346, 150);
            this.dvgPurchaseList.TabIndex = 1;
            this.dvgPurchaseList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // lblWarehouseList
            // 
            this.lblWarehouseList.AutoSize = true;
            this.lblWarehouseList.Location = new System.Drawing.Point(3, 82);
            this.lblWarehouseList.Name = "lblWarehouseList";
            this.lblWarehouseList.Size = new System.Drawing.Size(53, 12);
            this.lblWarehouseList.TabIndex = 2;
            this.lblWarehouseList.Text = "出库表：";
            // 
            // lblPurchaseList
            // 
            this.lblPurchaseList.AutoSize = true;
            this.lblPurchaseList.Location = new System.Drawing.Point(3, 329);
            this.lblPurchaseList.Name = "lblPurchaseList";
            this.lblPurchaseList.Size = new System.Drawing.Size(53, 12);
            this.lblPurchaseList.TabIndex = 3;
            this.lblPurchaseList.Text = "入库表：";
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "WLID";
            this.Column1.HeaderText = "入库单编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "WID";
            this.Column2.HeaderText = "仓库名";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "WLDate";
            this.Column3.HeaderText = "日期";
            this.Column3.Name = "Column3";
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "PID";
            this.dataGridViewTextBoxColumn1.HeaderText = "入库单编号";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "WID";
            this.dataGridViewTextBoxColumn2.HeaderText = "仓库名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PInDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "日期";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(3, 44);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(41, 12);
            this.lblName.TabIndex = 4;
            this.lblName.Text = "仓库名";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(75, 41);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(100, 21);
            this.txtName.TabIndex = 5;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(211, 39);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 6;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
            // 
            // FrmOutboundInventoryTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(355, 525);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPurchaseList);
            this.Controls.Add(this.lblWarehouseList);
            this.Controls.Add(this.dvgPurchaseList);
            this.Controls.Add(this.dvgWarehouseList);
            this.Name = "FrmOutboundInventoryTable";
            this.Text = "出库入库单表";
            this.Load += new System.EventHandler(this.FrmOutboundInventoryTable_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgWarehouseList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPurchaseList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgWarehouseList;
        private System.Windows.Forms.DataGridView dvgPurchaseList;
        private System.Windows.Forms.Label lblWarehouseList;
        private System.Windows.Forms.Label lblPurchaseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Button btnQuery;
    }
}