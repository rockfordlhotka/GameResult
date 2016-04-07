using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace GameResult
{
  public class RveConverter : IValueConverter
  {


    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    public object Convert(object value, Type targetType, object parameter, string language)
    {
      var rv = (int)value;
      Color result;

      if (rv < -9)
        result = HexColor.HexToColor("#ff4040");
      else if (rv < -7)
        result = HexColor.HexToColor("#fb607f");
      else if (rv < -5)
        result = HexColor.HexToColor("#b44668");
      else if (rv < -3)
        result = HexColor.HexToColor("#de6360");
      else if (rv < 0)
        result = HexColor.HexToColor("#c08081");
      else if (rv < 4)
        result = HexColor.HexToColor("#4f9d5d");
      else if (rv < 6)
        result = HexColor.HexToColor("#2e8b57");
      else if (rv < 14)
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

  public class RveLabelConverter : IValueConverter
  {

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }

    public object Convert(object value, Type targetType, object parameter, string language)
    {
      var rv = (int)value;
      string result;

      if (rv < -9)
        result = "Terrible (-3 AV/3 rnd)";
      else if (rv < -7)
        result = "Horrible (-2 AV/2 rnd)";
      else if (rv < -5)
        result = "Worse (-2 AV/1 rnd)";
      else if (rv < -3)
        result = "Bad (-1 AV/1 rnd)";
      else if (rv < 0)
        result = "Fail (0)";
      else if (rv < 2)
        result = "Fair (1)";
      else if (rv < 4)
        result = "Fair (2)";
      else if (rv < 6)
        result = "Good (3)";
      else if (rv < 14)
        result = "Great (" + (rv - 2).ToString() + ")";
      else
        result = "Superb (14)";

      return result;
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
      throw new NotImplementedException();
    }
  }
}
