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
    public partial class FrmDeliveryNote : Form
    {
        public FrmDeliveryNote()
        {
            InitializeComponent();
        }
        private FrmClientele f;
        private DBHelper helper = new DBHelper();
        private void btnQue_Click(object sender, EventArgs e)
        {
            string SPName = txtName.Text;
            string Gname = txtGname.Text;

            this.listView1.Items.Clear();
            string strSQL = "select * from DeliveryNote d inner join goods g on g.GID=d.GID inner join Supplier s on s.SPID=d.SPID where (CHARINDEX(@SPName,SPName)>0 or len(@SPName)=0) and(CHARINDEX(@Gname,Gname)>0 or len(@Gname)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@SPName", SPName),
                new SqlParameter("@Gname", Gname)
                );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SPName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("DNum")));
                lst.Tag = reader.GetString(reader.GetOrdinal("DID"));
                this.listView1.Items.Add(lst);
            }
            reader.Close();
        }

        private void FrmDeliveryNote_Load(object sender, EventArgs e)
        {
            this.listView1.Items.Clear();
            string strSQL = "select * from DeliveryNote d inner join goods g on g.GID=d.GID inner join Supplier s on s.SPID=d.SPID";
            IDataReader reader = helper.ExecuteReader(strSQL,CommandType.Text );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SPName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("GName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("DNum")));
                lst.Tag = reader.GetString(reader.GetOrdinal("DID"));
                this.listView1.Items.Add(lst);
            }
            reader.Close();
        }
    }
}
