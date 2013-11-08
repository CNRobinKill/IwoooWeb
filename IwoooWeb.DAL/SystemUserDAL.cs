using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class SystemUserDAL
    {
        private const string SPGetSystemUser = "GetSystemUser";
        private const string SPUpdSystemUser = "UpdSystemUser";


        public static SqlDataReader GetSystemUser()
        {
            return Common.SqlHelper.ExecuteReader(SPGetSystemUser, null);
        }

        public static int UpdSystemUser(string userName, string userPassword)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@userName",userName),
                                    new SqlParameter("@userPassword",userPassword)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPUpdSystemUser, paras);
        }

    }
}
