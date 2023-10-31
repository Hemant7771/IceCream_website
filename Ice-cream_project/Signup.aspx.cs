using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ice_cream_project
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void SignUpButton_Click(object sender, EventArgs e)
        {
            string connectionString = "Data Source=DESKTOP-RJL8MLN\\SQLEXPRESS;Initial Catalog=icecream;Integrated Security=True"; // Replace with your connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string insertQuery = "INSERT INTO Users (u_name,u_email,u_password) VALUES (@Username, @Email, @Password)";
                using (SqlCommand cmd = new SqlCommand(insertQuery, connection))
                {
                    cmd.Parameters.AddWithValue("@Username", UsernameTextBox.Text);
                    cmd.Parameters.AddWithValue("@Email", EmailTextBox.Text);
                    // You should hash and salt the password for security.
                    cmd.Parameters.AddWithValue("@Password", PasswordTextBox.Text);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}