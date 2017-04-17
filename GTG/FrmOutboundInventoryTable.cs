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
       
       
        private void FrmOutboundInventoryTable_Load(object sender, EventArgs e)
        {
            string name = "";
            string id = "";
            string date = "";
            string strSQL = "select * from PurchaseList " + "       " +
                "left join Warehouse on Warehouse.[WID]=PurchaseList.[WID]";

            IDataReader reader = helper.ExecuteReader(strSQL);
            while (reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("WName"));
                id = reader.GetInt32(reader.GetOrdinal("PID")).ToString();
                date = reader.GetDateTime(reader.GetOrdinal("PInDate")).ToString();
                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(date);

                lstPurchaseList.Items.Add(item);
            }
            reader.Close();
            strSQL = "select * from WarehouseList" + "       " +
                "left join Warehouse on Warehouse.[WID]=WarehouseList.[WID]";
            reader = helper.ExecuteReader(strSQL);
            while (reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("WName"));
                id = reader.GetInt32(reader.GetOrdinal("WID")).ToString();
                date = reader.GetDateTime(reader.GetOrdinal("WLDate")).ToString();
                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(date);

                lstWarehouseList.Items.Add(item);
            }
            reader.Close();

            strSQL = "select　* from Warehouse";
             reader = helper.ExecuteReader(strSQL,CommandType.Text);
            while (reader.Read())
            {
                this.cboName.Items.Add(reader.GetString(reader.GetOrdinal("WName")));
            }
            reader.Close();
        }

        private void btnQuery_Click(object sender, EventArgs e)
        {
            string Gname = this.cboName.Text.Trim();
            if (Gname == "显示所有")
            {
                Gname = "";
            }
            string name = "";
            string id = "";
            string date = "";
            string strSQL = "select * from PurchaseList " + "       " +
                "left join Warehouse on Warehouse.[WID]=PurchaseList.[WID]" +
               "where (charindex(@Gname,WName)>0 or len(@Gname)=0)";

            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@Gname", Gname));
            while (reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("WName"));
                id = reader.GetInt32(reader.GetOrdinal("PID")).ToString();
                date = reader.GetDateTime(reader.GetOrdinal("PInDate")).ToString();
                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(date);

                lstPurchaseList.Items.Add(item);
            }
            reader.Close();
            strSQL = "select * from WarehouseList" + "       " +
                "left join Warehouse on Warehouse.[WID]=WarehouseList.[WID]" +
               "where (charindex(@Gname,WName)>0 or len(@Gname)=0)";
            reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@Gname", Gname));
            while (reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("WName"));
                id = reader.GetInt32(reader.GetOrdinal("WID")).ToString();
                date = reader.GetDateTime(reader.GetOrdinal("WLDate")).ToString();
                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(date);

                lstWarehouseList.Items.Add(item);
            }
            reader.Close();

            this.cboName.Text = "";
        }
    }
}
