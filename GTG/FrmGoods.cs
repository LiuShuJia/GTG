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
              
                this.listView1.Items.Add(lst);
            }
            reader.Close();
        }
    }
}
