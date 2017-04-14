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
    public partial class FrmUpdateUserKey : Form
    {
        public FrmUpdateUserKey()
        {
            InitializeComponent();
        }
        public FrmUpdateUserKey(string s)
        {
            InitializeComponent();
            this.UserName = s;
            oldkey = this.txtoldpassword.Text.Trim();
            newkey = this.txtnewpassword.Text.Trim();
            twokey = this.txttwopassword.Text.Trim();
        }
        private string UserName = "";
        private string oldkey = "";
        private string newkey = "";
        private string twokey = "";
        private DBHelper helper = new DBHelper();
        private void btnModify_Click(object sender, EventArgs e)
        { 
            bool isEqual = Isnullandequal(oldkey, twokey);
            if (isEqual == true)
            {
                string strSQl = @"update admin set loginPWD='@loginPWD'where Loginid='@loginid'";
                int row = helper.ExecuteNonQuery(strSQl, CommandType.Text,
                    new SqlParameter("@loginid", UserName),
                    new SqlParameter("@loginPWD", oldkey));
                if (row > 0)
                {
                    MessageBox.Show("密码修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("密码修改失败");
                }
            }
            else
            {
                MessageBox.Show("请核对信息，输入错误");
            }

        }
        public bool Isnullandequal(string s,string s1)
        {
            bool f = false;
            if (s != ""&&s==s1)
            {
                f = true;
            }
            return f;
        }

        private void FrmUpdateUserKey_Load(object sender, EventArgs e)
        {
            this.txtoldpassword.Focus();
            this.txtnewpassword.Enabled = false;
            this.txttwopassword.Enabled = false;            
        }

        private void txtoldpassword_Leave(object sender, EventArgs e)
        {
            string strSQL = @"select LoginPWD from Admin where LoginId=@LoginId";
            string password = "";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@LoginId", UserName)))
            {
                if (reader.Read())
                {
                    password = reader.GetString(reader.GetOrdinal("LoginPWD")).Trim();//获取该用户名对应的密码                  
                }
            }
            if (oldkey== password)
            {
                this.txtnewpassword.Enabled = true;
                this.txttwopassword.Enabled = true;
            }
        }
    }
}
