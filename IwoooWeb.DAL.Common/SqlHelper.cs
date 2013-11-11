using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace IwoooWeb.DAL.Common
{

    /// <summary>
    /// Assess数据库通用逻辑组件
    /// </summary>
    public class SqlHelper
    {
        /// <summary>
        /// 多行查询（返回所有行）
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string sqlText)
        {
            DataSet ds = new DataSet();
            using (OleDbConnection con = DataProvider.GetConnection())
            {
                using (OleDbCommand com = new OleDbCommand())
                {
                    OleDbDataAdapter ad = new OleDbDataAdapter();
                    com.Connection = con;
                    ad.SelectCommand = com;
                    com.CommandText = sqlText;
                    com.CommandType = CommandType.Text;
                    com.CommandTimeout = 300;
                    con.Open();
                    ad.Fill(ds);
                    con.Close();
                }
            }
            return ds;
        }

        /// <summary>
        /// 单行查询（返回第一行）
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static OleDbDataReader ExecuteReader(string sqlText)
        {
            OleDbConnection con = DataProvider.GetConnection();
            OleDbCommand com = new OleDbCommand();
                com.Connection = con;
                com.CommandText = sqlText;
                com.CommandType = CommandType.Text;
                com.CommandTimeout = 300;
                con.Open();
                OleDbDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;        
        }

        /// <summary>
        /// 单值查询（返回第一行第一列）
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string sqlText)
        {
            object objectValue;
            using (OleDbConnection con = DataProvider.GetConnection())
            {
                using (OleDbCommand com = new OleDbCommand())
                {
                    com.Connection = con;
                    com.CommandText = sqlText;
                    com.CommandType = CommandType.Text;
                    com.CommandTimeout = 300;
                    con.Open();
                    objectValue = com.ExecuteScalar();
                    con.Close();
                }              
            }
            return objectValue;
        }

        /// <summary>
        /// 非查询（插入，修改，删除）
        /// </summary>
        /// <param name="sqlText"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string sqlText)
        {
            int rowsAffected;
            using (OleDbConnection con = DataProvider.GetConnection())
            {
                using (OleDbCommand com = new OleDbCommand())
                {
                    com.Connection = con;
                    com.CommandText = sqlText;
                    com.CommandType = CommandType.Text;
                    com.CommandTimeout = 300;
                    con.Open();
                    rowsAffected = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return rowsAffected;
        }
    }
}
