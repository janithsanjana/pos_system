using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace POS_Mrtech.Pages
{
    public partial class productsList : Page
    {
        public productsList()
        {
            InitializeComponent();
            Loaded += LoadProductList;
        }
        public class Product
        {
            public int ProductID { get; set; }
            public string ProductName { get; set; }
            public int CategoryName { get; set; }
            public string BarcodeID { get; set; }
            public int Price { get; set; }
            public int Stock { get; set; }
        }
        private void LoadProductList(object sender, RoutedEventArgs e)
        {
            // Create a MySqlConnection using your con string
            using (MySqlConnection con = MySqlConnector.CreateConnection())
            {
                con.Open();

                using (MySqlCommand command = new MySqlCommand("SELECT * FROM product", con))
                {
                    using (MySqlDataReader reader = command.ExecuteReader())
                    {
                        List<Product> productList = new List<Product>();

                        // Create a DataTable to hold the product data
                        DataTable dataTable = new DataTable();

                        dataTable.Columns.Add("id_product", typeof(int));
                        dataTable.Columns.Add("product_name", typeof(string));
                        dataTable.Columns.Add("category_id", typeof(int));
                        dataTable.Columns.Add("bar_code_id", typeof(string));
                        dataTable.Columns.Add("stock", typeof(decimal));
                        dataTable.Columns.Add("price", typeof(int));  
                        


                        // Iterate through the results and populate the DataTable
                        while (reader.Read())
                        {
                            // Access the data from each row
                            int productId = reader.GetInt32("id_product");
                            string productName = reader.GetString("product_name");
                            int categoryName = reader.GetInt32("category_id");
                            string barcodeId = reader.GetString("bar_code_id");
                            int price = reader.GetInt32("stock");
                            int stock = reader.GetInt32("price");

                            Product product = new Product
                            {
                                ProductID = productId,
                                ProductName = productName,
                                CategoryName = categoryName,
                                BarcodeID = barcodeId,
                                Price = price,
                                Stock = stock
                            };

                            // Add the product to the list
                            productList.Add(product);
                        }

                        productDataGrid.ItemsSource = productList;
                    }
                }
            }
        }

        private void productDataGrid_CellEditEnding(object sender, DataGridCellEditEndingEventArgs e)
        {
            if (e.EditAction == DataGridEditAction.Commit)
            {
                // Get the edited row
                DataGridRow editedRow = e.Row;

                // Get the edited product object
                Product editedProduct = editedRow.Item as Product;

                if (editedProduct != null)
                {
                    // Get the updated values from the edited cells
                    int productId = editedProduct.ProductID;
                    string updatedValue = (e.EditingElement as TextBox).Text;

                    // Get the column name based on the edited cell
                    DataGridColumn editedColumn = e.Column;
                    string columnName = (editedColumn as DataGridTextColumn)?.Header?.ToString();

                    // Update the corresponding property in the Product object
                    switch (columnName)
                    {
                        case "ProductName":
                            editedProduct.ProductName = updatedValue;
                            break;
                        case "CategoryName":
                            editedProduct.CategoryName = int.Parse(updatedValue);
                            break;
                        case "BarcodeID":
                            editedProduct.BarcodeID = updatedValue;
                            break;
                        case "Price":
                            editedProduct.Price = int.Parse(updatedValue);
                            break;
                        case "Stock":
                            editedProduct.Stock = int.Parse(updatedValue);
                            break;
                        default:
                            break;
                    }

                    // Update the DataTable with the new value
                    DataRowView rowView = productDataGrid.SelectedItem as DataRowView;
                    if (rowView != null)
                    {
                        DataRow row = rowView.Row;
                        row[columnName] = updatedValue;
                    }

                    // Update the database with the new value
                    using (MySqlConnection connection = MySqlConnector.CreateConnection())
                    {
                        connection.Open();

                        // Create a parameterized SQL query
                        string query = $"UPDATE product SET `{columnName}` = @columnValue WHERE id_product = @productId";
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            // Add the parameters to the command
                            command.Parameters.AddWithValue("@columnValue", updatedValue);
                            command.Parameters.AddWithValue("@productId", productId);

                            // Execute the update command
                            command.ExecuteNonQuery();
                                
                            
                            connection.Close();
                            MessageBox.Show("Updated");

                            //reshan hthrthtrhth
                        }
                    }
                }
            }
        }
    }
}
