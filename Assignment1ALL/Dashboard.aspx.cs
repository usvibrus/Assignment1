using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace WebApplication2
{
    public partial class Dashboard : System.Web.UI.Page
    {
        string DB = @"Server=192.9.200.183; Database=Test_DB; User Id = *****; Password=winsoft@*****";

        protected void Page_Load(object sender, EventArgs e)
        {


            if (!IsPostBack) {

                Bindgridview();
            }

                
        }


      protected  void Bindgridview()
        {
            using (SqlConnection SQ = new SqlConnection(DB))
            {

                string query = "Select USERID,FirstName,LastName,Contact,Gender,Address,UserName from UserInfo";
                SQ.Open();

                using (SqlCommand sql = new SqlCommand(query, SQ))
                {

                    using (SqlDataReader reader = sql.ExecuteReader())
                    {
                        gridview.DataSource = reader;
                        gridview.DataBind();

                    }



                }




            }
        }


        protected void gridview_delete_user(object sender, EventArgs e)
        {

            Button btnDelete = (Button)sender;
            string USERID = btnDelete.CommandArgument;

            using (SqlConnection Conn = new SqlConnection(DB)){

                string query = "Delete from UserInfo where USERID =@USERID";


                using (SqlCommand command = new SqlCommand(query, Conn))
                {

                    command.Parameters.AddWithValue("@USERID", USERID);
                    Conn.Open();
                    command.ExecuteNonQuery();
                }
            }

            Bindgridview();
        }


        protected void Bindgridview(string searchTerm = "")
        {
            using (SqlConnection SQ = new SqlConnection(DB))
            {
                string query = "SELECT USERID, FirstName, LastName, Contact, Gender, Address, UserName FROM UserInfo";

                // Append the WHERE clause if a search term is provided
                if (!string.IsNullOrEmpty(searchTerm))
                {
                    query += " WHERE FirstName LIKE @SearchTerm OR LastName LIKE @SearchTerm OR Contact LIKE @SearchTerm OR Gender LIKE @SearchTerm OR Address LIKE @SearchTerm OR UserName LIKE @SearchTerm";
                }

                SQ.Open();

                using (SqlCommand sql = new SqlCommand(query, SQ))
                {
                    // Add the search term parameter if provided
                    if (!string.IsNullOrEmpty(searchTerm))
                    {
                        sql.Parameters.AddWithValue("@SearchTerm", "%" + searchTerm + "%");
                    }

                    using (SqlDataReader reader = sql.ExecuteReader())
                    {
                        gridview.DataSource = reader;
                        gridview.DataBind();
                    }
                }
            }
        }

        protected void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm = txtSearch.Text.Trim();
            Bindgridview(searchTerm);
        }

        protected void btnEdit_Click(object sender, EventArgs e)
        {
            Button btnEdit = (Button)sender;
            string userId = btnEdit.CommandArgument;

            // Redirect to edit page with user ID
            Response.Redirect($"Edit.aspx?userid={userId}");
        }
    }


}
