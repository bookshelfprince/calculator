using System;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
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
    M = 2,
    Mplus = 3,
    MS = 4,
  }

  internal enum OperatorState
  {
    None = 0, // sets displayString
    Single = 1, // expects displayNumber
    Double = 2 // expects previousValue and displayNumber
  }

  public partial class CalculatorForm : Form
  {
    private ScienceCalculatorControl scienceCalculator;
    private StandardCalculatorControl standardCalculator;
    private ProgrammerCalculatorControl programmerCalculator;
    private MemoryClass memoryClass = new MemoryClass();

    public CalculatorForm()
    {
      InitializeComponent();
      scienceCalculator = new ScienceCalculatorControl(memoryClass);
      standardCalculator = new StandardCalculatorControl(memoryClass);
      programmerCalculator = new ProgrammerCalculatorControl(memoryClass);
      label1.Text = @"Standard";
      tableLayoutPanel1.Controls.Add(standardCalculator, 0, 1);
      tableLayoutPanel1.SetColumnSpan(standardCalculator, 2);
      standardCalculator.Dock = DockStyle.Fill;
    }

    private void standardCalc_Click(object sender, EventArgs e)
    {
      label1.Text = @"Standard";
      tableLayoutPanel1.Controls.Remove(scienceCalculator);
      tableLayoutPanel1.Controls.Remove(programmerCalculator);
      tableLayoutPanel1.Controls.Add(standardCalculator, 0, 1);
      tableLayoutPanel1.SetColumnSpan(standardCalculator, 2);
      standardCalculator.Dock = DockStyle.Fill;
    }

    private void scienceCalc_Click(object sender, EventArgs e)
    {
      label1.Text = @"Science";
      tableLayoutPanel1.Controls.Remove(standardCalculator);
      tableLayoutPanel1.Controls.Remove(programmerCalculator);
      tableLayoutPanel1.Controls.Add(scienceCalculator, 0, 1);
      tableLayoutPanel1.SetColumnSpan(scienceCalculator, 2);
      scienceCalculator.Dock = DockStyle.Fill;
    }

    private void programmerCalc_Click(object sender, EventArgs e)
    {
      label1.Text = @"Programmer";
      tableLayoutPanel1.Controls.Remove(standardCalculator);
      tableLayoutPanel1.Controls.Remove(scienceCalculator);
      tableLayoutPanel1.Controls.Add(programmerCalculator, 0, 1);
      tableLayoutPanel1.SetColumnSpan(programmerCalculator, 2);
      programmerCalculator.Dock = DockStyle.Fill;
    }
  }
}