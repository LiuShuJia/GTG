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
    public partial class FrmUpdateUserInfo : Form
    {
        public FrmUpdateUserInfo()
        {
            InitializeComponent();
        }
        public FrmUpdateUserInfo(string s)
        {
            InitializeComponent();
            this.userName = s;
        }
        private string userName = "";
        private DBHelper helper = new DBHelper();
        private void btnMofidy_Click(object sender, EventArgs e)
        {
            string strSQL = @"update  Admin set Aname=@name,Asex=@sex,ACardID=@cardID,APhone= @phone where Loginid=@Logonid";
            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@Loginid", userName),
                new SqlParameter("@name", this.txtrealname.Text.Trim()),
                new SqlParameter("@sex", this.txtSex.Text.Trim()),
                new SqlParameter("@cardID", this.txtIDcard.Text.Trim()),
                new SqlParameter("@phont", this.txtPhone.Text.Trim()));
            if(row > 0)
            {
                MessageBox.Show("修改成功");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败");
            }
        }
      
        private void FrmUpdateUserInfo_Load(object sender, EventArgs e)
        {
            string strSQL = @"select Aname,Asex,ACardID,APhone from Admin where Loginid=@Logonid";

            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@LoginId", userName)))
            {
                if (reader.Read())
                {
                    this.txtrealname.Text = reader.GetString(reader.GetOrdinal("Aname"));
                    this.txtSex.Text = reader.GetString(reader.GetOrdinal("Asex"));
                    this.txtIDcard.Text = reader.GetString(reader.GetOrdinal("ACardID"));
                    this.txtPhone.Text = reader.GetString(reader.GetOrdinal("APhone"));
                }
            }
        }
    }
}
