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
    public partial class FrmUp : Form
    {
        public FrmUp()
        {
            InitializeComponent();
        }
        public FrmUp(string top)
        {
            InitializeComponent();
            f = top;
        }
        DBHelper helpler = new DBHelper();
        private string f;
        private void FrmUp_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods where GID=@GID";
            
            using (IDataReader reader = helpler.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@GID", f)))
            {
                while (reader.Read())
                {

                    txtName.Text = reader.GetString(reader.GetOrdinal("GName"));
                    txtNum.Text = reader.GetInt32(reader.GetOrdinal("GNum")).ToString();
                    txtStyle.Text = reader.GetString(reader.GetOrdinal("GStyle"));
                    txtStandard.Text = reader.GetString(reader.GetOrdinal("GStandard"));
                    txtUnit.Text = reader.GetString(reader.GetOrdinal("GUnit"));

                }
                reader.Close(); 
            }
        }

        private void btnUp_Click(object sender, EventArgs e)
        {
            int a;
            if (txtName.Text=="")
            {
                MessageBox.Show("商品名不能为空！");
            }
            if (txtStandard.Text == "")
            {
                MessageBox.Show("商品规格不能为空！");
            }
            if (txtStyle.Text == "")
            {
                MessageBox.Show("商品类别不能为空！");
            }
            if (txtUnit.Text == "")
            {
                MessageBox.Show("商品单位不能为空！");
            }
        
            if (!int.TryParse(txtNum.Text,out a)||txtNum.Text=="")
            {
                MessageBox.Show("数量格式不正确！");
            }
            string strSQL = "update goods set GName=@GName,GNum=@GNum,GStyle=@GStyle,GStandard=@GStandard,GUnit=@GUnit where GID=@GID";
            object o = helpler.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@GName", txtName.Text),
                new SqlParameter("@GNum", Convert.ToInt32(txtNum.Text)),
                new SqlParameter("@GStyle", txtStyle.Text),
                new SqlParameter("@GStandard", txtStandard.Text),
                new SqlParameter("@GUnit", txtUnit.Text),
                new SqlParameter("@GID", f)
                );
            if(Convert.ToInt32(o) > 0)
            {
                MessageBox.Show("修改成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("修改失败！");
            }
        }
    }
}
