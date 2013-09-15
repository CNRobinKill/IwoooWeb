using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class SuccessStoriesDAL
    {
        private const string SPGetSuccessStories = "GetSuccessStories";

        public static DataSet GetSuccessStories()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetSuccessStories, null);
        }
    }
}
