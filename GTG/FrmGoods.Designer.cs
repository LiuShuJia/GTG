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
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.商品信息表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.供应商资料ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.送货单表ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblGName = new System.Windows.Forms.Label();
            this.GStyle = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.tsmiUp = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.商品信息表ToolStripMenuItem,
            this.供应商资料ToolStripMenuItem,
            this.送货单表ToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(8, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(624, 28);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // 商品信息表ToolStripMenuItem
            // 
            this.商品信息表ToolStripMenuItem.Name = "商品信息表ToolStripMenuItem";
            this.商品信息表ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.商品信息表ToolStripMenuItem.Text = "商品信息表";
            // 
            // 供应商资料ToolStripMenuItem
            // 
            this.供应商资料ToolStripMenuItem.Name = "供应商资料ToolStripMenuItem";
            this.供应商资料ToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.供应商资料ToolStripMenuItem.Text = "供应商资料";
            // 
            // 送货单表ToolStripMenuItem
            // 
            this.送货单表ToolStripMenuItem.Name = "送货单表ToolStripMenuItem";
            this.送货单表ToolStripMenuItem.Size = new System.Drawing.Size(81, 24);
            this.送货单表ToolStripMenuItem.Text = "送货单表";
            // 
            // lblGName
            // 
            this.lblGName.AutoSize = true;
            this.lblGName.Location = new System.Drawing.Point(57, 58);
            this.lblGName.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblGName.Name = "lblGName";
            this.lblGName.Size = new System.Drawing.Size(67, 15);
            this.lblGName.TabIndex = 3;
            this.lblGName.Text = "商品名：";
            // 
            // GStyle
            // 
            this.GStyle.AutoSize = true;
            this.GStyle.Location = new System.Drawing.Point(41, 118);
            this.GStyle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GStyle.Name = "GStyle";
            this.GStyle.Size = new System.Drawing.Size(82, 15);
            this.GStyle.TabIndex = 5;
            this.GStyle.Text = "商品类别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(136, 46);
            this.txtName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(177, 25);
            this.txtName.TabIndex = 6;
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(136, 106);
            this.txtStyle.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(177, 25);
            this.txtStyle.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(397, 72);
            this.btnSelect.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(179, 29);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader7,
            this.columnHeader12,
            this.columnHeader13,
            this.columnHeader14,
            this.columnHeader15});
            this.listView1.ContextMenuStrip = this.contextMenuStrip1;
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(44, 180);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(531, 268);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "商品名";
            this.columnHeader7.Width = 84;
            // 
            // columnHeader12
            // 
            this.columnHeader12.Text = "商品数量";
            this.columnHeader12.Width = 83;
            // 
            // columnHeader13
            // 
            this.columnHeader13.Text = "商品种类";
            this.columnHeader13.Width = 77;
            // 
            // columnHeader14
            // 
            this.columnHeader14.Text = "商品规格";
            this.columnHeader14.Width = 70;
            // 
            // columnHeader15
            // 
            this.columnHeader15.Text = "商品单位";
            this.columnHeader15.Width = 95;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmiUp});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(145, 30);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmiUp
            // 
            this.tsmiUp.Name = "tsmiUp";
            this.tsmiUp.Size = new System.Drawing.Size(181, 26);
            this.tsmiUp.Text = "修改信息";
            // 
            // FrmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(624, 500);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.GStyle);
            this.Controls.Add(this.lblGName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "FrmGoods";
            this.Text = "商品界面";
            this.Load += new System.EventHandler(this.FrmGoods_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 送货单表ToolStripMenuItem;
        private System.Windows.Forms.Label lblGName;
        private System.Windows.Forms.Label GStyle;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.Button btnSelect;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ColumnHeader columnHeader12;
        private System.Windows.Forms.ColumnHeader columnHeader13;
        private System.Windows.Forms.ColumnHeader columnHeader14;
        private System.Windows.Forms.ColumnHeader columnHeader15;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem tsmiUp;
    }
}