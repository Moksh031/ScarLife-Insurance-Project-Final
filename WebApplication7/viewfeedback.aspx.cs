using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class viewfeedback : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                SqlConnection con1 = new SqlConnection("uid=sa;password=123;database=scarLife;server=MOKSH");
                fillgrid();
            }
        }
        private void fillgrid()
        {
            SqlConnection con1 = new SqlConnection("uid=sa;password=123;database=scarLife;server=MOKSH");



            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM feedback", con1);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx");
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewproduct.aspx");
        }

        protected void Button6_Click(object sender, EventArgs e)
        {
            Response.Redirect("addsubproduct.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewsubproduct.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewagent.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            fillgrid();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("viewproduct.aspx");

        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("addsubproduct.aspx");
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("viewsubproduct.aspx");
        }

        protected void Button7_Click1(object sender, EventArgs e)
        {
            Response.Redirect("viewagent.aspx");
        }

        protected void LinkButton4_Click(object sender, EventArgs e)
        {
            Response.Redirect("afterlogin.aspx");
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {
            Response.Redirect("whyinsurance.aspx");
        }

        protected void LinkButton12_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }


}