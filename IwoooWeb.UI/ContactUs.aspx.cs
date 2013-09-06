using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI
{
    public partial class ContactUs : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        //protected void btnSendMseeage_Click(object sender, EventArgs e)
        //{
        //    if (txtName.Value.Trim() != "" || txtEmail.Value.Trim() != "" || txtTelphone.Value.Trim() != "" || txtComment.Value.Trim() != "")
        //    {
        //        string MailBody = "<div>发送时间：" + DateTime.Now.ToString() + "<br>访客姓名：" + txtName.Value + "<br>联系邮箱：" + txtEmail.Value + "<br>联系电话：" + txtTelphone.Value + "<br>询问内容：<br>" + txtComment.Value + "</div>";
        //        if (DAL.SendEmail.SendMail("yuebin20082008@sina.com", "smtp.sina.com", "yuebin2012", 25, "294233055@qq.com", "管理员", "公司网站在线留言", MailBody) == true)
        //        {
        //            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('留言成功');</script>");
        //        }
        //        else
        //        {
        //            Page.ClientScript.RegisterStartupScript(GetType(), "", "<script>alert('留言失败');</script>");
        //        }
        //    }
        //    else
        //    {
        //        Page.ClientScript.RegisterStartupScript(GetType(),"","<script>alert('所有信息都需填写')</script>");
        //    }
        //}
    }
}