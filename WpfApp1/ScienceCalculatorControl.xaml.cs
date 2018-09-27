using System;
using System.Diagnostics;
using System.Globalization;
using System.Windows.Controls;
using WindowsFormsApp1;

namespace WpfApp1
{
  /// <summary>
  ///   Interaction logic for ScienceCalculatorControl.xaml
  /// </summary>
  public partial class ScienceCalculatorControl : UserControl
  {
    private readonly MemoryClass memoryClass;
    private readonly NumberClass numberClass = new NumberClass();
    private MemoryFunction memoryFunction;
    private ButtonNumberType numberType;
    private OperatorState operatorState;
    private OperatorType type;

    public ScienceCalculatorControl(MemoryClass memoryclass)
    {
      InitializeComponent();
      memoryClass = memoryclass;
      // disable memory buttons till memory is added
      buttonMR.IsEnabled = false;
      buttonMplus.IsEnabled = false;
      buttonMC.IsEnabled = false;
      buttonMminus.IsEnabled = false;
    }

    private void ButtonMemory_Click(object sender, EventArgs e)
    {
      var b = (Button) sender;
      switch (b.Name)
      {
        case "buttonMC": //Memory clear
          memoryFunction = MemoryFunction.MC;
          buttonMR.IsEnabled = false;
          buttonMplus.IsEnabled = false;
          buttonMC.IsEnabled = false;
          buttonMminus.IsEnabled = false;
          break;
        case "buttonMR": // Memory Revert
          memoryFunction = MemoryFunction.MR; //MR
          break;
        case "buttonMplus": // Add to memory
          memoryFunction = MemoryFunction.Mplus;
          break;
        case "buttonMminus": // Remove from memory
          memoryFunction = MemoryFunction.Mminus;
          break;
        case "buttonMS": // Store in memory
          memoryFunction = MemoryFunction.MS;
          // enable memory buttons
          buttonMR.IsEnabled = true;
          buttonMplus.IsEnabled = true;
          buttonMC.IsEnabled = true;
          buttonMminus.IsEnabled = true;
          break;
      }

      MemoryPressed(memoryFunction);
    }

    private void ButtonOperator_Click(object sender, EventArgs e)
    {
      var b = (Button) sender;
      switch (b.Name)
      {
        case "buttonPercentage":
          type = OperatorType.Percentage;
          break;
        case "buttonSquareRoot":
          type = OperatorType.Squareroot;
          break;
        case "buttonXSquared":
          type = OperatorType.X2;
          break;
        case "buttonHalf":
          type = OperatorType.Half;
          break;
        case "buttonDivision":
          type = OperatorType.Divide;
          break;
        case "buttonMultiplication":
          type = OperatorType.Multiply;
          break;
        case "buttonMinus":
          type = OperatorType.Minus;
          break;
        case "buttonPlus":
          type = OperatorType.Plus;
          break;
        case "buttonPlusMinus":
          type = OperatorType.PlusMinus;
          break;
        case "buttonPi":
          type = OperatorType.Pi;
          break;
        case "buttonTan":
          type = OperatorType.Tan;
          break;
        case "buttonCos":
          type = OperatorType.Cos;
          break;
        case "buttonSin":
          type = OperatorType.Sin;
          break;
        case "buttonLog":
          type = OperatorType.Log;
          break;
        case "button10Square":
          type = OperatorType.TenSquared;
          break;
        default:
          Debug.Assert(false, "Fiks det");
          break;
      }

      OperatorPressed(type);
    }

    private void ButtonNumber_Click(object sender, EventArgs e)
    {
      var b = (Button) sender;
      switch (b.Name)
      {
        case "button0":
          numberType = ButtonNumberType.Zero;
          break;
        case "button1":
          numberType = ButtonNumberType.One;
          break;
        case "button2":
          numberType = ButtonNumberType.Two;
          break;
        case "button3":
          numberType = ButtonNumberType.Three;
          break;
        case "button4":
          numberType = ButtonNumberType.Four;
          break;
        case "button5":
          numberType = ButtonNumberType.Five;
          break;
        case "button6":
          numberType = ButtonNumberType.Six;
          break;
        case "button7":
          numberType = ButtonNumberType.Seven;
          break;
        case "button8":
          numberType = ButtonNumberType.Eight;
          break;
        case "button9":
          numberType = ButtonNumberType.Nine;
          break;
        case "buttonDot":
          numberType = ButtonNumberType.Dot;
          break;
        default:
          Debug.Assert(false, "Fiks det");
          break;
      }

      NumberPressed(numberType);
    }

    private void ButtonCE_Click(object sender, EventArgs e)
    {
      operatorState = OperatorState.Single;
      numberClass.NumberValue = 0;
      UpdateDisplay();
    }

    private void ButtonC_Click(object sender, EventArgs e)
    {
      operatorState = OperatorState.Single;
      numberClass.NumberValue = 0;
      numberClass.PreviousValue = 0;
      UpdateDisplay();
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      operatorState = OperatorState.Single;
      var displayLength = numberClass.StringValue.Length - 1;
      if (displayLength == 0)
        numberClass.NumberValue = 0;
      else
        numberClass.StringValue = numberClass.StringValue.Substring(0, displayLength);
      UpdateDisplay();
    }

