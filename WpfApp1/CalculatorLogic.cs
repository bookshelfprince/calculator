using System;

namespace WindowsFormsApp1
{
  public class CalculatorLogic
  {
    public static double Multiplication(double value1, double value2)
    {
      return value1 * value2;
    }

    public static double Substitution(double previous, double current)
    {
      return previous - current;
    }

    public static double Addition(double value1, double value2)
    {
      return value1 + value2;
    }

    public static double Division(double numerator, double denominator)
    {
      return numerator / denominator;
    }

    public static double Percentage(double previous, double current)
    {
      return previous / 100 * current;
    }

    public static double XSquared(double value)
    {
      return value * value;
    }

    public static double Half(double value)
    {
      return 1 / value;
    }

    public static double SquareRoot(double value)
    {
      return Math.Sqrt(value);
    }

    public static double PlusMinus(double value)
    {
      return value * -1;
    }

    public static double Pi()
    {
      return Math.PI;
    }

    public static double Tan(double value)
    {
      return Math.Tan(value);
    }

    public static double Cos(double value)
    {
      return Math.Cos(value);
    }

    public static double Sin(double value)
    {
      return Math.Sin(value);
    }

    public static double Log(double value)
    {
      return Math.Log(value);
    }

    public static double TenSquared(double value)
    {
      return Math.Pow(10, value);
    }
  }
}