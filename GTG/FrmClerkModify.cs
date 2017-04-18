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
    public partial class FrmClerkModify : Form
    {
        public FrmClerkModify()
        {
            InitializeComponent();
        }
        public FrmClerkModify(string CID)
        {
            this.CID = CID;
            InitializeComponent();
        }
        private string CID;
        private DBHelper helper = new DBHelper();

        private void btnDetermine_Click(object sender, EventArgs e)
        {
            string CCardID = this.txtCardID.Text.Trim();
            string SName = this.cmbSName.Text.Trim();
            string CName = this.txtCName.Text.Trim();
            string CSex = this.txtCSex.Text.Trim();
            string CPhone= this.txtCPhone.Text.Trim();

            string strSQL = "Update Clerk inner join SalesStore on SalesStore.SID=Clerk.SID set SName=@SName,CCardID=@CCardID,CName=@CName,CSex=@CSex,CPhone=@CPhone where CID=@CID";

            int row = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@CID", CID),
                new SqlParameter("@SName", SName),
                  new SqlParameter("@CCardID", CCardID),
                  new SqlParameter("@CName", CName),
                  new SqlParameter("@CSex", CSex),
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

        private void FrmClerkModify_Load(object sender, EventArgs e)
        {
            //this.txtCardID.Text = CID;
            //txtCardID.Enabled = false;
            string strSQL = "select distinct SName,CID,CName,CSex,CCardID,CPhone from Clerk inner join SalesStore on SalesStore.SID=Clerk.SID where CID=@CID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text, new SqlParameter("@CID", CID));
            while (reader.Read())
            {
                string SName = reader.GetString(reader.GetOrdinal("SName"));
                this.cmbSName.Items.Add(SName);

                int CID= reader.GetInt32(reader.GetOrdinal("CID"));
                this.txtCName.Text = reader.GetString(reader.GetOrdinal("CName"));
                this.txtCSex.Text = reader.IsDBNull(reader.GetOrdinal("CSex")) ? null : reader.GetString(reader.GetOrdinal("CSex"));
                this.txtCardID.Text = reader.IsDBNull(reader.GetOrdinal("CCardID")) ? null : reader.GetString(reader.GetOrdinal("CCardID"));
                this.txtCPhone.Text = reader.IsDBNull(reader.GetOrdinal("CPhone")) ? null : reader.GetString(reader.GetOrdinal("CPhone"));
            }
            reader.Close();
        }

        private void txtCName_Leave(object sender, EventArgs e)
        {
            if (this.txtCName.Text.Trim()==""||!Regex.IsMatch(this.txtCName.Text.Trim(),@"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }

        private void txtCSex_Leave(object sender, EventArgs e)
        {
            if (this.txtCSex.Text.Trim()!="女"|| this.txtCSex.Text.Trim()!="男")
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }

        private void txtCardID_Leave(object sender, EventArgs e)
        {
            if (this.txtCardID.Text.Trim() == "" || !Regex.IsMatch(this.txtCardID.Text.Trim(), @"^[1-9][0-9]{14}|[1-9][0-9]{16}[0-9Xx]$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }

        private void txtCPhone_Leave(object sender, EventArgs e)
        {
            if (this.txtCPhone.Text.Trim() == "" || !Regex.IsMatch(this.txtCPhone.Text.Trim(), @"^[0-9]+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入！");
            }
        }
    }
}
