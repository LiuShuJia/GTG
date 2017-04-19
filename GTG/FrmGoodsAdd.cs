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
    public partial class FrmGoodsAdd : Form
    {
        public FrmGoodsAdd()
        {
            InitializeComponent();
        }
        private DBHelper helper = new DBHelper();
        private void btnUp_Click(object sender, EventArgs e)
        {
            int a;
            if (txtName.Text == "")
            {
                MessageBox.Show("商品名不能为空！");
                return;
            }
            if (txtStandard.Text == "")
            {
                MessageBox.Show("商品规格不能为空！");
                return;
            }
            if (txtStyle.Text == "")
            {
                MessageBox.Show("商品类别不能为空！");
                return;
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("商品单位不能为空！");
                return;
            }

            if (!int.TryParse(txtNum.Text, out a) || txtNum.Text == "")
            {
                MessageBox.Show("数量格式不正确！");
                return;
            }
            string strSQL = "insertinto goods (GName,GNum,GStyle,GStandard,GUnit) values(@GName,@GNum,@GStyle,@GStandard,@GUnit)";
            int o = helper.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@GName", txtName.Text),
                new SqlParameter("@GNum", Convert.ToInt32(txtNum.Text)),
                new SqlParameter("@GStyle", txtStyle.Text),
                new SqlParameter("@GStandard", txtStandard.Text),
                new SqlParameter("@GUnit", txtUnit.Text)
                );
            if (o > 0)
            {
                MessageBox.Show("增加成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("增加失败！");
            }
        }
    }
}
