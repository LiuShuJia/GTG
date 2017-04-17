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
    public partial class FrmGoods : Form
    {
        public FrmGoods()
        {
            InitializeComponent();
        }
        DBHelper hepler = new DBHelper();
        private FrmClientele f;
        private DBHelper helper = new DBHelper();
        private void btnSelect_Click(object sender, EventArgs e)
        {
            string gname = txtName.Text;
            string gstyle = txtStyle.Text;

        
        }

        private void FrmGoods_Load(object sender, EventArgs e)
        {
           
        }
    }
}
