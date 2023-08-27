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
    public partial class viewagent : System.Web.UI.Page
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



            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM sendinformation", con1);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
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

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewfeedback.aspx");
        }

        protected void LinkButton1_Click(object sender, EventArgs e)
        {
            Response.Redirect("afterlogin.aspx");
        }

        protected void LinkButton2_Click(object sender, EventArgs e)
        {
            Response.Redirect("whyinsurance.aspx");
        }

        protected void LinkButton3_Click(object sender, EventArgs e)
        {

            Response.Redirect("home.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            fillgrid();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx");
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewproduct.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("addsubproduct.aspx");
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewsubproduct.aspx");
        }

        protected void Button10_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewagent.aspx");
        }

        protected void Button11_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewfeedback.aspx");
        }
    }

    
}