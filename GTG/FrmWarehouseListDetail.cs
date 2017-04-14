﻿using System;
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
    public partial class FrmWarehouseListDetail : Form
    {
        public FrmWarehouseListDetail()
        {
            InitializeComponent();
        }
        private string strCon = @"server=DEEP-20161031WY;database=GTGDB;uid=sa;password=123;";
        SqlDataAdapter adapter = null;
        DataSet ds = new DataSet();
        private void FrmWarehouseListDetail_Load(object sender, EventArgs e)
        {
            string strSQL = "select * from WarehouseListDetail";
            adapter = new SqlDataAdapter(strSQL, strCon);
            adapter.Fill(ds, "q");
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.DataSource = ds.Tables["q"];
        }
    }
}
