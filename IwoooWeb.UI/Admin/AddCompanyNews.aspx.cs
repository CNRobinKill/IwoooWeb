using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.Admin
{
    public partial class AddCompanyNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["id"] != null)
                {
                    btnUpdNews.Visible = true;
                    btnAddNews.Visible = false;
                    SetCompanyNews();
                }
                else
                {
                    btnUpdNews.Visible = false;
                    btnAddNews.Visible = true;
                }
            }
        }

        public void SetCompanyNews()
        {
            txtTittle.Text = DAL.CompanyNewsDAL.GetNewContentById(Request.QueryString["id"])[0].ToString();
        }

        protected void btnAddNews_Click(object sender, EventArgs e)
        {

        }

        protected void btnUpdNews_Click(object sender, EventArgs e)
        {

        }
    }
}