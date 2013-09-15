using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class JoinUsDAL
    {
        private const string SPGetJoinUs = "GetJoinUs";
        private const string SPGetPositionContentByPosition = "GetPositionContentByPosition";


        public static DataSet GetJoinUs()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetJoinUs, null);
        }

        public static string GetPositionContentByPosition(string position)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@position",position)
                                };
            return (string)Common.SqlHelper.ExecuteScalar(SPGetPositionContentByPosition, paras);
        }

    }
}
