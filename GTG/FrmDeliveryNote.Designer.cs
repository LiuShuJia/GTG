namespace GTG
{
    partial class FrmDeliveryNote
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.btnQue = new System.Windows.Forms.Button();
            this.txtGname = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listView1.FullRowSelect = true;
            this.listView1.GridLines = true;
            this.listView1.Location = new System.Drawing.Point(10, 96);
            this.listView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(350, 282);
            this.listView1.TabIndex = 12;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "供应商";
            this.columnHeader1.Width = 158;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "商品名";
            this.columnHeader2.Width = 126;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "数量";
            this.columnHeader3.Width = 182;
            // 
            // btnQue
            // 
            this.btnQue.Location = new System.Drawing.Point(284, 47);
            this.btnQue.Name = "btnQue";
            this.btnQue.Size = new System.Drawing.Size(75, 23);
            this.btnQue.TabIndex = 11;
            this.btnQue.Text = "查询";
            this.btnQue.UseVisualStyleBackColor = true;
            this.btnQue.Click += new System.EventHandler(this.btnQue_Click);
            // 
            // txtGname
            // 
            this.txtGname.Location = new System.Drawing.Point(139, 50);
            this.txtGname.Name = "txtGname";
            this.txtGname.Size = new System.Drawing.Size(117, 21);
            this.txtGname.TabIndex = 10;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(139, 10);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(117, 21);
            this.txtName.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(56, 53);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 12);
            this.label2.TabIndex = 8;
            this.label2.Text = "商品：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(53, 12);
            this.label1.TabIndex = 7;
            this.label1.Text = "供应商：";
            // 
            // FrmDeliveryNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(370, 387);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.btnQue);
            this.Controls.Add(this.txtGname);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "FrmDeliveryNote";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "FrmDeliveryNote";
            this.Load += new System.EventHandler(this.FrmDeliveryNote_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.Button btnQue;
        private System.Windows.Forms.TextBox txtGname;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}