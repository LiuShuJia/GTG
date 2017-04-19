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
    public partial class FrmDNUpdate : Form
    {
        public FrmDNUpdate()
        {
            InitializeComponent();
        }
        public FrmDNUpdate(string Tag)
        {
            this.f = Tag;
            InitializeComponent();
        }
        private string f;
        DBHelper helpler = new DBHelper();
        private void btnYes_Click(object sender, EventArgs e)
        {
            int a;
            if (txtName.Text == "")
            {
                MessageBox.Show("供应商名称不能为空！");
                return;
            }
            if (txtRname.Text == "")
            {
                MessageBox.Show("联系人不能为空！");
                return;
            }
            
            if (!int.TryParse(txtPhone.Text, out a) || txtPhone.Text == "")
            {
                MessageBox.Show("号码格式不正确！");
                return;
            }
            string strSQL = "update Supplier set SPName=@SPName,SPMan=@SPMan,SPPhone=@SPPhone  where SPID=@SPID";
            int reader = helpler.ExecuteNonQuery(strSQL, CommandType.Text,
                 new SqlParameter("@SPName", txtName.Text),
                 new SqlParameter("@SPMan", txtRname.Text),
                 new SqlParameter("@SPPhone", txtPhone.Text),
                 new SqlParameter("@SPID", Convert.ToInt32(f))
                 );
            if (reader > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void FrmDNUpdate_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Supplier where SPID=@SPID";
            using (IDataReader reader = helpler.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@SPID", Convert.ToInt32(f))))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(reader.GetOrdinal("SPName"));
                    txtRname.Text = reader.GetString(reader.GetOrdinal("SPMan"));
                    txtPhone.Text = reader.GetString(reader.GetOrdinal("SPPhone"));

                }
                reader.Close();
            }
        }
    }
}
