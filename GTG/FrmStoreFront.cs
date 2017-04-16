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
        //public FrmStoreFront(string CCardID)
        //{
        //    this.CCardID = CCardID;
        //    InitializeComponent();
        //}
        private FrmStoreFront f;
        private DBHelper helper = new DBHelper();
        private string CCardID;
        private void tsmiClerk_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmi_Click(object sender, EventArgs e)
        {

        }

        private void tsmiStore_Click(object sender, EventArgs e)
        {

        }

        private void FrmStoreFront_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from SalesStore";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string SaleName= reader.GetString(reader.GetOrdinal("SaleName"));
                this.cmbSaleName.Items.Add(SaleName);
                string SAddress = reader.GetString(reader.GetOrdinal("SAddress"));
                this.cmbSaleName.Items.Add(SAddress);

                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SManagerName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPhone")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();

        }

        private void btnAdd_Click(object sender, EventArgs e)                                //增加信息
        {
            
        }

        private void tsmiBillOfLading_Click(object sender, EventArgs e)                            //提货表
        {
            FrmBillOfLading f = new FrmBillOfLading();
            f.ShowDialog();
        }

        private void tsmiSalesTicket_Click(object sender, EventArgs e)                              //销售表
        {
            FrmSalesTicket f = new FrmSalesTicket();
            f.ShowDialog();
        }

        private void tsmiClientele_Click(object sender, EventArgs e)                            //客户信息表
        {
            FrmClientele f = new FrmClientele();
            f.ShowDialog();
        }

        private void tsmiClerk_Click_1(object sender, EventArgs e)
        {
            FrmClerk f = new FrmClerk();
            f.ShowDialog();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            if (this.cmbSaleName.Text.Trim() == "查询全部")
            {
                this.cmbSaleName.Text = "";
            }
            if (this.cmbSManagerName.Text.Trim() == "查询全部")
            {
                this.cmbSManagerName.Text = "";
            }
            this.lstTable.Items.Clear();
            string strSQL = "select * from SalesStore where(CHARINDEX(@SaleName,SaleName)>0 or len(@SaleName)=0) and(SAddress=@SAddress or len(@SAddress)=0) and (SManagerName=@SManagerName or len(@SManagerName)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                  new SqlParameter("@SaleName", this.cmbSaleName.Text.Trim()),
                   new SqlParameter("@SAddress", this.txtAddress.Text.Trim()),
                   new SqlParameter("@SManagerName", this.cmbSManagerName.Text.Trim()));
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem();
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SaleName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SManagerName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPhone")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }
    }
}
