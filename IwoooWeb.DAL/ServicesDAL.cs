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
        private const string SPAddServices = "AddServices";
        private const string SPGetServicesById = "GetServicesById";
        private const string SPGetAllServices = "GetAllServices";
        private const string SPUpdServices = "UpdServices";
        private const string SPDelServicesById = "DelServicesById";


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

        public static int GetServicesIndex(string servicesType)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@servicesType",servicesType)
                                };
            return int.Parse(Common.SqlHelper.ExecuteScalar(SPGetServicesIndex, paras).ToString());
        }

        public static int AddServices(string servicesType, string servicesName, string servicesPhoto, string servicesContent)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@servicesType",servicesType),
                                    new SqlParameter("@servicesName",servicesName),
                                    new SqlParameter("@servicesPhoto",servicesPhoto),
                                    new SqlParameter("@servicesContent",servicesContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPAddServices, paras);
        }

        public static SqlDataReader GetServicesById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteReader(SPGetServicesById, paras);
        }

        public static DataSet GetAllServices()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetAllServices, null);
        }

        public static int UpdServices(string id, string servicesType, string servicesName, string servicesContent)
        {
            SqlParameter[] paras ={
                                      new SqlParameter("@id",id),
                                    new SqlParameter("@servicesType",servicesType),
                                    new SqlParameter("@servicesName",servicesName),
                                    new SqlParameter("@servicesContent",servicesContent)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPUpdServices, paras);
        }

        public static int DelServicesById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPDelServicesById, paras);
        }
    }
}
