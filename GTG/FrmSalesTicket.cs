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
    public partial class FrmSalesTicket : Form
    {
        public FrmSalesTicket()
        {
            InitializeComponent();
        }
        public FrmSalesTicket(FrmSalesTicket f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmSalesTicket f;
        private DBHelper helper = new DBHelper();

        private void FrmSalesTicket_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from SalesTicket inner join SalesStore on SalesTicket.SID=SalesStore.SID join Client on SalesTicket.CTID=Client.CTID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string SName = reader.GetString(reader.GetOrdinal("SName"));
                this.cmbSName.Items.Add(SName);
                string CTName = reader.GetString(reader.GetOrdinal("CTName"));
                this.cmbCTName.Items.Add(CTName);
                
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetDateTime(reader.GetOrdinal("STDate")).ToString());

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {

            this.lstTable.Items.Clear();
            string strSQL = "select * from SalesTicket inner join SalesStore on SalesTicket.SID=SalesStore.SID join Client on SalesTicket.CTID=Client.CTID where (CHARINDEX(@CTName,CTName)>0 or len(@CTName)=0) and(CHARINDEX(@SName,SName)>0 or len(@SName)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@CTName", this.cmbCTName.Text.Trim()),
                new SqlParameter("@SName", this.cmbSName.Text.Trim()));
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetDateTime(reader.GetOrdinal("STDate")).ToString());
                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void cmbSName_Leave(object sender, EventArgs e)
        {
            if (this.cmbSName.Text.Trim() != "" && !Regex.IsMatch(this.cmbSName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbSName.Text.Trim() == "查询全部" || this.cmbSName.Text.Trim() == "")
            {
                this.cmbSName.Text = "";
            }
        }

        private void cmbCTName_Leave(object sender, EventArgs e)
        {
            if (this.cmbCTName.Text.Trim() != "" && !Regex.IsMatch(this.cmbCTName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbCTName.Text.Trim() == "查询全部" || this.cmbCTName.Text.Trim() == "")
            {
                this.cmbCTName.Text = "";
            }
        }
    }
}
