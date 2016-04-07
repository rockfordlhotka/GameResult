using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace GameResultRt
{
  public class DamageConverter : IValueConverter
  {


    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    public object Convert(object value, Type targetType, object parameter, string language)
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

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      throw new NotImplementedException();
    }
  }
}
