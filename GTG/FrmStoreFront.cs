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
    public partial class FrmStoreFront : Form
    {
        public FrmStoreFront()
        {
            InitializeComponent();
        }
        public FrmStoreFront(FrmStoreFront f)
        {
            this.f = f;
            InitializeComponent();
        }
        public FrmStoreFront(string SID)
        {
            this.SID = SID;
            InitializeComponent();
        }
        private FrmStoreFront f;
        private DBHelper helper = new DBHelper();
        private string SID;
        private void tsmiStore_Click(object sender, EventArgs e)
        {

        }

        private void FrmStoreFront_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select distinct * from SalesStore";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string SaleName= reader.GetString(reader.GetOrdinal("SName"));
                this.cmbSaleName.Items.Add(SaleName);
                string SAddress = reader.GetString(reader.GetOrdinal("SAddress"));
                this.cmbAddress.Items.Add(SAddress);
                string SManagerName = reader.GetString(reader.GetOrdinal("SManagerName"));
                this.cmbSManagerName.Items.Add(SManagerName);

                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SManagerName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPhone")));
                lst.Tag = reader.GetInt32(reader.GetOrdinal("SID"));
                this.lstTable.Items.Add(lst);
            }
            reader.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)                                //增加信息
        {
            FrmStoreFrontAdd f = new FrmStoreFrontAdd();
            f.ShowDialog();
            this.btnSelect.PerformClick();
        }

        private void tsmiBillOfLading_Click(object sender, EventArgs e)                            //提货表
        {
            //FrmBillOfLading f = new FrmBillOfLading();
            //f.ShowDialog();
        }

        private void tsmiSalesTicket_Click(object sender, EventArgs e)                              //销售表
        {
            //FrmSalesTicket f = new FrmSalesTicket();
            //f.ShowDialog();
        }

        private void tsmiClientele_Click(object sender, EventArgs e)                            //客户信息表
        {
            //FrmClientele f = new FrmClientele();
            //f.ShowDialog();
        }

        private void tsmiClerk_Click_1(object sender, EventArgs e)
        {
            //FrmClerk f = new FrmClerk();
            //f.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            string SName = this.cmbSaleName.Text;
            string SAddress = this.cmbAddress.Text;
            string SManagerName = this.cmbSManagerName.Text;
            this.lstTable.Items.Clear();
            string strSQL = "select distinct  * from SalesStore where(CHARINDEX(@SName,SName)>0 or len(@SName)=0) and(CHARINDEX(@SAddress,SAddress)>0 or len(@SAddress)=0) and (CHARINDEX(@SManagerName,SManagerName)>0 or len(@SManagerName)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                  new SqlParameter("@SName", SName),
                   new SqlParameter("@SAddress", SAddress),
                   new SqlParameter("@SManagerName", SManagerName));
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("SName")));
                lst.Tag = reader.GetInt32(reader.GetOrdinal("SID"));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SManagerName")));
                lst.SubItems.Add(reader.IsDBNull(reader.GetOrdinal("SPhone")) ? null : reader.GetString(reader.GetOrdinal("SPhone")));
                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void cmbSaleName_Enter(object sender, EventArgs e)
        {
            
        }

        private void cmbSaleName_Leave(object sender, EventArgs e)
        {
            if (this.cmbSaleName.Text.Trim() != "" && !Regex.IsMatch(this.cmbSaleName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbSaleName.Text.Trim() == "查询全部" || this.cmbSaleName.Text.Trim() == "")
            {
                this.cmbSaleName.Text = "";
            }
        }

        private void cmbAddress_Leave(object sender, EventArgs e)
        {
            if (this.cmbAddress.Text.Trim() != "" && !Regex.IsMatch(this.cmbAddress.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbAddress.Text.Trim() == "查询全部" || this.cmbAddress.Text.Trim() == "")
            {
                this.cmbAddress.Text = "";
            }
        }

        private void cmbSManagerName_Leave(object sender, EventArgs e)
        {
            if (this.cmbSManagerName.Text.Trim() != "" && !Regex.IsMatch(this.cmbSManagerName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbSManagerName.Text.Trim() == "查询全部" || this.cmbSManagerName.Text.Trim() == "")
            {
                this.cmbSManagerName.Text = "";
            }
        }

        private void tsmiDelete_Click(object sender, EventArgs e)
        {
            if (lstTable.SelectedItems.Count < 1)
            {
                return;
            }
            DialogResult result = MessageBox.Show("是否删除？", "信息", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }
            string SID = lstTable.SelectedItems[0].Tag.ToString();
            FrmStoreFrontDelete f = new FrmStoreFrontDelete(SID);
            f.ShowDialog();
            this.btnSelect.PerformClick();
        }

        private void tsmiModify_Click(object sender, EventArgs e)
        {
            if (lstTable.SelectedItems.Count < 1)
            {
                return;
            }
            DialogResult result = MessageBox.Show("是否修改？", "信息", MessageBoxButtons.OKCancel);
            if (result != DialogResult.OK)
            {
                return;
            }
            string SID = lstTable.SelectedItems[0].Tag.ToString();
            FrmStoreFrontModify f = new FrmStoreFrontModify(SID);
            f.ShowDialog();
            this.btnSelect.PerformClick();
        }
    }
}
