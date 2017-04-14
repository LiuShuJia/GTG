namespace GTG
{
    partial class FrmCargosManger
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
            this.tsmiPurc = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPurchaseList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiPurchaseListDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWarehous = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWarehouseList = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiWarehouseListDetail = new System.Windows.Forms.ToolStripMenuItem();
            this.出库入库单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPurc,
            this.tsmiWarehous,
            this.出库入库单管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiPurc
            // 
            this.tsmiPurc.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPurchaseList,
            this.tsmiPurchaseListDetail});
            this.tsmiPurc.Name = "tsmiPurc";
            this.tsmiPurc.Size = new System.Drawing.Size(68, 21);
            this.tsmiPurc.Text = "入库管理";
            // 
            // tsmiPurchaseList
            // 
            this.tsmiPurchaseList.Name = "tsmiPurchaseList";
            this.tsmiPurchaseList.Size = new System.Drawing.Size(184, 22);
            this.tsmiPurchaseList.Text = "货品入库";
            this.tsmiPurchaseList.Click += new System.EventHandler(this.tsmiPurchaseList_Click);
            // 
            // tsmiPurchaseListDetail
            // 
            this.tsmiPurchaseListDetail.Name = "tsmiPurchaseListDetail";
            this.tsmiPurchaseListDetail.Size = new System.Drawing.Size(184, 22);
            this.tsmiPurchaseListDetail.Text = "货品入库详细信息单";
            this.tsmiPurchaseListDetail.Click += new System.EventHandler(this.tsmiPurchaseListDetail_Click);
            // 
            // tsmiWarehous
            // 
            this.tsmiWarehous.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiWarehouseList,
            this.tsmiWarehouseListDetail});
            this.tsmiWarehous.Name = "tsmiWarehous";
            this.tsmiWarehous.Size = new System.Drawing.Size(68, 21);
            this.tsmiWarehous.Text = "出库管理";
            // 
            // tsmiWarehouseList
            // 
            this.tsmiWarehouseList.Name = "tsmiWarehouseList";
            this.tsmiWarehouseList.Size = new System.Drawing.Size(184, 22);
            this.tsmiWarehouseList.Text = "货品出库";
            this.tsmiWarehouseList.Click += new System.EventHandler(this.tsmiWarehouseList_Click);
            // 
            // tsmiWarehouseListDetail
            // 
            this.tsmiWarehouseListDetail.Name = "tsmiWarehouseListDetail";
            this.tsmiWarehouseListDetail.Size = new System.Drawing.Size(184, 22);
            this.tsmiWarehouseListDetail.Text = "货品出库详细信息单";
            this.tsmiWarehouseListDetail.Click += new System.EventHandler(this.tsmiWarehouseListDetail_Click);
            // 
            // 出库入库单管理ToolStripMenuItem
            // 
            this.出库入库单管理ToolStripMenuItem.Name = "出库入库单管理ToolStripMenuItem";
            this.出库入库单管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.出库入库单管理ToolStripMenuItem.Text = "出库入库单表";
            this.出库入库单管理ToolStripMenuItem.Click += new System.EventHandler(this.tsmiOutboundInventoryTable);
            // 
            // FrmCargosManger
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(435, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmCargosManger";
            this.Text = "货品出库入库管理";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiPurc;
        private System.Windows.Forms.ToolStripMenuItem tsmiPurchaseList;
        private System.Windows.Forms.ToolStripMenuItem tsmiPurchaseListDetail;
        private System.Windows.Forms.ToolStripMenuItem tsmiWarehous;
        private System.Windows.Forms.ToolStripMenuItem tsmiWarehouseList;
        private System.Windows.Forms.ToolStripMenuItem tsmiWarehouseListDetail;
        private System.Windows.Forms.ToolStripMenuItem 出库入库单管理ToolStripMenuItem;
    }
}