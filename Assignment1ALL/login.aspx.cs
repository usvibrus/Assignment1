using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace PracticeApp
{
    public partial class Login : System.Web.UI.Page
    {

        string DB = @"Server=192.9.200.183; Database=Test_DB; User Id=****; Password=winsoft****";

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void submit_Click(object sender, EventArgs e)
        {

            using (SqlConnection SQ = new SqlConnection(DB))
            {
                SQ.Open();
                string Query = "Select Count(1) from UserInfo where Username=@Username AND Password=@Password";

                SqlCommand cmd = new SqlCommand(Query, SQ);
                cmd.Parameters.AddWithValue("@Username", loginusername.Text.Trim());
                cmd.Parameters.AddWithValue("@Password", loginpass.Text.Trim());

                int count = Convert.ToInt32(cmd.ExecuteScalar());// this is to cheak if query executed and stored in one 

                if (count == 1)
                {
                    ErrorMessage.Text = "Login Successfull";

                    Session["Username"] = loginusername.Text.Trim();
                    Response.Redirect("Dashboard.aspx");

                }
                else
                {
                    ErrorMessage.Text = "Please Register first";
                    Response.Redirect("regform.aspx");

                }
            }

        }
    }
}
