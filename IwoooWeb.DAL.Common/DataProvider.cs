using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace IwoooWeb.DAL.Common
{
    /// <summary>
    /// 数据库连接字符串
    /// </summary>
    public class DataProvider
    {
        private const string ConStr = "server=.;Database=IwoooWeb;User ID=sa; Password=1q2w3e4r";

        public static SqlConnection GetConnection()
        {
            return new SqlConnection(ConStr);
        }
    }
}
