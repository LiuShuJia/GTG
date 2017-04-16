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
            this.lblDateTime = new System.Windows.Forms.Label();
            this.dtpDateTime = new System.Windows.Forms.DateTimePicker();
            this.btnQuery = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPurchaseList = new System.Windows.Forms.Label();
            this.lblWarehouseList = new System.Windows.Forms.Label();
            this.dvgPurchaseListDetail = new System.Windows.Forms.DataGridView();
            this.dvgWarehouseListDetail = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgPurchaseListDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgWarehouseListDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // cboName
            // 
            this.cboName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboName.FormattingEnabled = true;
            this.cboName.Items.AddRange(new object[] {
            "显示所有"});
            this.cboName.Location = new System.Drawing.Point(44, 21);
            this.cboName.Name = "cboName";
            this.cboName.Size = new System.Drawing.Size(121, 20);
            this.cboName.TabIndex = 18;
            // 
            // lblDateTime
            // 
            this.lblDateTime.AutoSize = true;
            this.lblDateTime.Location = new System.Drawing.Point(171, 24);
            this.lblDateTime.Name = "lblDateTime";
            this.lblDateTime.Size = new System.Drawing.Size(29, 12);
            this.lblDateTime.TabIndex = 17;
            this.lblDateTime.Text = "日期";
            // 
            // dtpDateTime
            // 
            this.dtpDateTime.Location = new System.Drawing.Point(206, 20);
            this.dtpDateTime.Name = "dtpDateTime";
            this.dtpDateTime.Size = new System.Drawing.Size(121, 21);
            this.dtpDateTime.TabIndex = 16;
            // 
            // btnQuery
            // 
            this.btnQuery.Location = new System.Drawing.Point(333, 21);
            this.btnQuery.Name = "btnQuery";
            this.btnQuery.Size = new System.Drawing.Size(75, 23);
            this.btnQuery.TabIndex = 15;
            this.btnQuery.Text = "查询";
            this.btnQuery.UseVisualStyleBackColor = true;
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
            // lblPurchaseList
            // 
            this.lblPurchaseList.AutoSize = true;
            this.lblPurchaseList.Location = new System.Drawing.Point(1, 243);
            this.lblPurchaseList.Name = "lblPurchaseList";
            this.lblPurchaseList.Size = new System.Drawing.Size(77, 12);
            this.lblPurchaseList.TabIndex = 13;
            this.lblPurchaseList.Text = "入库详细表：";
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
            // dvgPurchaseListDetail
            // 
            this.dvgPurchaseListDetail.AllowUserToAddRows = false;
            this.dvgPurchaseListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgPurchaseListDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.Column5,
            this.dataGridViewTextBoxColumn3});
            this.dvgPurchaseListDetail.Location = new System.Drawing.Point(3, 258);
            this.dvgPurchaseListDetail.Name = "dvgPurchaseListDetail";
            this.dvgPurchaseListDetail.RowTemplate.Height = 23;
            this.dvgPurchaseListDetail.Size = new System.Drawing.Size(445, 150);
            this.dvgPurchaseListDetail.TabIndex = 11;
            // 
            // dvgWarehouseListDetail
            // 
            this.dvgWarehouseListDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgWarehouseListDetail.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column4,
            this.Column3});
            this.dvgWarehouseListDetail.Location = new System.Drawing.Point(3, 71);
            this.dvgWarehouseListDetail.Name = "dvgWarehouseListDetail";
            this.dvgWarehouseListDetail.RowTemplate.Height = 23;
            this.dvgWarehouseListDetail.Size = new System.Drawing.Size(445, 159);
            this.dvgWarehouseListDetail.TabIndex = 10;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "WLID";
            this.Column1.HeaderText = "出库单编号";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GName";
            this.Column2.HeaderText = "商品名";
            this.Column2.Name = "Column2";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "WLDNum";
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
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
            this.dataGridViewTextBoxColumn2.DataPropertyName = "GName";
            this.dataGridViewTextBoxColumn2.HeaderText = "商品名";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "PLDNum";
            this.Column5.HeaderText = "数量";
            this.Column5.Name = "Column5";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "PInDate";
            this.dataGridViewTextBoxColumn3.HeaderText = "日期";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(459, 414);
            this.Controls.Add(this.cboName);
            this.Controls.Add(this.lblDateTime);
            this.Controls.Add(this.dtpDateTime);
            this.Controls.Add(this.btnQuery);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblPurchaseList);
            this.Controls.Add(this.lblWarehouseList);
            this.Controls.Add(this.dvgPurchaseListDetail);
            this.Controls.Add(this.dvgWarehouseListDetail);
            this.Name = "FrmDetailed";
            this.Text = "出库入库详情";
            this.Load += new System.EventHandler(this.FrmDetailed_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dvgPurchaseListDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dvgWarehouseListDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cboName;
        private System.Windows.Forms.Label lblDateTime;
        private System.Windows.Forms.DateTimePicker dtpDateTime;
        private System.Windows.Forms.Button btnQuery;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPurchaseList;
        private System.Windows.Forms.Label lblWarehouseList;
        private System.Windows.Forms.DataGridView dvgPurchaseListDetail;
        private System.Windows.Forms.DataGridView dvgWarehouseListDetail;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
    }
}