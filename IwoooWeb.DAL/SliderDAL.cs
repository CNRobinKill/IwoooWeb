using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class SliderDAL
    {
        //private const string SPAddSlider = "AddSlider";
        //private const string SPGetSlider = "GetSlider";
        //private const string SPDelSliderById = "DelSliderById";


        public static int AddSlider(string sliderName, string sliderContent, string sliderLink, string sliderPhoto)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static DataSet GetSlider()
        {
            string sql = "";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static int DelSliderById(string id)
        {
            string sql = "";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }
    }
}
