using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication7
{
    public partial class addproduct : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

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
            Response.Redirect("viewagentrequest.aspx");
        }

        protected void Button9_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewfeedback.aspx");
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            string filename = Path.GetFileName(FileUpload1.PostedFile.FileName);
            string contentType = FileUpload1.PostedFile.ContentType;
            using (Stream fs = FileUpload1.PostedFile.InputStream)
            {
                using (BinaryReader br = new BinaryReader(fs))
                {
                    byte[] bytes = br.ReadBytes((Int32)fs.Length);
                    SqlConnection con = new SqlConnection("uid=sa;password=123;database=scarLife;server=MOKSH");
                    con.Open();

                    SqlCommand cmd = new SqlCommand("sp_insert", con);
                    /*MessageBox.Show(cmd.CommandText);
                            */

                    cmd.CommandType = CommandType.StoredProcedure;


                    cmd.Parameters.AddWithValue("@Producttitle", TextBox1.Text);
                    cmd.Parameters.AddWithValue("@Productdescription", TextBox2.Text);

                    cmd.Parameters.AddWithValue("@Productimage", bytes);


                    Label5.Text = "" + TextBox1.Text + " Inserted Sucessfully";


                    int i = cmd.ExecuteNonQuery();
                    con.Close();


                }

            }
        }

        protected void Button5_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewsubproduct.aspx");
        }
    

        protected void Button13_Click(object sender, EventArgs e)
        {
            
    }

        protected void Button2_Click(object sender, EventArgs e)
        {
            Response.Redirect("viewproduct.aspx");
        }

        protected void Button14_Click(object sender, EventArgs e)
        {
            Response.Redirect("addsubproduct.aspx");
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
    