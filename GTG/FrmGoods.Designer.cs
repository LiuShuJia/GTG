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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtNum = new System.Windows.Forms.TextBox();
            this.txtStyle = new System.Windows.Forms.TextBox();
            this.btnSelect = new System.Windows.Forms.Button();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
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
            this.menuStrip1.Size = new System.Drawing.Size(543, 25);
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5});
            this.dataGridView1.Location = new System.Drawing.Point(0, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 23;
            this.dataGridView1.Size = new System.Drawing.Size(541, 343);
            this.dataGridView1.TabIndex = 2;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "GName";
            this.Column1.HeaderText = "商品名";
            this.Column1.Name = "Column1";
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "GNum";
            this.Column2.HeaderText = "商品数量";
            this.Column2.Name = "Column2";
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "GStyle";
            this.Column3.HeaderText = "商品类别";
            this.Column3.Name = "Column3";
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "GStandard";
            this.Column4.HeaderText = "商品规格";
            this.Column4.Name = "Column4";
            // 
            // Column5
            // 
            this.Column5.DataPropertyName = "GUnit";
            this.Column5.HeaderText = "商品单位";
            this.Column5.Name = "Column5";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(43, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 3;
            this.label1.Text = "商品名：";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(256, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "商品单位：";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(31, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "商品类别：";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(102, 37);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(134, 21);
            this.txtName.TabIndex = 6;
            // 
            // txtNum
            // 
            this.txtNum.Location = new System.Drawing.Point(337, 37);
            this.txtNum.Name = "txtNum";
            this.txtNum.Size = new System.Drawing.Size(134, 21);
            this.txtNum.TabIndex = 7;
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
            this.btnSelect.Location = new System.Drawing.Point(337, 83);
            this.btnSelect.Name = "btnSelect";
            this.btnSelect.Size = new System.Drawing.Size(134, 23);
            this.btnSelect.TabIndex = 9;
            this.btnSelect.Text = "查询";
            this.btnSelect.UseVisualStyleBackColor = true;
            this.btnSelect.Click += new System.EventHandler(this.btnSelect_Click);
            // 
            // FrmGoods
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(543, 481);
            this.Controls.Add(this.btnSelect);
            this.Controls.Add(this.txtStyle);
            this.Controls.Add(this.txtNum);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FrmGoods";
            this.Text = "商品界面";
            this.Load += new System.EventHandler(this.FrmGoods_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem 商品信息表ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 供应商资料ToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem 送货单表ToolStripMenuItem;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtNum;
        private System.Windows.Forms.TextBox txtStyle;
        private System.Windows.Forms.Button btnSelect;
    }
}