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
    public partial class FrmDetailed : Form
    {
        public FrmDetailed()
        {
            InitializeComponent();
        }
        public FrmDetailed(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }
        private Form parentForm; 
        private DBHelper helper = new DBHelper();
        private void btnQuery_Click(object sender, EventArgs e)
        {
            string name = this.cboName.Text.Trim();
            DateTime date = this.dtpDateTime.Value;
            if (name == "显示所有")
            {
                name = "";
            }
            DataView dv = ds.Tables["qq"].DefaultView;
            dv.RowFilter = "GName='name'";
            dv.RowFilter = "PInDate='date'";
            this.dvgPurchaseListDetail.DataSource = dv;

            DataView dv1 = ds.Tables["q"].DefaultView;
            dv.RowFilter = "GName='name'";
            dv.RowFilter = "WLDate='date'";
            this.dvgWarehouseListDetail.DataSource = dv1;
        }
       
        SqlDataAdapter adapter = null;
        DataSet ds = new DataSet();
        private void FrmDetailed_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from PurchaseListDetail "+"   " +
                "left join Goods on Goods.[GID]=PurchaseListDetail.[GID]" + "   " +
                "left join PurchaseList on PurchaseList.[PID]=PurchaseListDetail.[PID]";
            adapter = helper.Fill(strSQL, CommandType.Text);
            adapter.Fill(ds, "qq");
            this.dvgPurchaseListDetail.AutoGenerateColumns = false;
            this.dvgPurchaseListDetail.DataSource = ds.Tables["qq"];


            strSQL = "select * from WarehouseListDetail" + "   " +
                "left join Goods on Goods.[GID]=WarehouseListDetail.[GID]" + "   " +
                "left join WarehouseList on WarehouseList.[WLID]=WarehouseListDetail.[WLID]";
            adapter = helper.Fill(strSQL, CommandType.Text);
            adapter.Fill(ds, "q");
            this.dvgWarehouseListDetail.AutoGenerateColumns = false;
            this.dvgWarehouseListDetail.DataSource = ds.Tables["q"];

            strSQL = "select　* from Goods";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                this.cboName.Items.Add(reader.GetString(reader.GetOrdinal("GName")));
            }
            reader.Close();
        }
    }
}
