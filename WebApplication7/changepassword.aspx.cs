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
    public partial class changepassword : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Request.Cookies["UserID"] != null)
            {
                TextBox1.Text =(Request.Cookies["UserID"].Value.ToString());
            }
           
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string name = "";
            SqlConnection con = new SqlConnection("uid=sa;password=123;database=scarLife;server=MOKSH");
            con.Open();
            SqlCommand cmd = new SqlCommand("select password from RegistrationForm where UserId='" + TextBox1.Text + "' ", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);
            if (ds.Tables[0].Rows.Count > 0)
            {
                name = ds.Tables[0].Rows[0][0].ToString();
            }



            if (TextBox2.Text == name && TextBox3.Text == TextBox4.Text)
            {
                SqlCommand cmd1 = new SqlCommand("Update RegistrationForm set password='" + TextBox3.Text + "',confirmpassword='" + TextBox3.Text + "' where UserId='" + TextBox1.Text + "' ", con);
                int i = cmd1.ExecuteNonQuery();
                Label6.Text = "Updated " + TextBox1.Text + " Sucessfully";
            }
            else if (TextBox2.Text != name)
            {
                Label6.Text = "Previous Password Is Wrong!. Try Again";
            }
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("afterlogin.aspx");
        }

        protected void LinkButton6_Click(object sender, EventArgs e)
        {
            Server.Transfer("userlogin.aspx");
        }

        protected void LinkButton7_Click(object sender, EventArgs e)
        {
            Server.Transfer("whyinsurance.aspx");
        }

        protected void LinkButton8_Click(object sender, EventArgs e)
        {
            Server.Transfer("home.aspx",true);
        }

        protected void Button4_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewuserproduct.aspx");
        }

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewusersubproduct.aspx");
        }

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("addagentrequest.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("addfeedback.aspx");
        }
    }
}