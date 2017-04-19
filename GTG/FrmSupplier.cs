using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace GTG
{
    public partial class FrmSupplier : Form
    {
        public FrmSupplier()
        {
            InitializeComponent();
        }
        public FrmSupplier(FrmGoods frm)
        {
            InitializeComponent();
            this.f = frm;
        }
        private FrmGoods f;
        private DBHelper helper = new DBHelper();
        private void btnQue_Click(object sender, EventArgs e)
        {
            string Sname = txtName.Text;
            string SPMan = txtMan.Text;
            this.listView1.Items.Clear();
            string strSQL = "select * from Supplier where (CHARINDEX(@Sname,SPName)>0 or (len(@Sname)=0)) and((CHARINDEX(@SPMan,SPMan)>0) or (len(@SPMan)=0))";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@Sname", Sname),
                new SqlParameter("@SPMan", SPMan)
                );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SPName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPMan")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPPhone")));
                lst.Tag = reader.GetInt32(reader.GetOrdinal("SPID"));
                this.listView1.Items.Add(lst);
            }
            reader.Close();
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {

            this.listView1.Items.Clear();
            string strSQL = "select * from Supplier";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SPName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPMan")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPPhone")));
                lst.Tag = reader.GetInt32(reader.GetOrdinal("SPID"));

                this.listView1.Items.Add(lst);
            }
            reader.Close();
        }

        private void tsmiUp_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选择供应商！");
                return;
            }
            DialogResult result = MessageBox.Show("确认是否修改！", "确认", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }
            string GID = Convert.ToString(this.listView1.SelectedItems[0].Tag);

            FrmDNUpdate f = new FrmDNUpdate(GID);
            f.ShowDialog();
            this.btnQue.PerformClick();
        }

        private void tsmiRemove_Click(object sender, EventArgs e)
        {
            if (this.listView1.SelectedItems.Count < 1)
            {
                MessageBox.Show("请选择供应商！");
                return;
            }
            DialogResult result = MessageBox.Show("确认是否删除！", "确认", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }
            string GID = Convert.ToString(this.listView1.SelectedItems[0].Tag);

            FrmDNRemove f = new FrmDNRemove(GID);
            f.ShowDialog();
            this.btnQue.PerformClick();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {

            FrmSInsert f = new FrmSInsert();
            f.ShowDialog();
            this.btnQue.PerformClick();
        }
    }
}
