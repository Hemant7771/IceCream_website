using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ice_cream_project
{
    public partial class Login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void LoginButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RJL8MLN\\SQLEXPRESS;Initial Catalog=icecream;Integrated Security=True"; // Replace with your connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT COUNT(*) FROM Users WHERE u_name = @Username AND u_password = @Password";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", LoginUsernameTextBox.Text);
                    // You should hash and salt the password for security.
                    cmd.Parameters.AddWithValue("@Password", LoginPasswordTextBox.Text);
                    int userCount = (int)cmd.ExecuteScalar();

                    if (userCount > 0)
                    {
                        // Successful login; redirect to a secure page.
                        Response.Redirect("index.aspx");
                    }
                    else
                    {
                        // Failed login; show an error message.
                        // You can display the error message on the page.
                    }
                }
            }
        }
    }
}