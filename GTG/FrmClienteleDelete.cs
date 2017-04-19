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
    public partial class FrmClienteleDelete : Form
    {
        public FrmClienteleDelete()
        {
            InitializeComponent();
        }
        public FrmClienteleDelete(string CTID)
        {
            this.CTID = CTID;
            InitializeComponent();
        }
        public FrmClienteleDelete(FrmClienteleDelete f)
        {
            this.f = f;
            InitializeComponent();
        }
        private string CTID;
        private FrmClienteleDelete f;
        private DBHelper helper = new DBHelper();

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string strSQL = "Delete from Client where CTID=@CTID";
            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text, new SqlParameter("@CTID", CTID));
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

        private void FrmClienteleDelete_Load(object sender, EventArgs e)
        {
            string strSQL = "select distinct * from Client where CTID=@CTID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@CTID", CTID));
            while (reader.Read())
            {
                this.Tag= reader.GetInt32(reader.GetOrdinal("CTID"));
                this.lblCTName.Text = reader.GetString(reader.GetOrdinal("CTName"));
                this.lblCTAddress.Text = reader.IsDBNull(reader.GetOrdinal("CTAddress")) ? null : reader.GetString(reader.GetOrdinal("CTAddress"));
                this.lblCTPhone.Text = reader.IsDBNull(reader.GetOrdinal("CTPhone")) ? null : reader.GetString(reader.GetOrdinal("CTPhone"));
            }
            reader.Close();
        }
    }
}
