namespace FriedrichRehren.Maui.Helpers.Converters;

using System.Globalization;

public class DoubleToTimeSpanStringConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, CultureInfo culture) =>
        TimeSpan.FromSeconds((double)value).ToString((string)parameter);

    public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
        TimeSpan.ParseExact((string)value, (string)parameter, null).TotalSeconds;
}