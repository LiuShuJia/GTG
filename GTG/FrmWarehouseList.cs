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
    public partial class FrmWarehouseList : Form
    {
        public FrmWarehouseList()
        {
            InitializeComponent();
        }
        private DBHelper helper = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNumble.Text.Trim(), @"^[1-9][0-9]*$") == false)
            {
                MessageBox.Show("商品数量必须大于0！");
                return;
            }
            string GName = txtName.Text.Trim();
            string Numble = txtNumble.Text.Trim();
            int numble = 0;
            string strSQl = "select * from Goods where  GName=@GName  ";
            IDataReader reader = helper.ExecuteReader(strSQl, CommandType.Text, new SqlParameter("@GName", GName));
            if (reader.Read())
            {
                numble = reader.GetInt32(reader.GetOrdinal("GNum"));
            }
            reader.Close();
            if (numble > Convert.ToInt32(Numble))
            {
                strSQl = "update Goods  set GNum=@GNum where  GName=@GName  ";
                int rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@GName", GName),
                    new SqlParameter("@GNum", Numble));
                if (rows > 0)
                {
                    int wid = 0;
                    strSQl = "insert into PurchaseList (WID,PinDate)valuse(@WID,getdate())  ";
                    rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@WID", wid));
                    if (rows > 0)
                    {
                        strSQl = "insert into PurchaseListDetail (PID,GID,PLDNum,)valuse(select max(PID) from PurchaseList," +
                            "select GID from Goods where GName=@GName,@GNum)  ";
                        rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@GName", GName),
                         new SqlParameter("@GNum", Numble));
                        if (rows > 0)
                        {
                            MessageBox.Show("出库成功！");
                            this.Close();
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
                else
                {
                    MessageBox.Show("出库失败！");
                }
            }
            else
            {
                MessageBox.Show("库存数量不足！");
            }
        }

        private void txtNumble_Enter(object sender, EventArgs e)
        {
            string GName = txtName.Text.Trim();
            int numble = 0;
            string strSQl = "select * from Goods where  GName=@GName  ";
            IDataReader reader = helper.ExecuteReader(strSQl, CommandType.Text, new SqlParameter("@GName", GName));
            if (reader.Read())
            {
                numble = reader.GetInt32(reader.GetOrdinal("GNum"));
            }
            reader.Close();
            if (numble == 0)
            {
                MessageBox.Show("目前没有该商品！");
            }
            if (Regex.IsMatch(txtName.Text.Trim(), @"^\w+$") == false)
            {
                MessageBox.Show("商品名不能为空！");
            }
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtName.Text.Trim(),@"^\w+$")==false )
            {
                MessageBox.Show("商品名不能为空！");
            }
        }

        private void txtNumble_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNumble.Text.Trim(), @"^[1-9][0-9]*$") == false)
            {
                MessageBox.Show("商品数量必须大于0！");
            }
        }
    }
}
