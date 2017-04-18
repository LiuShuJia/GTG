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
    public partial class FrmStoreFrontModify : Form
    {
        public FrmStoreFrontModify()
        {
            InitializeComponent();
        }
        public FrmStoreFrontModify(FrmStoreFrontModify f)
        {
            this.f = f;
            InitializeComponent();
        }
        public FrmStoreFrontModify(string SID)
        {
            this.SID = SID;
            InitializeComponent();
        }
        private FrmStoreFrontModify f;
        private string SID;
        private DBHelper helper = new DBHelper();
        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string SName =this.txtSName.Text.Trim();
            string SAddress = this.txtSAddress.Text.Trim();
            string SManagerName = this.txtSManagerName.Text.Trim();
            string SPhone = this.txtSPhone.Text.Trim();
            string strSQL = "Update SalesStore set SName=@SName,SAddress=@SAddress,SManagerName=@SManagerName,SPhone=@SPhone where SID=@SID";
            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text, new SqlParameter("SID", SID),
                new SqlParameter("SName", SName),
                new SqlParameter("SAddress", SAddress),
                new SqlParameter("SManagerName", SManagerName),
                new SqlParameter("SPhone", SPhone)
                );
            if (row > 0)
            {
                MessageBox.Show("修改成功!");
                Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }

        private void FrmStoreFrontModify_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from SalesStore where SID=@SID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@SID", SID));
            while (reader.Read())
            {
                this.txtSName.Text = reader.GetString(reader.GetOrdinal("SName"));
                this.txtSAddress.Text = reader.IsDBNull(reader.GetOrdinal("SAddress")) ? null : reader.GetString(reader.GetOrdinal("SAddress"));
                this.txtSManagerName.Text = reader.IsDBNull(reader.GetOrdinal("SManagerName")) ? null : reader.GetString(reader.GetOrdinal("SManagerName"));
                this.txtSPhone.Text = reader.IsDBNull(reader.GetOrdinal("SPhone")) ? null : reader.GetString(reader.GetOrdinal("SPhone"));
            }
            reader.Close();
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
            if (!Regex.IsMatch(this.txtSName.Text.Trim(), @"^\w+$"))
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
            if (this.txtSPhone.Text.Trim() != "")
            {
                this.txtSPhone.Clear();
            }
        }

        private void txtPhone_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtSPhone.Text.Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtSPhone.Focus();
            }
        }
    }
}
