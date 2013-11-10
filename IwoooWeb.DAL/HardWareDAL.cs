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
        private const string SPAddHardWare = "AddHardWare";
        private const string SPGetHardWareById = "GetHardWareById";
        private const string SPGetAllHardWare = "GetAllHardWare";
        private const string SPUpdHardWare = "UpdHardWare";
        private const string SPDelHardWareById = "DelHardWareById";

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

        public static int GetHardWareIndex(string hardWareType)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@hardWareType",hardWareType)
                                };
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetHardWareIndex, paras).ToString());
        }

        public static int AddHardWare(string hardWareType, string hardWareName, string hardWarePhoto, string hardWareContent)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@hardWareType",hardWareType),
                                    new SqlParameter("@hardWareName",hardWareName),
                                    new SqlParameter("@hardWarePhoto",hardWarePhoto),
                                    new SqlParameter("@hardWareContent",hardWareContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPAddHardWare, paras);
        }

        public static SqlDataReader GetHardWareById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteReader(SPGetHardWareById, paras);
        }

        public static DataSet GetAllHardWare()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetAllHardWare, null);
        }

        public static int UpdHardWare(string id, string hardWareType, string hardWareName, string hardWareContent)
        {
            SqlParameter[] paras ={
                                      new SqlParameter("@id",id),
                                    new SqlParameter("@hardWareType",hardWareType),
                                    new SqlParameter("@hardWareName",hardWareName),
                                    new SqlParameter("@hardWareContent",hardWareContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPUpdHardWare, paras);
        }

        public static int DelHardWareById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPDelHardWareById, paras);
        }
    }
}
