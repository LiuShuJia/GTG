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
        private string strCon = @"server=.\SQL2014;database=GTGDB;uid=sa;password=123;";
        SqlDataAdapter adapter = null;
        DataSet ds = new DataSet();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string gname = txtName.Text;
            string gstyle = txtStyle.Text;

            DataView dv = ds.Tables["qq"].DefaultView;
            dv.RowFilter = $"GName like '%{gname}%'";
            this.dataGridView1.DataSource = dv;
        }

        private void FrmGoods_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods";
            adapter = new SqlDataAdapter(strSQL, strCon);
            adapter.Fill(ds, "qq");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["qq"];
        }
    }
}
