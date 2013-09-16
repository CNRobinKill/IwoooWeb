using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IwoooWeb.DAL
{
    public class SliderDAL
    {
        private const string SPGetSlider = "GetSlider";

        public static DataSet GetSlider()
        {
            return Common.SqlHelper.ExecuteDataSet(SPGetSlider, null);
        }
    }
}
