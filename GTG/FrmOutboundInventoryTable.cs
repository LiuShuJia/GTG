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
        public FrmOutboundInventoryTable(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }
        private Form parentForm;
        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private DBHelper helper = new DBHelper();
       
        SqlDataAdapter adapter = null;
        DataSet ds = new DataSet();
        private void FrmOutboundInventoryTable_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from PurchaseList " +
                "left join Warehouse on Warehouse.[WID]=PurchaseList.[WID]";
            adapter =helper.Fill(strSQL,CommandType.Text);
            adapter.Fill(ds, "qq");
            this.dvgPurchaseList.AutoGenerateColumns = false;
            this.dvgPurchaseList.DataSource = ds.Tables["qq"];


            strSQL = "select * from WarehouseList"+
                "left join Warehouse on Warehouse.[WID]=WarehouseList.[WID]";
            adapter = helper.Fill(strSQL, CommandType.Text); 
            adapter.Fill(ds, "q");
            this.dvgWarehouseList.AutoGenerateColumns = false;
            this.dvgWarehouseList.DataSource = ds.Tables["q"];

            strSQL = "select　* from Warehouse";
            IDataReader reader = helper.ExecuteReader(strSQL,CommandType.Text);
            while (reader.Read())
            {
                this.cboName.Items.Add(reader.GetString(reader.GetOrdinal("WName")));
            }
            reader.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string name = this.cboName.Text.Trim();
            DateTime date = this.dtpDateTime.Value;
            if (name == "显示所有")
            {
                name = "";
            }
            DataView dv = ds.Tables["qq"].DefaultView;
            dv.RowFilter = "WName='name'";
            dv.RowFilter = "PInDate='date'";
            this.dvgPurchaseList.DataSource= dv;

            DataView dv1 = ds.Tables["q"].DefaultView;
            dv.RowFilter = "WName='name'";
            dv.RowFilter = "WLDate='date'";
            this.dvgWarehouseList.DataSource = dv1;
        }
    }
}
