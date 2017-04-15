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
            this.dvgDetailed = new System.Windows.Forms.DataGridView();
            this.btnWarehouseList = new System.Windows.Forms.Button();
            this.btnPurchaseList = new System.Windows.Forms.Button();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailed)).BeginInit();
            this.SuspendLayout();
            // 
            // dvgDetailed
            // 
            this.dvgDetailed.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgDetailed.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column1,
            this.Column5});
            this.dvgDetailed.Location = new System.Drawing.Point(2, 81);
            this.dvgDetailed.Name = "dvgDetailed";
            this.dvgDetailed.RowTemplate.Height = 23;
            this.dvgDetailed.Size = new System.Drawing.Size(537, 311);
            this.dvgDetailed.TabIndex = 1;
            // 
            // btnWarehouseList
            // 
            this.btnWarehouseList.Location = new System.Drawing.Point(21, 20);
            this.btnWarehouseList.Name = "btnWarehouseList";
            this.btnWarehouseList.Size = new System.Drawing.Size(75, 23);
            this.btnWarehouseList.TabIndex = 2;
            this.btnWarehouseList.Text = "出库";
            this.btnWarehouseList.UseVisualStyleBackColor = true;
            // 
            // btnPurchaseList
            // 
            this.btnPurchaseList.Location = new System.Drawing.Point(134, 20);
            this.btnPurchaseList.Name = "btnPurchaseList";
            this.btnPurchaseList.Size = new System.Drawing.Size(75, 23);
            this.btnPurchaseList.TabIndex = 3;
            this.btnPurchaseList.Text = "入库";
            this.btnPurchaseList.UseVisualStyleBackColor = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "PID";
            this.Column2.HeaderText = "出库入库单编号";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GoodsName";
            this.Column3.HeaderText = "商品名";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "PLDNum";
            this.Column4.HeaderText = "数量";
            this.Column4.Name = "Column4";
            // 
            // Column1
            // 
            this.Column1.HeaderText = "操作";
            this.Column1.Name = "Column1";
            // 
            // Column5
            // 
            this.Column5.HeaderText = "日期";
            this.Column5.Name = "Column5";
            // 
            // FrmDetailed
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 395);
            this.Controls.Add(this.btnPurchaseList);
            this.Controls.Add(this.btnWarehouseList);
            this.Controls.Add(this.dvgDetailed);
            this.Name = "FrmDetailed";
            this.Text = "出库入库详情";
            ((System.ComponentModel.ISupportInitialize)(this.dvgDetailed)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dvgDetailed;
        private System.Windows.Forms.Button btnWarehouseList;
        private System.Windows.Forms.Button btnPurchaseList;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
    }
}