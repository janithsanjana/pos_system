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
    public partial class inventoryPage : Page
    {
        public inventoryPage()
        {
            InitializeComponent();
            Loaded += inventoryPage_Loaded;
        }
        private void inventoryPage_Loaded(object sender, RoutedEventArgs e)
        {
            inventory page = new inventory();
            FrameInventory.NavigationService.Navigate(page);
        }
    }
}
