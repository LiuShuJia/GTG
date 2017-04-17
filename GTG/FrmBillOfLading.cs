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
using System.Text.RegularExpressions;

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
            string strSQL = "select * from BillOfLading inner join SalesStore on BillOfLading.SID=SalesStore.SID join Warehouse on BillOfLading.WID=Warehouse.WID where (CHARINDEX(@WName,WName)>0 or len(@WName)=0) and(CHARINDEX(@SName,SName)>0 or len(@SName)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@WName", this.cmbWName.Text.Trim()),
                new SqlParameter("@SName", this.cmbSaleName.Text.Trim())
                );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("WName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SName")));
                lst.SubItems.Add(reader.GetDateTime(reader.GetOrdinal("BDate")).ToString());

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
                string SName = reader.GetString(reader.GetOrdinal("SName"));
                this.cmbSaleName.Items.Add(SName);
                string WName = reader.GetString(reader.GetOrdinal("WName"));
                this.cmbWName.Items.Add(WName);
                

                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("WName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SName")));
                lst.SubItems.Add(reader.GetDateTime(reader.GetOrdinal("BDate")).ToString());

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void cmbWName_Leave(object sender, EventArgs e)
        {
            if (this.cmbWName.Text != "" && !Regex.IsMatch(this.cmbWName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbWName.Text == "查询全部" || this.cmbWName.Text == "")
            {
                this.cmbWName.Text = "";
            }
        }

        private void cmbSaleName_Leave(object sender, EventArgs e)
        {
            if (this.cmbSaleName.Text != ""&& !Regex.IsMatch(this.cmbSaleName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbSaleName.Text == "查询全部" || this.cmbSaleName.Text == "")
            {
                this.cmbSaleName.Text = "";
            }
        }
    }
}
