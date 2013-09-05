using System;
using System.Collections.Generic;
using System.Linq;
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
                        hint = "<!--CompanyIntroduction--><div class='row'><div class='span12'>  <div class='well c-soon'><p><span class='color' style='font-size:18px'><b>爱沃计算机科技有限公司</b></span>(<a href='http://www.iwooo.com'>www.iwooo.com</a>) 是致力于为国内外企业提供世界领先的、全方位企业信息化专业服务信息技术提供商。作为INFOR、IBM中国合作伙伴，在市场份额、成功案例和顾问规模等方面均位居前列，在业内树立了IT技术、服务、尤其是INFOR产品专业服务的优良口碑。在服务领域，我们为企业客户提供以INFOR为核心、具备国际专业标准和本地特点的全方位专业服务，包括：管理与业务流程咨询、企业IT规划、INFOR ERP实施及INFOR全系列新技术实施、INFOR运维和支持、客户培训等服务业务。面向行业客户，我们提供安全、可靠、高质量、易扩展的行业解决方案，帮助客户实现信息化管理最佳实践，以满足客户需求。行业解决方案涵盖的领域包括：机械、电子、能源电力、汽车、制药、化工、钢铁、高科技、快速消费品、金融保险、电信等行业。爱沃将“品质、服务、创新”作为公司的经营思想和品牌承诺。作为一家以信息技术服务为核心的公司， 爱沃通过开放式创新、卓越运营管理、人力资源发展等战略的实施，全面构造公司的核心竞争力，创造客户和社会的价值。爱沃致力于成为行业领先、受社会认可、客户信赖、投资者和员工尊敬的企业信息化服务提供商，并通过组织与过程的持续改进、领导力与员工竞争力发展、联盟和开放式创新，使爱沃成为中国IT服务领域的领先公司。</p></div></div></div>";                        
                    }

                    if (q == "CompanyNews")
                    {
                        hint = "<!--CompanyNews--><div class='row'><div class='span12'>  <div class='well c-soon'><p><span class='color' style='font-size:18px'><b>爱沃计算机科技有限公司</b></span>(<a href='http://www.iwooo.com'>www.iwooo.com</a>) 是致力于为国内外企业提供世界领先的、全方位企业信息化专业服务信息技术提供商。作为INFOR、IBM中国合作伙伴，在市场份额、成功案例和顾问规模等方面均位居前列，在业内树立了IT技术、服务、尤其是INFOR产品专业服务的优良口碑。在服务领域，我们为企业客户提供以INFOR为核心、具备国际专业标准和本地特点的全方位专业服务，包括：管理与业务流程咨询、企业IT规划、INFOR ERP实施及INFOR全系列新技术实施、INFOR运维和支持、客户培训等服务业务。面向行业客户，我们提供安全、可靠、高质量、易扩展的行业解决方案，帮助客户实现信息化管理最佳实践，以满足客户需求。行业解决方案涵盖的领域包括：机械、电子、能源电力、汽车、制药、化工、钢铁、高科技、快速消费品、金融保险、电信等行业。爱沃将“品质、服务、创新”作为公司的经营思想和品牌承诺。作为一家以信息技术服务为核心的公司， 爱沃通过开放式创新、卓越运营管理、人力资源发展等战略的实施，全面构造公司的核心竞争力，创造客户和社会的价值。爱沃致力于成为行业领先、受社会认可、客户信赖、投资者和员工尊敬的企业信息化服务提供商，并通过组织与过程的持续改进、领导力与员工竞争力发展、联盟和开放式创新，使爱沃成为中国IT服务领域的领先公司。</p></div></div></div>";
                    }

                    if (q == "JoinUs")
                    {
                        hint = "<!--JoinUs--><div class='row'><div class='span12'>  <div class='well c-soon'><p><span class='color' style='font-size:18px'><b>爱沃计算机科技有限公司</b></span>(<a href='http://www.iwooo.com'>www.iwooo.com</a>) 是致力于为国内外企业提供世界领先的、全方位企业信息化专业服务信息技术提供商。作为INFOR、IBM中国合作伙伴，在市场份额、成功案例和顾问规模等方面均位居前列，在业内树立了IT技术、服务、尤其是INFOR产品专业服务的优良口碑。在服务领域，我们为企业客户提供以INFOR为核心、具备国际专业标准和本地特点的全方位专业服务，包括：管理与业务流程咨询、企业IT规划、INFOR ERP实施及INFOR全系列新技术实施、INFOR运维和支持、客户培训等服务业务。面向行业客户，我们提供安全、可靠、高质量、易扩展的行业解决方案，帮助客户实现信息化管理最佳实践，以满足客户需求。行业解决方案涵盖的领域包括：机械、电子、能源电力、汽车、制药、化工、钢铁、高科技、快速消费品、金融保险、电信等行业。爱沃将“品质、服务、创新”作为公司的经营思想和品牌承诺。作为一家以信息技术服务为核心的公司， 爱沃通过开放式创新、卓越运营管理、人力资源发展等战略的实施，全面构造公司的核心竞争力，创造客户和社会的价值。爱沃致力于成为行业领先、受社会认可、客户信赖、投资者和员工尊敬的企业信息化服务提供商，并通过组织与过程的持续改进、领导力与员工竞争力发展、联盟和开放式创新，使爱沃成为中国IT服务领域的领先公司。</p></div></div></div>";
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
            }
        }
    }
}