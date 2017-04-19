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
            this.btnPurchaseList = new System.Windows.Forms.Button();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtNumble = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNuit = new System.Windows.Forms.Label();
            this.lblNumble = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUnit1 = new System.Windows.Forms.Label();
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
            // btnPurchaseList
            // 
            this.btnPurchaseList.ForeColor = System.Drawing.Color.Black;
            this.btnPurchaseList.Location = new System.Drawing.Point(121, 168);
            this.btnPurchaseList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnPurchaseList.Name = "btnPurchaseList";
            this.btnPurchaseList.Size = new System.Drawing.Size(70, 21);
            this.btnPurchaseList.TabIndex = 18;
            this.btnPurchaseList.Text = "入库";
            this.btnPurchaseList.UseVisualStyleBackColor = true;
            this.btnPurchaseList.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtUnit
            // 
            this.txtUnit.Location = new System.Drawing.Point(130, 123);
            this.txtUnit.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(61, 21);
            this.txtUnit.TabIndex = 17;
            this.txtUnit.Enter += new System.EventHandler(this.txtUnit_Enter);
            this.txtUnit.Leave += new System.EventHandler(this.txtUnit_Leave);
            // 
            // txtNumble
            // 
            this.txtNumble.Location = new System.Drawing.Point(130, 68);
            this.txtNumble.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumble.Name = "txtNumble";
            this.txtNumble.Size = new System.Drawing.Size(139, 21);
            this.txtNumble.TabIndex = 16;
            this.txtNumble.Enter += new System.EventHandler(this.txtNumble_Enter);
            this.txtNumble.Leave += new System.EventHandler(this.txtNumble_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 19);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(139, 21);
            this.txtName.TabIndex = 15;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblNuit
            // 
            this.lblNuit.AutoSize = true;
            this.lblNuit.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNuit.ForeColor = System.Drawing.Color.Black;
            this.lblNuit.Location = new System.Drawing.Point(15, 126);
            this.lblNuit.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNuit.Name = "lblNuit";
            this.lblNuit.Size = new System.Drawing.Size(103, 12);
            this.lblNuit.TabIndex = 14;
            this.lblNuit.Text = "入库商品的单位:";
            // 
            // lblNumble
            // 
            this.lblNumble.AutoSize = true;
            this.lblNumble.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNumble.ForeColor = System.Drawing.Color.Black;
            this.lblNumble.Location = new System.Drawing.Point(15, 71);
            this.lblNumble.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumble.Name = "lblNumble";
            this.lblNumble.Size = new System.Drawing.Size(103, 12);
            this.lblNumble.TabIndex = 13;
            this.lblNumble.Text = "入库商品的数量:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(15, 22);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 12);
            this.lblName.TabIndex = 12;
            this.lblName.Text = "入库商品的名称:";
            // 
            // lblUnit1
            // 
            this.lblUnit1.AutoSize = true;
            this.lblUnit1.Location = new System.Drawing.Point(200, 126);
            this.lblUnit1.Name = "lblUnit1";
            this.lblUnit1.Size = new System.Drawing.Size(0, 12);
            this.lblUnit1.TabIndex = 20;
            // 
            // FrmPurchaseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(285, 228);
            this.Controls.Add(this.lblUnit1);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.btnPurchaseList);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtNumble);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNuit);
            this.Controls.Add(this.lblNumble);
            this.Controls.Add(this.lblName);
            this.Name = "FrmPurchaseList";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "入库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Button btnPurchaseList;
        private System.Windows.Forms.TextBox txtNumble;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNuit;
        private System.Windows.Forms.Label lblNumble;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblUnit1;
        private System.Windows.Forms.TextBox txtUnit;
    }
}