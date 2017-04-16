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
    public partial class FrmClientele : Form
    {
        public FrmClientele()
        {
            InitializeComponent();
        }
        public FrmClientele(FrmClientele f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmClientele f;
        private DBHelper helper = new DBHelper();
        private void FrmClientele_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Clientele";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string CTName = reader.GetString(reader.GetOrdinal("CTName"));
                this.cmbName.Items.Add(CTName);

                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTPhone")));
                
                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Clientele where (CHARINDEX(@CName,CName)>0 or len(@CName)=0) and(CTAddress=@CTAddress or len(@CTAddress)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@SaleName", this.cmbName.Text.Trim()),
                new SqlParameter("@CTAddress", this.txtAddress.Text.Trim())
                );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTPhone")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }
    }
}
