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
    public partial class FrmClerk : Form
    {
        public FrmClerk()
        {
            InitializeComponent();
        }
        public FrmClerk(FrmClerk f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmClerk f;
        private DBHelper helper = new DBHelper();
        private void FrmClerk_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Clerk inner join SalesStore on Clerk.SID=SalesStore.SID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string SaleName = reader.GetString(reader.GetOrdinal("SaleName"));
                this.cmbSaleName.Items.Add(SaleName);
                string CName = reader.GetString(reader.GetOrdinal("CName"));
                this.cmbSaleName.Items.Add(CName);
                string CSex = reader.GetString(reader.GetOrdinal("CSex"));
                this.cmbSaleName.Items.Add(CSex);

                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CSex")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CCardID")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CPhone")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Clerk inner join SalesStore on Clerk.SID=SalesStore.SID where (SaleName=@SaleName or len(@SaleName)=0)and (CName=@CName or len(@CName)=0)and(CSex=@CSex or len(@CSex)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@SaleName", this.cmbSaleName.Text.Trim()),
                new SqlParameter("@CName", this.cmbCName.Text.Trim()),
                new SqlParameter("@CSex", this.cmbSex.Text.Trim())
                );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CSex")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CCardID")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CPhone")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }
    }
}
