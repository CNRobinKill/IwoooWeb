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
            string sql = "select servicesType from [Services] group by servicesType order by servicesType";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static DataSet GetServices(string servicesType, string index)
        {
            string sql = "select *  from (select count(a.id) as row,a.servicesName,a.servicesPhoto from (select * from Services where servicesType='" + servicesType + "') a left join (select * from Services where servicesType='" + servicesType + "') b on a.id >= b.id group by a.servicesName,a.servicesPhoto)n where n.row>9*(" + index + "-1) and n.row<9*" + index + "+1 order by n.servicesName";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static string GetServicesContentByServicesName(string servicesName)
        {
            string sql = "select servicesContent from [Services] where servicesName='" + servicesName + "'";
            return (string)Common.SqlHelper.ExecuteScalar(sql);
        }

        public static int GetServicesIndex(string servicesType)
        {
            string sql = "select  int(IIF( MAX(rNo) mod 9 = 0,MAX(rNo) / 9 , MAX(rNo) / 9 + 1)) as rIndex from (select a.id, count(*) as rNo from (select * from Services where servicesType='" + servicesType + "') a inner join (select * from Services where servicesType='" + servicesType + "') b on a.id >= b.id group by a.id ) as t";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }

        public static int AddServices(string servicesType, string servicesName, string servicesPhoto, string servicesContent)
        {
            string sql = "insert into [Services](servicesType,servicesName,servicesPhoto,servicesContent) values ('" + servicesType + "','" + servicesName + "','" + servicesPhoto + "','" + servicesContent + "')";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static OleDbDataReader GetServicesById(string id)
        {
            string sql = "select servicesType,servicesName,servicesPhoto,servicesContent from [Services] where id=" + id;
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static DataSet GetAllServices()
        {
            string sql = "select id,servicesType,servicesName,servicesPhoto,servicesContent from [Services] order by servicesType";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static int UpdServices(string id, string servicesType, string servicesName, string servicesContent)
        {
            string sql = "update [Services] set servicesType='" + servicesType + "',servicesName='" + servicesName + "',servicesContent='" + servicesContent + "' where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelServicesById(string id)
        {
            string sql = "delete from [Services] where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
