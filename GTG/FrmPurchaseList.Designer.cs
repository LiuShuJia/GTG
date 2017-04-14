namespace GTG
{
    partial class FrmPurchaseList
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
            this.lbText = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtNumble = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.ForeColor = System.Drawing.Color.Black;
            this.lbText.Location = new System.Drawing.Point(519, 157);
            this.lbText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 12);
            this.lbText.TabIndex = 19;
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.Black;
            this.button1.Location = new System.Drawing.Point(192, 340);
            this.button1.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(138, 38);
            this.button1.TabIndex = 18;
            this.button1.Text = "入库";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(192, 243);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(308, 21);
            this.txtUnit.TabIndex = 17;
            this.txtUnit.Visible = false;
            this.txtUnit.Enter += new System.EventHandler(this.txtUnit_Enter);
            this.txtUnit.Leave += new System.EventHandler(this.txtUnit_Leave);
            // 
            // txtNumble
            // 
            this.txtNumble.Location = new System.Drawing.Point(192, 154);
            this.txtNumble.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumble.Name = "txtNumble";
            this.txtNumble.Size = new System.Drawing.Size(308, 21);
            this.txtNumble.TabIndex = 16;
            this.txtNumble.Enter += new System.EventHandler(this.txtNumble_Enter);
            this.txtNumble.Leave += new System.EventHandler(this.txtNumble_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(192, 73);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(308, 21);
            this.txtName.TabIndex = 15;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(38, 246);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(142, 12);
            this.label3.TabIndex = 14;
            this.label3.Text = "请输入入库商品的单位:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(38, 157);
            this.label2.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(142, 12);
            this.label2.TabIndex = 13;
            this.label2.Text = "请输入入库商品的数量:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(38, 76);
            this.label1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 12);
            this.label1.TabIndex = 12;
            this.label1.Text = "请输入入库商品的名称:";
            // 
            // FrmPurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(556, 444);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtNumble);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FrmPurchaseList";
            this.Text = "FrmPurchaseList";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtNumble;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txtUnit;
    }
}