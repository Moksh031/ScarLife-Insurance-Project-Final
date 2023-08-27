using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class afterlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserName"] != null)
            {
                Label24.Text = "Welcome Back " + (Request.Cookies["UserName"].Value.ToString());
            }
        }

        protected void LinkButton30_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx");
        }

        protected void LinkButton31_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewproduct.aspx");
        }

        protected void LinkButton32_Click(object sender, EventArgs e)
        {
            Response.Redirect("addsubproduct.aspx");
        }

        protected void LinkButton33_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewsubproduct.aspx");
        }

        protected void LinkButton34_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewagent.aspx");
        }

        protected void LinkButton35_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewfeedback.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("whyinsurance.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}