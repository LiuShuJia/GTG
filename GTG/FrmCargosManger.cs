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
            FrmOutboundInventoryTable f = new FrmOutboundInventoryTable(this);
            f.ShowDialog();
        }

        private void tsmiWarehouseList_Click(object sender, EventArgs e)
        {
            
        }

        private void tsmiPurchaseList_Click(object sender, EventArgs e)
        {
           
        }

        private void tsmiWarehouseListDetail_Click(object sender, EventArgs e)
        {
        }

        private void tsmiPurchaseListDetail_Click(object sender, EventArgs e)
        {
        }

        private void tsmiWarehous_Click(object sender, EventArgs e)
        {
            FrmWarehouseList f = new FrmWarehouseList(this);
            f.ShowDialog();
        }

        private void tsmiPurc_Click(object sender, EventArgs e)
        {
            FrmPurchaseList f = new FrmPurchaseList(this);
            f.ShowDialog();
        }
        
        private void tsmiDetailed_Click(object sender, EventArgs e)
        {
            FrmDetailed f = new FrmDetailed(this);
            f.ShowDialog();
        }

        private void tsmiPurc_Click_1(object sender, EventArgs e)
        {
            FrmPurchaseList f = new FrmPurchaseList(this);
            f.ShowDialog();
        }

        private void tsmiWarehous_Click_1(object sender, EventArgs e)
        {
            FrmWarehouseList f = new FrmWarehouseList(this);
            f.ShowDialog();
        }
    }
}
