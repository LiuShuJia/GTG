using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTG
{
    public partial class FrmMain : Form
    {
        public FrmMain()
        {
            InitializeComponent();
        }
        public FrmMain(FrmLogin f,string username)
        {
            this.userName = username;
            this.frm = f;
            InitializeComponent();
        }
        Form frm;
        string userName;
        private void lblregister_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            frm.Show();
        }

        private void FrmMain_Load(object sender, EventArgs e)
        {
            this.lblUserName.Text = userName;
           
        }

        private void treeView1_Click(object sender, EventArgs e)
        {
            if (treeView1.SelectedNode.Text == "产品信息")
            {
                FrmInfo f = new FrmInfo();

                f.Size = this.pictureBox1.Size;
                f.Location = this.pictureBox1.Location;
                f.MdiParent = this;
                this.pictureBox1.Visible = false;
                f.Show();
            }
        }
    }
}