    private void buttonEqual_Click_1(object sender, EventArgs e)
    {
      numberClass.StringValue = numberClass.PreviousValue.ToString(CultureInfo.InvariantCulture);
      UpdateDisplay();
    }

    private void NumberPressed(ButtonNumberType numberType)
    {
      var numberString = "0";
      switch (numberType)
      {
        case ButtonNumberType.Zero:
          numberString = "0";
          break;
        case ButtonNumberType.One:
          numberString = "1";
          break;
        case ButtonNumberType.Two:
          numberString = "2";
          break;
        case ButtonNumberType.Three:
          numberString = "3";
          break;
        case ButtonNumberType.Four:
          numberString = "4";
          break;
        case ButtonNumberType.Five:
          numberString = "5";
          break;
        case ButtonNumberType.Six:
          numberString = "6";
          break;
        case ButtonNumberType.Seven:
          numberString = "7";
          break;
        case ButtonNumberType.Eight:
          numberString = "8";
          break;
        case ButtonNumberType.Nine:
          numberString = "9";
          break;
        case ButtonNumberType.Dot:
          if (numberClass.StringValue == "0")
            numberClass.StringValue += "0.";
          if (numberClass.StringValue.Contains(".")) return;
          else
            numberString = ".";
          break;
        default:
          Debug.Assert(false, "Fiks det");
          break;
      }

      switch (operatorState)
      {
        case OperatorState.None:
          if (numberClass.StringValue == "0" || Math.Abs(numberClass.NumberValue) < 0) return;
          numberClass.StringValue += numberString;
          break;
        case OperatorState.Single:
          numberClass.StringValue = numberString;
          break;
        case OperatorState.Double:
          numberClass.PreviousValue = numberClass.NumberValue;
          numberClass.StringValue = numberString;
          break;
        default:
          Debug.Assert(false, "Fiks det");
          break;
      }

      operatorState = OperatorState.None;
      UpdateDisplay();
    }

    private void OperatorPressed(OperatorType type)
    {
      switch (type)
      {
        case OperatorType.Multiply:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          numberClass.NumberValue = CalculatorLogic.Multiplication(numberClass.NumberValue, numberClass.PreviousValue);
          break;
        case OperatorType.Minus:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          numberClass.NumberValue = CalculatorLogic.Substitution(numberClass.PreviousValue, numberClass.NumberValue);
          break;
        case OperatorType.Plus:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          numberClass.NumberValue = CalculatorLogic.Addition(numberClass.NumberValue, numberClass.PreviousValue);
          break;
        case OperatorType.Divide:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          numberClass.NumberValue = CalculatorLogic.Division(numberClass.PreviousValue, numberClass.NumberValue);
          break;
        case OperatorType.Percentage:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          numberClass.NumberValue = CalculatorLogic.Percentage(numberClass.PreviousValue, numberClass.NumberValue);
          break;
        case OperatorType.X2:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.XSquared(numberClass.NumberValue);
          break;
        case OperatorType.Half:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.XSquared(numberClass.NumberValue);
          break;
        case OperatorType.Squareroot:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.SquareRoot(numberClass.NumberValue);
          break;
        case OperatorType.PlusMinus:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.PlusMinus(numberClass.NumberValue);
          break;
        case OperatorType.Pi:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.Pi();
          break;
        case OperatorType.Tan:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.Tan(numberClass.NumberValue);
          break;
        case OperatorType.Cos:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.Cos(numberClass.NumberValue);
          break;
        case OperatorType.Sin:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.Sin(numberClass.NumberValue);
          break;
        case OperatorType.Log:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.Log(numberClass.NumberValue);
          break;
        case OperatorType.TenSquared:
          operatorState = OperatorState.Single;
          numberClass.NumberValue = CalculatorLogic.TenSquared(numberClass.NumberValue);
          break;
        default:
          Debug.Assert(false, "Fiks det");
          break;
      }

      numberClass.PreviousValue = numberClass.NumberValue;
      UpdateDisplay();
    }

    private void MemoryPressed(MemoryFunction memoryFunction)
    {
      operatorState = OperatorState.Single;
      switch (memoryFunction)
      {
        case MemoryFunction.MS:
          memoryClass.MemoryValue = numberClass.NumberValue;
          break;
        case MemoryFunction.MC:
          memoryClass.ClearMemory = 0;
          break;
        case MemoryFunction.MR:
          memoryClass.RevertMemory = 0;
          break;
        case MemoryFunction.Mplus:
          memoryClass.PlusMemory = 0;
          break;
        case MemoryFunction.Mminus:
          memoryClass.MinusMemory = 0;
          break;
      }

      label2.Text = memoryClass.MemoryValue.ToString(CultureInfo.InvariantCulture);
    }

    public void UpdateDisplay()
    {
      label1.Text = numberClass.StringValue;
    }
  }
}