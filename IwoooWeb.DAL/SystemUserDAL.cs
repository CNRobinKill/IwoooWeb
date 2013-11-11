using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class SystemUserDAL
    {
        //private const string SPGetSystemUser = "GetSystemUser";
        //private const string SPUpdSystemUser = "UpdSystemUser";


        public static OleDbDataReader GetSystemUser()
        {
            string sql = "select UserName,UserPassword from SystemUser where UserName='SystemIwooo'";
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static int UpdSystemUser(string userName, string userPassword)
        {
            string sql = "update SystemUser set UserPassword='" + userPassword + "' where UserName='" + userName + "'";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

    }
}
