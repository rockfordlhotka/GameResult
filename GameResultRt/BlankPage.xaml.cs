using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace GameResultRt
{
  /// <summary>
  /// An empty page that can be used on its own or navigated to within a Frame.
  /// </summary>
  public sealed partial class BlankPage : Page
  {
    public BlankPage()
    {
      this.InitializeComponent();

      DataContext = _calc;
    }

    /// <summary>
    /// Invoked when this page is about to be displayed in a Frame.
    /// </summary>
    /// <param name="e">Event data that describes how this page was reached.  The Parameter
    /// property is typically used to configure the page.</param>
    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
    }

    private Calculator _calc = new Calculator();



    private void AsMinus3(object sender, RoutedEventArgs e)
    {
      _calc.AsValue = _calc.AsValue - 3;
    }
    private void AsMinus2(object sender, RoutedEventArgs e)
    {
      _calc.AsValue = _calc.AsValue - 2;
    }
    private void AsMinus1(object sender, RoutedEventArgs e)
    {
      _calc.AsValue = _calc.AsValue - 1;
    }
    private void AsPlus1(object sender, RoutedEventArgs e)
    {
      _calc.AsValue = _calc.AsValue + 1;
    }
    private void AsPlus2(object sender, RoutedEventArgs e)
    {
      _calc.AsValue = _calc.AsValue + 2;
    }
    private void AsPlus3(object sender, RoutedEventArgs e)
    {
      _calc.AsValue = _calc.AsValue + 3;
    }

    private void TvMinus3(object sender, RoutedEventArgs e)
    {
      _calc.TvValue = _calc.TvValue - 3;
    }
    private void TvMinus2(object sender, RoutedEventArgs e)
    {
      _calc.TvValue = _calc.TvValue - 2;
    }
    private void TvMinus1(object sender, RoutedEventArgs e)
    {
      _calc.TvValue = _calc.TvValue - 1;
    }
    private void TvPlus1(object sender, RoutedEventArgs e)
    {
      _calc.TvValue = _calc.TvValue + 1;
    }
    private void TvPlus2(object sender, RoutedEventArgs e)
    {
      _calc.TvValue = _calc.TvValue + 2;
    }
    private void TvPlus3(object sender, RoutedEventArgs e)
    {
      _calc.TvValue = _calc.TvValue + 3;
    }

    private void RollDice(object sender, RoutedEventArgs e)
    {
      _calc.CalcRv();
    }

    private void WeaponMinus3(object sender, RoutedEventArgs e)
    {
      _calc.PlusSvValue = _calc.PlusSvValue - 3;
    }
    private void WeaponMinus2(object sender, RoutedEventArgs e)
    {
      _calc.PlusSvValue = _calc.PlusSvValue - 2;
    }
    private void WeaponMinus1(object sender, RoutedEventArgs e)
    {
      _calc.PlusSvValue = _calc.PlusSvValue - 1;
    }
    private void WeaponPlus1(object sender, RoutedEventArgs e)
    {
      _calc.PlusSvValue = _calc.PlusSvValue + 1;
    }
    private void WeaponPlus2(object sender, RoutedEventArgs e)
    {
      _calc.PlusSvValue = _calc.PlusSvValue + 2;
    }
    private void WeaponPlus3(object sender, RoutedEventArgs e)
    {
      _calc.PlusSvValue = _calc.PlusSvValue + 3;
    }

    private void ArmorMinus3(object sender, RoutedEventArgs e)
    {
      _calc.ArmorValue = _calc.ArmorValue - 3;
    }
    private void ArmorMinus2(object sender, RoutedEventArgs e)
    {
      _calc.ArmorValue = _calc.ArmorValue - 2;
    }
    private void ArmorMinus1(object sender, RoutedEventArgs e)
    {
      _calc.ArmorValue = _calc.ArmorValue - 1;
    }
    private void ArmorPlus1(object sender, RoutedEventArgs e)
    {
      _calc.ArmorValue = _calc.ArmorValue + 1;
    }
    private void ArmorPlus2(object sender, RoutedEventArgs e)
    {
      _calc.ArmorValue = _calc.ArmorValue + 2;
    }
    private void ArmorPlus3(object sender, RoutedEventArgs e)
    {
      _calc.ArmorValue = _calc.ArmorValue + 3;
    }

    private void RollDamage(object sender, RoutedEventArgs e)
    {
      _calc.CalcDamage();
    }

    private void RvMinus3(object sender, RoutedEventArgs e)
    {
      _calc.RvValue -= 3;
    }
    private void RvMinus2(object sender, RoutedEventArgs e)
    {
      _calc.RvValue -= 2;
    }
    private void RvMinus1(object sender, RoutedEventArgs e)
    {
      _calc.RvValue -= 1;
    }
    private void RvPlus1(object sender, RoutedEventArgs e)
    {
      _calc.RvValue += 1;
    }
    private void RvPlus2(object sender, RoutedEventArgs e)
    {
      _calc.RvValue += 2;
    }
    private void RvPlus3(object sender, RoutedEventArgs e)
    {
      _calc.RvValue += 3;
    }

    private void SvMinus3(object sender, RoutedEventArgs e)
    {
      _calc.SvValue -= 3;
    }
    private void SvMinus2(object sender, RoutedEventArgs e)
    {
      _calc.SvValue -= 2;
    }
    private void SvMinus1(object sender, RoutedEventArgs e)
    {
      _calc.SvValue -= 1;
    }
    private void SvPlus1(object sender, RoutedEventArgs e)
    {
      _calc.SvValue += 1;
    }
    private void SvPlus2(object sender, RoutedEventArgs e)
    {
      _calc.SvValue += 2;
    }
    private void SvPlus3(object sender, RoutedEventArgs e)
    {
      _calc.SvValue += 3;
    }

  }
}
