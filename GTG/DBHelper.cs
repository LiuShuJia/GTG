using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;

namespace GTG
{
    public class DBHelper
    {
        public DBHelper()
        {
            con = new SqlConnection(strCon);
            cmd = new SqlCommand();
            cmd.Connection = con;
        }
        private string strCon = ConfigurationManager.ConnectionStrings["myCon"].ConnectionString;
        private IDbConnection con = null;
        private IDbCommand cmd = null;
      
        /// <summary>
        /// 查询受影响的行数
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="commandtype">SQL语句类型</param>
        /// <param name="parameter">参数数组</param>
        /// <returns>受影响的行数</returns>
        public int ExecuteNonQuery(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            int rows = 0;

            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandtype;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                con.Open();
                rows = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return rows;
        }
        /// <summary>
        /// 查询受影响的行数（线程）
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="commandtype">SQL语句类型</param>
        /// <param name="parameter">参数数组</param>
        /// <returns>受影响的行数</returns>
        public Task<int> ExecuteNonQueryAsync(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            return Task<int>.Run(() =>
            {
                return ExecuteNonQuery(strSQL, commandtype, parameter);
            });
        }
        /// <summary>
        /// 从数据库中查询数据
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="commandtype">SQL语句类型</param>
        /// <param name="parameter">参数数组</param>
        /// <returns>要查询的结果</returns>
        public object ExecuteScalar(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            object rows = null;

            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandtype;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                con.Open();
                rows = cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                con.Close();
            }
            return rows;
        }
        /// <summary>
        /// 从数据库中查询数据（线程）
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="commandtype">SQL语句类型</param>
        /// <param name="parameter">参数数组</param>
        /// <returns>要查询的结果</returns>
        public Task<object> ExecuteScalarAsync(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            return Task<object>.Run(() =>
            {
                return ExecuteScalar(strSQL, commandtype, parameter);
            });

        }
        /// <summary>
        /// 从数据库中读取数据
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="commandtype">SQL语句类型</param>
        /// <param name="parameter">参数数组</param>
        /// <returns>要读取的数据</returns>
        public IDataReader ExecuteReader(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            IDataReader reader = null;
            try
            {
                this.cmd.CommandText = strSQL;
                this.cmd.CommandType = commandtype;
                this.cmd.Parameters.Clear();
                foreach (var item in parameter)
                {
                    this.cmd.Parameters.Add(item);
                }
                con.Open();
                reader = cmd.ExecuteReader(CommandBehavior.CloseConnection);
            }
            catch (Exception ex)
            {
                throw ex;
            }
            return reader;
        }
        /// <summary>
        /// 从数据库中读取数据（线程）
        /// </summary>
        /// <param name="strSQL">SQL语句</param>
        /// <param name="commandtype">SQL语句类型</param>
        /// <param name="parameter">参数数组</param>
        /// <returns>要读取的数据</returns>
        public Task<IDataReader> ExecuteReaderAsync(string strSQL, CommandType commandtype = CommandType.Text, params IDataParameter[] parameter)
        {
            return Task<IDataReader>.Run(() =>
            {
                return ExecuteReader(strSQL, commandtype, parameter);
            });
        }
    }
}
