using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Web.UI.WebControls;
 
namespace reg_form
{
    public partial class EditUser : System.Web.UI.Page
    {


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // Load user details for editing
                LoadUserDetails();
            }
        }

        private void LoadUserDetails()
        {
            try
            {
                string userId = Request.QueryString["userId"];
                if (!string.IsNullOrEmpty(userId))
                {
                    string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                    using (SqlConnection connection = new SqlConnection(connectionString))
                    {
                        connection.Open();

                        string query = "Select USERID,FirstName,LastName,Contact,Gender,Address,UserName from UserInfo WHERE USERID = @UserId";
                        SqlCommand cmd = new SqlCommand(query, connection);
                        cmd.Parameters.AddWithValue("@UserId", userId);
                        SqlDataReader reader = cmd.ExecuteReader();

                        if (reader.Read())
                        {
                            // Set user details in the form
                            lblUserId.Text = userId;
                            txtFirstName.Text = reader["FirstName"].ToString();
                            txtLastname.Text = reader["Lastname"].ToString();
                            txtContact.Text = reader["Contact"].ToString();
                            txtGender.SelectedValue = reader["gender"].ToString();
                            txtAddress.Text = reader["Address"].ToString();
                            txtUserName.Text = reader["UserName"].ToString();
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }

        protected void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                string userId = lblUserId.Text;
                string name = txtFirstName.Text.Trim();
                string lastname = txtLastname.Text.Trim();
                string contact = txtContact.Text.Trim();
                string gender = txtGender.SelectedValue;
                string address = txtAddress.Text.Trim();
                string username = txtUserName.Text.Trim();

                string connectionString = ConfigurationManager.ConnectionStrings["DB"].ConnectionString;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string query = "UPDATE UserInfo SET FirstName = @FirstName, LastName = @lastname, Contact = @contact, Gender = @gender ,Address =@address ,UserName=@username WHERE USERID = @UserId";
                    SqlCommand cmd = new SqlCommand(query, connection);
                    cmd.Parameters.AddWithValue("@UserId", userId);
                    cmd.Parameters.AddWithValue("@FirstName", name);
                    cmd.Parameters.AddWithValue("@LastName", lastname);
                    cmd.Parameters.AddWithValue("@Contact", contact);
                    cmd.Parameters.AddWithValue("@Gender", gender);
                    cmd.Parameters.AddWithValue("@Address", address);
                    cmd.Parameters.AddWithValue("@UserName", username);

                    cmd.ExecuteNonQuery();
                }

                Response.Redirect("~/Dashboard.aspx");
            }
            catch (Exception ex)
            {
                // Handle the exception or display an error message
                Response.Write($"<script>alert('Error: {ex.Message}');</script>");
            }
        }

        protected void btnCancel_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/Dashboard.aspx");
        }
    }
}