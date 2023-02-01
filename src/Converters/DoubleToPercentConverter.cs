namespace FriedrichRehren.Maui.Helpers.Converters;

using System.Globalization;

public class DoubleToPercentConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
        System.Convert.ToInt32((double)value * 100);

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
         System.Convert.ToDouble(value) / 100;
}