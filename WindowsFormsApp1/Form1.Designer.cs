namespace WindowsFormsApp1
{
    partial class Calculator
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Calculator));
      this.buttonPlusMinus = new System.Windows.Forms.Button();
      this.label1 = new System.Windows.Forms.Label();
      this.buttonDot = new System.Windows.Forms.Button();
      this.button0 = new System.Windows.Forms.Button();
      this.button1 = new System.Windows.Forms.Button();
      this.button2 = new System.Windows.Forms.Button();
      this.button3 = new System.Windows.Forms.Button();
      this.buttonPlus = new System.Windows.Forms.Button();
      this.button4 = new System.Windows.Forms.Button();
      this.button7 = new System.Windows.Forms.Button();
      this.buttonCE = new System.Windows.Forms.Button();
      this.button5 = new System.Windows.Forms.Button();
      this.button8 = new System.Windows.Forms.Button();
      this.buttonC = new System.Windows.Forms.Button();
      this.button6 = new System.Windows.Forms.Button();
      this.button9 = new System.Windows.Forms.Button();
      this.buttonDelete = new System.Windows.Forms.Button();
      this.buttonDivision = new System.Windows.Forms.Button();
      this.buttonMultiplication = new System.Windows.Forms.Button();
      this.buttonMinus = new System.Windows.Forms.Button();
      this.buttonPercentage = new System.Windows.Forms.Button();
      this.buttonSquareRoot = new System.Windows.Forms.Button();
      this.buttonXSquared = new System.Windows.Forms.Button();
      this.buttonMC = new System.Windows.Forms.Button();
      this.buttonMR = new System.Windows.Forms.Button();
      this.buttonMplus = new System.Windows.Forms.Button();
      this.buttonMminus = new System.Windows.Forms.Button();
      this.buttonMS = new System.Windows.Forms.Button();
      this.buttonM = new System.Windows.Forms.Button();
      this.buttonHalf = new System.Windows.Forms.Button();
      this.buttonEqual = new System.Windows.Forms.Button();
      this.SuspendLayout();
      // 
      // buttonPlusMinus
      // 
      this.buttonPlusMinus.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonPlusMinus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonPlusMinus.FlatAppearance.BorderSize = 0;
      this.buttonPlusMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonPlusMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonPlusMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonPlusMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonPlusMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonPlusMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonPlusMinus.Location = new System.Drawing.Point(-7, 405);
      this.buttonPlusMinus.Margin = new System.Windows.Forms.Padding(0);
      this.buttonPlusMinus.Name = "buttonPlusMinus";
      this.buttonPlusMinus.Size = new System.Drawing.Size(84, 65);
      this.buttonPlusMinus.TabIndex = 0;
      this.buttonPlusMinus.Text = "±";
      this.buttonPlusMinus.UseVisualStyleBackColor = false;
      this.buttonPlusMinus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // label1
      // 
      this.label1.BackColor = System.Drawing.Color.White;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 40.8F);
      this.label1.Location = new System.Drawing.Point(0, 1);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(299, 87);
      this.label1.TabIndex = 1;
      this.label1.Text = "0";
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
      // 
      // buttonDot
      // 
      this.buttonDot.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonDot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonDot.FlatAppearance.BorderSize = 0;
      this.buttonDot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonDot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonDot.Location = new System.Drawing.Point(151, 405);
      this.buttonDot.Margin = new System.Windows.Forms.Padding(0);
      this.buttonDot.Name = "buttonDot";
      this.buttonDot.Size = new System.Drawing.Size(74, 65);
      this.buttonDot.TabIndex = 2;
      this.buttonDot.Text = ".";
      this.buttonDot.UseVisualStyleBackColor = false;
      this.buttonDot.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button0
      // 
      this.button0.BackColor = System.Drawing.Color.Gainsboro;
      this.button0.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.button0.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button0.FlatAppearance.BorderSize = 0;
      this.button0.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button0.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button0.ForeColor = System.Drawing.Color.Black;
      this.button0.Location = new System.Drawing.Point(77, 405);
      this.button0.Margin = new System.Windows.Forms.Padding(0);
      this.button0.Name = "button0";
      this.button0.Size = new System.Drawing.Size(74, 65);
      this.button0.TabIndex = 3;
      this.button0.Text = "0";
      this.button0.UseVisualStyleBackColor = false;
      this.button0.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button1
      // 
      this.button1.BackColor = System.Drawing.Color.Gainsboro;
      this.button1.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button1.FlatAppearance.BorderSize = 0;
      this.button1.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.button1.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.button1.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button1.Location = new System.Drawing.Point(-7, 347);
      this.button1.Margin = new System.Windows.Forms.Padding(0);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(84, 58);
      this.button1.TabIndex = 5;
      this.button1.Text = "1";
      this.button1.UseVisualStyleBackColor = false;
      this.button1.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button2
      // 
      this.button2.BackColor = System.Drawing.Color.Gainsboro;
      this.button2.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button2.FlatAppearance.BorderSize = 0;
      this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button2.Location = new System.Drawing.Point(77, 347);
      this.button2.Margin = new System.Windows.Forms.Padding(0);
      this.button2.Name = "button2";
      this.button2.Size = new System.Drawing.Size(74, 58);
      this.button2.TabIndex = 6;
      this.button2.Text = "2";
      this.button2.UseVisualStyleBackColor = false;
      this.button2.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button3
      // 
      this.button3.BackColor = System.Drawing.Color.Gainsboro;
      this.button3.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button3.FlatAppearance.BorderSize = 0;
      this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button3.Location = new System.Drawing.Point(151, 347);
      this.button3.Margin = new System.Windows.Forms.Padding(0);
      this.button3.Name = "button3";
      this.button3.Size = new System.Drawing.Size(74, 58);
      this.button3.TabIndex = 7;
      this.button3.Text = "3";
      this.button3.UseVisualStyleBackColor = false;
      this.button3.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // buttonPlus
      // 
      this.buttonPlus.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonPlus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonPlus.FlatAppearance.BorderSize = 0;
      this.buttonPlus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonPlus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonPlus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonPlus.Location = new System.Drawing.Point(225, 347);
      this.buttonPlus.Margin = new System.Windows.Forms.Padding(0);
      this.buttonPlus.Name = "buttonPlus";
      this.buttonPlus.Size = new System.Drawing.Size(82, 58);
      this.buttonPlus.TabIndex = 8;
      this.buttonPlus.Text = "+";
      this.buttonPlus.UseVisualStyleBackColor = false;
      this.buttonPlus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // button4
      // 
      this.button4.BackColor = System.Drawing.Color.Gainsboro;
      this.button4.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button4.FlatAppearance.BorderSize = 0;
      this.button4.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.button4.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button4.Location = new System.Drawing.Point(-7, 289);
      this.button4.Margin = new System.Windows.Forms.Padding(0);
      this.button4.Name = "button4";
      this.button4.Size = new System.Drawing.Size(84, 58);
      this.button4.TabIndex = 9;
      this.button4.Text = "4";
      this.button4.UseVisualStyleBackColor = false;
      this.button4.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button7
      // 
      this.button7.BackColor = System.Drawing.Color.Gainsboro;
      this.button7.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button7.FlatAppearance.BorderSize = 0;
      this.button7.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.button7.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.button7.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.button7.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button7.Location = new System.Drawing.Point(-7, 231);
      this.button7.Margin = new System.Windows.Forms.Padding(0);
      this.button7.Name = "button7";
      this.button7.Size = new System.Drawing.Size(84, 58);
      this.button7.TabIndex = 10;
      this.button7.Text = "7";
      this.button7.UseVisualStyleBackColor = false;
      this.button7.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // buttonCE
      // 
      this.buttonCE.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonCE.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonCE.FlatAppearance.BorderSize = 0;
      this.buttonCE.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonCE.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonCE.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonCE.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonCE.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonCE.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonCE.Location = new System.Drawing.Point(-7, 173);
      this.buttonCE.Margin = new System.Windows.Forms.Padding(0);
      this.buttonCE.Name = "buttonCE";
      this.buttonCE.Size = new System.Drawing.Size(84, 58);
      this.buttonCE.TabIndex = 11;
      this.buttonCE.Text = "CE";
      this.buttonCE.UseVisualStyleBackColor = false;
      this.buttonCE.Click += new System.EventHandler(this.ButtonCE_Click);
      // 
      // button5
      // 
      this.button5.BackColor = System.Drawing.Color.Gainsboro;
      this.button5.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button5.FlatAppearance.BorderSize = 0;
      this.button5.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.button5.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.button5.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.button5.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button5.Location = new System.Drawing.Point(77, 289);
      this.button5.Margin = new System.Windows.Forms.Padding(0);
      this.button5.Name = "button5";
      this.button5.Size = new System.Drawing.Size(74, 58);
      this.button5.TabIndex = 12;
      this.button5.Text = "5";
      this.button5.UseVisualStyleBackColor = false;
      this.button5.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button8
      // 
      this.button8.BackColor = System.Drawing.Color.Gainsboro;
      this.button8.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button8.FlatAppearance.BorderSize = 0;
      this.button8.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.button8.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button8.Location = new System.Drawing.Point(77, 231);
      this.button8.Margin = new System.Windows.Forms.Padding(0);
      this.button8.Name = "button8";
      this.button8.Size = new System.Drawing.Size(74, 58);
      this.button8.TabIndex = 13;
      this.button8.Text = "8";
      this.button8.UseVisualStyleBackColor = false;
      this.button8.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // buttonC
      // 
      this.buttonC.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonC.FlatAppearance.BorderSize = 0;
      this.buttonC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonC.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonC.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonC.Location = new System.Drawing.Point(77, 173);
      this.buttonC.Margin = new System.Windows.Forms.Padding(0);
      this.buttonC.Name = "buttonC";
      this.buttonC.Size = new System.Drawing.Size(74, 58);
      this.buttonC.TabIndex = 14;
      this.buttonC.Text = "C";
      this.buttonC.UseVisualStyleBackColor = false;
      this.buttonC.Click += new System.EventHandler(this.ButtonC_Click);
      // 
      // button6
      // 
      this.button6.BackColor = System.Drawing.Color.Gainsboro;
      this.button6.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button6.FlatAppearance.BorderSize = 0;
      this.button6.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.button6.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.button6.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.button6.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button6.Location = new System.Drawing.Point(151, 289);
      this.button6.Margin = new System.Windows.Forms.Padding(0);
      this.button6.Name = "button6";
      this.button6.Size = new System.Drawing.Size(74, 58);
      this.button6.TabIndex = 15;
      this.button6.Text = "6";
      this.button6.UseVisualStyleBackColor = false;
      this.button6.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // button9
      // 
      this.button9.BackColor = System.Drawing.Color.Gainsboro;
      this.button9.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.button9.FlatAppearance.BorderSize = 0;
      this.button9.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.button9.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.button9.Location = new System.Drawing.Point(151, 231);
      this.button9.Margin = new System.Windows.Forms.Padding(0);
      this.button9.Name = "button9";
      this.button9.Size = new System.Drawing.Size(74, 58);
      this.button9.TabIndex = 16;
      this.button9.Text = "9";
      this.button9.UseVisualStyleBackColor = false;
      this.button9.Click += new System.EventHandler(this.ButtonNumber_Click);
      // 
      // buttonDelete
      // 
      this.buttonDelete.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
      this.buttonDelete.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonDelete.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonDelete.FlatAppearance.BorderSize = 0;
      this.buttonDelete.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonDelete.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonDelete.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonDelete.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.25F);
      this.buttonDelete.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonDelete.Image = ((System.Drawing.Image)(resources.GetObject("buttonDelete.Image")));
      this.buttonDelete.Location = new System.Drawing.Point(151, 173);
      this.buttonDelete.Margin = new System.Windows.Forms.Padding(0);
      this.buttonDelete.Name = "buttonDelete";
      this.buttonDelete.Size = new System.Drawing.Size(75, 58);
      this.buttonDelete.TabIndex = 17;
      this.buttonDelete.UseVisualStyleBackColor = false;
      this.buttonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
      // 
      // buttonDivision
      // 
      this.buttonDivision.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonDivision.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonDivision.FlatAppearance.BorderSize = 0;
      this.buttonDivision.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonDivision.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonDivision.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonDivision.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonDivision.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonDivision.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonDivision.Location = new System.Drawing.Point(225, 173);
      this.buttonDivision.Margin = new System.Windows.Forms.Padding(0);
      this.buttonDivision.Name = "buttonDivision";
      this.buttonDivision.Size = new System.Drawing.Size(82, 58);
      this.buttonDivision.TabIndex = 18;
      this.buttonDivision.Text = "÷";
      this.buttonDivision.UseVisualStyleBackColor = false;
      this.buttonDivision.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMultiplication
      // 
      this.buttonMultiplication.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonMultiplication.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonMultiplication.FlatAppearance.BorderSize = 0;
      this.buttonMultiplication.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonMultiplication.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonMultiplication.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonMultiplication.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMultiplication.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonMultiplication.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonMultiplication.Location = new System.Drawing.Point(225, 231);
      this.buttonMultiplication.Margin = new System.Windows.Forms.Padding(0);
      this.buttonMultiplication.Name = "buttonMultiplication";
      this.buttonMultiplication.Size = new System.Drawing.Size(82, 58);
      this.buttonMultiplication.TabIndex = 19;
      this.buttonMultiplication.Text = "×";
      this.buttonMultiplication.UseVisualStyleBackColor = false;
      this.buttonMultiplication.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMinus
      // 
      this.buttonMinus.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonMinus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonMinus.FlatAppearance.BorderSize = 0;
      this.buttonMinus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonMinus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonMinus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonMinus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMinus.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonMinus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
      this.buttonMinus.Location = new System.Drawing.Point(225, 289);
      this.buttonMinus.Margin = new System.Windows.Forms.Padding(0);
      this.buttonMinus.Name = "buttonMinus";
      this.buttonMinus.Size = new System.Drawing.Size(82, 58);
      this.buttonMinus.TabIndex = 20;
      this.buttonMinus.Text = "-";
      this.buttonMinus.UseVisualStyleBackColor = false;
      this.buttonMinus.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonPercentage
      // 
      this.buttonPercentage.BackColor = System.Drawing.Color.WhiteSmoke;
      this.buttonPercentage.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonPercentage.FlatAppearance.BorderSize = 0;
      this.buttonPercentage.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonPercentage.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonPercentage.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonPercentage.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonPercentage.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonPercentage.ForeColor = System.Drawing.Color.Black;
      this.buttonPercentage.Location = new System.Drawing.Point(-7, 115);
      this.buttonPercentage.Margin = new System.Windows.Forms.Padding(0);
      this.buttonPercentage.Name = "buttonPercentage";
      this.buttonPercentage.Size = new System.Drawing.Size(84, 58);
      this.buttonPercentage.TabIndex = 21;
      this.buttonPercentage.Text = "%";
      this.buttonPercentage.UseVisualStyleBackColor = false;
      this.buttonPercentage.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonSquareRoot
      // 
      this.buttonSquareRoot.BackColor = System.Drawing.Color.WhiteSmoke;
      this.buttonSquareRoot.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonSquareRoot.FlatAppearance.BorderSize = 0;
      this.buttonSquareRoot.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonSquareRoot.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonSquareRoot.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonSquareRoot.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonSquareRoot.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonSquareRoot.ForeColor = System.Drawing.Color.Black;
      this.buttonSquareRoot.Location = new System.Drawing.Point(77, 115);
      this.buttonSquareRoot.Margin = new System.Windows.Forms.Padding(0);
      this.buttonSquareRoot.Name = "buttonSquareRoot";
      this.buttonSquareRoot.Size = new System.Drawing.Size(74, 58);
      this.buttonSquareRoot.TabIndex = 22;
      this.buttonSquareRoot.Text = "√";
      this.buttonSquareRoot.UseVisualStyleBackColor = false;
      this.buttonSquareRoot.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonXSquared
      // 
      this.buttonXSquared.BackColor = System.Drawing.Color.WhiteSmoke;
      this.buttonXSquared.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonXSquared.FlatAppearance.BorderSize = 0;
      this.buttonXSquared.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonXSquared.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonXSquared.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonXSquared.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonXSquared.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
      this.buttonXSquared.ForeColor = System.Drawing.Color.Black;
      this.buttonXSquared.Image = ((System.Drawing.Image)(resources.GetObject("buttonXSquared.Image")));
      this.buttonXSquared.Location = new System.Drawing.Point(151, 115);
      this.buttonXSquared.Margin = new System.Windows.Forms.Padding(0);
      this.buttonXSquared.Name = "buttonXSquared";
      this.buttonXSquared.Size = new System.Drawing.Size(74, 58);
      this.buttonXSquared.TabIndex = 23;
      this.buttonXSquared.Text = "x";
      this.buttonXSquared.UseVisualStyleBackColor = false;
      this.buttonXSquared.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonMC
      // 
      this.buttonMC.BackColor = System.Drawing.Color.White;
      this.buttonMC.Enabled = false;
      this.buttonMC.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonMC.FlatAppearance.BorderSize = 0;
      this.buttonMC.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonMC.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonMC.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonMC.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.buttonMC.Location = new System.Drawing.Point(-7, 88);
      this.buttonMC.Margin = new System.Windows.Forms.Padding(0);
      this.buttonMC.Name = "buttonMC";
      this.buttonMC.Size = new System.Drawing.Size(59, 27);
      this.buttonMC.TabIndex = 25;
      this.buttonMC.Text = "MC";
      this.buttonMC.UseVisualStyleBackColor = false;
      // 
      // buttonMR
      // 
      this.buttonMR.BackColor = System.Drawing.Color.White;
      this.buttonMR.Enabled = false;
      this.buttonMR.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonMR.FlatAppearance.BorderSize = 0;
      this.buttonMR.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonMR.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonMR.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonMR.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMR.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.buttonMR.Location = new System.Drawing.Point(52, 88);
      this.buttonMR.Margin = new System.Windows.Forms.Padding(0);
      this.buttonMR.Name = "buttonMR";
      this.buttonMR.Size = new System.Drawing.Size(47, 27);
      this.buttonMR.TabIndex = 26;
      this.buttonMR.Text = "MR";
      this.buttonMR.UseVisualStyleBackColor = false;
      // 
      // buttonMplus
      // 
      this.buttonMplus.BackColor = System.Drawing.Color.White;
      this.buttonMplus.Enabled = false;
      this.buttonMplus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonMplus.FlatAppearance.BorderSize = 0;
      this.buttonMplus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonMplus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonMplus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonMplus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMplus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.buttonMplus.Location = new System.Drawing.Point(99, 88);
      this.buttonMplus.Margin = new System.Windows.Forms.Padding(0);
      this.buttonMplus.Name = "buttonMplus";
      this.buttonMplus.Size = new System.Drawing.Size(47, 27);
      this.buttonMplus.TabIndex = 27;
      this.buttonMplus.Text = "M+";
      this.buttonMplus.UseVisualStyleBackColor = false;
      // 
      // buttonMminus
      // 
      this.buttonMminus.BackColor = System.Drawing.Color.White;
      this.buttonMminus.Enabled = false;
      this.buttonMminus.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonMminus.FlatAppearance.BorderSize = 0;
      this.buttonMminus.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonMminus.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonMminus.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonMminus.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMminus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.buttonMminus.Location = new System.Drawing.Point(152, 88);
      this.buttonMminus.Margin = new System.Windows.Forms.Padding(0);
      this.buttonMminus.Name = "buttonMminus";
      this.buttonMminus.Size = new System.Drawing.Size(47, 27);
      this.buttonMminus.TabIndex = 28;
      this.buttonMminus.Text = "M-";
      this.buttonMminus.UseVisualStyleBackColor = false;
      // 
      // buttonMS
      // 
      this.buttonMS.BackColor = System.Drawing.Color.White;
      this.buttonMS.Enabled = false;
      this.buttonMS.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonMS.FlatAppearance.BorderSize = 0;
      this.buttonMS.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonMS.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonMS.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonMS.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonMS.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.buttonMS.Location = new System.Drawing.Point(199, 88);
      this.buttonMS.Margin = new System.Windows.Forms.Padding(0);
      this.buttonMS.Name = "buttonMS";
      this.buttonMS.Size = new System.Drawing.Size(47, 27);
      this.buttonMS.TabIndex = 29;
      this.buttonMS.Text = "MS";
      this.buttonMS.UseVisualStyleBackColor = false;
      // 
      // buttonM
      // 
      this.buttonM.BackColor = System.Drawing.Color.White;
      this.buttonM.Enabled = false;
      this.buttonM.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonM.FlatAppearance.BorderSize = 0;
      this.buttonM.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonM.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonM.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonM.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonM.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.25F);
      this.buttonM.Location = new System.Drawing.Point(246, 88);
      this.buttonM.Margin = new System.Windows.Forms.Padding(0);
      this.buttonM.Name = "buttonM";
      this.buttonM.Size = new System.Drawing.Size(61, 27);
      this.buttonM.TabIndex = 30;
      this.buttonM.Text = "M";
      this.buttonM.UseVisualStyleBackColor = false;
      // 
      // buttonHalf
      // 
      this.buttonHalf.BackColor = System.Drawing.Color.WhiteSmoke;
      this.buttonHalf.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonHalf.FlatAppearance.BorderSize = 0;
      this.buttonHalf.FlatAppearance.CheckedBackColor = System.Drawing.Color.Silver;
      this.buttonHalf.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Silver;
      this.buttonHalf.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Silver;
      this.buttonHalf.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonHalf.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F);
      this.buttonHalf.ForeColor = System.Drawing.Color.Black;
      this.buttonHalf.Location = new System.Drawing.Point(225, 115);
      this.buttonHalf.Margin = new System.Windows.Forms.Padding(0);
      this.buttonHalf.Name = "buttonHalf";
      this.buttonHalf.Size = new System.Drawing.Size(82, 58);
      this.buttonHalf.TabIndex = 24;
      this.buttonHalf.Text = "1/x";
      this.buttonHalf.UseVisualStyleBackColor = false;
      this.buttonHalf.Click += new System.EventHandler(this.ButtonOperator_Click);
      // 
      // buttonEqual
      // 
      this.buttonEqual.BackColor = System.Drawing.Color.Gainsboro;
      this.buttonEqual.FlatAppearance.BorderColor = System.Drawing.SystemColors.ActiveBorder;
      this.buttonEqual.FlatAppearance.BorderSize = 0;
      this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.buttonEqual.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.buttonEqual.Location = new System.Drawing.Point(225, 405);
      this.buttonEqual.Margin = new System.Windows.Forms.Padding(0);
      this.buttonEqual.Name = "buttonEqual";
      this.buttonEqual.Size = new System.Drawing.Size(82, 65);
      this.buttonEqual.TabIndex = 31;
      this.buttonEqual.Text = "=";
      this.buttonEqual.UseVisualStyleBackColor = false;
      this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click_1);
      // 
      // Calculator
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(303, 468);
      this.Controls.Add(this.buttonEqual);
      this.Controls.Add(this.buttonM);
      this.Controls.Add(this.buttonMS);
      this.Controls.Add(this.buttonMminus);
      this.Controls.Add(this.buttonMplus);
      this.Controls.Add(this.buttonMR);
      this.Controls.Add(this.buttonMC);
      this.Controls.Add(this.buttonHalf);
      this.Controls.Add(this.buttonXSquared);
      this.Controls.Add(this.buttonSquareRoot);
      this.Controls.Add(this.buttonPercentage);
      this.Controls.Add(this.buttonMinus);
      this.Controls.Add(this.buttonMultiplication);
      this.Controls.Add(this.buttonDivision);
      this.Controls.Add(this.buttonDelete);
      this.Controls.Add(this.button9);
      this.Controls.Add(this.button6);
      this.Controls.Add(this.buttonC);
      this.Controls.Add(this.button8);
      this.Controls.Add(this.button5);
      this.Controls.Add(this.buttonCE);
      this.Controls.Add(this.button7);
      this.Controls.Add(this.button4);
      this.Controls.Add(this.buttonPlus);
      this.Controls.Add(this.button3);
      this.Controls.Add(this.button2);
      this.Controls.Add(this.button1);
      this.Controls.Add(this.button0);
      this.Controls.Add(this.buttonDot);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.buttonPlusMinus);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "Calculator";
      this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
      this.Text = "Calculator";
      this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonPlusMinus;
        private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Button buttonDot;
    private System.Windows.Forms.Button button0;
    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.Button button2;
    private System.Windows.Forms.Button button3;
    private System.Windows.Forms.Button buttonPlus;
    private System.Windows.Forms.Button button4;
    private System.Windows.Forms.Button button7;
    private System.Windows.Forms.Button buttonCE;
    private System.Windows.Forms.Button button5;
    private System.Windows.Forms.Button button8;
    private System.Windows.Forms.Button buttonC;
    private System.Windows.Forms.Button button6;
    private System.Windows.Forms.Button button9;
    private System.Windows.Forms.Button buttonDivision;
    private System.Windows.Forms.Button buttonMultiplication;
    private System.Windows.Forms.Button buttonMinus;
    private System.Windows.Forms.Button buttonPercentage;
    private System.Windows.Forms.Button buttonSquareRoot;
    private System.Windows.Forms.Button buttonXSquared;
    private System.Windows.Forms.Button buttonMC;
    private System.Windows.Forms.Button buttonMR;
    private System.Windows.Forms.Button buttonMplus;
    private System.Windows.Forms.Button buttonMminus;
    private System.Windows.Forms.Button buttonMS;
    private System.Windows.Forms.Button buttonM;
    private System.Windows.Forms.Button buttonHalf;
    private System.Windows.Forms.Button buttonDelete;
    private System.Windows.Forms.Button buttonEqual;
  }
}

