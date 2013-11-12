using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.IO;

namespace IwoooWeb.UI.Admin
{
    public partial class AddSliders : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null)
            { }
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        protected void btnAddNews_Click(object sender, EventArgs e)
        {
            if (txtSliderName.Text.Trim() != "" && txtSliderContent.Text.Trim() != "" && txtSliderLink.Text.Trim() != "")
            {
                if (fuPic.HasFile)//上传控件命名为fuFILE了
                {
                    string path = Server.MapPath("~/uploadimg/slider/");//你要保存的目录
                    //if (!Directory.Exists(path))    //判断目录是否存在
                    //    Directory.CreateDirectory(path);
                    string name = fuPic.FileName;  //获取上传的文件名称
                    String ext = Path.GetExtension(fuPic.FileName).ToLower();  //获取上传文件的后缀名
                    String[] allowedExtensions = { ".gif", ".png", ".bmp", ".jpg" };
                    bool fileOK = false;
                    for (int i = 0; i < allowedExtensions.Length; i++)//判断是否是图片
                    {
                        if (ext == allowedExtensions[i])
                        {
                            fileOK = true;
                            break;
                        }
                    }
                    if (fileOK)//是图片上传
                    {
                        string newName = Guid.NewGuid() + ext; //重命名，防止重名文件
                        fuPic.SaveAs(path + newName);        //保存到服务器上了。
                        if (DAL.SliderDAL.AddSlider(txtSliderName.Text.Trim(), txtSliderContent.Text.Trim(), txtSliderLink.Text.Trim(), newName) > 0)
                        {
                            this.Response.Write("<script language=javascript>alert('添加成功！');window.window.location.href='HomePageSetting.aspx';</script>");
                        }
                    }
                }
            }
            else {
                this.Response.Write("<script language=javascript>alert('请输入完整数据！');</script>");
            }
        }


        //protected void btnUpdate_Click(object sender, EventArgs e)
        //{
        //    if (fuPic.HasFile)//上传控件命名为fuFILE了
        //    {
        //        string path = Server.MapPath("~/uploadimg/");//你要保存的目录
        //        //if (!Directory.Exists(path))    //判断目录是否存在
        //        //    Directory.CreateDirectory(path);
        //        string name = fuPic.FileName;  //获取上传的文件名称
        //        String ext = Path.GetExtension(fuPic.FileName).ToLower();  //获取上传文件的后缀名
        //        String[] allowedExtensions = { ".gif", ".png", ".bmp", ".jpg" };
        //        bool fileOK = false;
        //        for (int i = 0; i < allowedExtensions.Length; i++)//判断是否是图片
        //        {
        //            if (ext == allowedExtensions[i])
        //            {
        //                fileOK = true;
        //                break;
        //            }
        //        }
        //        if (fileOK)//是图片上传
        //        {
        //            string newName = Guid.NewGuid() + ext; //重命名，防止重名文件
        //            DAL.EventLogsDAL.UpdateUpLoadPic(eventNo, "", newName);
        //            DAL.SceneServiceProviderDAL.UpdateRemainToken(eventNo, "0");
        //            fuPic.SaveAs(path + newName);        //保存到服务器上了。
        //        }
        //    }
        //}
    }
}