using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{ 
    public class CompanyNewsDAL
    {
        private const string SPGetCompanyNews = "GetCompanyNews";
        private const string SPGetNewContentByNewTittle = "GetNewContentByNewTittle";
        private const string SPGetNewContentById = "GetNewContentById";
        private const string SPGetCompanyNewsIndex = "GetCompanyNewsIndex";
        private const string SPDelCompanyNewsById = "DelCompanyNewsById";

        public static DataSet GetCompanyNews(string index)
        {
            SqlParameter[] paras ={
                                      new SqlParameter("@index",index)
                                  };
            return Common.SqlHelper.ExecuteDataSet(SPGetCompanyNews, paras);
        }

        public static string GetNewContentByNewTittle(string newTittle)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@newTittle",newTittle)
                                };
            return (string)Common.SqlHelper.ExecuteScalar(SPGetNewContentByNewTittle, paras);
        }

        public static SqlDataReader GetNewContentById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteReader(SPGetNewContentById, paras);
        }

        public static int GetCompanyNewsIndex()
        {
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetCompanyNewsIndex, null).ToString());
        }

        public static int DelCompanyNewsById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPDelCompanyNewsById, paras);
        }
    }
}
