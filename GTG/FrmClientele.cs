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
using System.Text.RegularExpressions;


namespace GTG
{
    public partial class FrmClientele : Form
    {
        public FrmClientele()
        {
            InitializeComponent();
        }
        public FrmClientele(FrmClientele f)
        {
            this.f = f;
            InitializeComponent();
        }
        private FrmClientele f;
        private DBHelper helper = new DBHelper();
        private void FrmClientele_Load(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Client";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text);
            while (reader.Read())
            {
                string CTName = reader.GetString(reader.GetOrdinal("CTName"));
                this.cmbCTName.Items.Add(CTName);
                string CTAddress = reader.GetString(reader.GetOrdinal("CTAddress"));
                this.cmbCTAddress.Items.Add(CTAddress);

                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTPhone")));
                
                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void btnSelect_Click(object sender, EventArgs e)
        {
            this.lstTable.Items.Clear();
            string strSQL = "select * from Client where (CHARINDEX(@CTName,CTName)>0 or len(@CTName)=0) and(CHARINDEX(@CTAddress,CTAddress)>0 or len(@CTAddress)=0)";
            IDataReader reader = helper.ExecuteReader(strSQL, CommandType.Text,
                new SqlParameter("@CTName", this.cmbCTName.Text.Trim()),
                new SqlParameter("@CTAddress", this.cmbCTAddress.Text.Trim())
                );
            while (reader.Read())
            {
                ListViewItem lst = new ListViewItem(reader.GetString(reader.GetOrdinal("CTName")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTAddress")));
                lst.SubItems.Add(reader.GetString(reader.GetOrdinal("CTPhone")));

                this.lstTable.Items.Add(lst);
            }
            reader.Close();
        }

        private void cmbCTName_Leave(object sender, EventArgs e)
        {
            if (this.cmbCTName.Text.Trim() != "" && !Regex.IsMatch(this.cmbCTName.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbCTName.Text.Trim() == "查询全部" || this.cmbCTName.Text.Trim() == "")
            {
                this.cmbCTName.Text = "";
            }
        }

        private void txtCTAddress_Leave(object sender, EventArgs e)
        {
            
        }

        private void cmbCTAddress_Leave(object sender, EventArgs e)
        {
            if (this.cmbCTAddress.Text.Trim() != "" && !Regex.IsMatch(this.cmbCTAddress.Text.Trim(), @"^\w+$"))
            {
                MessageBox.Show("您输入的格式错误，请重新输入!");
            }
            if (this.cmbCTAddress.Text.Trim() == "查询全部" || this.cmbCTAddress.Text.Trim() == "")
            {
                this.cmbCTAddress.Text = "";
            }
        }
    }
}