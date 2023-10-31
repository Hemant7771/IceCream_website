using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Ice_cream_project
{
    public partial class cart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindCart();
            }
        }

        protected void BindCart()
        {
            // Fetch the shopping cart items from the database and bind to the GridView
            DataTable cartItems = GetCartItems();
            CartGridView.DataSource = cartItems;
            CartGridView.DataBind();
        }

        private DataTable GetCartItems()
        {
            string connectionString = "Your Connection String"; // Replace with your connection string

            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                string selectQuery = "SELECT c.CartItemId, p.ProductId, p.ProductName, p.Price, c.Quantity " +
                                      "FROM ShoppingCart c " +
                                      "INNER JOIN Products p ON c.ProductId = p.ProductId";
                using (SqlCommand cmd = new SqlCommand(selectQuery, connection))
                {
                    DataTable dt = new DataTable();
                    using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                    {
                        da.Fill(dt);
                    }
                    return dt;
                }
            }
        }

        protected void CartGridView_RowCommand(object sender, GridViewCommandEventArgs e)
        {
            int cartItemId = Convert.ToInt32(e.CommandArgument);

            if (e.CommandName == "Increase")
            {
                // Implement code to increase quantity
                // You need to update the quantity in the database
            }
            else if (e.CommandName == "Delete")
            {
                // Implement code to delete the item from the cart
                // You need to remove the item from the database
            }

            BindCart(); // Refresh the cart view
        }
    }
}