using System.Globalization;

namespace MauiApp1
{

    public class ToButton1Visible : IValueConverter
    {

        public bool Convert(int value)
        {
            return (bool)Convert(value, typeof(int), null, CultureInfo.InvariantCulture);
        }

        public object Convert(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            var tValue = value is int buttonNumber ? buttonNumber : 4;
            return tValue==0;
        }

        public object? ConvertBack(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

    public class ToButton2Visible : IValueConverter
    {

        public bool Convert(int value)
        {
            return (bool)Convert(value, typeof(int), null, CultureInfo.InvariantCulture);
        }

        public object Convert(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            var tValue = value is int buttonNumber ? buttonNumber : 4;
            return tValue == 1;
        }

        public object? ConvertBack(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }

    public class ToButton3Visible : IValueConverter
    {

        public bool Convert(int value)
        {
            return (bool)Convert(value, typeof(int), null, CultureInfo.InvariantCulture);
        }

        public object Convert(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            var tValue = value is int buttonNumber ? buttonNumber : 4;
            return tValue == 2;
        }

        public object? ConvertBack(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }

    }
}
