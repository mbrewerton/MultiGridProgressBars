using System;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Data;

namespace MultiGridProgressBars.Converters
{
    public class InvertIsCheckedVisiblityConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, string language)
        {
            bool isChecked = (bool) value;
            return isChecked ? Visibility.Collapsed : Visibility.Visible;
        }

        public object ConvertBack(object value, Type targetType, object parameter, string language)
        {
            return null;
        }
    }
}
