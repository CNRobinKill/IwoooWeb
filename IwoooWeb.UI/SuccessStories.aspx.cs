using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI
{
    public partial class SuccessStories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            DataTable dt = DAL.SuccessStoriesDAL.GetSuccessStories().Tables[0];
            string html = "";
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                string successStoriesName = dt.Rows[i][1].ToString();
                string successStoriesContent = dt.Rows[i][2].ToString();
                string successStoriesYear = dt.Rows[i][3].ToString();
                string collapse = "collapse" + i.ToString();
                html += "<div class='accordion-group'><div class='accordion-heading'><a class='accordion-toggle collapsed' data-toggle='collapse' data-parent='#accordion2' href='#" + collapse + "'><h5>" + successStoriesName + "</h5></a> </div><div id='" + collapse + "' class='accordion-body collapse' style='height: 0px;'> <div class='accordion-inner'><span>案例期：" + successStoriesYear + "</span>" + successStoriesContent + "</div></div></div>";
            }
            accordion2.InnerHtml = html;
        }
    }
}