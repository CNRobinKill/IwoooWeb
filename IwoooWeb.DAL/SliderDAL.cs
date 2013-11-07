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
        private const string SPAddSlider = "AddSlider";
        private const string SPGetSlider = "GetSlider";
        private const string SPDelSliderById = "DelSliderById";


        public static int AddSlider(string sliderName, string sliderContent, string sliderLink, string sliderPhoto)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@sliderName",sliderName),
                                    new SqlParameter("@sliderContent",sliderContent),
                                    new SqlParameter("@sliderLink",sliderLink),
                                    new SqlParameter("@sliderPhoto",sliderPhoto)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPAddSlider, paras);
        }

        public static DataSet GetSlider()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetSlider, null);
        }

        public static int DelSliderById(string id)
        {
            SqlParameter[] paras ={
                                    new SqlParameter("@id",id)
                                };
            return Common.SqlHelper.ExecuteNonQuery(SPDelSliderById, paras);
        }
    }
}
