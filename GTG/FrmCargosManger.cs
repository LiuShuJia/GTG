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
    public partial class FrmCargosManger : Form
    {
        public FrmCargosManger()
        {
            InitializeComponent();
        }
        
        private void tsmiOutboundInventoryTable(object sender, EventArgs e)
        {
            FrmOutboundInventoryTable f = new FrmOutboundInventoryTable();
            f.ShowDialog();
        }

        private void tsmiWarehouseList_Click(object sender, EventArgs e)
        {
            FrmWarehouseList f = new FrmWarehouseList();
            f.ShowDialog();
        }

        private void tsmiPurchaseList_Click(object sender, EventArgs e)
        {
            FrmPurchaseList f = new FrmPurchaseList();
            f.ShowDialog();
        }

        private void tsmiWarehouseListDetail_Click(object sender, EventArgs e)
        {
            FrmWarehouseListDetail f = new FrmWarehouseListDetail();
            f.ShowDialog();
        }

        private void tsmiPurchaseListDetail_Click(object sender, EventArgs e)
        {
            FrmPurchaseListDetail f = new FrmPurchaseListDetail();
            f.ShowDialog();
        }
    }
}
