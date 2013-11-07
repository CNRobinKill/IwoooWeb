using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.WebControl
{
    public partial class Slider : System.Web.UI.UserControl
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DAL.SliderDAL.GetSlider().Tables[0];
            string html = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string sliderName = dt.Rows[i][1].ToString();
                string sliderContent = dt.Rows[i][2].ToString();
                string sliderLink = dt.Rows[i][3].ToString();
                string sliderPhoto = dt.Rows[i][4].ToString();
                if (i == 0)
                {
                    html += "<div class='da-slide da-slide-fromright da-slide-current'><h2><span>" + sliderName + "</span></h2> <p>" + sliderContent + "</p><a href=\'" + sliderLink + "\' class='da-link'>Read more</a><div class='da-img'><img src=\'" + sliderPhoto + "\' alt=\'" + sliderName + "\'></div></div>";
                }
                if (i > 0)
                {
                    html += "<div class='da-slide da-slide-toleft'><h2><span>" + sliderName + "</span></h2> <p>" + sliderContent + "</p><a href=\'" + sliderLink + "\' class='da-link'>Read more</a><div class='da-img'><img src=\'" + sliderPhoto + "\' alt=\'" + sliderName + "\'></div></div>";
                }
            }
            html += "<nav class='da-arrows'><span class='da-arrows-prev'></span><span class='da-arrows-next'></span></nav><nav class='da-dots'><span class='da-dots-current'></span><span class=''></span><span class=''></span><span class=''></span></nav>";
            html = "<div id='da-slider' class='da-slider' style='background-position: 600% 0%;'>" + html + "</div>";
            upSlider.InnerHtml = html;
        }
    }
}