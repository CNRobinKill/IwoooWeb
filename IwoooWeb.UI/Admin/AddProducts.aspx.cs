using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Data.OleDb;

namespace IwoooWeb.UI.Admin
{
    public partial class AddProducts : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"].ToString() == "SystemIwooo")
            {
                if (!IsPostBack)
                {
                    if (Request.QueryString["id"] != null)
                    {
                        btnUpdProducts.Visible = true;
                        btnAddProducts.Visible = false;
                        if (Request.QueryString["type"] == "0")
                        {
                            ddlType.SelectedValue = "0";
                            SetHardWareProducts();
                        }
                        if (Request.QueryString["type"] == "1")
                        {
                            ddlType.SelectedValue = "1";
                            SetSoftWareProducts();
                        }
                        if (Request.QueryString["type"] == "2")
                        {
                            ddlType.SelectedValue = "2";
                            SetServicesProducts();
                        }
                        ddlType.Enabled = false;
                        fuPic.Enabled = false;
                        SetDdlProductType();
                        //SetProducts();
                    }
                    else
                    {
                        btnUpdProducts.Visible = false;
                        btnAddProducts.Visible = true;
                        ddlType.SelectedValue = "0";
                        SetDdlProductType();
                    }
                }
            }
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        public void SetDdlProductType()
        {
            if (ddlType.SelectedValue == "0")
            {
                ddlProductType.DataSource = DAL.HardWareDAL.GetHardWareType();
                ddlProductType.DataValueField = "hardWareType";
                ddlProductType.DataTextField = "hardWareType";
                ddlProductType.DataBind();
            }
            if (ddlType.SelectedValue == "1")
            {
                ddlProductType.DataSource = DAL.SoftWareDAL.GetSoftWareType();
                ddlProductType.DataValueField = "softWareType";
                ddlProductType.DataTextField = "softWareType";
                ddlProductType.DataBind();
            }
            if (ddlType.SelectedValue == "2")
            {
                ddlProductType.DataSource = DAL.ServicesDAL.GetServicesType();
                ddlProductType.DataValueField = "servicesType";
                ddlProductType.DataTextField = "servicesType";
                ddlProductType.DataBind();
            }
        }

        protected void ddlType_SelectedIndexChanged(object sender, EventArgs e)
        {
            SetDdlProductType();
        }

        protected void ddlProductType_DataBound(object sender, EventArgs e)
        {
            ddlProductType.Items.Insert(0, "");
        }

        public void SetHardWareProducts()
        {
            OleDbDataReader dr = DAL.HardWareDAL.GetHardWareById(Request.QueryString["id"]);
            dr.Read();
            string hardWareType = dr[0].ToString();
            string hardWareName = dr[1].ToString();
            string content = dr[3].ToString();
            dr.Close();
            ddlProductType.SelectedValue = hardWareType;
            txtProductName.Text = hardWareName;
            ClientScript.RegisterStartupScript(this.Page.GetType(), "myscript", "<script>window.editor.ready(function(){ window.editor.setContent('" + content + "');});</script>");
        }
        public void SetSoftWareProducts()
        {
            OleDbDataReader dr = DAL.SoftWareDAL.GetSoftWareById(Request.QueryString["id"]);
            dr.Read();
            string softWareType = dr[0].ToString();
            string softWareName = dr[1].ToString();
            string content = dr[3].ToString();
            dr.Close();
            ddlProductType.SelectedValue = softWareType;
            txtProductName.Text = softWareName;
            ClientScript.RegisterStartupScript(this.Page.GetType(), "myscript", "<script>window.editor.ready(function(){ window.editor.setContent('" + content + "');});</script>");
        }
        public void SetServicesProducts()
        {
            OleDbDataReader dr = DAL.ServicesDAL.GetServicesById(Request.QueryString["id"]);
            dr.Read();
            string servicesType = dr[0].ToString();
            string servicesName = dr[1].ToString();
            string content = dr[3].ToString();
            dr.Close();
            ddlProductType.SelectedValue = servicesType;
            txtProductName.Text = servicesName;
            ClientScript.RegisterStartupScript(this.Page.GetType(), "myscript", "<script>window.editor.ready(function(){ window.editor.setContent('" + content + "');});</script>");
        }

