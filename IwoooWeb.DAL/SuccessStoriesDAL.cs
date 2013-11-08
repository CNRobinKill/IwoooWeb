using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class SuccessStoriesDAL
    {

        private const string SPAddSuccessStories = "AddSuccessStories";
        private const string SPGetSuccessStories = "GetSuccessStories";
        private const string SPGetSuccessStoriesById = "GetSuccessStoriesById";
        private const string SPUpdSuccessStoriesById = "UpdSuccessStoriesById";
        private const string SPDelSuccessStoriesById = "DelSuccessStoriesById";



        public static int AddSuccessStories(string successStoriesName, string successStoriesContent, string successStoriesYear)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@successStoriesName",successStoriesName),
                                    new SqlParameter("@successStoriesContent",successStoriesContent),
                                    new SqlParameter("@successStoriesYear",successStoriesYear)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPAddSuccessStories, paras);
        }

        public static DataSet GetSuccessStories()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetSuccessStories, null);
        }

        public static SqlDataReader GetSuccessStoriesById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteReader(SPGetSuccessStoriesById, paras);
        }

        public static int UpdSuccessStoriesById(string id, string successStoriesName, string successStoriesContent, string successStoriesYear)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id),
                                    new SqlParameter("@successStoriesName",successStoriesName),
                                    new SqlParameter("@successStoriesContent",successStoriesContent),
                                    new SqlParameter("@successStoriesYear",successStoriesYear)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPUpdSuccessStoriesById, paras);
        }

        public static int DelSuccessStoriesById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPDelSuccessStoriesById, paras);
        }
    }
}
