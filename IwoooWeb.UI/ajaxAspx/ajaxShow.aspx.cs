﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.ajaxAspx
{
    public partial class CompanyIntroduction : System.Web.UI.Page
    {
        string hint = string.Empty;

        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Request.QueryString["q"] != null)
                {
                    string q = Request.QueryString["q"];
                    if (q == "CompanyIntroduction")
                    {
                        hint = "<!--CompanyIntroduction--><div class='row'><div class='span12'>  <div class='well c-soon' style='text-align:left'><p><span class='color' style='font-size:18px'><b>爱沃计算机科技有限公司</b></span>(<a href='http://www.iwooo.com'>www.iwooo.com</a>) 是致力于为国内外企业提供世界领先的、全方位企业信息化专业服务信息技术提供商。作为INFOR、IBM中国合作伙伴，在市场份额、成功案例和顾问规模等方面均位居前列，在业内树立了IT技术、服务、尤其是INFOR产品专业服务的优良口碑。在服务领域，我们为企业客户提供以INFOR为核心、具备国际专业标准和本地特点的全方位专业服务，包括：管理与业务流程咨询、企业IT规划、INFOR ERP实施及INFOR全系列新技术实施、INFOR运维和支持、客户培训等服务业务。面向行业客户，我们提供安全、可靠、高质量、易扩展的行业解决方案，帮助客户实现信息化管理最佳实践，以满足客户需求。行业解决方案涵盖的领域包括：机械、电子、能源电力、汽车、制药、化工、钢铁、高科技、快速消费品、金融保险、电信等行业。爱沃将“品质、服务、创新”作为公司的经营思想和品牌承诺。作为一家以信息技术服务为核心的公司， 爱沃通过开放式创新、卓越运营管理、人力资源发展等战略的实施，全面构造公司的核心竞争力，创造客户和社会的价值。爱沃致力于成为行业领先、受社会认可、客户信赖、投资者和员工尊敬的企业信息化服务提供商，并通过组织与过程的持续改进、领导力与员工竞争力发展、联盟和开放式创新，使爱沃成为中国IT服务领域的领先公司。</p></div></div></div>";                        
                    }

                    if (q == "CompanyNews")
                    {
                        tbCompanyNews.DataSource = DAL.CompanyNewsDAL.GetCompanyNews("1");
                        tbCompanyNews.DataKeyNames = new string[] { "newTittle" };
                        tbCompanyNews.DataBind();
                        if (tbCompanyNews.HeaderRow != null)
                        {
                            tbCompanyNews.HeaderRow.Cells[0].Text = "#";
                            tbCompanyNews.HeaderRow.Cells[1].Text = "Tittle";
                            tbCompanyNews.HeaderRow.Cells[2].Text = "CreateTime";
                        }

                        string ajaxHttp1 = GridViewToHtml(tbCompanyNews);
                        //string ajaxHttp2 = divCountLine.InnerHtml;
                        //int a = ajaxHttp2.IndexOf("<!--CountLine-->");
                        //int b = ajaxHttp2.IndexOf("<!--CountLineEnd-->") + 10;
                        ajaxHttp1 = ajaxHttp1.Replace("\n", "").Replace("\r", "");
                        int index = DAL.CompanyNewsDAL.GetCompanyNewsIndex();
                        string http2 = "<span class='current' style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">1</span>";
                        if (index <= 10)
                        {
                            for (int i = 1; i < index; i++)
                            {
                                int n = i + 1;
                                http2 += "<span style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">" + n + "</span>";
                            }
                        }
                        else
                        {
                            for (int i = 1; i < 5; i++)
                            {
                                int n = i + 1;
                                http2 += "<span style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">" + n + "</span>";
                            }
                            http2 = http2 + "<span class='dots'>…</span>";
                            for (int i = index-4; i < index; i++)
                            {
                                int n = i + 1;
                                http2 += "<span style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">" + n + "</span>";
                            }
                        }
                        http2 = http2 + "<span style='cursor:pointer' onclick=\"selectIndex(parseInt($('#hideIndex').text())+1,0)\">Next</span>";
                        //ajaxHttp2 = ajaxHttp2.Substring(a, b).Replace("\n", "").Replace("\r", "");
                        string ajaxHttp2 = "<!--CountLine--><div class='paging'>" + http2 + "</div><!--CountLineEnd-->";
                        hint = "<!--CompanyNews--><!--CompanyNewsTable--><div id='companyNewsTable'>" + ajaxHttp1 + "</div><!--CompanyNewsTableEnd-->" + ajaxHttp2 + "<!--CompanyNewsEnd-->\r";
                        //hint = "<!--CompanyNews-->";
                    }

                    if (q == "JoinUs")
                    {

                        //string ajaxHttp = strContent.InnerHtml;
                        //int a = ajaxHttp.IndexOf("<!--JoinUs-->");
                        //int b = ajaxHttp.IndexOf("<!--JoinUsEnd-->") + 10;
                        //ajaxHttp = ajaxHttp.Substring(a, b).Replace("\n","").Replace("\r","").Replace("\\","");
                        //hint = ajaxHttp + "\r";
                        string liText = "";
                        for(int i=0;i<4;i++)
                        {
                            string text = ".Net软件开发工程师" + i;
                            liText += "<li style='cursor:pointer' onclick='listLiComment(" + "\"" + text + "\"" + ")'>" + text + "</li>";
                        }
                        string li = liText;
                        string liComment = "";
                        hint = "<!--JoinUs--> <!--JoinUsLi--><div class='price-a pricel center' style='width:240px;float:left'> <div class='phead-top b-blue'>  <h4>我们正在寻找</h4>    </div>  <div class='phead-bottom'></div>  <div class='arrow-down'></div>  <div class='plist'>  <ul class='nav' style='font-weight:600;font-size:14px'>   <!--Li-->" + li + "<!--LiEnd-->  </ul> </div> <div class='pbutton button'></div></div> <!--JoinUsLiEnd-->   <!--JoinUsLiComment--><div class='well c-soon' style=' width:600px;float:right' id='divLiComment'>" + liComment + "</div>  <!--JoinUsLiCommentEnd--> <!--JoinUsEnd-->";
                    }

                    if (hint == "")
                    {
                        Response.Write("页面出错，可能有非法值注入！");
                    }
                    else
                    {
                        Response.Write(hint);
                    }
                }
                if (Request.QueryString["r"] != null)
                {
                    string r = Request.QueryString["r"];
                    hint = "<!--" + Request.QueryString["r"] + "--><div>" + Request.QueryString["r"]+"</div>";
                    if (hint == "")
                    {
                        Response.Write("页面出错，可能有非法值注入！");
                    }
                    else
                    {
                        Response.Write(hint);
                    }
                }
                if (Request.QueryString["n"] != null)
                {
                    string n = Request.QueryString["n"];
                    hint = "<div><button class='btn' onclick=\"selectIndex($(\'#hideIndex\').text(),1)\">返回</button></div>" + DAL.CompanyNewsDAL.GetNewContentByNewTittle(n);
                    if (hint == "")
                    {
                        Response.Write("页面出错，可能有非法值注入！");
                    }
                    else
                    {
                        Response.Write(hint);
                    }
                }
                if (Request.QueryString["i"] != null && Request.QueryString["j"]=="1")
                {
                    string idx = Request.QueryString["i"];
                    tbCompanyNews.DataSource = DAL.CompanyNewsDAL.GetCompanyNews(idx);
                    tbCompanyNews.DataKeyNames = new string[] { "newTittle" };
                    tbCompanyNews.DataBind();
                    if (tbCompanyNews.HeaderRow != null)
                    {
                        tbCompanyNews.HeaderRow.Cells[0].Text = "#";
                        tbCompanyNews.HeaderRow.Cells[1].Text = "Tittle";
                        tbCompanyNews.HeaderRow.Cells[2].Text = "CreateTime";
                    }

                    string ajaxHttp1 = GridViewToHtml(tbCompanyNews);
                    ajaxHttp1 = ajaxHttp1.Replace("\n", "").Replace("\r", "");
                    int index = DAL.CompanyNewsDAL.GetCompanyNewsIndex();
                    string http2 = "<span style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">1</span>";
                    if (index <= 10)
                    {
                        for (int i = 1; i < index; i++)
                        {
                            int n = i + 1;
                            http2 += "<span style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">" + n + "</span>";
                        }
                    }
                    else
                    {
                        for (int i = 1; i < 5; i++)
                        {
                            int n = i + 1;
                            http2 += "<span style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">" + n + "</span>";
                        }
                        http2 = http2 + "<span class='dots'>…</span>";
                        for (int i = index - 4; i < index; i++)
                        {
                            int n = i + 1;
                            http2 += "<span style='cursor:pointer' onclick=\"selectIndex($(this).text(),0)\">" + n + "</span>";
                        }
                    }
                    http2 = http2 + "<span style='cursor:pointer' onclick=\"selectIndex(parseInt($('#hideIndex').text())+1,0)\">Next</span>";
                    string ajaxHttp2 = "<!--CountLine--><div class='paging'>" + http2 + "</div><!--CountLineEnd-->";
                    hint = "<!--CompanyNews--><!--CompanyNewsTable--><div id='companyNewsTable'>" + ajaxHttp1 + "</div><!--CompanyNewsTableEnd-->" + ajaxHttp2 + "<!--CompanyNewsEnd-->\r";
                    if (hint == "")
                    {
                        Response.Write("页面出错，可能有非法值注入！");
                    }
                    else
                    {
                        Response.Write(hint);
                    }
                }

                if (Request.QueryString["i"] != null && Request.QueryString["j"] == "0")
                {
                    string idx = Request.QueryString["i"];
                    tbCompanyNews.DataSource = DAL.CompanyNewsDAL.GetCompanyNews(idx);
                    tbCompanyNews.DataKeyNames = new string[] { "newTittle" };
                    tbCompanyNews.DataBind();
                    if (tbCompanyNews.HeaderRow != null)
                    {
                        tbCompanyNews.HeaderRow.Cells[0].Text = "#";
                        tbCompanyNews.HeaderRow.Cells[1].Text = "Tittle";
                        tbCompanyNews.HeaderRow.Cells[2].Text = "CreateTime";
                    }

                    string ajaxHttp1 = GridViewToHtml(tbCompanyNews);
                    ajaxHttp1 = ajaxHttp1.Replace("\n", "").Replace("\r", "");
                    hint =  ajaxHttp1 ;
                    if (hint == "")
                    {
                        Response.Write("页面出错，可能有非法值注入！");
                    }
                    else
                    {
                        Response.Write(hint);
                    }
                }
            }
        }

        public override void VerifyRenderingInServerForm(Control control)
        {
            //OverRide　为了使导出成Excel可行！
        }

        private string GridViewToHtml(GridView gv)
        {
            StringBuilder sb = new StringBuilder();
            StringWriter sw = new StringWriter(sb);
            HtmlTextWriter hw = new HtmlTextWriter(sw);
            gv.RenderControl(hw);
            return sb.ToString();
        }

        protected void tbCompanyNews_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                string onclickText = e.Row.Cells[1].Text.Trim();
                e.Row.Attributes.Add("onclick", "showNewContent('" + onclickText + "')");
                e.Row.Attributes.Add("style", "cursor:pointer");
            }
        }


    }
}