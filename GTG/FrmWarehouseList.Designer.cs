namespace GTG
{
    partial class FrmWarehouseList
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
            this.label3 = new System.Windows.Forms.Label();
            this.btnWarehouseList = new System.Windows.Forms.Button();
            this.txtNumble = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblNumble = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbText
            // 
            this.lbText.AutoSize = true;
            this.lbText.Location = new System.Drawing.Point(475, 217);
            this.lbText.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lbText.Name = "lbText";
            this.lbText.Size = new System.Drawing.Size(0, 12);
            this.lbText.TabIndex = 15;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(469, 119);
            this.label3.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 12);
            this.label3.TabIndex = 14;
            // 
            // btnWarehouseList
            // 
            this.btnWarehouseList.Location = new System.Drawing.Point(130, 146);
            this.btnWarehouseList.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.btnWarehouseList.Name = "btnWarehouseList";
            this.btnWarehouseList.Size = new System.Drawing.Size(114, 26);
            this.btnWarehouseList.TabIndex = 13;
            this.btnWarehouseList.Text = "出库";
            this.btnWarehouseList.UseVisualStyleBackColor = true;
            this.btnWarehouseList.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtNumble
            // 
            this.txtNumble.Location = new System.Drawing.Point(130, 87);
            this.txtNumble.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtNumble.Name = "txtNumble";
            this.txtNumble.Size = new System.Drawing.Size(137, 21);
            this.txtNumble.TabIndex = 12;
            this.txtNumble.Enter += new System.EventHandler(this.txtNumble_Enter);
            this.txtNumble.Leave += new System.EventHandler(this.txtNumble_Leave);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(130, 38);
            this.txtName.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(137, 21);
            this.txtName.TabIndex = 11;
            this.txtName.Leave += new System.EventHandler(this.txtName_Leave);
            // 
            // lblNumble
            // 
            this.lblNumble.AutoSize = true;
            this.lblNumble.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblNumble.Location = new System.Drawing.Point(15, 90);
            this.lblNumble.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblNumble.Name = "lblNumble";
            this.lblNumble.Size = new System.Drawing.Size(103, 12);
            this.lblNumble.TabIndex = 10;
            this.lblNumble.Text = "出库商品的数量:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.lblName.Location = new System.Drawing.Point(15, 41);
            this.lblName.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(103, 12);
            this.lblName.TabIndex = 9;
            this.lblName.Text = "出库商品的名称:";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(128, 129);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(0, 12);
            this.lblStock.TabIndex = 16;
            // 
            // FrmWarehouseList
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(297, 242);
            this.Controls.Add(this.lblStock);
            this.Controls.Add(this.lbText);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnWarehouseList);
            this.Controls.Add(this.txtNumble);
            this.Controls.Add(this.txtName);
            this.Controls.Add(this.lblNumble);
            this.Controls.Add(this.lblName);
            this.Name = "FrmWarehouseList";
            this.Text = "出库";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbText;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnWarehouseList;
        private System.Windows.Forms.TextBox txtNumble;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblNumble;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblStock;
    }
}