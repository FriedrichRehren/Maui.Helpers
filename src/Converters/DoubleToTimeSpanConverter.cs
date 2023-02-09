namespace FriedrichRehren.Maui.Helpers.Converters;

using System.Globalization;

public class DoubleToTimeSpanConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
        ((TimeSpan)value).TotalSeconds;

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        TimeSpan.FromSeconds((double)value);
}