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
    public partial class SystemManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"].ToString() == "SystemIwooo")
            {
                if (!IsPostBack)
                {
                    lblSystemID.Text = SetSystemUser(0);
                }
            }
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        public string SetSystemUser(int n)
        {
            OleDbDataReader dr = DAL.SystemUserDAL.GetSystemUser();
            dr.Read();
            string reader = dr[n].ToString();
            dr.Close();
            return reader;
        }

        protected void btnUpa_Click(object sender, EventArgs e)
        {
            if (lblSystemID.Text == SetSystemUser(0) && txtPassword.Text.Trim() == SetSystemUser(1))
            {
                if (txtNewPassword.Text.Trim() != "" && txtRePassword.Text.Trim() != "" && txtNewPassword.Text.Trim() == txtRePassword.Text.Trim() && txtNewPassword.Text.Trim() != txtPassword.Text.Trim())
                {
                    DAL.SystemUserDAL.UpdSystemUser(lblSystemID.Text, txtNewPassword.Text.Trim());
                    this.Response.Write("<script language=javascript>alert('密码修改成功！');</script>");
                }
                else
                {
                    this.Response.Write("<script language=javascript>alert('新密码设置不规范或两次输入不一致！');</script>");
                }
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('原密码错误！');</script>");
            }
        }
    }
}