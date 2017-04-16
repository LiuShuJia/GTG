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
        private string strCon = @"server=.\SQL2014;database=GTGDB;uid=sa;password=123;";
        private SqlDataAdapter adapter = null;
        private DataSet ds = new DataSet();
        private void btnQue_Click(object sender, EventArgs e)
        {
            string Sname = txtName.Text;
            string gstyle = txtPhone.Text;

            DataView dv = ds.Tables["qq"].DefaultView;
            dv.RowFilter = $"SPName  like '%{Sname}%' and SPMan  like '%{gstyle}%' ";
            this.dataGridView1.DataSource = dv;
        }

        private void FrmSupplier_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Supplier";
            adapter = new SqlDataAdapter(strSQL, strCon);
            adapter.Fill(ds, "qq");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["qq"];
        }
    }
}
