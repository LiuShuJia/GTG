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
    public partial class FrmStoreFrontAdd : Form
    {
        public FrmStoreFrontAdd()
        {
            InitializeComponent();
        }
        public FrmStoreFrontAdd(FrmStoreFrontAdd f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmStoreFrontAdd f;
        private DBHelper helper = new DBHelper();
        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string SID = Guid.NewGuid().ToString();
            string SName = this.txtSName.Text.Trim();
            string SAddress = this.txtSAddress.Text.Trim();
            string SManagerName = this.txtSManagerName.Text.Trim();
            string SPhone = this.txtPhone.Text.Trim();

            string strSQL = "insert into SalesStore(SName,SAddress,SManagerName,SPhone)values(@SName,@SAddress,@SManagerName,@SPhone)";

            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                  //new SqlParameter("@SID", SID),
                  new SqlParameter("@SName", SName),
                  new SqlParameter("@SAddress", SAddress),
                  new SqlParameter("@SManagerName", SManagerName),
                  new SqlParameter("@SPhone", SPhone));
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

        private void txtSName_Enter(object sender, EventArgs e)
        {
            if (this.txtSName.Text.Trim()!="")
            {
                this.txtSName.Clear();
            }
        }

        private void txtSName_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtSName.Text.Trim(),@"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtSName.Focus();
            }
        }

        private void txtSAddress_Enter(object sender, EventArgs e)
        {
            if (this.txtSAddress.Text.Trim() != "")
            {
                this.txtSAddress.Clear();
            }
        }

        private void txtSAddress_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtSAddress.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtSAddress.Focus();
            }
        }

        private void txtSManagerName_Enter(object sender, EventArgs e)
        {
            if (this.txtSManagerName.Text.Trim() != "")
            {
                this.txtSManagerName.Clear();
            }
        }

        private void txtSManagerName_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtSManagerName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtSManagerName.Focus();
            }
            
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (this.txtPhone.Text.Trim() != "")
            {
                this.txtPhone.Clear();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtPhone.Text.Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtPhone.Focus();
            }
        }
    }
}
