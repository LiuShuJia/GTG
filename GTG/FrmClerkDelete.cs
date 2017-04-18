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
    public partial class FrmClerkDelete : Form
    {
        public FrmClerkDelete()
        {
            InitializeComponent();
        }
        public FrmClerkDelete(FrmClerkDelete f)
        {
            this.f = f;
            InitializeComponent();
        }
        public FrmClerkDelete(string CCardID)
        {
            this.CCardID = CCardID;
            InitializeComponent();
        }
        private FrmClerkDelete f;
        private string CCardID;
        private DBHelper helper = new DBHelper();

        private void FrmClerkDelete_Load(object sender, EventArgs e)
        {
            this.lblCCardID.Text=CCardID;
            string strSQL = "select * from Clerk where CCardID=@CCardID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@CCardID", this.lblCCardID.Text));
            while (reader.Read())
            {
                this.lblCName.Text = reader.GetString(reader.GetOrdinal("CName"));
                this.lblCSex.Text = reader.IsDBNull(reader.GetOrdinal("CSex")) ? null : reader.GetString(reader.GetOrdinal("CSex"));
                this.lblCCardID.Text = reader.IsDBNull(reader.GetOrdinal("CCardID")) ? null : reader.GetString(reader.GetOrdinal("CCardID"));
                this.lblCPhone.Text = reader.IsDBNull(reader.GetOrdinal("CPhone")) ? null : reader.GetString(reader.GetOrdinal("CPhone"));
            }
            reader.Close();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            this.lblCCardID.Text =CCardID;
            string strSQL = "Delete from Clerk where CCardID=@CCardID";
            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                  new SqlParameter("@CCardID", CCardID));
            if (row > 0)
            {
                MessageBox.Show("添加成功");
                this.Close();//成功即关闭该窗体
            }
            else
            {
                MessageBox.Show("添加失败");
            }
        }
    }
}
