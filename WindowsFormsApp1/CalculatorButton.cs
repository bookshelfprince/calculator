using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  public sealed partial class CalculatorButton : Button
  {
    public enum ButtonColor
    {
      Gainsboro = 0,
      WhiteSmoke = 1,
      White = 2
    }

    public enum ButtonFontColor
    {
      Default = 0,
      Gray = 1
    }

    public CalculatorButton(string name, ButtonColor color, string text)
    {
      InitializeComponent();
      switch (color)
      {
        case ButtonColor.Gainsboro:
          BackColor = Color.Gainsboro;
          break;
        case ButtonColor.WhiteSmoke:
          BackColor = Color.WhiteSmoke;
          break;
        case ButtonColor.White:
          BackColor = Color.White;
          break;
      }

      FlatAppearance.BorderSize = 0;
      Dock = DockStyle.Fill;
      FlatAppearance.CheckedBackColor = Color.Silver;
      FlatAppearance.MouseDownBackColor = Color.Silver;
      FlatAppearance.MouseOverBackColor = Color.Silver;
      FlatStyle = FlatStyle.Flat;
      Font = new Font("Microsoft Sans Serif", 20.00F);
      Margin = new Padding(0);
      Name = name;
      Text = text;
      AutoSize = true;
    }

    public CalculatorButton(string name, string text, ButtonFontColor color)
    {
      InitializeComponent();
      switch (color)
      {
        case ButtonFontColor.Gray:
          ForeColor = Color.FromArgb(64, 64, 64);
          break;
        default:
          break;
      }

      BackColor = Color.Gainsboro;
      Dock = DockStyle.Fill;
      FlatAppearance.BorderSize = 0;
      FlatAppearance.CheckedBackColor = Color.Silver;
      FlatAppearance.MouseDownBackColor = Color.Silver;
      FlatAppearance.MouseOverBackColor = Color.Silver;
      FlatStyle = FlatStyle.Flat;
      Font = new Font("Microsoft Sans Serif", 20.00F);
      Margin = new Padding(0);
      Name = name;
      Text = text;
      AutoSize = true;
    }
  }
}