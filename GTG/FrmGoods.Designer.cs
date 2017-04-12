namespace GTG
{
    partial class FrmGoods
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
            this.商品信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.送货单表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品信息表ToolStripMenuItem,
            this.供应商资料ToolStripMenuItem,
            this.送货单表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(420, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 商品信息表ToolStripMenuItem
            // 
            this.商品信息表ToolStripMenuItem.Name = "商品信息表ToolStripMenuItem";
            this.商品信息表ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.商品信息表ToolStripMenuItem.Text = "商品信息表";
            // 
            // 供应商资料ToolStripMenuItem
            // 
            this.供应商资料ToolStripMenuItem.Name = "供应商资料ToolStripMenuItem";
            this.供应商资料ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.供应商资料ToolStripMenuItem.Text = "供应商资料";
            // 
            // 送货单表ToolStripMenuItem
            // 
            this.送货单表ToolStripMenuItem.Name = "送货单表ToolStripMenuItem";
            this.送货单表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.送货单表ToolStripMenuItem.Text = "送货单表";
            // 
            // FrmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(420, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGoods";
            this.Text = "商品界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 送货单表ToolStripMenuItem;
    }
}