        protected void btnAddProducts_Click(object sender, EventArgs e)
        {
            if ((txtProductType.Text.Trim() != "" || ddlProductType.SelectedValue != "") && txtProductName.Text.Trim() != "")
            {
                string content = Request.Form["myContent"];
                if (fuPic.HasFile)//上传控件命名为fuFILE了
                {
                    string path = Server.MapPath("~/uploadimg/product/");//你要保存的目录
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
                        if (ddlType.SelectedValue == "0")
                        {
                            if (DAL.HardWareDAL.AddHardWare(ddlProductType.SelectedValue == "" ? txtProductType.Text.Trim() : ddlProductType.SelectedValue, txtProductName.Text.Trim(), newName, content) > 0)
                            {
                                this.Response.Write("<script language=javascript>alert('添加成功！');window.window.location.href='ProductManagement.aspx';</script>");
                            }
                        }
                        if (ddlType.SelectedValue == "1")
                        {
                            if (DAL.SoftWareDAL.AddSoftWare(ddlProductType.SelectedValue == "" ? txtProductType.Text.Trim() : ddlProductType.SelectedValue, txtProductName.Text.Trim(), newName, content) > 0)
                            {
                                this.Response.Write("<script language=javascript>alert('添加成功！');window.window.location.href='ProductManagement.aspx';</script>");
                            }
                        }
                        if (ddlType.SelectedValue == "2")
                        {
                            if (DAL.ServicesDAL.AddServices(ddlProductType.SelectedValue == "" ? txtProductType.Text.Trim() : ddlProductType.SelectedValue, txtProductName.Text.Trim(), newName, content) > 0)
                            {
                                this.Response.Write("<script language=javascript>alert('添加成功！');window.window.location.href='ProductManagement.aspx';</script>");
                            }
                        }
                    }
                }
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('请输入完整数据！');</script>");
            }
        }

        protected void btnUpdProducts_Click(object sender, EventArgs e)
        {
            if ((txtProductType.Text.Trim() != "" || ddlProductType.SelectedValue != "") && txtProductName.Text.Trim() != "")
            {
                string content = Request.Form["myContent"];
                if (ddlType.SelectedValue == "0")
                {
                    if (DAL.HardWareDAL.UpdHardWare(Request.QueryString["id"], ddlProductType.SelectedValue == "" ? txtProductType.Text.Trim() : ddlProductType.SelectedValue, txtProductName.Text.Trim(), content) > 0)
                    {
                        this.Response.Write("<script language=javascript>alert('修改成功！');window.window.location.href='ProductManagement.aspx';</script>");
                    }
                }
                if (ddlType.SelectedValue == "1")
                {
                    if (DAL.SoftWareDAL.UpdSoftWare(Request.QueryString["id"], ddlProductType.SelectedValue == "" ? txtProductType.Text.Trim() : ddlProductType.SelectedValue, txtProductName.Text.Trim(), content) > 0)
                    {
                        this.Response.Write("<script language=javascript>alert('修改成功！');window.window.location.href='ProductManagement.aspx';</script>");
                    }
                }
                if (ddlType.SelectedValue == "2")
                {
                    if (DAL.ServicesDAL.UpdServices(Request.QueryString["id"], ddlProductType.SelectedValue == "" ? txtProductType.Text.Trim() : ddlProductType.SelectedValue, txtProductName.Text.Trim(), content) > 0)
                    {
                        this.Response.Write("<script language=javascript>alert('修改成功！');window.window.location.href='ProductManagement.aspx';</script>");
                    }
                }
            }
            else
            {
                this.Response.Write("<script language=javascript>alert('请输入完整数据！');</script>");
            }
        }

    }
}