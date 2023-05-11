using POS_Mrtech.View.UserControls;
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
    public partial class AddNewCategory : Page
    {
        public AddNewCategory()
        {
            InitializeComponent();
        }

        private int subCategoryCount = 1;
        private bool isEmptyList = false;
        private void AddElementButton_Click(object sender, RoutedEventArgs e)
        {
            if (subCategoryCount < 4)
            {
                TextBoxComp newTextBoxComp = new TextBoxComp();
                newTextBoxComp.Name = "subCategory" + subCategoryCount.ToString("00");
                newTextBoxComp.Placeholder = "Sub category " + subCategoryCount.ToString("00");

                containerStackPanel.Children.Add(newTextBoxComp);

                subCategoryCount++;

                if (subCategoryCount >= 4)
                {
                    addButton.IsEnabled = false;

                    if (isEmptyList) {
                        addButton.IsEnabled = true;
                    };

                }
            }
        }

        private void ResetButton_Click(object sender, RoutedEventArgs e)
        {
            if (!tb_categoryName.TextBoxContent.Equals("") || !tb_subCategoryName.TextBoxContent.Equals("") || !tb_CategoryDiscription.TextBoxContent.Equals(""))
            {
                MessageBoxResult result = MessageBox.Show("Are you sure you want to clear all Entries?", "Warning!", MessageBoxButton.YesNo, MessageBoxImage.Warning, MessageBoxResult.No);
                if (result == MessageBoxResult.Yes)
                {
                    tb_categoryName.SetTextBoxText("", true);
                    tb_subCategoryName.SetTextBoxText("", false);
                    tb_CategoryDiscription.SetTextBoxText("", false);
                    containerStackPanel.Children.Clear();
                    subCategoryCount = 0;
                    isEmptyList = true;
                }
            }
            else
            {
                tb_categoryName.SetTextBoxText("", true);
                containerStackPanel.Children.Clear();
                subCategoryCount = 0;
                isEmptyList = true;
            }

        }
    }
}
