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
    public partial class FrmPurchaseList : Form
    {
        public FrmPurchaseList()
        {
            InitializeComponent();
        }
        public FrmPurchaseList(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }
        private Form parentForm;
        private DBHelper helper = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtName.Text.Trim(), @"^\w+$") == false)
            {
                MessageBox.Show("商品名不能为空！");
                return;
            }
            if (Regex.IsMatch(txtNumble.Text.Trim(), @"^[1-9][0-9]*$") == false)
            {
                MessageBox.Show("商品数量必须大于0！");
                return;
            }
            if (Regex.IsMatch(txtUnit.Text.Trim(), @"^\w+$") == false)
            {
                MessageBox.Show("商品单位不能为空！");
                return;
            }
            string GName = txtName.Text.Trim();
            string Numble = txtNumble.Text.Trim();
            string unit = txtUnit.Text.Trim();
            int numble = 0;
            string strSQl = "select * from Goods where  GName=@GName  ";
            IDataReader reader = helper.ExecuteReader(strSQl, CommandType.Text, new SqlParameter("@GName", GName));
            if (reader.Read())
            {
                numble = reader.GetInt32(reader.GetOrdinal("GNum"));
            }
            reader.Close();
            if (numble > 0)
            {

                int wid = 1;
                strSQl = "insert into PurchaseList (WID,PInDate)values(@WID,getdate())  ";
                int rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@WID", wid));
                if (rows > 0)
                {
                    strSQl = "insert into PurchaseListDetail (PID,GID,PLDNum)values((select max(PID) from PurchaseList)," +
                        "(select GID from Goods where GName=@GName),@GNum)  ";
                    rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@GName", GName),
                     new SqlParameter("@GNum", Numble));
                    if (rows > 0)
                    {
                        if (numble > 0)
                        {
                            strSQl = "update Goods  set GNum+=@GNum where  GName=@GName  ";
                            rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@GName", GName),
                                 new SqlParameter("@GNum", Numble));
                        }
                        else
                        {
                            strSQl = "insert into Goods (GName,GNum,GUnit)values(@GName,@GNum,@GUnit)  ";
                            rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@GName", GName),
                                new SqlParameter("@GNum", Numble), new SqlParameter("@GUnit", unit));
                        }
                        if (rows > 0)
                        {
                            this.lblUnit1.Text = "";
                            if (numble > 0)
                            {
                                MessageBox.Show("入库成功！");
                                this.Close();
                            }
                            else
                            {
                                MessageBox.Show("新增货物，入库成功！");
                                this.Close();
                            }
                        }
                        else
                        {
                            MessageBox.Show("入库失败！");
                        }
                    }
                    else
                    {
                        MessageBox.Show("生成出库详细信息单失败！");
                    }
                }
                else
                {
                    MessageBox.Show("生成出库单失败！");
                }
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            string GName = txtName.Text.Trim();
            string strSQl = "select * from Goods where  GName=@GName  ";
            IDataReader reader = helper.ExecuteReader(strSQl, CommandType.Text, new SqlParameter("@GName", GName));
            if (reader.Read())
            {
                this.lblUnit1.Text = reader.GetString(reader.GetOrdinal("GUnit"));
            }
            reader.Close();
            if (lblUnit1.Text.Trim() != "")
            {
                txtUnit.Visible = false;
                this.txtUnit.Text = this.lblUnit1.Text;
            }
        }

        private void txtNumble_Enter(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(txtName.Text.Trim(), @"^\w+$") == false)
            //{
            //    MessageBox.Show("商品名不能为空！");
            //}
        }

        private void txtNumble_Leave(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(txtNumble.Text.Trim(), @"^[1-9][0-9]*$") == false)
            //{
            //    MessageBox.Show("商品数量必须大于0！");
            //}
        }

        private void txtUnit_Enter(object sender, EventArgs e)
        {
            //if (Regex.IsMatch(txtNumble.Text.Trim(), @"^[1-9][0-9]*$") == false)
            //{
            //    MessageBox.Show("商品数量必须大于0！");
            //}
        }

        private void txtUnit_Leave(object sender, EventArgs e)
        {
            ////if (Regex.IsMatch(txtUnit.Text.Trim(), @"^\w+$") == false)
            ////{
            ////    MessageBox.Show("商品单位不能为空！");
            ////}
        }
    }
}
