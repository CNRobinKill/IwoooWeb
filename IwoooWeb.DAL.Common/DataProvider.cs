using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace IwoooWeb.DAL.Common
{
    /// <summary>
    /// 数据库连接字符串
    /// </summary>
    public class DataProvider
    {
        //private const string ConStr = "server=.;Database=IwoooWeb;User ID=sa; Password=1q2w3e4r";
        //private const string ConStr = @"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + System.Web.HttpContext.Current.Server.MapPath(@"\Access\IwoooWeb.mdb");

        public static OleDbConnection GetConnection()
        {
            return new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + System.Web.HttpContext.Current.Server.MapPath(@"\Access\IwoooWeb.mdb"));
        }
    }
}
