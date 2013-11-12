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
    public partial class AddCompanyNews : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
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
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        public void SetCompanyNews()
        {
            OleDbDataReader dr=DAL.CompanyNewsDAL.GetNewContentById(Request.QueryString["id"]);
            dr.Read();
            string tittle = dr[0].ToString();
            string content = dr[1].ToString();
            dr.Close();
            txtTittle.Text = tittle;
            ClientScript.RegisterStartupScript(this.Page.GetType(), "myscript", "<script>window.editor.ready(function(){ window.editor.setContent('" + content + "');});</script>");
            
        }

        protected void btnAddNews_Click(object sender, EventArgs e)
        {
            string content = Request.Form["myContent"];
            if (DAL.CompanyNewsDAL.AddCompanyNews(txtTittle.Text.Trim(), content, DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")) > 0)
            {
                this.Response.Write("<script language=javascript>alert('Successfully');window.window.location.href='NewsManagement.aspx';</script>");
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('Failed');</script>");
            }
        }

        protected void btnUpdNews_Click(object sender, EventArgs e)
        {
            string content = Request.Form["myContent"];
            if (DAL.CompanyNewsDAL.UpdCompanyNewsById(Request.QueryString["id"], txtTittle.Text.Trim(), content) > 0)
            {
                this.Response.Write("<script language=javascript>alert('Updated Successfully');window.window.location.href='NewsManagement.aspx';</script>");
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('Updated Failed');</script>");
            }
        }
    }
}