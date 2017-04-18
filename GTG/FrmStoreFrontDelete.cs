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
    public partial class FrmStoreFrontDelete : Form
    {
        public FrmStoreFrontDelete()
        {
            InitializeComponent();
        }
        public FrmStoreFrontDelete(FrmStoreFrontDelete f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmStoreFrontDelete f;
        private DBHelper helper = new DBHelper();
        private string SID;
        public FrmStoreFrontDelete(string SID)
        {
            this.SID = SID;
            InitializeComponent();
        }
        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string strSQL = "Delete from SalesStore where SID=@SID";
            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text, new SqlParameter("SID", SID));
            if (row > 0)
            {
                MessageBox.Show("删除成功!");
                Close();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void FrmStoreFrontDelete_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from SalesStore where SID=@SID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@SID", SID));
            while (reader.Read())
            {
                this.lblSName.Text = reader.GetString(reader.GetOrdinal("SName"));
                this.lblSAddress.Text = reader.GetString(reader.GetOrdinal("SAddress"));
                this.lblSmanagerName.Text = reader.GetString(reader.GetOrdinal("SManagerName"));
                this.lblSPhone.Text = reader.GetString(reader.GetOrdinal("SPhone"));
            }
            reader.Close();
        }
    }
}
