namespace GTG
{
    partial class FrmHelper
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFolder = new System.Windows.Forms.TextBox();
            this.btnBrower = new System.Windows.Forms.Button();
            this.btnReduce = new System.Windows.Forms.Button();
            this.txtReduce = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnBackup = new System.Windows.Forms.Button();
            this.btnRecever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 12);
            this.label1.TabIndex = 1;
            this.label1.Text = "备份路径：";
            // 
            // txtFolder
            // 
            this.txtFolder.Location = new System.Drawing.Point(93, 41);
            this.txtFolder.Name = "txtFolder";
            this.txtFolder.Size = new System.Drawing.Size(175, 21);
            this.txtFolder.TabIndex = 2;
            // 
            // btnBrower
            // 
            this.btnBrower.Location = new System.Drawing.Point(285, 39);
            this.btnBrower.Name = "btnBrower";
            this.btnBrower.Size = new System.Drawing.Size(75, 23);
            this.btnBrower.TabIndex = 3;
            this.btnBrower.Text = "浏览";
            this.btnBrower.UseVisualStyleBackColor = true;
            this.btnBrower.Click += new System.EventHandler(this.btnBrower_Click);
            // 
            // btnReduce
            // 
            this.btnReduce.Location = new System.Drawing.Point(285, 146);
            this.btnReduce.Name = "btnReduce";
            this.btnReduce.Size = new System.Drawing.Size(75, 23);
            this.btnReduce.TabIndex = 6;
            this.btnReduce.Text = "浏览";
            this.btnReduce.UseVisualStyleBackColor = true;
            this.btnReduce.Click += new System.EventHandler(this.btnReduce_Click);
            // 
            // txtReduce
            // 
            this.txtReduce.Location = new System.Drawing.Point(93, 148);
            this.txtReduce.Name = "txtReduce";
            this.txtReduce.Size = new System.Drawing.Size(175, 21);
            this.txtReduce.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 151);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "恢复文件路径：";
            // 
            // btnBackup
            // 
            this.btnBackup.Location = new System.Drawing.Point(93, 79);
            this.btnBackup.Name = "btnBackup";
            this.btnBackup.Size = new System.Drawing.Size(75, 23);
            this.btnBackup.TabIndex = 7;
            this.btnBackup.Text = "备份";
            this.btnBackup.UseVisualStyleBackColor = true;
            this.btnBackup.Click += new System.EventHandler(this.btnBackup_Click);
            // 
            // btnRecever
            // 
            this.btnRecever.Location = new System.Drawing.Point(93, 199);
            this.btnRecever.Name = "btnRecever";
            this.btnRecever.Size = new System.Drawing.Size(75, 23);
            this.btnRecever.TabIndex = 8;
            this.btnRecever.Text = "恢复";
            this.btnRecever.UseVisualStyleBackColor = true;
            this.btnRecever.Click += new System.EventHandler(this.btnRecever_Click);
            // 
            // FrmHelper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 261);
            this.Controls.Add(this.btnRecever);
            this.Controls.Add(this.btnBackup);
            this.Controls.Add(this.btnReduce);
            this.Controls.Add(this.txtReduce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btnBrower);
            this.Controls.Add(this.txtFolder);
            this.Controls.Add(this.label1);
            this.Name = "FrmHelper";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "备份恢复";
            this.Load += new System.EventHandler(this.FrmHelper_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFolder;
        private System.Windows.Forms.Button btnBrower;
        private System.Windows.Forms.Button btnReduce;
        private System.Windows.Forms.TextBox txtReduce;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBackup;
        private System.Windows.Forms.Button btnRecever;
    }
}