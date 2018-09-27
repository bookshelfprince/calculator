namespace WindowsFormsApp1
{
  partial class CalculatorForm
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CalculatorForm));
      this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
      this.menu = new System.Windows.Forms.MenuStrip();
      this.menuDropdown = new System.Windows.Forms.ToolStripMenuItem();
      this.calc = new System.Windows.Forms.ToolStripMenuItem();
      this.menuSeperator = new System.Windows.Forms.ToolStripSeparator();
      this.standardCalc = new System.Windows.Forms.ToolStripMenuItem();
      this.scienceCalc = new System.Windows.Forms.ToolStripMenuItem();
      this.programmerCalc = new System.Windows.Forms.ToolStripMenuItem();
      this.label1 = new System.Windows.Forms.Label();
      this.tableLayoutPanel1.SuspendLayout();
      this.menu.SuspendLayout();
      this.SuspendLayout();
      // 
      // tableLayoutPanel1
      // 
      this.tableLayoutPanel1.AutoSize = true;
      this.tableLayoutPanel1.BackColor = System.Drawing.Color.White;
      this.tableLayoutPanel1.ColumnCount = 2;
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Controls.Add(this.menu, 0, 0);
      this.tableLayoutPanel1.Controls.Add(this.label1, 1, 0);
      this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
      this.tableLayoutPanel1.Name = "tableLayoutPanel1";
      this.tableLayoutPanel1.RowCount = 2;
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 50F));
      this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
      this.tableLayoutPanel1.Size = new System.Drawing.Size(363, 528);
      this.tableLayoutPanel1.TabIndex = 0;
      // 
      // menu
      // 
      this.menu.BackgroundImage = global::WindowsFormsApp1.Properties.Resources.menu;
      this.menu.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.menu.ImageScalingSize = new System.Drawing.Size(0, 0);
      this.menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuDropdown});
      this.menu.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
      this.menu.Location = new System.Drawing.Point(0, 0);
      this.menu.Name = "menu";
      this.menu.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
      this.menu.Size = new System.Drawing.Size(50, 50);
      this.menu.TabIndex = 0;
      // 
      // menuDropdown
      // 
      this.menuDropdown.AutoSize = false;
      this.menuDropdown.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
      this.menuDropdown.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calc,
            this.menuSeperator,
            this.standardCalc,
            this.scienceCalc,
            this.programmerCalc});
      this.menuDropdown.Image = ((System.Drawing.Image)(resources.GetObject("menuDropdown.Image")));
      this.menuDropdown.Name = "menuDropdown";
      this.menuDropdown.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
      this.menuDropdown.RightToLeft = System.Windows.Forms.RightToLeft.No;
      this.menuDropdown.Size = new System.Drawing.Size(94, 50);
      this.menuDropdown.Text = " ";
      this.menuDropdown.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
      // 
      // calc
      // 
      this.calc.Checked = true;
      this.calc.CheckState = System.Windows.Forms.CheckState.Checked;
      this.calc.Enabled = false;
      this.calc.Name = "calc";
      this.calc.Size = new System.Drawing.Size(152, 22);
      this.calc.Text = "Calculator";
      // 
      // menuSeperator
      // 
      this.menuSeperator.Name = "menuSeperator";
      this.menuSeperator.Size = new System.Drawing.Size(149, 6);
      // 
      // standardCalc
      // 
      this.standardCalc.Name = "standardCalc";
      this.standardCalc.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
      this.standardCalc.Size = new System.Drawing.Size(152, 22);
      this.standardCalc.Text = "Standard";
      this.standardCalc.Click += new System.EventHandler(this.standardCalc_Click);
      // 
      // scienceCalc
      // 
      this.scienceCalc.Name = "scienceCalc";
      this.scienceCalc.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
      this.scienceCalc.Size = new System.Drawing.Size(152, 22);
      this.scienceCalc.Text = "Science";
      this.scienceCalc.Click += new System.EventHandler(this.scienceCalc_Click);
      // 
      // programmerCalc
      // 
      this.programmerCalc.Name = "programmerCalc";
      this.programmerCalc.Overflow = System.Windows.Forms.ToolStripItemOverflow.AsNeeded;
      this.programmerCalc.Size = new System.Drawing.Size(152, 22);
      this.programmerCalc.Text = "Programmer";
      this.programmerCalc.Click += new System.EventHandler(this.programmerCalc_Click);
      // 
      // label1
      // 
      this.label1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.label1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.label1.Location = new System.Drawing.Point(53, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(307, 50);
      this.label1.TabIndex = 1;
      this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // CalculatorForm
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.AutoSize = true;
      this.ClientSize = new System.Drawing.Size(363, 528);
      this.Controls.Add(this.tableLayoutPanel1);
      this.MinimumSize = new System.Drawing.Size(379, 567);
      this.Name = "CalculatorForm";
      this.ShowIcon = false;
      this.Text = "Calculator";
      this.tableLayoutPanel1.ResumeLayout(false);
      this.tableLayoutPanel1.PerformLayout();
      this.menu.ResumeLayout(false);
      this.menu.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
    private System.Windows.Forms.MenuStrip menu;
    private System.Windows.Forms.ToolStripMenuItem menuDropdown;
    private System.Windows.Forms.ToolStripMenuItem standardCalc;
    private System.Windows.Forms.ToolStripMenuItem scienceCalc;
    private System.Windows.Forms.ToolStripMenuItem programmerCalc;
    private System.Windows.Forms.ToolStripMenuItem calc;
    private System.Windows.Forms.ToolStripSeparator menuSeperator;
    public System.Windows.Forms.Label label1;
  }
}