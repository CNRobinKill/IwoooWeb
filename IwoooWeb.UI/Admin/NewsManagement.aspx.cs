using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.Admin
{
    public partial class NewsManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                GvDatabind();
            }
        }

        public void GvDatabind()
        {
            tbCompanyNews.DataSource = DAL.CompanyNewsDAL.GetCompanyNews("All");
            tbCompanyNews.DataKeyNames = new string[] { "newTittle" };
            tbCompanyNews.DataBind();
            if (tbCompanyNews.HeaderRow != null)
            {
                tbCompanyNews.HeaderRow.Cells[0].Text = "#";
                tbCompanyNews.HeaderRow.Cells[1].Text = "Tittle";
                tbCompanyNews.HeaderRow.Cells[2].Text = "CreateTime";
            }
        }

        protected void tbCompanyNews_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Redirect("AddCompanyNews.aspx?tittle=" + tbCompanyNews.Rows[e.NewSelectedIndex].Cells[1].Text, true);
        }

        protected void btnAddNews_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddCompanyNews.aspx", true);
        }



    }
}