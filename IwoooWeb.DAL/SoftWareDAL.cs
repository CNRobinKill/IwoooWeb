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
        private const string SPAddSoftWare = "AddSoftWare";
        private const string SPGetSoftWareById = "GetSoftWareById";
        private const string SPGetAllSoftWare = "GetAllSoftWare";
        private const string SPUpdSoftWare = "UpdSoftWare";
        private const string SPDelSoftWareById = "DelSoftWareById";

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

        public static int GetSoftWareIndex(string softWareType)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@softWareType",softWareType)
                                };
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetSoftWareIndex, paras).ToString());
        }

        public static int AddSoftWare(string softWareType, string softWareName, string softWarePhoto, string softWareContent)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@softWareType",softWareType),
                                    new SqlParameter("@softWareName",softWareName),
                                    new SqlParameter("@softWarePhoto",softWarePhoto),
                                    new SqlParameter("@softWareContent",softWareContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPAddSoftWare, paras);
        }

        public static SqlDataReader GetSoftWareById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteReader(SPGetSoftWareById, paras);
        }

        public static DataSet GetAllSoftWare()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetAllSoftWare, null);
        }

        public static int UpdSoftWare(string id, string softWareType, string softWareName, string softWareContent)
        {
            SqlParameter[] paras ={
                                      new SqlParameter("@id",id),
                                    new SqlParameter("@softWareType",softWareType),
                                    new SqlParameter("@softWareName",softWareName),
                                    new SqlParameter("@softWareContent",softWareContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPUpdSoftWare, paras);
        }

        public static int DelSoftWareById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPDelSoftWareById, paras);
        }
    }
}
