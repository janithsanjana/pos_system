using System;
using System.Windows;
using System.Windows.Controls;


namespace POS_Mrtech.Pages
{
    public partial class inventory : Page
    {
        public inventory()
        {
            InitializeComponent();
            Loaded += inventory_Loded;
        }

        private void gotoAddProducts(object sender, RoutedEventArgs e)
        {
            Content_Main_addProduct.Content = new addProduct();
        }

        private void gotoCategory(object sender, RoutedEventArgs e)
        {
            addProduct newAddProduct = new addProduct();
            newAddProduct.PreviewFrame.Content = new Pages.AddNewCategory();
        }

        private void inventory_Loded(object sender, RoutedEventArgs e)
        {
            Content_Main_addProduct.Content = new productsList();
        }
        private void gotoProductList(object sender, RoutedEventArgs e)
        {
            Content_Main_addProduct.Content = new productsList();
        }
    }
}
