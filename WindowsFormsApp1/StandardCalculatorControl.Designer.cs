using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
  partial class StandardCalculatorControl
  {
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (components != null))
      {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {

      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(StandardCalculatorControl));
      this.label1 = new System.Windows.Forms.Label();
      this.button0 = new CalculatorButton("button0", "0", CalculatorButton.ButtonFontColor.Default);
      this.button1 = new CalculatorButton("button1", "1", CalculatorButton.ButtonFontColor.Default);
      this.button2 = new CalculatorButton("button2", "2", CalculatorButton.ButtonFontColor.Default);
      this.button3 = new CalculatorButton("button3", "3", CalculatorButton.ButtonFontColor.Default);
      this.button4 = new CalculatorButton("button4", "4", CalculatorButton.ButtonFontColor.Default);
      this.button5 = new CalculatorButton("button5", "5", CalculatorButton.ButtonFontColor.Default);
      this.button6 = new CalculatorButton("button6", "6", CalculatorButton.ButtonFontColor.Default);
      this.button7 = new CalculatorButton("button7", "7", CalculatorButton.ButtonFontColor.Default);
      this.button8 = new CalculatorButton("button8", "8", CalculatorButton.ButtonFontColor.Default);
      this.button9 = new CalculatorButton("button9", "9", CalculatorButton.ButtonFontColor.Default);
      this.buttonDot = new CalculatorButton("buttonDot", ".", CalculatorButton.ButtonFontColor.Default);
      this.buttonEqual = new CalculatorButton("buttonEqual", "=", CalculatorButton.ButtonFontColor.Default);
      this.buttonPlusMinus = new CalculatorButton("buttonPlusMinus", "±", CalculatorButton.ButtonFontColor.Gray);
      this.buttonC = new CalculatorButton("buttonC", "C", CalculatorButton.ButtonFontColor.Gray);
      this.buttonCE = new CalculatorButton("buttonCE", "CE", CalculatorButton.ButtonFontColor.Gray);
      this.buttonPlus = new CalculatorButton("buttonPlus", "+", CalculatorButton.ButtonFontColor.Gray);
      this.buttonDelete = new CalculatorButton("buttonDelete", "", CalculatorButton.ButtonFontColor.Gray);
      this.buttonDivision = new CalculatorButton("buttonDivision", "÷", CalculatorButton.ButtonFontColor.Gray);
      this.buttonMultiplication = new CalculatorButton("buttonMultiplication", "×", CalculatorButton.ButtonFontColor.Gray);
      this.buttonMinus = new CalculatorButton("buttonMinus", "-", CalculatorButton.ButtonFontColor.Gray);
      this.buttonPercentage = new CalculatorButton("buttonPercentage", CalculatorButton.ButtonColor.WhiteSmoke, "%");
      this.buttonSquareRoot = new CalculatorButton("buttonSquareRoot", CalculatorButton.ButtonColor.WhiteSmoke, "√");
      this.buttonXSquared = new CalculatorButton("buttonXSquared", CalculatorButton.ButtonColor.WhiteSmoke, "x");
      this.buttonHalf = new CalculatorButton("buttonHalf", CalculatorButton.ButtonColor.WhiteSmoke, "⅟");
      this.buttonMC = new CalculatorButton("buttonMC", CalculatorButton.ButtonColor.White, "MC");
      this.buttonMplus = new CalculatorButton("buttonMplus", CalculatorButton.ButtonColor.White, "M+");
      this.buttonMminus = new CalculatorButton("buttonMminus", CalculatorButton.ButtonColor.White, "M-");
      this.buttonM = new CalculatorButton("buttonM", CalculatorButton.ButtonColor.White, "MR");
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.White;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tableLayoutPanel1.SetColumnSpan(this.label1, 4);
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.8F);
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(397, 118);
      this.label1.TabIndex = 1;
      this.label1.Text = "0";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

      // 
      // buttonPlusMinus
      // 
      this.buttonPlusMinus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonDot
      // 
      this.buttonDot.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button0
      // 
      this.button0.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button1
      // 
      this.button1.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button2
      // 
      this.button2.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button3
      // 
      this.button3.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button4
      // 
      this.button4.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button5
      // 
      this.button5.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button6
      // 
      this.button6.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button7
      // 
      this.button7.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button8
      // 
      this.button8.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button9
      // 
      this.button9.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // buttonEqual
      // 
      this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click_1);
      // 
      // buttonC
      // 
      this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
      // 
      // buttonCE
      // 
      this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
      // 
      // buttonPlus
      // 
      this.buttonPlus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Image = global::WindowsFormsApp1.Properties.Resources.delete_512;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
      // 
      // buttonDivision
      // 
      this.buttonDivision.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMultiplication
      // 
      this.buttonMultiplication.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMinus
      // 
      this.buttonMinus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonPercentage
      // 
      this.buttonPercentage.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonSquareRoot
      // 
      this.buttonSquareRoot.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonXSquared
      // 
      this.buttonXSquared.Image = global::WindowsFormsApp1.Properties.Resources.square_5122222;
      this.buttonXSquared.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonHalf
      // 
      this.buttonHalf.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMC
      // 
      this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      // 
      // buttonMplus
      // 
      this.buttonMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      // 
      // buttonMminus
      // 
      this.buttonMminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      // 
      // buttonM
      // 
      this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 4;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.buttonEqual, 3, 7);
      this.tableLayoutPanel1.Controls.Add(this.buttonM, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.buttonDot, 2, 7);
      this.tableLayoutPanel1.Controls.Add(this.button0, 1, 7);
      this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 3, 6);
      this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 3, 5);
      this.tableLayoutPanel1.Controls.Add(this.buttonPlusMinus, 0, 7);
      this.tableLayoutPanel1.Controls.Add(this.button3, 2, 6);
      this.tableLayoutPanel1.Controls.Add(this.buttonHalf, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.button2, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.button6, 2, 5);
      this.tableLayoutPanel1.Controls.Add(this.button1, 0, 6);
      this.tableLayoutPanel1.Controls.Add(this.buttonMultiplication, 3, 4);
      this.tableLayoutPanel1.Controls.Add(this.button5, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.buttonMC, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.button4, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.button9, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.buttonDivision, 3, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonXSquared, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.button8, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonMminus, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.button7, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.buttonSquareRoot, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonMplus, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.buttonC, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonPercentage, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonCE, 0, 3);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 8;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.39208F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.431654F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(403, 507);
      this.tableLayoutPanel1.TabIndex = 32;
      // 
      // StandardCalculatorControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "StandardCalculatorControl";
      this.Size = new System.Drawing.Size(403, 507);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private CalculatorButton buttonPlusMinus;
    private Label label1;
    private CalculatorButton buttonDot;
    private CalculatorButton button0;
    private CalculatorButton button1;
    private CalculatorButton button2;
    private CalculatorButton button3;
    private CalculatorButton buttonPlus;
    private CalculatorButton button4;
    private CalculatorButton button7;
    private CalculatorButton buttonCE;
    private CalculatorButton button5;
    private CalculatorButton button8;
    private CalculatorButton buttonC;
    private CalculatorButton button6;
    private CalculatorButton button9;
    private CalculatorButton buttonDivision;
    private CalculatorButton buttonMultiplication;
    private CalculatorButton buttonMinus;
    private CalculatorButton buttonPercentage;
    private CalculatorButton buttonSquareRoot;
    private CalculatorButton buttonXSquared;
    private CalculatorButton buttonMC;
    private CalculatorButton buttonMplus;
    private CalculatorButton buttonMminus;
    private CalculatorButton buttonM;
    private CalculatorButton buttonHalf;
    private CalculatorButton buttonDelete;
    private CalculatorButton buttonEqual;
  }
}
