using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class HardWareDAL
    {
        private const string SPGetHardWareType = "GetHardWareType";
        private const string SPGetHardWare = "GetHardWare";
        private const string SPGetHardWareContentByHardWareName = "GetHardWareContentByHardWareName";
        private const string SPGetHardWareIndex = "GetHardWareIndex";

        public static DataSet GetHardWareType()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetHardWareType, null);
        }

        public static DataSet GetHardWare(string hardWareType, string index)
        {
            SqlParameter[] paras ={
                                      new SqlParameter("@hardWareType",hardWareType),
                                      new SqlParameter("@index",index)
                                  };
            return Common.SqlHelper.ExecuteDataSet(SPGetHardWare, paras);
        }

        public static string GetHardWareContentByHardWareName(string hardWareName)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@hardWareName",hardWareName)
                                };
            return (string)Common.SqlHelper.ExecuteScalar(SPGetHardWareContentByHardWareName, paras);
        }

        public static int GetHardWareIndex()
        {
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetHardWareIndex, null).ToString());
        }
    }
}
