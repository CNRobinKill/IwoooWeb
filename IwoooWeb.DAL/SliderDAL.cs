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
            string sliderOrder = GetCountSlider();
            string sql = "insert into Slider(sliderName,sliderContent,sliderLink,sliderPhoto,sliderOrder) values('" + sliderName + "','" + sliderContent + "','" + sliderLink + "','" + sliderPhoto + "','"+sliderOrder+"')";
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static DataSet GetSlider()
        {
            string sql = "select id,sliderName,sliderContent,sliderLink,sliderPhoto from Slider  order by sliderOrder";
            return Common.SqlHelper.ExecuteDataSet(sql);
        }

        public static int DelSliderById(string id)
        {
            string sql = "delete from Slider where id=" + id;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }

        public static string GetCountSlider()
        {
            string sql = "select count(id) from Slider";
            return Common.SqlHelper.ExecuteScalar(sql).ToString();
        }

        public static string GetSliderOrder(string id)
        {
            string sql = "select sliderOrder from Slider where id=" + id;
            return Common.SqlHelper.ExecuteScalar(sql).ToString();
        }

        public static int UpdSliderOrder(string id)
        {
            string sliderOrder = GetSliderOrder(id);
            DelSliderById(id);
            string sql = "update Slider set sliderOrder=sliderOrder-1 where sliderOrder>" + sliderOrder;
            return Common.SqlHelper.ExecuteNonQuery(sql);
        }


    }
}
