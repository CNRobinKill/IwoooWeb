using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.Admin
{
    public partial class PostRecruitment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"].ToString() == "SystemIwooo")
            {
                if (!IsPostBack)
                {
                    GvDatabind();
                }
            }
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        public void GvDatabind()
        {
            tbJoinUs.DataSource = DAL.JoinUsDAL.GetJoinUs();
            tbJoinUs.DataKeyNames = new string[] { "id" };
            tbJoinUs.DataBind();
            if (tbJoinUs.HeaderRow != null)
            {
                tbJoinUs.HeaderRow.Cells[0].Text = "招聘职位";
            }
        }

        protected void tbJoinUs_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Redirect("AddPostRecruitment.aspx?id=" + tbJoinUs.DataKeys[e.NewSelectedIndex].Value.ToString() + "&position=" + tbJoinUs.Rows[e.NewSelectedIndex].Cells[0].Text.Trim(), true);
        }

        protected void tbJoinUs_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DAL.JoinUsDAL.DelJoinUsById(tbJoinUs.DataKeys[e.RowIndex].Value.ToString());
            GvDatabind();
        }

        protected void btnAddPosition_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddPostRecruitment.aspx", true);
        }
    }
}