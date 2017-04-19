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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        private DBHelper helper = new DBHelper();

        private void Form1_Load(object sender, EventArgs e)
        {
            this.txtUserName.Focus();
        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if (this.txtUserName .Text.Trim() == "")
            {
                this.errorNotNull.SetError(this .txtUserName ,"用户名不能为空！");
                return;
            }
            if (this.txtpassword.Text.Trim() == "")
            {
                this.errorNotNull.SetError(this.txtpassword , "请输入密码！");
                return;
            }
            string userName = this.txtUserName.Text.Trim();
            string key = this.txtpassword.Text.Trim();
            bool fuserName = IsNull(userName);
            bool fkey = IsNull(key);
            int i = 0;//设置i为0
            string password = "";
            string strSQL = @"select LoginPWD from Admin where LoginId=@LoginId";
            if (fuserName && fkey)
            {
                using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@LoginId", userName)))
                {
                    if (reader.Read())
                    {
                        password = reader.GetString(reader.GetOrdinal("LoginPWD")).Trim();//获取该用户名对应的密码
                        i++;//能进入这一步说明存在该用户名
                    }
                }
                if (i == 0)
                {
                    MessageBox.Show("用户名不存在！");
                    this.txtUserName.Clear();
                    this.txtpassword.Clear();
                }
                else
                {
                    if (password == key)
                    {
                        MessageBox.Show("登录成功");
                        FrmMain f = new FrmMain(this, this.txtUserName.Text);
                        //FrmUserManger fum = new FrmUserManger(this .txtUserName .Text .Trim ());    
                        this.Hide();
                        f.Show();
                        //fum.ShowDialog();
                        //this.Show();
                    }
                    else
                    {
                        MessageBox.Show("您的密码不正确！");
                        this.txtpassword.Clear();
                    }
                }
            }
        }
        private bool IsNull(string s)
        {
            bool f = false;
            if (s != "")
            {
                f = true;
            }
            return f;
        }
      
        private void picsee_MouseDown(object sender, MouseEventArgs e)
        {
            this.txtpassword.PasswordChar = (char)0;//鼠标离开变成*
        }
        
        private void piceye_Click(object sender, EventArgs e)
        {
            if (this.txtpassword.PasswordChar == '*')//如果为*，则变成字符串，反之也是
            {
                this.txtpassword.PasswordChar = (char)0;
            }
            else
            {
                this.txtpassword.PasswordChar = '*';
            }
        }

        private void lblAddUser_Click(object sender, EventArgs e)
        {
            FrmAddUser fau = new FrmAddUser();
            fau.ShowDialog();
        }
    }
}
