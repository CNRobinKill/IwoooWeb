using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.Admin
{
    public partial class SuccessStoriesManagement : System.Web.UI.Page
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
            tbSuccessStories.DataSource = DAL.SuccessStoriesDAL.GetSuccessStories();
            tbSuccessStories.DataKeyNames = new string[] { "id" };
            tbSuccessStories.DataBind();
            if (tbSuccessStories.HeaderRow != null)
            {
                tbSuccessStories.HeaderRow.Cells[0].Text = "案例名称";
                tbSuccessStories.HeaderRow.Cells[1].Text = "案例期";
            }
        }

        protected void tbSuccessStories_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Redirect("AddSuccessStories.aspx?id=" + tbSuccessStories.DataKeys[e.NewSelectedIndex].Value.ToString() + "&successStoriesName=" + tbSuccessStories.Rows[e.NewSelectedIndex].Cells[0].Text.Trim(), true);
        }

        protected void tbSuccessStories_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DAL.SuccessStoriesDAL.DelSuccessStoriesById(tbSuccessStories.DataKeys[e.RowIndex].Value.ToString());
            GvDatabind();
        }

        protected void btnAddSuccessStories_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSuccessStories.aspx", true);
        }
    }
}