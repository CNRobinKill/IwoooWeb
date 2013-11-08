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

        private const string SPAddJoinUs = "AddJoinUs";
        private const string SPGetJoinUs = "GetJoinUs";
        private const string SPGetPositionContentByPosition = "GetPositionContentByPosition";
        private const string SPUpdJoinUsById = "UpdJoinUsById";
        private const string SPDelJoinUsById = "DelJoinUsById";



        public static int AddJoinUs(string position, string positionContent)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@position",position),
                                    new SqlParameter("@positionContent",positionContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPAddJoinUs, paras);
        }

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

        public static int UpdJoinUsById(string id, string position, string positionContent)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id),
                                    new SqlParameter("@position",position),
                                    new SqlParameter("@positionContent",positionContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPUpdJoinUsById, paras);
        }

        public static int DelJoinUsById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPDelJoinUsById, paras);
        }
    }
}
