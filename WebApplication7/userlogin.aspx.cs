using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class userlogin : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["username"] != null)
            {
                Label16.Text = "Welcome Back " + (Request.Cookies["UserID"].Value.ToString());
            }
           
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewuserproduct.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewusersubproduct.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("addagentrequest.aspx");
        }

        protected void LinkButton5_Click(object sender, EventArgs e)
        {
            Response.Redirect("addfeedback.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }

        protected void LinkButton16_Click(object sender, EventArgs e)
        {

            Response.Redirect("changepassword.aspx");
            
        }
    }
}