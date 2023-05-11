using System;
using System.ComponentModel;
using System.Windows;
using System.Windows.Media;
using System.Windows.Controls;
using POS_Mrtech.Pages;

namespace POS_Mrtech.View.UserControls
{
    public partial class TextBoxComp : UserControl, INotifyPropertyChanged
    {
        public event EventHandler CancelButtonClicked;
        public TextBoxComp()
        {
            DataContext = this;
            InitializeComponent();
        }
        //data binding for previews


        public static readonly DependencyProperty TextProperty = DependencyProperty.Register("Text", typeof(string), typeof(TextBoxComp), new PropertyMetadata(""));

        public string Text
        {
            get { return (string)GetValue(TextProperty); }
            set { SetValue(TextProperty, value); }
        }

        //binding placeholder
        private string placeholder;

        public event PropertyChangedEventHandler PropertyChanged;

        public string Placeholder
        {
            get { return placeholder; }
            set 
            { 
                placeholder = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Placeholder"));
            }
        }


        private void TextBox_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (string.IsNullOrEmpty(textBox.Text))
            {
                placeholderText.Visibility = Visibility.Visible;
            }
            else
            {
                placeholderText.Visibility = Visibility.Collapsed;
            }
        }
        public string TextBoxContent
        {
            get { return textBox.Text; }
            set { textBox.Text = value; }
        }
        public void SetTextBoxText(string text, bool isFocuseRequested)
        {
            textBox.Text = text;
            textBox.BorderBrush = new SolidColorBrush(Colors.Red);
            textBox.BorderThickness = new Thickness(1);

            if (isFocuseRequested) 
            {
                textBox.Focus();
            }
        }

    }
}
