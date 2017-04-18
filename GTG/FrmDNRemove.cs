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
    public partial class FrmDNRemove : Form
    {
        public FrmDNRemove()
        {
            InitializeComponent();
        }
        public FrmDNRemove(string Tag)
        {
            this.f = Tag;
            InitializeComponent();
        }
        private string f;
        DBHelper helpler = new DBHelper();
        private void FrmDNRemove_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from Supplier where SPID=@SPID";
            using (IDataReader reader = helpler.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@SPID", Convert.ToInt32(f))))
            {
                while (reader.Read())
                {
                    txtName.Text = reader.GetString(reader.GetOrdinal("SPName"));
                    txtRname.Text = reader.GetString(reader.GetOrdinal("SPMan"));
                    txtPhone.Text = reader.GetString(reader.GetOrdinal("SPPhone"));

                }
                reader.Close();
                txtName.Enabled = false;
                txtRname.Enabled = false;
                txtPhone.Enabled = false;
            }
        }

        private void btnYes_Click(object sender, EventArgs e)
        {
            string strSQL = "delete from Supplier where SPID=@SPID";
            int o = helpler.ExecuteNonQuery(strSQL, CommandType.Text,
                new SqlParameter("@SPID", Convert.ToInt32(f))
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
    }
}
