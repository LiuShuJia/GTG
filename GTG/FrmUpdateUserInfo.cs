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
            if (this.txtrealname.Text.Trim() == "")
            {
                this.errorNotNull.SetError(this.txtrealname, "真实姓名不能为空！");
                return;
            }
            if (this.txtIDcard.Text.Trim() == "")
            {
                this.errorNotNull.SetError(this.txtIDcard, "联系方式不能为空！");
                return;
            }
            if (this.txtIDcard.Text.Trim() == "")
            {
                this.errorNotNull.SetError(this.txtIDcard, "身份证号不能为空！");
                return;
            }

            bool fName = Isnull(this.txtrealname.Text.Trim());
            bool fsex = (this .rdoMan .Checked ==true ||this .rdoFamale .Checked ==true)?(true ):(false);
            bool fIDcard = Isnull(this.txtIDcard.Text.Trim());
            bool fphone =Isnull(this.txtPhone.Text.Trim());

            if (fName &&fsex &&fIDcard &&fphone)
            {
                string strSQL = @"update  Admin set Aname=@name,Asex=@sex,ACardID=@cardID,APhone= @phone where Loginid=@Logonid";
                int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                    new SqlParameter("@Logonid", userName),
                    new SqlParameter("@name", this.txtrealname.Text.Trim()),
                    new SqlParameter("@sex", (this.rdoMan.Checked == true) ? ("男") : ("女")),
                    new SqlParameter("@cardID", this.txtIDcard.Text.Trim()),
                    new SqlParameter("@phone", this.txtPhone.Text.Trim()));
                if (row > 0)
                {
                    MessageBox.Show("修改成功");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("修改失败");
                }
            }
        }
      
        private void FrmUpdateUserInfo_Load(object sender, EventArgs e)
        {
            string strSQL = @"select Aname,Asex,ACardID,APhone from Admin where Loginid=@Logonid";

            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@Logonid", userName)))
            {
                if (reader.Read())
                {
                    this.txtrealname.Text = reader.GetString(reader.GetOrdinal("Aname"));
                    string sex= reader.GetString(reader.GetOrdinal("Asex")).Trim ();
                    if (sex == "男")
                    {
                        this.rdoMan.Checked = true;
                    }
                    else if (sex =="女")
                    {
                        this.rdoFamale.Checked = true;
                    }
                    this.txtIDcard.Text = reader.GetString(reader.GetOrdinal("ACardID"));
                    this.txtPhone.Text = reader.GetString(reader.GetOrdinal("APhone"));
                }
            }
        }
        public bool Isnull(string s)
        {
            bool f = false;
            if (s != "")
            {
                f = true;
            }
            return f;
        }
    }
}
