using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class SoftWareDAL
    {
        private const string SPGetSoftWareType = "GetSoftWareType";
        private const string SPGetSoftWare = "GetSoftWare";
        private const string SPGetSoftWareContentBySoftWareName = "GetSoftWareContentBySoftWareName";
        private const string SPGetSoftWareIndex = "GetSoftWareIndex";

        public static DataSet GetSoftWareType()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetSoftWareType, null);
        }

        public static DataSet GetSoftWare(string softWareType, string index)
        {
            SqlParameter[] paras ={
                                      new SqlParameter("@softWareType",softWareType),
                                      new SqlParameter("@index",index)
                                  };
            return Common.SqlHelper.ExecuteDataSet(SPGetSoftWare, paras);
        }

        public static string GetSoftWareContentBySoftWareName(string softWareName)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@softWareName",softWareName)
                                };
            return (string)Common.SqlHelper.ExecuteScalar(SPGetSoftWareContentBySoftWareName, paras);
        }

        public static int GetSoftWareIndex()
        {
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetSoftWareIndex, null).ToString());
        }
    }
}
