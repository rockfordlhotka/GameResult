using System;
using System.Windows.Data;

namespace GameResult
{
  public class Class2Converter : IValueConverter
  {

    public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      var v = (int)value;
      v = v / 10;
      if (v == 0)
        return "-";
      else
        return v.ToString();
    }

    public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
    {
      throw new NotImplementedException();
    }
  }
}
