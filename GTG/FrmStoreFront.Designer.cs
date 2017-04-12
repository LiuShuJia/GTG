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
            this.店铺信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.客户信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.提货单信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.店铺信息ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.店员信息ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.销售单ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.店铺信息ToolStripMenuItem,
            this.客户信息表ToolStripMenuItem,
            this.提货单信息表ToolStripMenuItem,
            this.销售单ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(427, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 店铺信息ToolStripMenuItem
            // 
            this.店铺信息ToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.店铺信息ToolStripMenuItem1,
            this.店员信息ToolStripMenuItem});
            this.店铺信息ToolStripMenuItem.Name = "店铺信息ToolStripMenuItem";
            this.店铺信息ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.店铺信息ToolStripMenuItem.Text = "店铺信息";
            // 
            // 客户信息表ToolStripMenuItem
            // 
            this.客户信息表ToolStripMenuItem.Name = "客户信息表ToolStripMenuItem";
            this.客户信息表ToolStripMenuItem.Size = new System.Drawing.Size(80, 21);
            this.客户信息表ToolStripMenuItem.Text = "客户信息表";
            // 
            // 提货单信息表ToolStripMenuItem
            // 
            this.提货单信息表ToolStripMenuItem.Name = "提货单信息表ToolStripMenuItem";
            this.提货单信息表ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.提货单信息表ToolStripMenuItem.Text = "提货单信息表";
            // 
            // 店铺信息ToolStripMenuItem1
            // 
            this.店铺信息ToolStripMenuItem1.Name = "店铺信息ToolStripMenuItem1";
            this.店铺信息ToolStripMenuItem1.Size = new System.Drawing.Size(152, 22);
            this.店铺信息ToolStripMenuItem1.Text = "店铺信息";
            // 
            // 店员信息ToolStripMenuItem
            // 
            this.店员信息ToolStripMenuItem.Name = "店员信息ToolStripMenuItem";
            this.店员信息ToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.店员信息ToolStripMenuItem.Text = "店员信息";
            // 
            // 销售单ToolStripMenuItem
            // 
            this.销售单ToolStripMenuItem.Name = "销售单ToolStripMenuItem";
            this.销售单ToolStripMenuItem.Size = new System.Drawing.Size(92, 21);
            this.销售单ToolStripMenuItem.Text = "销售单信息表";
            // 
            // FrmStoreFront
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(427, 261);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmStoreFront";
            this.Text = "店面销售界面";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 店铺信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 店铺信息ToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem 店员信息ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 客户信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 提货单信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 销售单ToolStripMenuItem;
    }
}