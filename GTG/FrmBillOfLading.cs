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
    public partial class FrmBillOfLading : Form
    {
        public FrmBillOfLading()
        {
            InitializeComponent();
        }
        public FrmBillOfLading(FrmBillOfLading f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmBillOfLading f;
        private DBHelper helper = new DBHelper();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from BillOfLading inner join SalesStore on BillOfLading.SID=SalesStore.SID join Warehouse on BillOfLading.WID=Warehouse.WID where (SaleName=@SaleName or len(@SaleName)=0)and (WName=@WName or len(@WName)=0)and(BSubDate=@BSubDate or len(@BSubDate)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@WName", this.cmbWName.Text.Trim()),
                new SqlParameter("@SaleName", this.cmbSaleName.Text.Trim()),
                new SqlParameter("@BSubDate", this.dtpTime.Text.Trim())
                );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("WName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("BSubDate")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void FrmBillOfLading_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from BillOfLading inner join SalesStore on BillOfLading.SID=SalesStore.SID join Warehouse on BillOfLading.WID=Warehouse.WID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string SaleName = reader.GetString(reader.GetOrdinal("SaleName"));
                this.cmbSaleName.Items.Add(SaleName);
                string WName = reader.GetString(reader.GetOrdinal("WName"));
                this.cmbSaleName.Items.Add(WName);
                string BSubDate = reader.GetString(reader.GetOrdinal("BSubDate"));
                this.cmbSaleName.Items.Add(BSubDate);

                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("WName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("BSubDate")));
               
                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }
    }
}
