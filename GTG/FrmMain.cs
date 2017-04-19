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
        private bool ShowChildrenForm(string childFormName)
        {
            //检测当前窗体的子窗体
            for (int i = 0; i < this.MdiChildren.Length; i++)
            {
                //判断当前子窗体的Name属性值是否与传入的子窗体的Name属性相同
                if (this.MdiChildren[i].Name == childFormName)
                {
                    //如果值相同则表示此子窗体为想要调用的子窗体，激活此子窗体并返回true值
                    this.MdiChildren[i].Activate();
                    return true;
                }
            }
            //如果没有相同的值则表示要调用的子窗体还没有被打开，返回false值
            return false;
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

                if (e.Node.Name == "节点01")
                {
                    if (!ShowChildrenForm("FrmInfo"))
                    {
                        FrmInfo f = new FrmInfo();
                        f.Size = this.pictureBox1.Size;
                        f.Location = this.pictureBox1.Location;
                        f.MdiParent = this;
                        this.pictureBox1.Visible = false;
                        f.Show();
                    }

                }

                else if (e.Node.Name == "节点02")
                {
                    if (!ShowChildrenForm("FrmPurchaseList"))
                    {
                        FrmPurchaseList f = new FrmPurchaseList();
                        f.Size = this.pictureBox1.Size;
                        f.Location = this.pictureBox1.Location;
                        f.MdiParent = this;
                        this.pictureBox1.Visible = false;
                        f.Show();
                    }
                   
                }
                else if (e.Node.Name == "节点03")
                {
                    if (!ShowChildrenForm("FrmPutDetailed"))
                    {
                        FrmPutDetailed f = new FrmPutDetailed();
                        f.Size = this.pictureBox1.Size;
                        f.Location = this.pictureBox1.Location;
                        f.MdiParent = this;
                        this.pictureBox1.Visible = false;
                        f.Show();
                    }

                }
                else if (e.Node.Name == "节点06")
                {
                    if (!ShowChildrenForm("FrmWarehouseList"))
                    {
                        FrmWarehouseList f = new FrmWarehouseList();
                        f.Size = this.pictureBox1.Size;
                        f.Location = this.pictureBox1.Location;
                        f.MdiParent = this;
                        this.pictureBox1.Visible = false;
                        f.Show();
                    }

                }
                else if (e.Node.Name == "节点07")
                {
                    if (!ShowChildrenForm("FrmOutDetailed"))
                    {
                        FrmOutDetailed f = new FrmOutDetailed();
                        f.Size = this.pictureBox1.Size;
                        f.Location = this.pictureBox1.Location;
                        f.MdiParent = this;
                        this.pictureBox1.Visible = false;
                        f.Show();
                    }

                }
                else if (e.Node.Name == "节点08")
                {
                    if (!ShowChildrenForm("FrmSupplier"))
                    {
                        FrmSupplier f = new FrmSupplier();
                        f.Size = this.pictureBox1.Size;
                        f.Location = this.pictureBox1.Location;
                        f.MdiParent = this;
                        this.pictureBox1.Visible = false;
                        f.Show();
                    }

                }
                else if (e.Node.Name == "节点09")
                {
                    if (!ShowChildrenForm("FrmSupplier"))
                    {
                        FrmSupplier f = new FrmSupplier();
                        f.Size = this.pictureBox1.Size;
                        f.Location = this.pictureBox1.Location;
                        f.MdiParent = this;
                        this.pictureBox1.Visible = false;
                        f.Show();
                    }

                }
            }

        }
    }
}
