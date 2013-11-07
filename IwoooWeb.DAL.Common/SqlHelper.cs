using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace IwoooWeb.DAL.Common
{

    /// <summary>
    /// 数据库通用逻辑组件
    /// </summary>
    public class SqlHelper
    {
        /// <summary>
        /// 多行查询（返回所有行）
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static DataSet ExecuteDataSet(string spName, SqlParameter[] paras)
        {
            DataSet ds = new DataSet();
            using(SqlConnection con= DataProvider.GetConnection())
            {
                using (SqlCommand com=new SqlCommand())
                {
                    SqlDataAdapter ad=new SqlDataAdapter();
                    com.Connection = con;
                    ad.SelectCommand = com;
                    com.CommandText = spName;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandTimeout = 300;
                    if (paras != null)
                    {
                        com.Parameters.AddRange(paras);
                    }
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
        /// <param name="spName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static SqlDataReader ExecuteReader(string spName, SqlParameter[] paras)
        {
                SqlConnection con = DataProvider.GetConnection();
                SqlCommand com = new SqlCommand();
                com.Connection = con;
                com.CommandText = spName;
                com.CommandType = CommandType.StoredProcedure;
                com.CommandTimeout = 300;
                if (paras != null)
                {
                    com.Parameters.AddRange(paras);
                }
                con.Open();
                SqlDataReader reader = com.ExecuteReader(CommandBehavior.CloseConnection);
                return reader;        
        }

        /// <summary>
        /// 单值查询（返回第一行第一列）
        /// </summary>
        /// <param name="spName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static object ExecuteScalar(string spName, SqlParameter[] paras)
        {
            object objectValue;
            using (SqlConnection con = DataProvider.GetConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = spName;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandTimeout = 300;
                    if (paras != null)
                    {
                        com.Parameters.AddRange(paras);
                    }
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
        /// <param name="spName"></param>
        /// <param name="paras"></param>
        /// <returns></returns>
        public static int ExecuteNonQuery(string spName, SqlParameter[] paras)
        {
            int rowsAffected;
            using (SqlConnection con = DataProvider.GetConnection())
            {
                using (SqlCommand com = new SqlCommand())
                {
                    com.Connection = con;
                    com.CommandText = spName;
                    com.CommandType = CommandType.StoredProcedure;
                    com.CommandTimeout = 300;
                    if (paras != null)
                    {
                        com.Parameters.AddRange(paras);
                    }
                    con.Open();
                    rowsAffected = com.ExecuteNonQuery();
                    con.Close();
                }
            }
            return rowsAffected;
        }
    }
}
