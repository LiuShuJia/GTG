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
            this.入库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货品出库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货品出库信息单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货品入库ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.货品入库单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.出库入库单管理ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.入库管理ToolStripMenuItem,
            this.出库管理ToolStripMenuItem,
            this.出库入库单管理ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(435, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 入库管理ToolStripMenuItem
            // 
            this.入库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.货品入库ToolStripMenuItem,
            this.货品入库单ToolStripMenuItem});
            this.入库管理ToolStripMenuItem.Name = "入库管理ToolStripMenuItem";
            this.入库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.入库管理ToolStripMenuItem.Text = "入库管理";
            // 
            // 出库管理ToolStripMenuItem
            // 
            this.出库管理ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.货品出库ToolStripMenuItem,
            this.货品出库信息单ToolStripMenuItem});
            this.出库管理ToolStripMenuItem.Name = "出库管理ToolStripMenuItem";
            this.出库管理ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.出库管理ToolStripMenuItem.Text = "进货管理";
            // 
            // 货品出库ToolStripMenuItem
            // 
            this.货品出库ToolStripMenuItem.Name = "货品出库ToolStripMenuItem";
            this.货品出库ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.货品出库ToolStripMenuItem.Text = "进货";
            // 
            // 货品出库信息单ToolStripMenuItem
            // 
            this.货品出库信息单ToolStripMenuItem.Name = "货品出库信息单ToolStripMenuItem";
            this.货品出库信息单ToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.货品出库信息单ToolStripMenuItem.Text = "货品出库信息单";
            // 
            // 货品入库ToolStripMenuItem
            // 
            this.货品入库ToolStripMenuItem.Name = "货品入库ToolStripMenuItem";
            this.货品入库ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.货品入库ToolStripMenuItem.Text = "货品入库";
            // 
            // 货品入库单ToolStripMenuItem
            // 
            this.货品入库单ToolStripMenuItem.Name = "货品入库单ToolStripMenuItem";
            this.货品入库单ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.货品入库单ToolStripMenuItem.Text = "货品入库单";
            // 
            // 出库入库单管理ToolStripMenuItem
            // 
            this.出库入库单管理ToolStripMenuItem.Name = "出库入库单管理ToolStripMenuItem";
            this.出库入库单管理ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.出库入库单管理ToolStripMenuItem.Text = "出库入库单表";
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
        private System.Windows.Forms.ToolStripMenuItem 入库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货品入库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货品入库单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库管理ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货品出库ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 货品出库信息单ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 出库入库单管理ToolStripMenuItem;
    }
}