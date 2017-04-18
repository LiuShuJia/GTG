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
    public partial class FrmGoods : Form
    {
        public FrmGoods()
        {
            InitializeComponent();
        }
        DBHelper hepler = new DBHelper();
        private FrmClientele f;
        private DBHelper helper = new DBHelper();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            if (txtName.Text==null)
            {
                txtName.Text = "";
            }
            if (txtStyle.Text == null)
            {
                txtStyle.Text = "";
            }
            string gname = txtName.Text;
            string gstyle = txtStyle.Text;
            this.listView1.Items.Clear();
            string strSQL = "select * from Goods where (CHARINDEX(@gname,gname)>0 or len(@gname)=0) and(CHARINDEX(@gstyle,gstyle)>0 or len(@gstyle)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@gname", gname),
                new SqlParameter("@gstyle", gstyle));

            while (reader.Read())
            {

                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("GName")));
                lst.SubItems.Add(reader.GetInt32(reader.GetOrdinal("GNum")).ToString ());
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GStyle")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GStandard")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GUnit")));
                lst.Tag = reader.GetString(reader.GetOrdinal("GID"));
                this.listView1.Items.Add(lst);
            }
            reader.Close();

        }

        private void FrmGoods_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            string strSQL = "select * from Goods";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {

                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("GName")));
                lst.SubItems.Add(reader.GetInt32(reader.GetOrdinal("GNum")).ToString());
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GStyle")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GStandard")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GUnit")));
                lst.Tag = reader.GetString(reader.GetOrdinal("GID"));
                this.listView1.Items.Add(lst);
            }
            reader.Close();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            //if (this.listView1.SelectedItems.Count < 1)
            //{
            //    MessageBox.Show("请选择商品！");
            //    return;
            //}
            //DialogResult result = MessageBox.Show("确认是否修改！", "确认", MessageBoxButtons.OKCancel);
            //if (result != DialogResult.OK)
            //{
            //    return;
            //}
            //string GID = Convert.ToString(this.listView1.SelectedItems[0].Tag);
            
            //FrmUp f = new FrmUp();
            //f.ShowDialog();
            //this.btnSelect.PerformClick();
        }
    }
}
