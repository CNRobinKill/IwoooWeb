using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace IwoooWeb.UI.Admin
{
    public partial class ProductManagement : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["userName"] != null && Session["userName"].ToString() == "SystemIwooo")
            { }
            else
            {
                Response.Redirect("LogOn.aspx", true);
            }
        }

        public void GvHardWareDatabind()
        {
            tbHardWare.DataSource = DAL.HardWareDAL.GetAllHardWare();
            tbHardWare.DataKeyNames = new string[] { "id" };
            tbHardWare.DataBind();
            if (tbHardWare.HeaderRow != null)
            {
                tbHardWare.HeaderRow.Cells[0].Text = "硬件产品系列";
                tbHardWare.HeaderRow.Cells[1].Text = "硬件产品名称";
            }
        }
        public void GvSoftWareDatabind()
        {
            tbSoftWare.DataSource = DAL.SoftWareDAL.GetAllSoftWare();
            tbSoftWare.DataKeyNames = new string[] { "id" };
            tbSoftWare.DataBind();
            if (tbSoftWare.HeaderRow != null)
            {
                tbSoftWare.HeaderRow.Cells[0].Text = "软件产品系列";
                tbSoftWare.HeaderRow.Cells[1].Text = "软件产品名称";
            }
        }

        public void GvServicesDatabind()
        {
            tbServices.DataSource = DAL.ServicesDAL.GetAllServices();
            tbServices.DataKeyNames = new string[] { "id" };
            tbServices.DataBind();
            if (tbServices.HeaderRow != null)
            {
                tbServices.HeaderRow.Cells[0].Text = "服务产品系列";
                tbServices.HeaderRow.Cells[1].Text = "服务产品名称";
            }
        }

        protected void btnAddProducts_Click(object sender, EventArgs e)
        {
            Response.Redirect("AddProducts.aspx", true);
        }

        protected void btnShowHardWare_Click(object sender, EventArgs e)
        {
            tbHardWare.Visible = true;
            tbSoftWare.Visible = false;
            tbServices.Visible = false;
            GvHardWareDatabind();
        }

        protected void btnShowSoftWare_Click(object sender, EventArgs e)
        {
            tbHardWare.Visible = false;
            tbSoftWare.Visible = true;
            tbServices.Visible = false;
            GvSoftWareDatabind();
        }

        protected void btnShowServices_Click(object sender, EventArgs e)
        {
            tbHardWare.Visible = false;
            tbSoftWare.Visible = false;
            tbServices.Visible = true;
            GvServicesDatabind();
        }

        protected void tbHardWare_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Redirect("AddProducts.aspx?id=" + tbHardWare.DataKeys[e.NewSelectedIndex].Value.ToString() + "&type=0", true);
        }

        protected void tbHardWare_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DAL.HardWareDAL.DelHardWareById(tbHardWare.DataKeys[e.RowIndex].Value.ToString());
            GvHardWareDatabind();
        }

        protected void tbSoftWare_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Redirect("AddProducts.aspx?id=" + tbSoftWare.DataKeys[e.NewSelectedIndex].Value.ToString() + "&type=1", true);
        }

        protected void tbSoftWare_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DAL.SoftWareDAL.DelSoftWareById(tbSoftWare.DataKeys[e.RowIndex].Value.ToString());
            GvSoftWareDatabind();
        }

        protected void tbServices_SelectedIndexChanging(object sender, GridViewSelectEventArgs e)
        {
            Response.Redirect("AddProducts.aspx?id=" + tbServices.DataKeys[e.NewSelectedIndex].Value.ToString() + "&type=2", true);
        }

        protected void tbServices_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            DAL.ServicesDAL.DelServicesById(tbServices.DataKeys[e.RowIndex].Value.ToString());
            GvServicesDatabind();
        }

    }
}