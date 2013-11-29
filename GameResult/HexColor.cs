using System.Windows.Media;
using System.Globalization;

namespace GameResult
{
  public class HexColor
  {
    public static Color HexToColor(string hexColor)
    {
      //Remove # if present
      if (hexColor.IndexOf('#') != -1)
        hexColor = hexColor.Replace("#", "");

      byte red = 0;
      byte green = 0;
      byte blue = 0;

      if (hexColor.Length == 6)
      {
        //#RRGGBB
        red = byte.Parse(hexColor.Substring(0, 2), NumberStyles.AllowHexSpecifier);
        green = byte.Parse(hexColor.Substring(2, 2), NumberStyles.AllowHexSpecifier);
        blue = byte.Parse(hexColor.Substring(4, 2), NumberStyles.AllowHexSpecifier);


      }
      else if (hexColor.Length == 3)
      {
        //#RGB
        red = byte.Parse(hexColor[0].ToString() + hexColor[0].ToString(), NumberStyles.AllowHexSpecifier);
        green = byte.Parse(hexColor[1].ToString() + hexColor[1].ToString(), NumberStyles.AllowHexSpecifier);
        blue = byte.Parse(hexColor[2].ToString() + hexColor[2].ToString(), NumberStyles.AllowHexSpecifier);
      }

      return Color.FromArgb(255, red, green, blue);
    }

    public static bool IsValidHex(string hexColor)
    {
      if (hexColor.StartsWith("#"))
        return hexColor.Length == 7 || hexColor.Length == 4;
      else
        return hexColor.Length == 6 || hexColor.Length == 3;
    }
  }
}
