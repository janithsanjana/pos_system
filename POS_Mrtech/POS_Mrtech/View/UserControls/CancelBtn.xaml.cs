using System.ComponentModel;
using System.Windows;
using System.Windows.Controls;

namespace POS_Mrtech.View.UserControls
{
    public partial class CancelBtn : Button
    {

        private string BtnContent;

        public string Content
        {
            get { return BtnContent; }
            set { BtnContent = value; }
        }
        public CancelBtn()
        {
            InitializeComponent();
            Click += CancelBtn_Click;
            DataContext = this;
        }
        private void CancelBtn_Click(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
