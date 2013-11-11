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
    public class HardWareDAL
    {
        //private const string SPGetHardWareType = "GetHardWareType";
        //private const string SPGetHardWare = "GetHardWare";
        //private const string SPGetHardWareContentByHardWareName = "GetHardWareContentByHardWareName";
        //private const string SPGetHardWareIndex = "GetHardWareIndex";
        //private const string SPAddHardWare = "AddHardWare";
        //private const string SPGetHardWareById = "GetHardWareById";
        //private const string SPGetAllHardWare = "GetAllHardWare";
        //private const string SPUpdHardWare = "UpdHardWare";
        //private const string SPDelHardWareById = "DelHardWareById";

        public static DataSet GetHardWareType()
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static DataSet GetHardWare(string hardWareType, string index)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetHardWareContentByHardWareName(string hardWareName)
        {
            string sql = "";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static int GetHardWareIndex(string hardWareType)
        {
            string sql = "";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }

        public static int AddHardWare(string hardWareType, string hardWareName, string hardWarePhoto, string hardWareContent)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static OleDbDataReader GetHardWareById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static DataSet GetAllHardWare()
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static int UpdHardWare(string id, string hardWareType, string hardWareName, string hardWareContent)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelHardWareById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
