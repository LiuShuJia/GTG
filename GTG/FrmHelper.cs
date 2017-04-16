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
    public partial class FrmHelper : Form
    {
        public FrmHelper()
        {
            InitializeComponent();
        }

        private DBHelper helper = new DBHelper();
        
        /// <summary>
        /// 浏览备份路径
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void btnBrower_Click(object sender, EventArgs e)
        {
            FolderBrowserDialog folder = new FolderBrowserDialog();
            folder.ShowDialog();
            this.txtFolder.Text = folder.SelectedPath;
        }

        /// <summary>
        /// 备份和恢复数据库
        /// </summary>
        /// <param name="cmdText">SQL语句</param>
        /// <param name="isBak">是否为备份</param>
        private void BakReductSql(string cmdText, bool isBak)
        {
            try
            {
                string cmdBakRst;
                if (!isBak)     //恢复操作
                {
                    string setOffline = "Alter database GTGDB Set Offline With rollback immediate ";
                    string setOnline = " Alter database GTGDB Set Online With Rollback immediate";
                    cmdBakRst = setOffline + cmdText + setOnline;
                }
                else   //备份操作
                {
                    cmdBakRst=cmdText;
                }
                helper.ExecuteNonQuery(cmdBakRst);
                if (!isBak)
                {
                    MessageBox.Show("恭喜，数据恢复成功！", "系统消息");
                }
                else
                {
                    MessageBox.Show("恭喜，你已经成功备份当前数据！", "系统消息");
                }
            }
            catch (SqlException sexc)
            {
                MessageBox.Show("失败，可能是对数据库操作失败，原因：" + sexc, "数据库错误消息");
            }
            catch (Exception ex)
            {
                MessageBox.Show("对不起，操作失败，可能原因：" + ex, "系统消息");
            }
        }

        private void FrmHelper_Load(object sender, EventArgs e)
        {
           this.txtFolder.Text=System.Environment.CurrentDirectory;
        }

        private void tsmiRecover_Click(object sender, EventArgs e)
        {
            string openAway = this.txtReduce.Text.ToString().Trim();//读取恢复文件的路径
            string cmdText = @"restore database GTGDB from disk='" + openAway + "' With Replace";
            BakReductSql(cmdText, false);
        }

        private void btnReduce_Click(object sender, EventArgs e)
        {
            OpenFileDialog dialog = new OpenFileDialog();
            dialog.Filter = "备份文件|*.bak";
            if (dialog.ShowDialog() == DialogResult.OK)
            {
                this.txtReduce.Text = dialog.FileName;
            }
        }

        private void btnBackup_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFolder.Text))
            {
                MessageBox.Show("请输入备份的路径");
                return;
            }
            string saveAway = this.txtFolder.Text.ToString().Trim() +"/GTGDB.bak";
            string cmdText = @"use master backup database GTGDB to disk='" + saveAway + "'";
            BakReductSql(cmdText, true);
        }
        
        private void btnRecever_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtReduce.Text))
            {
                MessageBox.Show("请选择恢复文件");
                return;
            }
            string openAway = this.txtReduce.Text.ToString().Trim();//读取恢复文件的路径
            string cmdText = @"restore database GTGDB from disk='" + openAway + "' With Replace";
            BakReductSql(cmdText, false);
        }
    }
}
