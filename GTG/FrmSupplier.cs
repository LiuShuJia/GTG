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
        private FrmClientele f;
        private DBHelper helper = new DBHelper();
        private void btnQue_Click(object sender, EventArgs e)
        {
            string Sname = txtName.Text;
            string SPMan = txtPhone.Text;
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
    }
}
