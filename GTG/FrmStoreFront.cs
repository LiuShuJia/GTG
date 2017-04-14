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
        public FrmStoreFront(string CCardID)
        {
            this.CCardID = CCardID;
            InitializeComponent();
        }
        private DBHelper helper = new DBHelper();
        private string CCardID;
        private void tsmiClerk_Click(object sender, EventArgs e)
        {
            string SName = this.cmbName.Text.Trim();
            string SAddress= this.txtAddress.Text.Trim();
            string strSQL = "select * from CLerk where (SName=@SName or len(@SName)=0)and (SAddress=@SAddress or len(@SAddress)=0)";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                  new SqlParameter("@SName", this.cmbName.Text.Trim()),
                   new SqlParameter("@SAddress", this.txtAddress.Text.Trim())))
            {
                while (reader.Read())
                {
                    SName= reader.GetString(reader.GetOrdinal("SName"));
                    this.cmbName.Items.Add(SName);
                    SAddress = reader.GetString(reader.GetOrdinal("SAddress"));
                    this.cmbText2.Items.Add(SName);
                    

                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SName")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SAddress")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SManagerName")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPhone")));

                    this.lstTable.Items.Add(lst);
                }
                reader.Close();
            }
        }

        private void tsmi_Click(object sender, EventArgs e)
        {

        }

        private void tsmiStore_Click(object sender, EventArgs e)
        {

        }

        private void FrmStoreFront_Load(object sender, EventArgs e)
        {
            string SName = this.cmbName.Text.Trim(); ;
            string SAddress = this.txtAddress.Text.Trim();
            string strSQL = "select * from CLerk where SID=@SID";
            using (IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text))
            {
                while (reader.Read())
                {
                    ListViewItem lst = new ListViewItem();
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SName")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SAddress")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SManagerName")));
                    lst.SubItems.Add(reader.GetString(reader.GetOrdinal("SPhone")));

                    this.lstTable.Items.Add(lst);
                }
                reader.Close();
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)                                //增加信息
        {
            
        }

        private void tsmiBillOfLading_Click(object sender, EventArgs e)                            //提货表
        {
            //lblText1.Text = "按日期查询：";
        }

        private void tsmiSalesTicket_Click(object sender, EventArgs e)                              //销售表
        {
            //lblText1.Text = "按日期查询：";
        }

        private void tsmiClientele_Click(object sender, EventArgs e)                            //客户信息表
        {
            //lblText1.Text = "按姓名查询：";
        }
    }
}
