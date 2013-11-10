using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.Admin
{
    public partial class LogOn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnLogOn_Click(object sender, EventArgs e)
        {
            if (txtUserName.Text.Trim() != "" && txtPassword.Text.Trim() != "")
            {
                SqlDataReader dr = DAL.SystemUserDAL.GetSystemUser();
                dr.Read();
                string userName = dr[0].ToString();
                string userPassword = dr[1].ToString();
                dr.Close();
                if (txtUserName.Text.Trim() == userName && txtPassword.Text.Trim() == userPassword)
                {
                    Session["userName"] = txtUserName.Text.Trim();
                    Session.Timeout = 6000;
                    Response.Redirect("SystemManagement.aspx",true);
                }
            }
        }
    }
}