using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class addsubproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection("uid=sa;password=123;database=scarLife;server=MOKSH");
            con.Open();

            string filename = Path.GetFileName(FileUpload10.PostedFile.FileName);
            string contentType = FileUpload10.PostedFile.ContentType;
            using (Stream fs = FileUpload10.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                  

                    SqlCommand cmd = new SqlCommand("sp_subcategory", con);
                    /*MessageBox.Show(cmd.CommandText);
                            */

                    cmd.CommandType = CommandType.StoredProcedure;


                 





                    cmd.Parameters.AddWithValue("@InsuranceCategory", TextBox10.Text);
                    cmd.Parameters.AddWithValue("@SubProductType", TextBox20.Text);
                    cmd.Parameters.AddWithValue("@SubProductDescription", TextBox30.Text);
                    cmd.Parameters.AddWithValue("@SubProductimage", bytes);




                    Label6.Text = "" + TextBox10.Text + " Inserted Sucessfully";





                    int i = cmd.ExecuteNonQuery();
                    con.Close();
                }
            
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

        protected void Button13_Click(object sender, EventArgs e)
        {
            Response.Redirect("addproduct.aspx"); 
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewproduct.aspx");
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
    
