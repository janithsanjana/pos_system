using POS_Mrtech.View.UserControls;
using System.Windows.Controls;

namespace POS_Mrtech.Pages
{
    public partial class productpreviews : Page
    {
        public productpreviews()
        {
            TextBoxComp textBoxComp = new TextBoxComp();
            DataContext = textBoxComp;
            InitializeComponent();
        }
    }
}
