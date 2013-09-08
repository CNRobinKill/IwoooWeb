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
        private const string SPGetCompanyNewsIndex = "GetCompanyNewsIndex";

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
            return Common.SqlHelper.ExecuteScalar(SPGetNewContentByNewTittle, paras).ToString();
        }

        public static int GetCompanyNewsIndex()
        {
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetCompanyNewsIndex, null).ToString());
        }
    }
}
