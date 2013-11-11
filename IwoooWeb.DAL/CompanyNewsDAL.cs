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
    public class CompanyNewsDAL
    {
        //private const string SPAddCompanyNews = "AddCompanyNews";
        //private const string SPGetCompanyNews = "GetCompanyNews";
        //private const string SPGetNewContentByNewTittle = "GetNewContentByNewTittle";
        //private const string SPGetNewContentById = "GetNewContentById";
        //private const string SPGetCompanyNewsIndex = "GetCompanyNewsIndex";
        //private const string SPDelCompanyNewsById = "DelCompanyNewsById";
        //private const string SPUpdCompanyNewsById = "UpdCompanyNewsById";


        public static int AddCompanyNews(string newTittle, string newContent, string newDate)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static DataSet GetCompanyNews(string index)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetNewContentByNewTittle(string newTittle)
        {
            string sql = "";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static OleDbDataReader GetNewContentById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static int GetCompanyNewsIndex()
        {
            string sql = "";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }

        public static int DelCompanyNewsById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int UpdCompanyNewsById(string id, string newTittle, string newContent)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
