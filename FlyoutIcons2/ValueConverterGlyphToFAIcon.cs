using System.Globalization;

namespace MauiApp1.Converters
{
    public class ValueConverterGlyphToFAIcon : IValueConverter
    {
        #region methods
        public object Convert(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            if (!(value is string tValue )) throw new ArgumentException($"{nameof(ValueConverterGlyphToFAIcon)}");
            return new FontImageSource()
                {
                    Glyph = tValue,
                    FontFamily = "FontAwesome",
                    Color = Colors.Green,
                    Size = 18.0
                };
        }

        public object? ConvertBack(object value, Type targetType, object? parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }

}
