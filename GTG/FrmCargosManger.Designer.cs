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
            this.tsmiWarehous = new System.Windows.Forms.ToolStripMenuItem();
            this.出库入库单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmiDetailed = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiPurc,
            this.tsmiWarehous,
            this.出库入库单管理ToolStripMenuItem,
            this.tsmiDetailed});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // tsmiPurc
            // 
            this.tsmiPurc.Name = "tsmiPurc";
            this.tsmiPurc.Size = new System.Drawing.Size(68, 21);
            this.tsmiPurc.Text = "入库管理";
            this.tsmiPurc.Click += new System.EventHandler(this.tsmiPurc_Click_1);
            // 
            // tsmiWarehous
            // 
            this.tsmiWarehous.Name = "tsmiWarehous";
            this.tsmiWarehous.Size = new System.Drawing.Size(68, 21);
            this.tsmiWarehous.Text = "出库管理";
            this.tsmiWarehous.Click += new System.EventHandler(this.tsmiWarehous_Click_1);
            // 
            // 出库入库单管理ToolStripMenuItem
            // 
            this.出库入库单管理ToolStripMenuItem.Name = "出库入库单管理ToolStripMenuItem";
            this.出库入库单管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.出库入库单管理ToolStripMenuItem.Text = "出库入库单表";
            this.出库入库单管理ToolStripMenuItem.Click += new System.EventHandler(this.tsmiOutboundInventoryTable);
            // 
            // tsmiDetailed
            // 
            this.tsmiDetailed.Name = "tsmiDetailed";
            this.tsmiDetailed.Size = new System.Drawing.Size(104, 21);
            this.tsmiDetailed.Text = "出库入库详情表";
            this.tsmiDetailed.Click += new System.EventHandler(this.tsmiDetailed_Click);
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
        private System.Windows.Forms.ToolStripMenuItem tsmiWarehous;
        private System.Windows.Forms.ToolStripMenuItem 出库入库单管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tsmiDetailed;
    }
}