using System;
using System.Windows.Media;
using System.Windows.Data;

namespace GameResult
{
  public class DamageConverter : IValueConverter
  {

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      var rv = (int)value;
      Color result = Colors.Black;

      if (rv < 4)
        result = HexColor.HexToColor("#4f9d5d");
      else if (rv < 8)
        result = HexColor.HexToColor("#2e8b57");
      else if (rv < 11)
        result = HexColor.HexToColor("#228b22");
      else
        result = HexColor.HexToColor("#3fff00");

      return new SolidColorBrush(result);
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
