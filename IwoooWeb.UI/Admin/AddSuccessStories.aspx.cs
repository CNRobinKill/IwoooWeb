using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace IwoooWeb.UI.Admin
{
    public partial class AddSuccessStories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["id"] != null)
                    {
                        btnUpdSuccessStories.Visible = true;
                        btnAddSuccessStories.Visible = false;
                        SetSuccessStories();
                    }
                    else
                    {
                        btnUpdSuccessStories.Visible = false;
                        btnAddSuccessStories.Visible = true;
                    }
                }
            }
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        public void SetSuccessStories()
        {

            OleDbDataReader dr = DAL.SuccessStoriesDAL.GetSuccessStoriesById(Request.QueryString["id"]);
            dr.Read();
            string successStoriesName = dr[0].ToString();
            string content = dr[1].ToString();
            string successStoriesYear = dr[2].ToString();
            dr.Close();
            txtSuccessStoriesName.Text = successStoriesName;
            txtSuccessStoriesYear.Text = successStoriesYear;
            ClientScript.RegisterStartupScript(this.Page.GetType(), "myscript", "<script>window.editor.ready(function(){ window.editor.setContent('" + content + "');});</script>");

        }

        protected void btnAddSuccessStories_Click(object sender, EventArgs e)
        {
            string content = Request.Form["myContent"];
            if (DAL.SuccessStoriesDAL.AddSuccessStories(txtSuccessStoriesName.Text.Trim(), content, txtSuccessStoriesYear.Text) > 0)
            {
                this.Response.Write("<script language=javascript>alert('Successfully');window.window.location.href='SuccessStoriesManagement.aspx';</script>");
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('Failed');</script>");
            }
        }

        protected void btnUpdSuccessStories_Click(object sender, EventArgs e)
        {
            string content = Request.Form["myContent"];
            if (DAL.SuccessStoriesDAL.UpdSuccessStoriesById(Request.QueryString["id"], txtSuccessStoriesName.Text.Trim(), content, txtSuccessStoriesYear.Text) > 0)
            {
                this.Response.Write("<script language=javascript>alert('Updated Successfully');window.window.location.href='SuccessStoriesManagement.aspx';</script>");
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('Updated Failed');</script>");
            }
        }
    }
}