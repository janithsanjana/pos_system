using System;
using System.Globalization;
using System.Windows;
using System.Windows.Data;
using System.Windows.Markup;

namespace POS_Mrtech.Pages
{
    public class ContentToVisibilityConverter : MarkupExtension, IValueConverter
    {
        public override object ProvideValue(IServiceProvider serviceProvider)
        {
            return this;
        }

        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            // Check if the value is of type productpreviews
            if (value is productpreviews)
            {
                // Hide the button
                return Visibility.Collapsed;
            }
            else if (value is addProduct)
            {
                return Visibility.Collapsed;
            }

            // Show the button
            return Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
