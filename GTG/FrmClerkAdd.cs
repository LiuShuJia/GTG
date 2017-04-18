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
    public partial class FrmClerkAdd : Form
    {
        public FrmClerkAdd()
        {
            InitializeComponent();
        }
        public FrmClerkAdd(FrmClerk f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmClerk f;
        private DBHelper helper =new DBHelper();
        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string CID = Guid.NewGuid().ToString();
            string CName = this.txtCName.Text.Trim();
            string CSex = this.txtCSex.Text.Trim();
            string CCardID = this.txtCardID.Text.Trim();
            string CPhone = this.txtCPhone.Text.Trim();

            string strSQL = "insert into Clerk (CName,CSex,CCardID,CPhone)values(@CName,@CSex,@CCardID,@CPhone)";

            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                  new SqlParameter("@CName", CName),
                  new SqlParameter("@CSex", CSex),
                   new SqlParameter("@CCardID", CCardID),
                  new SqlParameter("@CPhone", CPhone));
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

        private void txtCName_Enter(object sender, EventArgs e)
        {
            if (this.txtCName.Text.Trim() != "")
            {
                this.txtCName.Clear();
            }
        }

        private void txtCName_Leave(object sender, EventArgs e)
        {

            if (!Regex.IsMatch(this.txtCName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtCName.Focus();
            }
        }

        private void txtCSex_Enter(object sender, EventArgs e)
        {
            if (this.txtCSex.Text.Trim() != "")
            {
                this.txtCSex.Clear();
            }
        }

        private void txtCSex_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtCSex.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtCSex.Focus();
            }
        }

        private void txtCardID_Enter(object sender, EventArgs e)
        {
            if (this.txtCardID.Text.Trim() != "")
            {
                this.txtCardID.Clear();
            }
        }

        private void txtCardID_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtCardID.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtCardID.Focus();
            }
        }

        private void txtCPhone_Enter(object sender, EventArgs e)
        {
            if (this.txtCPhone.Text.Trim() != "")
            {
                this.txtCPhone.Clear();
            }
        }

        private void txtCPhone_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtCPhone.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtCPhone.Focus();
            }
        }

        private void FrmClerkAdd_Load(object sender, EventArgs e)
        {
           
        }
    }
}
