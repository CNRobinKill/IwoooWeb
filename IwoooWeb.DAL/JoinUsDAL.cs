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

        //private const string SPAddJoinUs = "AddJoinUs";
        //private const string SPGetJoinUs = "GetJoinUs";
        //private const string SPGetPositionContentByPosition = "GetPositionContentByPosition";
        //private const string SPUpdJoinUsById = "UpdJoinUsById";
        //private const string SPDelJoinUsById = "DelJoinUsById";



        public static int AddJoinUs(string position, string positionContent)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static DataSet GetJoinUs()
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetPositionContentByPosition(string position)
        {
            string sql = "";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static int UpdJoinUsById(string id, string position, string positionContent)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelJoinUsById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
