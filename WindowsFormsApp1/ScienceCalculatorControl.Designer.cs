using System.Drawing;

namespace WindowsFormsApp1
{
  partial class ScienceCalculatorControl
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
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
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
      this.buttonPlusMinus = new CalculatorButton("buttonPlusMinus", "±", CalculatorButton.ButtonFontColor.Gray);
      this.buttonDot = new CalculatorButton("buttonDot", ".", CalculatorButton.ButtonFontColor.Default);
      this.buttonEqual = new CalculatorButton("buttonEqual", "=", CalculatorButton.ButtonFontColor.Default);
      this.buttonPlus = new CalculatorButton("buttonPlus", "+", CalculatorButton.ButtonFontColor.Gray);
      this.buttonMinus = new CalculatorButton("buttonMinus", "-", CalculatorButton.ButtonFontColor.Gray);
      this.buttonMultiplication = new CalculatorButton("buttonMultiplication", "×", CalculatorButton.ButtonFontColor.Gray);
      this.buttonDivision = new CalculatorButton("buttonDivision", "÷", CalculatorButton.ButtonFontColor.Gray);
      this.buttonHalf = new CalculatorButton("buttonHalf", CalculatorButton.ButtonColor.WhiteSmoke, "⅟");
      this.buttonMplus = new CalculatorButton("buttonMplus", CalculatorButton.ButtonColor.White, "M+");
      this.buttonXSquared = new CalculatorButton("buttonXSquared", CalculatorButton.ButtonColor.WhiteSmoke, "x");
      this.buttonDelete = new CalculatorButton("buttonDelete", "", CalculatorButton.ButtonFontColor.Gray);
      this.buttonC = new CalculatorButton("buttonC", "C", CalculatorButton.ButtonFontColor.Gray);
      this.buttonSquareRoot = new CalculatorButton("buttonSquareRoot", CalculatorButton.ButtonColor.WhiteSmoke, "√");
      this.buttonM = new CalculatorButton("buttonM", CalculatorButton.ButtonColor.White, "MR");
      this.buttonMS = new CalculatorButton("buttonMS", CalculatorButton.ButtonColor.White, "MS");
      this.buttonMminus = new CalculatorButton("buttonMminus", CalculatorButton.ButtonColor.White, "M-");
      this.buttonPercentage = new CalculatorButton("buttonPercentage", CalculatorButton.ButtonColor.WhiteSmoke, "%");
      this.buttonCE = new CalculatorButton("buttonCE", "CE", CalculatorButton.ButtonFontColor.Gray);
      this.buttonPi = new CalculatorButton("buttonPi", "π", CalculatorButton.ButtonFontColor.Gray);
      this.buttonLog = new CalculatorButton("buttonLog", "Log", CalculatorButton.ButtonFontColor.Gray);
      this.buttonSin = new CalculatorButton("buttonSin", "Sin", CalculatorButton.ButtonFontColor.Gray);
      this.buttonCos = new CalculatorButton("buttonCos", "Cos", CalculatorButton.ButtonFontColor.Gray);
      this.buttonTan = new CalculatorButton("buttonTan", "Tan", CalculatorButton.ButtonFontColor.Gray);
      this.button10Square = new CalculatorButton("button10Square", CalculatorButton.ButtonColor.WhiteSmoke, "10");
      this.buttonMC = new CalculatorButton("buttonMC", CalculatorButton.ButtonColor.White, "MC");
      this.tableLayoutPanel1.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.ColumnCount = 5;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20F));
      this.tableLayoutPanel1.Controls.Add(this.buttonMC, 0, 1);
      this.tableLayoutPanel1.Controls.Add(this.button10Square, 0, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonTan, 0, 4);
      this.tableLayoutPanel1.Controls.Add(this.buttonCos, 0, 5);
      this.tableLayoutPanel1.Controls.Add(this.label1, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.button0, 2, 7);
      this.tableLayoutPanel1.Controls.Add(this.button1, 1, 6);
      this.tableLayoutPanel1.Controls.Add(this.button2, 2, 6);
      this.tableLayoutPanel1.Controls.Add(this.button3, 3, 6);
      this.tableLayoutPanel1.Controls.Add(this.button4, 1, 5);
      this.tableLayoutPanel1.Controls.Add(this.button5, 2, 5);
      this.tableLayoutPanel1.Controls.Add(this.button6, 3, 5);
      this.tableLayoutPanel1.Controls.Add(this.button7, 1, 4);
      this.tableLayoutPanel1.Controls.Add(this.button8, 2, 4);
      this.tableLayoutPanel1.Controls.Add(this.button9, 3, 4);
      this.tableLayoutPanel1.Controls.Add(this.buttonPlusMinus, 1, 7);
      this.tableLayoutPanel1.Controls.Add(this.buttonDot, 3, 7);
      this.tableLayoutPanel1.Controls.Add(this.buttonEqual, 4, 7);
      this.tableLayoutPanel1.Controls.Add(this.buttonPlus, 4, 6);
      this.tableLayoutPanel1.Controls.Add(this.buttonMinus, 4, 5);
      this.tableLayoutPanel1.Controls.Add(this.buttonMultiplication, 4, 4);
      this.tableLayoutPanel1.Controls.Add(this.buttonDivision, 4, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonHalf, 4, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonMS, 4, 1);
      this.tableLayoutPanel1.Controls.Add(this.buttonMplus, 3, 1);
      this.tableLayoutPanel1.Controls.Add(this.buttonXSquared, 3, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonDelete, 3, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonC, 2, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonSquareRoot, 2, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonM, 2, 1);
      this.tableLayoutPanel1.Controls.Add(this.buttonMminus, 1, 1);
      this.tableLayoutPanel1.Controls.Add(this.buttonPercentage, 1, 2);
      this.tableLayoutPanel1.Controls.Add(this.buttonCE, 1, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonPi, 0, 3);
      this.tableLayoutPanel1.Controls.Add(this.buttonLog, 0, 7);
      this.tableLayoutPanel1.Controls.Add(this.buttonSin, 0, 6);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 8;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 23.39209F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 6.431656F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 11.69604F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(551, 642);
      this.tableLayoutPanel1.TabIndex = 33;
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.White;
      this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.tableLayoutPanel1.SetColumnSpan(this.label1, 5);
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.8F);
      this.label1.Location = new System.Drawing.Point(3, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(445, 126);
      this.label1.TabIndex = 1;
      this.label1.Text = "0";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // label2
      // 
      this.label2.BackColor = System.Drawing.Color.White;
      this.label2.BorderStyle = System.Windows.Forms.BorderStyle.None;
      //this.label2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.SetColumnSpan(this.label2, 1);
      this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.8F);
      this.label2.Location = new System.Drawing.Point(0, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(100, 126);
      this.label2.TabIndex = 1;
      this.label2.Text = "";
      //this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;

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
      // buttonPlusMinus
      // 
      this.buttonPlusMinus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonDot
      // 
      this.buttonDot.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // buttonEqual
      // 
      this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click_1);
      // 
      // buttonPlus
      // 
      this.buttonPlus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMinus
      // 
      this.buttonMinus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMultiplication
      // 
      this.buttonMultiplication.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonDivision
      // 
      this.buttonDivision.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonHalf
      // 
      this.buttonHalf.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMplus
      // 
      this.buttonMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      this.buttonMplus.Click += new System.EventHandler(this.ButtonMemory_Click);
      // 
      // buttonXSquared
      // 
      this.buttonXSquared.Image = global::WindowsFormsApp1.Properties.Resources.square_5122222;
      this.buttonXSquared.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.Image = global::WindowsFormsApp1.Properties.Resources.delete_512;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
      // 
      // buttonC
      // 
      this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
      // 
      // buttonSquareRoot
      // 
      this.buttonSquareRoot.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonM
      // 
      this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      this.buttonM.Click += new System.EventHandler(this.ButtonMemory_Click);
      // 
      // buttonMminus
      // 
      this.buttonMminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      this.buttonMminus.Click += new System.EventHandler(this.ButtonMemory_Click);
      // 
      // buttonPercentage
      // 
      this.buttonPercentage.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonCE
      // 
      this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
      // 
      // buttonPi
      // 
      this.buttonPi.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonLog
      // 
      this.buttonLog.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonSin
      // 
      this.buttonSin.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonCos
      // 
      this.buttonCos.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonTan
      // 
      this.buttonTan.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // button10Square
      // 
      this.button10Square.Image = global::WindowsFormsApp1.Properties.Resources.square_5122222;
      this.button10Square.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMC
      // 
      this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      this.buttonMC.Click += new System.EventHandler(this.ButtonMemory_Click);
      //
      // buttonMS
      //
      this.buttonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
      this.buttonMS.Click += new System.EventHandler(this.ButtonMemory_Click);
      // 
      // ScienceCalculatorControl
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.BackColor = System.Drawing.Color.White;
      this.Controls.Add(this.tableLayoutPanel1);
      this.Name = "ScienceCalculatorControl";
      this.Size = new Size(451, 542);
      this.tableLayoutPanel1.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private CalculatorButton buttonMC;
    private CalculatorButton button10Square;
    private CalculatorButton buttonTan;
    private CalculatorButton buttonCos;
    private CalculatorButton button0;
    private CalculatorButton button1;
    private CalculatorButton button2;
    private CalculatorButton button3;
    private CalculatorButton button4;
    private CalculatorButton button5;
    private CalculatorButton button6;
    private CalculatorButton button7;
    private CalculatorButton button8;
    private CalculatorButton button9;
    private CalculatorButton buttonPlusMinus;
    private CalculatorButton buttonDot;
    private CalculatorButton buttonEqual;
    private CalculatorButton buttonPlus;
    private CalculatorButton buttonMinus;
    private CalculatorButton buttonMultiplication;
    private CalculatorButton buttonDivision;
    private CalculatorButton buttonHalf;
    private CalculatorButton buttonMplus;
    private CalculatorButton buttonMS;
    private CalculatorButton buttonXSquared;
    private CalculatorButton buttonDelete;
    private CalculatorButton buttonC;
    private CalculatorButton buttonSquareRoot;
    private CalculatorButton buttonM;
    private CalculatorButton buttonMminus;
    private CalculatorButton buttonPercentage;
    private CalculatorButton buttonCE;
    private CalculatorButton buttonPi;
    private CalculatorButton buttonLog;
    private CalculatorButton buttonSin;
  }
}
