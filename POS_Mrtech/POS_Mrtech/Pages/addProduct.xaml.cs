using POS_Mrtech.View.UserControls;
using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using MySql.Data.MySqlClient;
using MaterialDesignThemes.Wpf;
using System.Windows.Threading;
using System;

namespace POS_Mrtech.Pages
{

    public partial class addProduct : Page
    {

        MySqlConnection con = MySqlConnector.CreateConnection();

        private productpreviews productPreviewsPage;
        private SnackbarMessageQueue messageQueue = new SnackbarMessageQueue();

        public addProduct()
        {
            DataContext = this;
            InitializeComponent();
            Loaded += AddProductPage_Loaded; 
            productPreviewsPage = new productpreviews();

        }

        private void GoBack_Click(object sender, RoutedEventArgs e)
        {
            if (NavigationService.CanGoBack)
            {
                NavigationService.GoBack();
            }
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            if(!tb_pName.TextBoxContent.Equals("") || !tb_pCategory.TextBoxContent.Equals("") || !tb_pBarCode.TextBoxContent.Equals("") || !tb_pStock.TextBoxContent.Equals("") || !tb_pPrice.TextBoxContent.Equals(""))
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to clear all Entries?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                {
                    tb_pName.SetTextBoxText("",true);
                    tb_pCategory.SetTextBoxText("",false);
                    tb_pBarCode.SetTextBoxText("", false);
                    tb_pStock.SetTextBoxText("", false);
                    tb_pPrice.SetTextBoxText("", false);
                }
            }
                else
                {
                    tb_pName.SetTextBoxText("", true);
                }
            
        }

        private void AddNewCategory_click(object sender, RoutedEventArgs e)
        {
            PreviewFrame.Content = new Pages.AddNewCategory();
        }

        private void AddProductPage_Loaded(object sender, RoutedEventArgs e)
        {
            PreviewFrame.Content = new productpreviews();
        }

        private void gotoPreviewWindow(object sender, RoutedEventArgs e)
        {

            PreviewFrame.Content = new productpreviews();
        }

        private void save_product_click(object sender, RoutedEventArgs e)
        {

            try
            {
                if (!tb_pName.TextBoxContent.Equals("") || !tb_pCategory.TextBoxContent.Equals("") || !tb_pBarCode.TextBoxContent.Equals("") || !tb_pStock.TextBoxContent.Equals("") || !tb_pPrice.TextBoxContent.Equals(""))
                {
                    con.Open();
                    string query = "insert into product (product_name, category_id, bar_code_id, stock, price) values (@product_name, @category_id, @bar_code_id, @stock, @price)";
                    MySqlCommand cmd = new MySqlCommand(query, con);
                    cmd.Parameters.AddWithValue("@product_name", tb_pName.TextBoxContent);
                    cmd.Parameters.AddWithValue("@category_id", tb_pCategory.TextBoxContent);
                    cmd.Parameters.AddWithValue("@bar_code_id", tb_pBarCode.TextBoxContent);
                    cmd.Parameters.AddWithValue("@stock", tb_pStock.TextBoxContent);
                    cmd.Parameters.AddWithValue("@price", tb_pPrice.TextBoxContent);
                    cmd.ExecuteNonQuery();

                }
                else 
                {
                    MessageBox.Show("All Fields Are Required", "Error!!", MessageBoxButton.OK, MessageBoxImage.Exclamation);
                }
            }
            catch (MySqlException ex)
            {
                MessageBox.Show(ex.Message,"Error",MessageBoxButton.OK,MessageBoxImage.Error);
            }
            finally
            {
                con.Close();
            }
        }

        private void clickViewcategory(object sender, RoutedEventArgs e)
        {
            messageQueue.Enqueue("New product added to the system", null, null, null, false, true, TimeSpan.FromSeconds(5));
        }
    }
}
