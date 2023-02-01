namespace FriedrichRehren.Maui.Helpers.Converters;

using System.Globalization;

public class TimeSpanToStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
        ((TimeSpan)value).ToString((string)parameter);

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        TimeSpan.ParseExact((string)value, (string)parameter, null);
}