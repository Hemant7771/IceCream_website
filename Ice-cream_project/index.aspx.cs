using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ice_cream_project
{
	public partial class WebForm1 : System.Web.UI.Page
	{
		protected void Page_Load(object sender, EventArgs e)
		{
			/*if (!IsPostBack)
            {
                string connectionString = "Server=localhost;Database=product;";
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                   // connection.Open();

                    string query = "SELECT * FROM ice_cream";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        using (SqlDataAdapter adapter = new SqlDataAdapter(command))
                        {
                            DataTable dataTable = new DataTable();
                            //adapter.Fill(dataTable);

                            
                        }
                    }
                }
            }*/
		}
	}
}