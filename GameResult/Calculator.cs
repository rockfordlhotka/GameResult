using System;
using System.Linq;
using System.ComponentModel;

namespace GameResult
{
  public class Calculator : INotifyPropertyChanged
  {
    private int _tv = 5;
    public int TvValue
    {
      get { return _tv; }
      set 
      { 
        _tv = value; 
        OnPropertyChanged("TvValue");
        CalcRv();
      }
    }

    private int _as = 5;
    public int AsValue
    {
      get { return _as; }
      set 
      { 
        _as = value; 
        OnPropertyChanged("AsValue");
        CalcRv();
      }
    }

    private int _rv;
    public int RvValue
    {
      get { return _rv; }
      set 
      { 
        _rv = value; 
        OnPropertyChanged("RvValue");
        CalcSv();
      }
    }

    private int _roll;
    public int RollValue
    {
      get { return _roll; }
      set { _roll = value; OnPropertyChanged("RollValue"); }
    }

    public void CalcRv()
    {
      RollValue = Dice.Roll(4, 3);
      RvValue = (AsValue + RollValue) - TvValue;
    }

    private int _plusSv;
    public int PlusSvValue
    {
      get { return _plusSv; }
      set 
      { 
        _plusSv = value; 
        OnPropertyChanged("PlusSvValue");
        CalcSv();
      }
    }

    private int _svValue;
    public int SvValue
    {
      get { return _svValue; }
      set 
      { 
        _svValue = value;
        if (_svValue < 0)
          _svValue = 0;
        OnPropertyChanged("SvValue");
        CalcDamage();
      }
    }

    public void CalcSv()
    {
      SvValue = RVs(RvValue) + PlusSvValue + ArmorValue;
    }

    private int _armor;
    public int ArmorValue
    {
      get { return _armor; }
      set 
      { 
        _armor = value; 
        OnPropertyChanged("ArmorValue");
        CalcSv();
      }
    }

    private int _damage;
    public int DamageValue
    {
      get { return _damage; }
      set { _damage = value; OnPropertyChanged("DamageValue"); }
    }

    private int _fat;
    public int FatValue
    {
      get { return _fat; }
      set { _fat = value; OnPropertyChanged("FatValue"); }
    }

    private int _vit;
    public int VitValue
    {
      get { return _vit; }
      set { _vit = value; OnPropertyChanged("VitValue"); }
    }

    private int _wnd;
    public int WndValue
    {
      get { return _wnd; }
      set { _wnd = value; OnPropertyChanged("WndValue"); }
    }

    public void CalcDamage()
    {
      DamageValue = RollSvResult();
      CalcActualDamage();
    }

    public void CalcActualDamage()
    {
      if (DamageValue < 20)
      {
        FatValue = DamageValue;
        switch (DamageValue)
        {
          case 5:
            VitValue = 1;
            WndValue = 0;
            break;
          case 6:
            VitValue = 2;
            WndValue = 0;
            break;
          case 7:
            VitValue = 4;
            WndValue = 1;
            break;
          case 8:
            VitValue = 6;
            WndValue = 1;
            break;
          case 9:
            VitValue = 8;
            WndValue = 1;
            break;
          case 10:
            VitValue = 10;
            WndValue = 2;
            break;
          case 11:
            VitValue = 11;
            WndValue = 2;
            break;
          case 12:
            VitValue = 12;
            WndValue = 2;
            break;
          case 13:
            VitValue = 13;
            WndValue = 2;
            break;
          case 14:
            VitValue = 14;
            WndValue = 2;
            break;
          case 15:
            VitValue = 15;
            WndValue = 3;
            break;
          case 16:
            VitValue = 16;
            WndValue = 3;
            break;
          case 17:
            VitValue = 17;
            WndValue = 3;
            break;
          case 18:
            VitValue = 18;
            WndValue = 3;
            break;
          case 19:
            VitValue = 19;
            WndValue = 3;
            break;
          default:
            VitValue = 0;
            WndValue = 0;
            break;
        }
      }
      else
      {
        var old = DamageValue;
        var count = DamageValue / 10;
        DamageValue = 10;
        CalcActualDamage();
        DamageValue = old;
        FatValue = FatValue * count;
        VitValue = VitValue * count;
        WndValue = WndValue * count;
      }
    }

    public int RollSvResult()
    {
      var roll = 0;
      if (RvValue >= 0)
      {
        switch (SvValue)
        {
          case 0:
            roll = Dice.Roll(1, 2);
            break;
          case 1:
            roll = (Dice.Roll(1, 6) + 1) / 2;
            if (roll > 3) roll = 3;
            break;
          case 2:
            roll = Dice.Roll(1, 6);
            break;
          case 3:
            roll = Dice.Roll(1, 8);
            break;
          case 4:
            roll = Dice.Roll(1, 10);
            break;
          case 5:
            roll = Dice.Roll(1, 12);
            break;
          case 6:
            roll = Dice.Roll(1, 6) + Dice.Roll(1, 8);
            break;
          case 7:
            roll = Dice.Roll(2, 8);
            break;
          case 8:
            roll = Dice.Roll(2, 10);
            break;
          case 9:
            roll = Dice.Roll(2, 12);
            break;
          case 10:
            roll = Dice.Roll(3, 10);
            break;
          case 11:
            roll = Dice.Roll(3, 12);
            break;
          case 12:
          case 13:
          case 14:
            roll = Dice.Roll(4, 10);
            break;
          case 15:
          case 16:
            roll = Dice.Roll(1, 6) * 10;
            break;
          case 17:
          case 18:
            roll = Dice.Roll(1, 8) * 10;
            break;
          default:
            roll = Dice.Roll(1, 10) * 10;
            break;
        }
      }
      return roll;
    }

    public static int RVs(int rv)
    {
      int result = 0;
      if (rv < -8)
        result = -3;
      else if (rv < -6)
        result = -2;
      else if (rv < -4)
        result = -2;
      else if (rv < -2)
        result = -1;
      else if (rv < 2)
        result = 0;
      else if (rv < 4)
        result = 1;
      else if (rv < 8)
        result = 2;
      else if (rv < 12)
        result = 3;
      else 
        result = 4;
      return result;
    }

    public event PropertyChangedEventHandler PropertyChanged;

    protected virtual void OnPropertyChanged(string propertyName)
    {
      if (PropertyChanged != null)
        PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
    }
  }
}
