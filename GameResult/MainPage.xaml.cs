using GameResultRt.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234237

namespace GameResultRt
{
  /// <summary>
  /// A basic page that provides characteristics common to most applications.
  /// </summary>
  public sealed partial class MainPage : Page
  {

    private NavigationHelper navigationHelper;
    private ObservableDictionary defaultViewModel = new ObservableDictionary();

    /// <summary>
    /// This can be changed to a strongly typed view model.
    /// </summary>
    public ObservableDictionary DefaultViewModel
    {
      get { return this.defaultViewModel; }
    }

    /// <summary>
    /// NavigationHelper is used on each page to aid in navigation and 
    /// process lifetime management
    /// </summary>
    public NavigationHelper NavigationHelper
    {
      get { return this.navigationHelper; }
    }


    public MainPage()
    {
      this.InitializeComponent();
      this.navigationHelper = new NavigationHelper(this);
      this.navigationHelper.LoadState += navigationHelper_LoadState;
      this.navigationHelper.SaveState += navigationHelper_SaveState;

      DataContext = _calc;

    }

    /// <summary>
    /// Populates the page with content passed during navigation. Any saved state is also
    /// provided when recreating a page from a prior session.
    /// </summary>
    /// <param name="sender">
    /// The source of the event; typically <see cref="NavigationHelper"/>
    /// </param>
    /// <param name="e">Event data that provides both the navigation parameter passed to
    /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
    /// a dictionary of state preserved by this page during an earlier
    /// session. The state will be null the first time a page is visited.</param>
    private void navigationHelper_LoadState(object sender, LoadStateEventArgs e)
    {
    }

    /// <summary>
    /// Preserves state associated with this page in case the application is suspended or the
    /// page is discarded from the navigation cache.  Values must conform to the serialization
    /// requirements of <see cref="SuspensionManager.SessionState"/>.
    /// </summary>
    /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
    /// <param name="e">Event data that provides an empty dictionary to be populated with
    /// serializable state.</param>
    private void navigationHelper_SaveState(object sender, SaveStateEventArgs e)
    {
    }

    #region NavigationHelper registration

    /// The methods provided in this section are simply used to allow
    /// NavigationHelper to respond to the page's navigation methods.
    /// 
    /// Page specific logic should be placed in event handlers for the  
    /// <see cref="GridCS.Common.NavigationHelper.LoadState"/>
    /// and <see cref="GridCS.Common.NavigationHelper.SaveState"/>.
    /// The navigation parameter is available in the LoadState method 
    /// in addition to page state preserved during an earlier session.

    protected override void OnNavigatedTo(NavigationEventArgs e)
    {
      navigationHelper.OnNavigatedTo(e);
    }

    protected override void OnNavigatedFrom(NavigationEventArgs e)
    {
      navigationHelper.OnNavigatedFrom(e);
    }

    #endregion

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
