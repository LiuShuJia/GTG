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
    public partial class FrmPutDetailed : Form
    {
        public FrmPutDetailed()
        {
            InitializeComponent();
        }
        public FrmPutDetailed(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }
        private Form parentForm; 
        private DBHelper helper = new DBHelper();
        private void btnQuery_Click(object sender, EventArgs e)
        {
           
        }
       
        private void FrmDetailed_Load(object sender, EventArgs e)
        {
            string name = "";
            string id = "";
            string num = "";
            string date = "";
            string strSQL = "select * from PurchaseListDetail " + "   " +
                "left join Goods on Goods.[GID]=PurchaseListDetail.[GID]" + "   " +
                "left join PurchaseList on PurchaseList.[PID]=PurchaseListDetail.[PID]";

            IDataReader reader = helper.ExecuteReader(strSQL);
            while (reader.Read())
            {
                name = reader.GetString(reader.GetOrdinal("GName"));
                id = reader.GetInt32(reader.GetOrdinal("PID")).ToString();
                num = reader.GetInt32(reader.GetOrdinal("PLDNum")).ToString();
                date = reader.GetDateTime(reader.GetOrdinal("PInDate")).ToString();
                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(name);
                item.SubItems.Add(num);
                item.SubItems.Add(date);

                lstPurchaseList.Items.Add(item);
            }
            reader.Close();
            
            strSQL = "select　* from Goods";
             reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                this.cboName.Items.Add(reader.GetString(reader.GetOrdinal("GName")));
            }
            reader.Close();
        }

        private void btnQuery_Click_1(object sender, EventArgs e)
        {
            string name = this.cboName.Text.Trim();
            if (name == "显示所有")
            {
                name = "";
            }
            string gname = "";
            string id = "";
            string num = "";
            string date = "";
            string strSQL = "select * from PurchaseListDetail " + "   " +
               "left join Goods on Goods.[GID]=PurchaseListDetail.[GID]" + "   " +
               "left join PurchaseList on PurchaseList.[PID]=PurchaseListDetail.[PID]" +
               "where(charindex(@Gname,Gname)>0 or len(@Gname)=0)";
            lstPurchaseList.Items.Clear();
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@Gname", name));
            while (reader.Read())
            {
                gname = reader.GetString(reader.GetOrdinal("GName"));
                id = reader.GetInt32(reader.GetOrdinal("PID")).ToString();
                num = reader.GetInt32(reader.GetOrdinal("PLDNum")).ToString();
                date = reader.GetDateTime(reader.GetOrdinal("PInDate")).ToString();
                ListViewItem item = new ListViewItem(id);
                item.SubItems.Add(gname);
                item.SubItems.Add(num);
                item.SubItems.Add(date);

                lstPurchaseList.Items.Add(item);
            }
            reader.Close();
            //strSQL = "select * from WarehouseListDetail" + "   " +
            //    "left join Goods on Goods.[GID]=WarehouseListDetail.[GID]" + "   " +
            //    "left join WarehouseList on WarehouseList.[WLID]=WarehouseListDetail.[WLID]" +
            //   "where (charindex(@Gname,Gname)>0 or len(@Gname)=0)";
            //lstWarehouseList.Items.Clear();
            //reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@Gname", name));
            //while (reader.Read())
            //{
            //    gname = reader.GetString(reader.GetOrdinal("GName"));
            //    id = reader.GetInt32(reader.GetOrdinal("WLID")).ToString();
            //    num = reader.GetInt32(reader.GetOrdinal("WLDNum")).ToString();
            //    date = reader.GetDateTime(reader.GetOrdinal("WLDate")).ToString();
            //    ListViewItem item = new ListViewItem(id);
            //    item.SubItems.Add(gname);
            //    item.SubItems.Add(num);
            //    item.SubItems.Add(date);

            //    lstWarehouseList.Items.Add(item);
            //}
            //reader.Close();

            this.cboName.Text = "显示所有";
        }
    }
}
