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
            this.tsmiRemove = new System.Windows.Forms.ToolStripMenuItem();
            this.btnGoodsAdd = new System.Windows.Forms.Button();
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
            this.menuStrip1.Size = new System.Drawing.Size(468, 25);
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
            this.供应商资料ToolStripMenuItem.Click += new System.EventHandler(this.供应商资料ToolStripMenuItem_Click);
            // 
            // 送货单表ToolStripMenuItem
            // 
            this.送货单表ToolStripMenuItem.Name = "送货单表ToolStripMenuItem";
            this.送货单表ToolStripMenuItem.Size = new System.Drawing.Size(68, 21);
            this.送货单表ToolStripMenuItem.Text = "送货单表";
            this.送货单表ToolStripMenuItem.Click += new System.EventHandler(this.送货单表ToolStripMenuItem_Click);
            // 
            // lblGName
            // 
            this.lblGName.AutoSize = true;
            this.lblGName.Location = new System.Drawing.Point(43, 46);
            this.lblGName.Name = "lblGName";
            this.lblGName.Size = new System.Drawing.Size(53, 12);
            this.lblGName.TabIndex = 3;
            this.lblGName.Text = "商品名：";
            // 
            // GStyle
            // 
            this.GStyle.AutoSize = true;
            this.GStyle.Location = new System.Drawing.Point(31, 94);
            this.GStyle.Name = "GStyle";
            this.GStyle.Size = new System.Drawing.Size(65, 12);
            this.GStyle.TabIndex = 5;
            this.GStyle.Text = "商品类别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtStyle
            // 
            this.txtStyle.Location = new System.Drawing.Point(102, 85);
            this.txtStyle.Name = "txtStyle";
            this.txtStyle.Size = new System.Drawing.Size(134, 21);
            this.txtStyle.TabIndex = 8;
            // 
            // btnSelect
            // 
            this.btnSelect.Location = new System.Drawing.Point(287, 83);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(134, 23);
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
            this.listView1.Location = new System.Drawing.Point(33, 144);
            this.listView1.Margin = new System.Windows.Forms.Padding(2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(399, 215);
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
            this.tsmiUp,
            this.tsmiRemove});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(125, 48);
            this.contextMenuStrip1.Opening += new System.ComponentModel.CancelEventHandler(this.contextMenuStrip1_Opening);
            // 
            // tsmiUp
            // 
            this.tsmiUp.Name = "tsmiUp";
            this.tsmiUp.Size = new System.Drawing.Size(124, 22);
            this.tsmiUp.Text = "修改信息";
            this.tsmiUp.Click += new System.EventHandler(this.tsmiUp_Click);
            // 
            // tsmiRemove
            // 
            this.tsmiRemove.Name = "tsmiRemove";
            this.tsmiRemove.Size = new System.Drawing.Size(124, 22);
            this.tsmiRemove.Text = "删除信息";
            this.tsmiRemove.Click += new System.EventHandler(this.tsmiRemove_Click);
            // 
            // btnGoodsAdd
            // 
            this.btnGoodsAdd.Location = new System.Drawing.Point(287, 35);
            this.btnGoodsAdd.Name = "btnGoodsAdd";
            this.btnGoodsAdd.Size = new System.Drawing.Size(134, 23);
            this.btnGoodsAdd.TabIndex = 11;
            this.btnGoodsAdd.Text = "增加商品信息";
            this.btnGoodsAdd.UseVisualStyleBackColor = true;
            this.btnGoodsAdd.Click += new System.EventHandler(this.btnGoodsAdd_Click);
            // 
            // FrmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(468, 400);
            this.Controls.Add(this.btnGoodsAdd);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.GStyle);
            this.Controls.Add(this.lblGName);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "FrmGoods";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
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
        private System.Windows.Forms.ToolStripMenuItem tsmiRemove;
        private System.Windows.Forms.Button btnGoodsAdd;
    }
}