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
    public partial class FrmClienteleModify : Form
    {
        public FrmClienteleModify()
        {
            InitializeComponent();
        }
        public FrmClienteleModify(FrmClienteleModify f)
        {
            this.f = f;
            InitializeComponent();
        }
        public FrmClienteleModify(string CTID)
        {
            this.CTID = CTID;
            InitializeComponent();
        }
        private string CTID;
        private FrmClienteleModify f;
        private DBHelper helper = new DBHelper();
        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string CTName = this.txtCTName.Text.Trim();
            string CTAddress = this.txtCTAddress.Text.Trim();
            string CTPhone = this.txtCTPhone.Text.Trim();
            string strSQL = "Update Client set(CTName=@CTName,STAddress=@STAddress,STPhone=@STPhone) where STID=@STID";

            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                  new SqlParameter("@CTID", CTID),
                  new SqlParameter("@CTName", CTName),
                  new SqlParameter("@CTAddress", CTAddress),
                  new SqlParameter("@CTPhone", CTPhone));
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

        private void FrmClienteleModify_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Client where CTID=@CTID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@CTID", CTID));
            while (reader.Read())
            {
                this.txtCTName.Text = reader.GetString(reader.GetOrdinal("CTName"));
                this.txtCTAddress.Text = reader.IsDBNull(reader.GetOrdinal("CTAddress")) ? null : reader.GetString(reader.GetOrdinal("SAddress"));
                this.txtCTPhone.Text = reader.IsDBNull(reader.GetOrdinal("CTPhone")) ? null : reader.GetString(reader.GetOrdinal("CTPhone"));
            }
            reader.Close();
        }

        private void txtCTName_Enter(object sender, EventArgs e)
        {
            if (this.txtCTName.Text.Trim() != "")
            {
                this.txtCTName.Clear();
            }
        }

        private void txtCTName_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtCTName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtCTName.Focus();
            }
        }

        private void txtCTAddress_Enter(object sender, EventArgs e)
        {
            if (this.txtCTAddress.Text.Trim() != "")
            {
                this.txtCTAddress.Clear();
            }
        }

        private void txtCTAddress_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtCTAddress.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtCTAddress.Focus();
            }
        }

        private void txtCTPhone_Enter(object sender, EventArgs e)
        {
            if (this.txtCTPhone.Text.Trim() != "")
            {
                this.txtCTPhone.Clear();
            }
        }

        private void txtCTPhone_Leave(object sender, EventArgs e)
        {
            if (!Regex.IsMatch(this.txtCTPhone.Text.Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
                this.txtCTPhone.Focus();
            }
        }
    }
}
