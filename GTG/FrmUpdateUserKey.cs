﻿using System;
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
            this.UserName =s;
        }
        private string UserName = "";
        private DBHelper helper = new DBHelper();
        private void btnModify_Click(object sender, EventArgs e)
        {        
            string oldkey = this.txtoldpassword.Text.Trim();
            string newkey = this.txtnewpassword.Text.Trim();
            string twokey = this.txtsureNewpassword.Text.Trim();
            bool isEqual = Isnullandequal(newkey , twokey);
            if (isEqual == true)
            {
                string strSQL = @"update Admin set LoginPWD=@loginPWD where LoginId=@loginid";

                int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                    new SqlParameter("@loginid", UserName),
                    new SqlParameter("@loginPWD", this.txtnewpassword.Text.Trim()));
                MessageBox.Show(row.ToString());
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
                MessageBox.Show("请核对信息，注意新密码和确认密码要一致");
            }
        }
        public bool Isnullandequal(string s,string s1)
        {
            bool f = false;
            if (s != ""&&s==s1)//不能为空且两个要等
            {
                f = true;
            }
            return f;
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
                if (this.txtoldpassword.Text.Trim()== password)
                {
                    this.txtsureNewpassword.Enabled = true;//如果密码输入正确的话,就设置确认密码可用
            } 
                else
            {
                MessageBox.Show("您输入的密码有误");
                this.txtsureNewpassword.Enabled = false;//如果密码错误，让确认密码不可用
            }          
        }

        private void FrmUpdateUserKey_Load(object sender, EventArgs e)
        {
            this.txtsureNewpassword.Enabled =false;//设置让确认密码不可用，如果密码输入不正确的话
        }
    }
}
