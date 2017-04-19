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
            //if (treeView1.SelectedNode.Name == "节点3")
            //{
            //    FrmInfo f = new FrmInfo();
            //    f.Size = this.pictureBox1.Size;
            //    f.Location = this.pictureBox1.Location;
            //    f.MdiParent = this;
            //    this.pictureBox1.Visible = false;
            //    f.Show();
            //}
            
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Action == TreeViewAction.ByMouse)
            {

                if (e.Node.Name == "节点3")
                {
                    FrmInfo f = new FrmInfo();
                    f.Size = this.pictureBox1.Size;
                    f.Location = this.pictureBox1.Location;
                    f.MdiParent = this;
                    this.pictureBox1.Visible = false;
                    f.Show();
                }

                else if (e.Node.Name == "节点8")
                {
                    FrmClerkAdd f = new FrmClerkAdd();
                    //f.Size = this.pictureBox1.Size;
                    //f.Location = this.pictureBox1.Location;
                    f.MdiParent = this;
                    this.pictureBox1.Visible = false;
                    f.Show();
                }

            }

        }
    }
}
