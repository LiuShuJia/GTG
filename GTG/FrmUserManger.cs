using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GTG
{
    public partial class FrmUserManger : Form
    {
        public FrmUserManger()
        {
            InitializeComponent();
        }
        public FrmUserManger(string s)
        {
            InitializeComponent();
            this.UserName = s;
        }
        private string UserName = "";
        private void Tsmiupuserinfo_Click(object sender, EventArgs e)
        {
            FrmUpdateUserInfo finfo = new FrmUpdateUserInfo(UserName);
            this.Hide();
            finfo.ShowDialog();
            this.Show();
        }

        private void Tsmiupuserkey_Click(object sender, EventArgs e)
        {
            FrmUpdateUserKey fkey = new GTG.FrmUpdateUserKey(UserName);
            this.Hide();
            fkey.ShowDialog();
            this.Show();
        }
    }
}
