using System;
using System.Collections.Generic;
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
    public partial class AdminDashboard : Window
    {
        bool isMaximized = true;
        public AdminDashboard()
        {
            InitializeComponent();
            Loaded += dashboard_Loaded;
            Content_Main.NavigationUIVisibility = NavigationUIVisibility.Hidden;
        }

        private void Button_Click_Maximize(object sender, RoutedEventArgs e)
        {
            if (isMaximized)
            {
                this.WindowState = WindowState.Maximized;
                this.WindowStyle = WindowStyle.None;
                isMaximized = false;
            }
            else
            {
                this.WindowState = WindowState.Normal;
                this.WindowStyle = WindowStyle.SingleBorderWindow;
                isMaximized = true;
            }
        }
        private void Button_Click_close(object sender, RoutedEventArgs e)
        {
            Close();
        }
        private void dashboard_Loaded(object sender, RoutedEventArgs e)
        {
            // Create an instance of the page you want to load
            dashboard page = new dashboard();

            // Set the content of the Frame to the desired page
            Content_Main.NavigationService.Navigate(page);
        }
        private void gotoDashBoard(object sender, RoutedEventArgs e)
        {
            Content_Main.Content = new Pages.dashboard();
        }
        private void gotoInventory(object sender, RoutedEventArgs e)
        {
            Content_Main.Content = new Pages.inventoryPage();
        }
        private void gotoUsers(object sender, RoutedEventArgs e)
        {
            Content_Main.Content = new Pages.users();
        }
        private void gotoReports(object sender, RoutedEventArgs e)
        {
            Content_Main.Content = new Pages.reports();
        }
        private void gotoSettings(object sender, RoutedEventArgs e)
        {
            Content_Main.Content = new Pages.settings();
        }
    }
}
