using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class viewsubproduct : System.Web.UI.Page
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



            SqlDataAdapter da = new SqlDataAdapter("SELECT * FROM SubCategory", con1);
            DataSet ds = new DataSet();
            SqlCommand cmd = new SqlCommand();
            da.Fill(ds);
            GridView1.DataSource = ds.Tables[0];
            GridView1.DataBind();
        }



        protected void GridView1_RowCancelingEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1; //no editing row
            this.fillgrid();
        }

        protected void GridView1_RowDataBound(object sender, GridViewRowEventArgs e)
        {
            if (e.Row.RowType == DataControlRowType.DataRow)
            {
                DataRowView dr = (DataRowView)e.Row.DataItem;
                string imageUrl = "data:image/jpg;base64," + Convert.ToBase64String((byte[])dr["SubProductimage"]);
                (e.Row.FindControl("Image1") as Image).ImageUrl = imageUrl;
            }
        }

        protected void GridView1_RowDeleting(object sender, GridViewDeleteEventArgs e)
        {
            SqlCommand cmd = new SqlCommand();
            SqlConnection con = new SqlConnection("Initial catalog=scarLife; integrated security=true;server=MOKSH");
            Response.Write(e.RowIndex);
            string ptitle = GridView1.Rows[e.RowIndex].Cells[2].Text;





            cmd.CommandText = "delete from SubCategory where InsuranceCategory = '" + ptitle + "'";



            cmd.Connection = con;
            con.Open();
            cmd.ExecuteNonQuery();
            this.fillgrid();

        }

        protected void GridView1_RowEditing(object sender, GridViewEditEventArgs e)
        {
            {
                int n = e.NewEditIndex;
                GridView1.EditIndex = n;
                this.fillgrid();
            }
        }

        protected void GridView1_RowUpdating(object sender, GridViewUpdateEventArgs e)
        {
            SqlConnection con1 = new SqlConnection("Initial catalog=scarLife; integrated security=true;server=MOKSH");
            SqlCommand cmd = new SqlCommand();
            string InsuranceCategory = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text.Trim();
            string SubProductType = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text.Trim();
            string SubProductDescription = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text.Trim();


   
            //Prepare Sql Update Command 
            string strSqlCommand = "Update SubCategory Set InsuranceCategory='" + InsuranceCategory + "', SubProductType='" + SubProductType + "',SubProductDescription='"+SubProductDescription+ "' Where InsuranceCategory='" + InsuranceCategory + " '";
            con1.Open();
            cmd = new SqlCommand(strSqlCommand, con1);
            int i = cmd.ExecuteNonQuery();
            if (i > 0)
            {
                Response.Write("SubProduct Data Updated Successfully!!!");
                GridView1.EditIndex = -1; //Refresh GridView 
                this.fillgrid();
            }
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

        protected void Button8_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewagent.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewfeedback.aspx");
        }

        protected void Button6_Click1(object sender, EventArgs e)
        {
            Response.Redirect("viewsubproduct.aspx");
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

        protected void Button7_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewagent.aspx");
        }

        protected void Button8_Click1(object sender, EventArgs e)
        {
            Response.Redirect("viewfeedback.aspx");
        }

        protected void Button4_Click1(object sender, EventArgs e)
        {
            Response.Redirect("addsubproduct.aspx");
        }

        protected void Button3_Click1(object sender, EventArgs e)
        {
            Response.Redirect("viewproduct.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx");
        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            fillgrid();
            GridView1.PageIndex = e.NewPageIndex;
            GridView1.DataBind();
        }
    }
    
    }
