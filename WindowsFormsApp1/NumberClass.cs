using System;
using System.Globalization;

namespace WindowsFormsApp1
{
  public class NumberClass
  {
    private double numberValue;
    private string stringValue;

    public string StringValue
    {
      get => stringValue;
      set
      {
        stringValue = value;
        numberValue = Convert.ToDouble(stringValue);
      }
    }

    public double NumberValue
    {
      get => numberValue;
      set
      {
        numberValue = value;
        stringValue = numberValue.ToString(CultureInfo.InvariantCulture);
      }
    }

    public double PreviousValue { get; set; }
  }
}