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
    public partial class FrmClerk : Form
    {
        public FrmClerk()
        {
            InitializeComponent();
        }
        public FrmClerk(FrmClerk f)
        {
            this.f = f;
            InitializeComponent();
        }
        //public FrmClerk(string CCardID)
        //{
        //    this.CardID = CCardID;
        //    InitializeComponent();
        //}
        //private string CardID;
        private FrmClerk f;
        private DBHelper helper = new DBHelper();
        private void FrmClerk_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Clerk inner join SalesStore on Clerk.SID=SalesStore.SID";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string SName = reader.GetString(reader.GetOrdinal("SName"));
                this.cmbSName.Items.Add(SName);
                string CName = reader.GetString(reader.GetOrdinal("CName"));
                this.cmbCName.Items.Add(CName);
               
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CSex")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CCardID")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CPhone")));
               
                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Clerk inner join SalesStore on Clerk.SID=SalesStore.SID where (CHARINDEX(@SName,SName)>0 or len(@SName)=0)and (CHARINDEX(@CName,CName)>0 or len(@CName)=0)and(CSex=@CSex or len(@CSex)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@SName", this.cmbSName.Text.Trim()),
                new SqlParameter("@CName", this.cmbCName.Text.Trim()),
                new SqlParameter("@CSex", this.cmbCSex.Text.Trim())
                );
            while (reader.Read()) 
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CSex")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CCardID")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CPhone")));
                lst.Tag = CCardID;
                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void cmbSName_Leave(object sender, EventArgs e)
        {
            if (this.cmbSName.Text.Trim() != "" && !Regex.IsMatch(this.cmbSName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbSName.Text.Trim() == "查询全部" || this.cmbSName.Text.Trim() == "")
            {
                this.cmbSName.Text = "";
            }
        }

        private void cmbCName_Leave(object sender, EventArgs e)
        {
            if (this.cmbCName.Text.Trim() != "" && !Regex.IsMatch(this.cmbCName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbCName.Text.Trim() == "查询全部" || this.cmbCName.Text.Trim() == "")
            {
                this.cmbCName.Text = "";
            }
        }

        private void cmbCSex_Leave(object sender, EventArgs e)
        {
            if (this.cmbCSex.Text.Trim() != "" && !Regex.IsMatch(this.cmbCSex.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbCSex.Text.Trim() == "查询全部" || this.cmbCSex.Text.Trim() == "")
            {
                this.cmbCSex.Text = "";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            FrmClerkAdd f = new FrmClerkAdd();
            f.ShowDialog();
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            FrmClerkDelete f = new FrmClerkDelete();
            f.ShowDialog();
        }

        private void tsmiModify_Click(object sender, EventArgs e)
        {
            FrmClerkModify f = new FrmClerkModify();
            f.ShowDialog();
        }
    }
}
