using System;
using System.Globalization;
using System.Threading;
using System.Windows;
using System.Windows.Controls;
using WindowsFormsApp1;

namespace WpfApp1
{
  /// <summary>
  ///   Interaction logic for MainWindow.xaml
  /// </summary>
  internal enum OperatorType
  {
    Uknown = 0,
    Percentage = 1,
    Squareroot = 2,
    X2 = 3,
    Half = 4,
    Divide = 5,
    Multiply = 6,
    Plus = 7,
    Minus = 8,
    PlusMinus = 9,
    Pi = 10,
    Tan = 11,
    Cos = 12,
    Sin = 13,
    Log = 14,
    TenSquared = 15
  }

  internal enum ButtonNumberType
  {
    Zero = 0,
    One = 1,
    Two = 2,
    Three = 3,
    Four = 4,
    Five = 5,
    Six = 6,
    Seven = 7,
    Eight = 8,
    Nine = 9,
    Dot = 10
  }

  internal enum MemoryFunction
  {
    MC = 0,
    Mminus = 1,
    MR = 2,
    Mplus = 3,
    MS = 4
  }

  internal enum OperatorState
  {
    None = 0, // sets displayString
    Single = 1, // expects displayNumber
    Double = 2 // expects previousValue and displayNumber
  }

  public partial class MainWindow : Window
  {
    private readonly MemoryClass memoryClass = new MemoryClass();
    private readonly ProgrammerCalculatorControl programmerCalculator;
    private readonly ScienceCalculatorControl scienceCalculator;
    private readonly StandardCalculatorControl standardCalculator;

    public MainWindow()
    {
      InitializeComponent();
      var customCulture = (CultureInfo) Thread.CurrentThread.CurrentCulture.Clone();
      customCulture.NumberFormat.NumberDecimalSeparator = ".";
      Thread.CurrentThread.CurrentCulture = customCulture;
      standardCalculator = new StandardCalculatorControl(memoryClass);
      scienceCalculator = new ScienceCalculatorControl(memoryClass);
      programmerCalculator = new ProgrammerCalculatorControl(memoryClass);
      label1.Content = @"Standard";
      grid.Children.Remove(scienceCalculator);
      grid.Children.Remove(programmerCalculator);
      grid.Children.Add(standardCalculator);
      Grid.SetColumn(standardCalculator, 0);
      Grid.SetColumnSpan(standardCalculator, 2);
      Grid.SetRow(standardCalculator, 1);
    }

    private void standardCalc_Click(object sender, EventArgs e)
    {
      label1.Content = @"Standard";
      grid.Children.Remove(standardCalculator);
      grid.Children.Remove(scienceCalculator);
      grid.Children.Remove(programmerCalculator);
      grid.Children.Add(standardCalculator);
      Grid.SetColumn(standardCalculator, 0);
      Grid.SetColumnSpan(standardCalculator, 2);
      Grid.SetRow(standardCalculator, 1);
    }

    private void scienceCalc_Click(object sender, EventArgs e)
    {
      label1.Content = @"Science";
      grid.Children.Remove(standardCalculator);
      grid.Children.Remove(scienceCalculator);
      grid.Children.Remove(programmerCalculator);
      grid.Children.Add(scienceCalculator);
      Grid.SetColumn(scienceCalculator, 0);
      Grid.SetColumnSpan(scienceCalculator, 2);
      Grid.SetRow(scienceCalculator, 1);
    }

    private void programmerCalc_Click(object sender, EventArgs e)
    {
      label1.Content = @"Programmer";
      grid.Children.Remove(standardCalculator);
      grid.Children.Remove(scienceCalculator);
      grid.Children.Remove(programmerCalculator);
      grid.Children.Add(programmerCalculator);
      Grid.SetColumn(programmerCalculator, 0);
      Grid.SetColumnSpan(programmerCalculator, 2);
      Grid.SetRow(programmerCalculator, 1);
    }
  }
}