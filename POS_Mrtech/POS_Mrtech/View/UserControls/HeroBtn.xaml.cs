using System.Windows;
using System.Windows.Controls;

namespace POS_Mrtech.View.UserControls
{
    public partial class HeroBtn : Button
    {
        private string BtnContent;

        public string Content
        {
            get { return BtnContent; }
            set { BtnContent = value; }
        }


        public HeroBtn()
        {
            InitializeComponent();
            Click += HeroBtn_Click;
            DataContext = this;
        }

        private void HeroBtn_Click(object sender, RoutedEventArgs e)
        {
            // Handle the button click event
        }
    }
}
