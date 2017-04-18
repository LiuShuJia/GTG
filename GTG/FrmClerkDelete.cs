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
        public FrmClerkDelete(string CID)
        {
            this.CID = CID;
            InitializeComponent();
        }
        private string CID;
        private FrmClerkDelete f;
        private DBHelper helper = new DBHelper();

        private void FrmClerkDelete_Load(object sender, EventArgs e)
        {
            string strSQL = "select distinct CName,SName,CSex,CCardID,CPhone from Clerk inner join SalesStore on SalesStore.SID=Clerk.SID where CID=@CID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@CID", CID));
            while (reader.Read())
            {
                this.lblCName.Text = reader.GetString(reader.GetOrdinal("CName"));
                this.lblSName.Text= reader.GetString(reader.GetOrdinal("SName"));
                this.lblCSex.Text = reader.IsDBNull(reader.GetOrdinal("CSex")) ? null : reader.GetString(reader.GetOrdinal("CSex"));
                this.lblCCardID.Text = reader.IsDBNull(reader.GetOrdinal("CCardID")) ? null : reader.GetString(reader.GetOrdinal("CCardID"));
                this.lblCPhone.Text = reader.IsDBNull(reader.GetOrdinal("CPhone")) ? null : reader.GetString(reader.GetOrdinal("CPhone"));
            }
            reader.Close();
        }

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string strSQL = "Delete from Clerk where CID=@CID";
            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                  new SqlParameter("@CID", CID));
            if (row > 0)
            {
                MessageBox.Show("删除成功");
                this.Close();//成功即关闭该窗体
            }
            else
            {
                MessageBox.Show("删除失败");
            }
        }
    }
}
