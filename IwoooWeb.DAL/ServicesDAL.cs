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
    public class ServicesDAL
    {
        //private const string SPGetServicesType = "GetServicesType";
        //private const string SPGetServices = "GetServices";
        //private const string SPGetServicesContentByServicesName = "GetServicesContentByServicesName";
        //private const string SPGetServicesIndex = "GetServicesIndex";
        //private const string SPAddServices = "AddServices";
        //private const string SPGetServicesById = "GetServicesById";
        //private const string SPGetAllServices = "GetAllServices";
        //private const string SPUpdServices = "UpdServices";
        //private const string SPDelServicesById = "DelServicesById";


        public static DataSet GetServicesType()
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static DataSet GetServices(string servicesType, string index)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetServicesContentByServicesName(string servicesName)
        {
            string sql = "";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static int GetServicesIndex(string servicesType)
        {
            string sql = "";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }

        public static int AddServices(string servicesType, string servicesName, string servicesPhoto, string servicesContent)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static OleDbDataReader GetServicesById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static DataSet GetAllServices()
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static int UpdServices(string id, string servicesType, string servicesName, string servicesContent)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelServicesById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
