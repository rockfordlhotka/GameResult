using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace GameResult
{
  public class DieConverter : IValueConverter
  {


    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    public object Convert(object value, Type targetType, object parameter, string language)
    {
      var die = (int)value;
      Color result = Colors.Black;

      if (die < -4)
        result = HexColor.HexToColor("#770f05");
      else if (die < 0)
        result = HexColor.HexToColor("#b32d29");
      else if (die == 0)
        result = HexColor.HexToColor("#549019");
      else if (die > 0)
        result = HexColor.HexToColor("#4fa83d");
      else if (die > 4)
        result = HexColor.HexToColor("#7fff00");

      return new SolidColorBrush(result);
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      throw new NotImplementedException();
    }
  }
}
