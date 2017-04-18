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
    public partial class FrmWDelete : Form
    {
        public FrmWDelete()
        {
            InitializeComponent();
        }
        public FrmWDelete(string top)
        {
            InitializeComponent();
            f = top;
        }
        DBHelper helpler = new DBHelper();
        private string f;
        private void btnUp_Click(object sender, EventArgs e)
        {
            string strSQL = "delete from goods where GID=@GID";
            int o = helpler.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@GID", f)
                );
            if (o > 0)
            {
                MessageBox.Show("删除成功！");
                this.Close();
            }
            else
            {
                MessageBox.Show("删除失败！");
            }
        }

        private void FrmWDelete_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Goods where GID=@GID";
            using (IDataReader reader = helpler.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@GID", Convert.ToInt32(f))))
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
            txtName.Enabled = false;
            txtNum.Enabled = false;
            txtStandard.Enabled = false;
            txtStyle.Enabled = false;
            txtUnit.Enabled = false;
        }
    }
}
