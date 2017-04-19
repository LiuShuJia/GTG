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
    public partial class FrmSInsert : Form
    {
        public FrmSInsert()
        {
            InitializeComponent();
        }
        
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
            string strSQL = "insert into Supplier(SPName,SPMan,SPPhone) values (@SPName,@SPMan,@SPPhone)";
            int reader = helpler.ExecuteNonQuery(strSQL, CommandType.Text,
                 new SqlParameter("@SPName", txtName.Text),
                 new SqlParameter("@SPMan", txtRname.Text),
                 new SqlParameter("@SPPhone", txtPhone.Text)
                 );
            if (reader > 0)
            {
                MessageBox.Show("增加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("增加失败！");
            }
        }
    }
}
