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
    public class SuccessStoriesDAL
    {

        //private const string SPAddSuccessStories = "AddSuccessStories";
        //private const string SPGetSuccessStories = "GetSuccessStories";
        //private const string SPGetSuccessStoriesById = "GetSuccessStoriesById";
        //private const string SPUpdSuccessStoriesById = "UpdSuccessStoriesById";
        //private const string SPDelSuccessStoriesById = "DelSuccessStoriesById";



        public static int AddSuccessStories(string successStoriesName, string successStoriesContent, string successStoriesYear)
        {
            if (GetSuccessStoriesName(successStoriesName) == 0)
            {
                string sql = "insert into SuccessStories(successStoriesName,successStoriesContent,successStoriesYear) values('" + successStoriesName + "','" + successStoriesContent + "','" + successStoriesYear + "')";
                return Common.SqlHelper.ExecuteNonQuery(sql);
            }
            else
            {
                return 0;
            }
        }

        public static DataSet GetSuccessStories()
        {
            string sql = "select id,successStoriesName,successStoriesContent,successStoriesYear from SuccessStories  order by Clng(successStoriesYear)";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static OleDbDataReader GetSuccessStoriesById(string id)
        {
            string sql = "select successStoriesName,successStoriesContent,successStoriesYear from SuccessStories where id=" + id;
            return Common.SqlHelper.ExecuteReader(sql);
        }

        public static int UpdSuccessStoriesById(string id, string successStoriesName, string successStoriesContent, string successStoriesYear)
        {
            string sql = "update SuccessStories set successStoriesName='" + successStoriesName + "',successStoriesContent='" + successStoriesContent + "',successStoriesYear='" + successStoriesYear + "' where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int DelSuccessStoriesById(string id)
        {
            string sql = "delete from SuccessStories where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static int GetSuccessStoriesName(string successStoriesName)
        {
            string sql = "select count(successStoriesName) from SuccessStories where successStoriesName='" + successStoriesName + "'";
            return int.Parse(Common.SqlHelper.ExecuteScalar(sql).ToString());
        }
    }
}
