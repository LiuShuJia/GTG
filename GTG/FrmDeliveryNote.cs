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
            string name = txtName.Text;
            string GName = txtGName.Text;

            this.listView1.Items.Clear();
            string strSQL = "select * from DeliveryNote innor join Supplier on SPID=DSPID innor join Goods on GID=DGID where (CHARINDEX(@name,SPName)>0 or len(@name)=0) and(CHARINDEX(@GName,GName)>0 or len(@GName)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@name", name),
                new SqlParameter("@GName", GName)
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
            string strSQL = "select * from DeliveryNote innor join Supplier on SPID=DSPID innor join Goods on GID=DGID ";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
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

        private void label1_Click(object sender, EventArgs e)
        {
            this.label1.Text = "供应商：";
        }
    }
}
