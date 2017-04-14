namespace GTG
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.picsee = new System.Windows.Forms.PictureBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtKey = new System.Windows.Forms.TextBox();
            this.txtUserName = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picsee)).BeginInit();
            this.SuspendLayout();
            // 
            // picsee
            // 
            this.picsee.Image = global::GTG.Properties.Resources.eye1;
            this.picsee.Location = new System.Drawing.Point(228, 134);
            this.picsee.Name = "picsee";
            this.picsee.Size = new System.Drawing.Size(27, 21);
            this.picsee.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picsee.TabIndex = 20;
            this.picsee.TabStop = false;
            this.picsee.Click += new System.EventHandler(this.picsee_Click);
            this.picsee.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picsee_MouseDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("宋体", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(93, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 19;
            this.label3.Text = "用户登录";
            // 
            // txtKey
            // 
            this.txtKey.Location = new System.Drawing.Point(113, 134);
            this.txtKey.Name = "txtKey";
            this.txtKey.PasswordChar = '*';
            this.txtKey.Size = new System.Drawing.Size(109, 21);
            this.txtKey.TabIndex = 18;
            this.txtKey.Enter += new System.EventHandler(this.txtKey_Enter);
            this.txtKey.Leave += new System.EventHandler(this.txtKey_Leave);
            // 
            // txtUserName
            // 
            this.txtUserName.Location = new System.Drawing.Point(113, 83);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.Size = new System.Drawing.Size(109, 21);
            this.txtUserName.TabIndex = 17;
            // 
            // btnEnter
            // 
            this.btnEnter.Location = new System.Drawing.Point(86, 207);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(75, 23);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.Text = "登录";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(30, 137);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 12);
            this.label2.TabIndex = 15;
            this.label2.Text = "请输入密码：";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(30, 86);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 12);
            this.label1.TabIndex = 14;
            this.label1.Text = "请输入用户名：";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.picsee);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtKey);
            this.Controls.Add(this.txtUserName);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "登录界面";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picsee)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox picsee;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtKey;
        private System.Windows.Forms.TextBox txtUserName;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}

