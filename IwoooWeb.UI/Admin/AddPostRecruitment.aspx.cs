using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace IwoooWeb.UI.Admin
{
    public partial class AddPostRecruitment : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null && Session["userName"].ToString() == "SystemIwooo")
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["id"] != null)
                    {
                        btnUpdPosition.Visible = true;
                        btnAddPosition.Visible = false;
                        SetPosition();
                    }
                    else
                    {
                        btnUpdPosition.Visible = false;
                        btnAddPosition.Visible = true;
                    }
                }
            }
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        public void SetPosition()
        {

            string position = Request.QueryString["position"];
            string content = DAL.JoinUsDAL.GetPositionContentByPosition(Request.QueryString["position"]);
            txtPosition.Text = position;
            ClientScript.RegisterStartupScript(this.Page.GetType(), "myscript", "<script>window.editor.ready(function(){ window.editor.setContent('" + content + "');});</script>");

        }

        protected void btnAddPosition_Click(object sender, EventArgs e)
        {
            string content = Request.Form["myContent"];
            if (DAL.JoinUsDAL.AddJoinUs(txtPosition.Text.Trim(),content) > 0)
            {
                this.Response.Write("<script language=javascript>alert('Successfully');window.window.location.href='PostRecruitment.aspx';</script>");
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('Failed');</script>");
            }
        }

        protected void btnUpdPosition_Click(object sender, EventArgs e)
        {
            string content = Request.Form["myContent"];
            if (DAL.JoinUsDAL.UpdJoinUsById(Request.QueryString["id"], txtPosition.Text.Trim(), content) > 0)
            {
                this.Response.Write("<script language=javascript>alert('Updated Successfully');window.window.location.href='PostRecruitment.aspx';</script>");
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('Updated Failed');</script>");
            }
        }
    }
}