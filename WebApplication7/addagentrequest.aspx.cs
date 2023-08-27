using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class addagentrequest : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button2_Click(object sender, EventArgs e)
        {

            TextBox1.Text = "";
            TextBox2.Text = "";
            TextBox3.Text = "";
            TextBox4.Text = "";
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("Trusted_Connection=Yes;database=scarLife;server=MOKSH");
            con.Open();
            SqlCommand cmd = new SqlCommand("insert into sendinformation values('" + TextBox1.Text + "','" +
            TextBox2.Text + "','" + TextBox3.Text + "','" + TextBox4.Text + "','" + DropDownList1.Text + "')", con);
            int i = cmd.ExecuteNonQuery();
            con.Close();
            Label7.Text = "Agent Will contact you soon";
        }

        protected void LinkButton11_Click(object sender, EventArgs e)
        {

        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewuserproduct.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewusersubproduct.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("addfeedback.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Response.Redirect("userlogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Response.Redirect("whyinsurance.aspx");

        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Response.Redirect("home.aspx");
        }
    }
}