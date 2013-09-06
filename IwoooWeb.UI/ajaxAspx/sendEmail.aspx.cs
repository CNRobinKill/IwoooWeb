using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.ajaxAspx
{
    public partial class sendEmail : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string MailBody = "<div>发送时间：" + DateTime.Now.ToString() + "<br>访客姓名：" + Request.QueryString["txtName"].Trim() + "<br>联系邮箱：" + Request.QueryString["txtEmail"].Trim() + "<br>联系电话：" + Request.QueryString["txtTelphone"].Trim() + "<br>询问内容：<br>" + Request.QueryString["txtComment"].Trim() + "</div>";
            if (DAL.SendEmail.SendMail("yuebin20082008@sina.com", "smtp.sina.com", "yuebin2012", 25, "294233055@qq.com", "管理员", "公司网站在线留言", MailBody) == true)
            {
                Response.Write("1");
            }
            else
            {
                Response.Write("0");
            }
        }
    }
}