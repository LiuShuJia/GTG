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
        public FrmWarehouseList(Form parentForm)
        {
            InitializeComponent();
            this.parentForm = parentForm;

        }
        private Form parentForm;
        private DBHelper helper = new DBHelper();
        private void button1_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNumble.Text.Trim(), @"^[1-9][0-9]*$") == false)
            {
                MessageBox.Show("商品数量必须大于0！");
                return;
            }
            string GName = cboName.Text.Trim();
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
                int wid = 1;
                strSQl = "insert into WarehouseList (WID,WLDate)values(@WID,getdate())  ";
                int rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@WID", wid));
                if (rows > 0)
                {
                    strSQl = "insert into WarehouseListDetail (WLID,GID,WLDNum)values((select max(WLID) from WarehouseList)," +
                            "(select GID from Goods where GName=@GName),@GNum)  ";
                    rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@GName", GName), new SqlParameter("@GNum", Numble));
                    if (rows > 0)
                    {
                        strSQl = "update Goods  set GNum=GNum-@GNum where  GName=@GName  ";
                        rows = helper.ExecuteNonQuery(strSQl, CommandType.Text, new SqlParameter("@GName", GName),
                         new SqlParameter("@GNum", Numble));
                        if (rows > 0)
                        {
                            MessageBox.Show("出库成功！");
                            this.Close();
                        }
                        else
                        {
                            MessageBox.Show("出库失败！");
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
            else
            {
                MessageBox.Show("库存数量不足！");
            }
        }

        private void txtNumble_Enter(object sender, EventArgs e)
        {
           
        }

        private void txtName_Leave(object sender, EventArgs e)
        {
           
        }

        private void txtNumble_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(txtNumble.Text.Trim(), @"^[1-9][0-9]*$") == false)
            {
                MessageBox.Show("商品数量必须大于0！");
            }
        }

        private void FrmWarehouseList_Load(object sender, EventArgs e)
        {
            string strSQl = "select * from Goods ";
            IDataReader reader = helper.ExecuteReader(strSQl, CommandType.Text);
            while (reader.Read())
            {
                this.cboName.Items.Add(reader.GetInt32(reader.GetOrdinal("GName")));
            }
            reader.Close();
        }

        private void cboName_Leave(object sender, EventArgs e)
        {
            if (Regex.IsMatch(cboName.Text.Trim(), @"^\w+$") == false)
            {
                MessageBox.Show("商品名不能为空！");
            }
            else
            {
                lblStock.Text = "";
                string GName = cboName.Text.Trim();
                string unit = "";
                int numble = 0;
                if (GName != null)
                {
                    string strSQl = "select * from Goods where  GName=@GName  ";
                    IDataReader reader = helper.ExecuteReader(strSQl, CommandType.Text, new SqlParameter("@GName", GName));
                    if (reader.Read())
                    {
                        numble = reader.GetInt32(reader.GetOrdinal("GNum"));
                        unit = reader.GetString(reader.GetOrdinal("GUnit"));
                    }
                    reader.Close();
                    if (numble == 0)
                    {
                        MessageBox.Show("目前没有该商品！");
                    }
                    else
                    {
                        lblStock.Text = GName + "的库存为：" + numble + unit;
                    }
                }
            }
        }
    }
}
