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
            string strSQL = "select * from SalesTicket inner join SalesStore on SalesTicket.SID=SalesStore.SID join Clientele on Clientele.CTID=Clientele.CTID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("STDate")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from SalesTicket inner join SalesStore on SalesTicket.SID=SalesStore.SID join Clientele on Clientele.CTID=Clientele.CTID where (CHARINDEX(@CName,CName)>0 or len(@CName)=0) and(SaleName=@SaleName or len(@SaleName)=0) and (STDate=@STDate or len(@STDate)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@CName", this.cmbCName.Text.Trim()),
                new SqlParameter("@SaleName", this.cmbSaleName.Text.Trim()),
                new SqlParameter("@STDate", this.dtpTime.Text.Trim()));
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("STDate")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }
    }
}
