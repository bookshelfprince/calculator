using System;
using System.Diagnostics;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  enum OperatorType //Type of operator
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
  }

  enum ButtonNumberType
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
    Dot = 10,
  }

  enum OperatorState // State (category) of the selected operator type
  {
    None = 0, // += to existing number
    Single = 1, // Operators only depending on one number
    Double = 2, // Operators requiring two numbers
  }
  public partial class Calculator : Form
  {
    private NumberClass displayNumber = new NumberClass();
    private OperatorState operatorState;
    private double previousNumber;
    private OperatorType type;
    private ButtonNumberType numberType;

    public Calculator()
    {
      InitializeComponent();
    }
    private void ButtonOperator_Click(object sender, EventArgs e)
    {
      Button b = (Button)sender;
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
      }
      OperatorPressed(type);
    }
    private void ButtonNumber_Click(object sender, EventArgs e)
    {
      Button b = (Button)sender;
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
      }
      NumberPressed(numberType);
    }

    private void ButtonCE_Click(object sender, EventArgs e)
    {
      operatorState = OperatorState.None;
      displayNumber.NumberValue = 0;
      UpdateDisplay();
    }

    private void ButtonC_Click(object sender, EventArgs e)
    {
      operatorState = OperatorState.None;
      displayNumber.NumberValue = 0;
      previousNumber = 0;
      UpdateDisplay();
    }

    private void ButtonDelete_Click(object sender, EventArgs e)
    {
      var displayLength = displayNumber.StringValue.Length - 1;
      if (displayLength == 0)
        displayNumber.NumberValue = 0;
      else
        displayNumber.StringValue = displayNumber.StringValue.Substring(0, displayLength);
      // displayString = displayString.Remove(displayLength);
      UpdateDisplay();
    }

    private void buttonEqual_Click_1(object sender, EventArgs e)
    {

      displayNumber.StringValue = previousNumber.ToString();
      UpdateDisplay();
    }

    private void NumberPressed(ButtonNumberType numberType)
    {
      string numberString = "";
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
          if (displayNumber.StringValue.Contains(",")) return;
          numberString = ",";
          break;
        default:
          Debug.Assert(false, "Fiks det");
          break;
      }
      if (operatorState == OperatorState.Double)
      {
        previousNumber = displayNumber.NumberValue;
        displayNumber.StringValue = numberString;
      }
      else if (operatorState == OperatorState.Single)
      {
        displayNumber.StringValue = numberString;
      }
      else
      {
        if (displayNumber.StringValue == "0" && numberString == "0") return;
        displayNumber.StringValue += numberString;
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
          displayNumber.NumberValue = displayNumber.NumberValue * previousNumber;
          break;

        case OperatorType.Minus:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          displayNumber.NumberValue = previousNumber - displayNumber.NumberValue;
          break;

        case OperatorType.Plus:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          displayNumber.NumberValue = displayNumber.NumberValue + previousNumber;
          break;

        case OperatorType.Divide:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          displayNumber.NumberValue = previousNumber / displayNumber.NumberValue;
          break;
        case OperatorType.Percentage:
          if (operatorState == OperatorState.Double) return;
          operatorState = OperatorState.Double;
          displayNumber.NumberValue = previousNumber / 100 * displayNumber.NumberValue;
          break;
        case OperatorType.X2:
          operatorState = OperatorState.Single;
          displayNumber.NumberValue = displayNumber.NumberValue * displayNumber.NumberValue;
          break;
        case OperatorType.Half:
          operatorState = OperatorState.Single;
          displayNumber.NumberValue = 1 / displayNumber.NumberValue;
          break;
        case OperatorType.Squareroot:
          operatorState = OperatorState.Single;
          displayNumber.NumberValue = Math.Sqrt(displayNumber.NumberValue);
          break;
        case OperatorType.PlusMinus:
          operatorState = OperatorState.Single;
          if (displayNumber.NumberValue < 0)
            displayNumber.NumberValue = displayNumber.NumberValue + displayNumber.NumberValue;
          else
            displayNumber.NumberValue = (displayNumber.NumberValue - displayNumber.NumberValue) - displayNumber.NumberValue;
          break;
        default:
          Debug.Assert(false, "Fiks det");
          break;
      }
      UpdateDisplay();
    }

    private void UpdateDisplay()
    {
      label1.Text = displayNumber.StringValue;
    }
  }
}