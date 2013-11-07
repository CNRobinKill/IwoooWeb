using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.Admin
{
    public partial class HomePageSetting : System.Web.UI.Page
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
            tbSlider.DataSource = DAL.SliderDAL.GetSlider();
            tbSlider.DataKeyNames = new string[] { "id" };
            tbSlider.DataBind();
            if (tbSlider.HeaderRow != null)
            {
                tbSlider.HeaderRow.Cells[0].Text = "Slider";
                tbSlider.HeaderRow.Cells[1].Text = "Link";
                tbSlider.HeaderRow.Cells[2].Text = "Photo";
            }
        }

        protected void tbSlider_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DAL.SliderDAL.DelSliderById(tbSlider.DataKeys[e.RowIndex].Value.ToString());
        }

        protected void btnAddSlider_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddSliders.aspx", true);
        }
    }
}