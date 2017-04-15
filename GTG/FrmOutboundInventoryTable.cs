using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTG
{
    public partial class FrmOutboundInventoryTable : Form
    {
        public FrmOutboundInventoryTable()
        {
            InitializeComponent();
        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private string strCon = @"server=DEEP-20161031WY;database=GTGDB;uid=sa;password=123;";
        SqlDataAdapter adapter = null;
        DataSet ds = new DataSet();
        private void FrmOutboundInventoryTable_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from PurchaseList ";
            adapter = new SqlDataAdapter(strSQL, strCon);
            adapter.Fill(ds, "qq");
            this.dvgPurchaseList.AutoGenerateColumns = false;
            this.dvgPurchaseList.DataSource = ds.Tables["qq"];


            strSQL = "select * from WarehouseList";
            adapter = new SqlDataAdapter(strSQL, strCon);
            adapter.Fill(ds, "q");
            this.dvgWarehouseList.AutoGenerateColumns = false;
            this.dvgWarehouseList.DataSource = ds.Tables["q"];
        }
    }
}
