using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class ServicesDAL
    {
        private const string SPGetServicesType = "GetServicesType";
        private const string SPGetServices = "GetServices";
        private const string SPGetServicesContentByServicesName = "GetServicesContentByServicesName";
        private const string SPGetServicesIndex = "GetServicesIndex";


        public static DataSet GetServicesType()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetServicesType, null);
        }

        public static DataSet GetServices(string servicesType, string index)
        {
            SqlParameter[] paras ={
                                      new SqlParameter("@servicesType",servicesType),
                                      new SqlParameter("@index",index)
                                  };
            return Common.SqlHelper.ExecuteDataSet(SPGetServices, paras);
        }

        public static string GetServicesContentByServicesName(string servicesName)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@servicesName",servicesName)
                                };
            return (string)Common.SqlHelper.ExecuteScalar(SPGetServicesContentByServicesName, paras);
        }

        public static int GetServicesIndex()
        {
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetServicesIndex, null).ToString());
        }
    }
}
