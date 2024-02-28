using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System;
using System.Web.UI;
using System.Data;

namespace PracticeApp
{
    public partial class userReg : System.Web.UI.Page
    {


        string DB = @"Server=192.9.200.183; Database=Test_DB; User Id=*****; Password=winsoft*****

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                //  This property is often used to differentiate between the initial page load and subsequent postback requests.
                formclear();
            }
        }

        protected void sumbit_Click(object sender, EventArgs e)
        {

            if (username.Text == "" || password.Text == "")
            {
                failmessage.Text = "enter username and password";
            }
            else if (password.Text != confirmpassword.Text)
            {
                failmessage.Text = "Password don,t match!";
            }
            else
            {

                using (SqlConnection SQLCon = new SqlConnection(DB))
                {
                    SQLCon.Open();
                    SqlCommand SQLCMD = new SqlCommand("userADDorEDIT", SQLCon);
                    SQLCMD.CommandType = CommandType.StoredProcedure;
                    SQLCMD.Parameters.AddWithValue("@USERID", Convert.ToInt32(hfID.Value == "" ? "0" : hfID.Value));
                    SQLCMD.Parameters.AddWithValue("@FirstName", firstname.Text.Trim());
                    SQLCMD.Parameters.AddWithValue("@LastName", lastname.Text.Trim());
                    SQLCMD.Parameters.AddWithValue("@Contact", contact.Text.Trim());
                    SQLCMD.Parameters.AddWithValue("@Gender", gender.Text.Trim());
                    SQLCMD.Parameters.AddWithValue("@Address", address.Text.Trim());
                    SQLCMD.Parameters.AddWithValue("@username", username.Text.Trim());
                    SQLCMD.Parameters.AddWithValue("@PassWord", password.Text.Trim());
                    SQLCMD.ExecuteNonQuery();//executing procedue 
                    formclear();
                    successmessage.Text = "Submited Successfully";
                    Response.Redirect("~/Dashboard.aspx");
                }
            }



        }



        void formclear()
        {
            firstname.Text = lastname.Text = contact.Text = address.Text = username.Text = password.Text = confirmpassword.Text = "";
            hfID.Value = "";
            successmessage.Text = failmessage.Text = "";

        }
    }
}
