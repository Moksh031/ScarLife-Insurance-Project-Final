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
    public partial class viewproduct : System.Web.UI.Page
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



                SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM productdetails", con1);
                DataSet ds = new DataSet();
                SqlCommand cmd = new SqlCommand();
                da.Fill(ds);
                GridView1.DataSource = ds.Tables[0];
                GridView1.DataBind();
            }
        

      

      
     
    

      

     

        protected void GridView1_RowDataBound1(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["Productimage"]);
                (e.Row.FindControl("Image1") as Image).ImageUrl = imageUrl;
            }
        }

        protected void GridView1_RowDeleting1(object sender, GridViewDeleteEventArgs e)
        {
                SqlCommand cmd = new SqlCommand();
                SqlConnection con = new SqlConnection("Initial catalog=scarLife; integrated security=true;server=MOKSH");
                Response.Write(e.RowIndex);
                string ptitle = GridView1.Rows[e.RowIndex].Cells[2].Text;





                cmd.CommandText = "delete from productdetails where producttitle = '" + ptitle + "'";



                cmd.Connection = con;
                con.Open();
                cmd.ExecuteNonQuery();
                this.fillgrid();
            
        }

        protected void GridView1_RowUpdating1(object sender, GridViewUpdateEventArgs e)
        {

            SqlConnection con1 = new SqlConnection("Initial catalog=scarLife; integrated security=true;server=MOKSH");
            SqlCommand cmd = new SqlCommand();
            string producttitle = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim();
            string productdescription = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.Trim();
            //Prepare Sql Update Command 
            string strSqlCommand = "Update productdetails Set producttitle='" + producttitle + "', productdescription='" + productdescription + "' Where producttitle='" + producttitle + " '";
            con1.Open();
            cmd = new SqlCommand(strSqlCommand, con1);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("Employee Data Updated Successfully!!!");
                GridView1.EditIndex = -1; //Refresh GridView 
                this.fillgrid();
            }
        }

        protected void GridView1_RowEditing1(object sender, GridViewEditEventArgs e)
        {
            {
                int n = e.NewEditIndex;
                GridView1.EditIndex = n;
                this.fillgrid();
            }

        }

        protected void GridView1_RowCancelingEdit1(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; //no editing row
            this.fillgrid();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx");
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

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewfeedback.aspx");
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
    }
}













