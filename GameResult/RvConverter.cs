using System;
using System.Windows.Media;
using System.Windows.Data;

namespace GameResult
{
  public class RvConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      var rv = (int)value;
      Color result;

      if (rv < -8)
        result = HexColor.HexToColor("#ff4040");
      else if (rv < -6)
        result = HexColor.HexToColor("#fb607f");
      else if (rv < -4)
        result = HexColor.HexToColor("#b44668");
      else if (rv < -2)
        result = HexColor.HexToColor("#de6360");
      else if (rv < 0)
        result = HexColor.HexToColor("#c08081");
      else if (rv < 4)
        result = HexColor.HexToColor("#4f9d5d");
      else if (rv < 8)
        result = HexColor.HexToColor("#2e8b57");
      else if (rv < 12)
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

  public class RvLabelConverter : IValueConverter
  {
    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      var rv = (int)value;
      var rvs = Calculator.RVs(rv).ToString();
      string result;

      if (rv < -8)
        result = "Terrible (" + rvs + " AV/3 rnd)";
      else if (rv < -6)
        result = "Horrible (" + rvs + " AV/2 rnd)";
      else if (rv < -4)
        result = "Worse (" + rvs + " AV/1 rnd)";
      else if (rv < -2)
        result = "Bad (" + rvs + " AV/1 rnd)";
      else if (rv < 0)
        result = "Fail";
      else if (rv < 2)
        result = "Fair (+" + rvs + " SV)";
      else if (rv < 4)
        result = "Fair (+" + rvs + " SV)";
      else if (rv < 8)
        result = "Good (+" + rvs + " SV)";
      else if (rv < 12)
        result = "Great (+" + rvs + " SV)";
      else
        result = "Superb (+" + rvs + " SV)";

      return result;
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
