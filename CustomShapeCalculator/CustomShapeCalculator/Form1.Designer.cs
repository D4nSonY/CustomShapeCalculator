namespace CustomShapeCalculator
{
  partial class MainWindow
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainWindow));
      this.Berechnen = new System.Windows.Forms.Button();
      this.DrawPanel = new System.Windows.Forms.Panel();
      this.Scope = new System.Windows.Forms.Label();
      this.ScopeNumber = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.label3 = new System.Windows.Forms.Label();
      this.label4 = new System.Windows.Forms.Label();
      this.Undo = new System.Windows.Forms.Button();
      this.RedoButton = new System.Windows.Forms.Button();
      this.Surface = new System.Windows.Forms.Label();
      this.SurfaceNumber = new System.Windows.Forms.Label();
      this.ClearButton = new System.Windows.Forms.Button();
      this.ScaleOption = new System.Windows.Forms.NumericUpDown();
      this.panel1 = new System.Windows.Forms.Panel();
      this.ToolBox = new System.Windows.Forms.Panel();
      this.MovePoint = new System.Windows.Forms.Button();
      this.label5 = new System.Windows.Forms.Label();
      this.PenThicknessControl = new System.Windows.Forms.TrackBar();
      this.CurveBrush = new System.Windows.Forms.Button();
      this.PenBrush = new System.Windows.Forms.Button();
      this.DrawPanelBackGround = new System.Windows.Forms.Panel();
      this.AntiAliasingButton = new System.Windows.Forms.Button();
      ((System.ComponentModel.ISupportInitialize)(this.ScaleOption)).BeginInit();
      this.panel1.SuspendLayout();
      this.ToolBox.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PenThicknessControl)).BeginInit();
      this.SuspendLayout();
      // 
      // Berechnen
      // 
      this.Berechnen.AccessibleName = "CalculateButton";
      this.Berechnen.BackColor = System.Drawing.Color.DarkGray;
      this.Berechnen.Font = new System.Drawing.Font("Century Gothic", 13.75F);
      this.Berechnen.Location = new System.Drawing.Point(3, 404);
      this.Berechnen.Name = "Berechnen";
      this.Berechnen.Size = new System.Drawing.Size(202, 45);
      this.Berechnen.TabIndex = 2;
      this.Berechnen.Text = "Berechnen";
      this.Berechnen.UseVisualStyleBackColor = false;
      this.Berechnen.Click += new System.EventHandler(this.button1_Click);
      // 
      // DrawPanel
      // 
      this.DrawPanel.AccessibleName = "DrawPanel";
      this.DrawPanel.BackColor = System.Drawing.Color.Gainsboro;
      this.DrawPanel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.DrawPanel.Cursor = System.Windows.Forms.Cursors.Cross;
      this.DrawPanel.Location = new System.Drawing.Point(26, 33);
      this.DrawPanel.Name = "DrawPanel";
      this.DrawPanel.Size = new System.Drawing.Size(660, 500);
      this.DrawPanel.TabIndex = 0;
      this.DrawPanel.Click += new System.EventHandler(this.DrawPanelClick);
      this.DrawPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.DrawPanelMouseDown);
      this.DrawPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.DrawPanelMouseMove);
      // 
      // Scope
      // 
      this.Scope.AccessibleName = "Scope";
      this.Scope.AutoSize = true;
      this.Scope.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Scope.Location = new System.Drawing.Point(3, 467);
      this.Scope.Name = "Scope";
      this.Scope.Size = new System.Drawing.Size(71, 20);
      this.Scope.TabIndex = 3;
      this.Scope.Text = "Umfang:";
      // 
      // ScopeNumber
      // 
      this.ScopeNumber.AccessibleName = "ScopeAmount";
      this.ScopeNumber.AutoSize = true;
      this.ScopeNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ScopeNumber.Location = new System.Drawing.Point(80, 467);
      this.ScopeNumber.Name = "ScopeNumber";
      this.ScopeNumber.Size = new System.Drawing.Size(34, 20);
      this.ScopeNumber.TabIndex = 4;
      this.ScopeNumber.Text = "0 m";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.label1.Location = new System.Drawing.Point(19, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(42, 39);
      this.label1.TabIndex = 5;
      this.label1.Text = "⇤";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 25.25F);
      this.label2.Location = new System.Drawing.Point(656, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(42, 39);
      this.label2.TabIndex = 6;
      this.label2.Text = "⇥";
      // 
      // label3
      // 
      this.label3.AutoSize = true;
      this.label3.Font = new System.Drawing.Font("Century Gothic", 14.25F);
      this.label3.Location = new System.Drawing.Point(355, 5);
      this.label3.Name = "label3";
      this.label3.Size = new System.Drawing.Size(27, 22);
      this.label3.TabIndex = 7;
      this.label3.Text = "m";
      // 
      // label4
      // 
      this.label4.AutoSize = true;
      this.label4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.label4.Font = new System.Drawing.Font("Century Gothic", 14.25F);
      this.label4.Location = new System.Drawing.Point(5, 273);
      this.label4.Name = "label4";
      this.label4.Size = new System.Drawing.Size(40, 24);
      this.label4.TabIndex = 8;
      this.label4.Text = "0m";
      // 
      // Undo
      // 
      this.Undo.AccessibleName = "UndoButton";
      this.Undo.BackColor = System.Drawing.Color.DarkGray;
      this.Undo.Font = new System.Drawing.Font("Century Gothic", 18.75F);
      this.Undo.Location = new System.Drawing.Point(3, 3);
      this.Undo.Name = "Undo";
      this.Undo.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
      this.Undo.Size = new System.Drawing.Size(44, 48);
      this.Undo.TabIndex = 9;
      this.Undo.Text = "↶";
      this.Undo.UseVisualStyleBackColor = false;
      this.Undo.Click += new System.EventHandler(this.Undo_Click);
      // 
      // RedoButton
      // 
      this.RedoButton.AccessibleName = "RedoButton";
      this.RedoButton.BackColor = System.Drawing.Color.DarkGray;
      this.RedoButton.Font = new System.Drawing.Font("Century Gothic", 18.75F);
      this.RedoButton.Location = new System.Drawing.Point(53, 3);
      this.RedoButton.Name = "RedoButton";
      this.RedoButton.Padding = new System.Windows.Forms.Padding(0, 0, 0, 10);
      this.RedoButton.Size = new System.Drawing.Size(44, 48);
      this.RedoButton.TabIndex = 10;
      this.RedoButton.Text = "↷";
      this.RedoButton.UseVisualStyleBackColor = false;
      this.RedoButton.Click += new System.EventHandler(this.RedoLine);
      // 
      // Surface
      // 
      this.Surface.AccessibleName = "Surface";
      this.Surface.AutoSize = true;
      this.Surface.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.Surface.Location = new System.Drawing.Point(3, 494);
      this.Surface.Name = "Surface";
      this.Surface.Size = new System.Drawing.Size(62, 20);
      this.Surface.TabIndex = 11;
      this.Surface.Text = "Fläche:";
      // 
      // SurfaceNumber
      // 
      this.SurfaceNumber.AccessibleName = "SurfaceNumber";
      this.SurfaceNumber.AutoSize = true;
      this.SurfaceNumber.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.SurfaceNumber.Location = new System.Drawing.Point(80, 494);
      this.SurfaceNumber.Name = "SurfaceNumber";
      this.SurfaceNumber.Size = new System.Drawing.Size(39, 20);
      this.SurfaceNumber.TabIndex = 12;
      this.SurfaceNumber.Text = "0 m²";
      // 
      // ClearButton
      // 
      this.ClearButton.AccessibleName = "ClearButton";
      this.ClearButton.BackColor = System.Drawing.Color.DarkGray;
      this.ClearButton.Font = new System.Drawing.Font("Century Gothic", 13.75F);
      this.ClearButton.Location = new System.Drawing.Point(110, 3);
      this.ClearButton.Name = "ClearButton";
      this.ClearButton.Size = new System.Drawing.Size(95, 48);
      this.ClearButton.TabIndex = 13;
      this.ClearButton.Text = "Clear";
      this.ClearButton.UseVisualStyleBackColor = false;
      this.ClearButton.Click += new System.EventHandler(this.Clear);
      // 
      // ScaleOption
      // 
      this.ScaleOption.AccessibleName = "ScaleOption";
      this.ScaleOption.BackColor = System.Drawing.Color.Gainsboro;
      this.ScaleOption.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.ScaleOption.Font = new System.Drawing.Font("Century Gothic", 13F);
      this.ScaleOption.Location = new System.Drawing.Point(308, 3);
      this.ScaleOption.Name = "ScaleOption";
      this.ScaleOption.Size = new System.Drawing.Size(41, 29);
      this.ScaleOption.TabIndex = 14;
      this.ScaleOption.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      this.ScaleOption.ValueChanged += new System.EventHandler(this.ScaleChange);
      // 
      // panel1
      // 
      this.panel1.BackColor = System.Drawing.Color.Gray;
      this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.panel1.Controls.Add(this.ToolBox);
      this.panel1.Controls.Add(this.Berechnen);
      this.panel1.Controls.Add(this.RedoButton);
      this.panel1.Controls.Add(this.ClearButton);
      this.panel1.Controls.Add(this.ScopeNumber);
      this.panel1.Controls.Add(this.SurfaceNumber);
      this.panel1.Controls.Add(this.Undo);
      this.panel1.Controls.Add(this.Scope);
      this.panel1.Controls.Add(this.Surface);
      this.panel1.Location = new System.Drawing.Point(704, 5);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(210, 528);
      this.panel1.TabIndex = 2;
      // 
      // ToolBox
      // 
      this.ToolBox.AccessibleName = "ToolBox";
      this.ToolBox.BackColor = System.Drawing.Color.DimGray;
      this.ToolBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.ToolBox.Controls.Add(this.AntiAliasingButton);
      this.ToolBox.Controls.Add(this.MovePoint);
      this.ToolBox.Controls.Add(this.label5);
      this.ToolBox.Controls.Add(this.PenThicknessControl);
      this.ToolBox.Controls.Add(this.CurveBrush);
      this.ToolBox.Controls.Add(this.PenBrush);
      this.ToolBox.Location = new System.Drawing.Point(3, 57);
      this.ToolBox.Name = "ToolBox";
      this.ToolBox.Size = new System.Drawing.Size(202, 341);
      this.ToolBox.TabIndex = 14;
      // 
      // MovePoint
      // 
      this.MovePoint.AccessibleName = "MovePoint";
      this.MovePoint.BackColor = System.Drawing.Color.DarkGray;
      this.MovePoint.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
      this.MovePoint.Location = new System.Drawing.Point(127, 3);
      this.MovePoint.Name = "MovePoint";
      this.MovePoint.Padding = new System.Windows.Forms.Padding(0, 0, 0, 19);
      this.MovePoint.Size = new System.Drawing.Size(67, 67);
      this.MovePoint.TabIndex = 16;
      this.MovePoint.Text = "⤝";
      this.MovePoint.UseVisualStyleBackColor = false;
      this.MovePoint.Click += new System.EventHandler(this.MovePoint_Click);
      // 
      // label5
      // 
      this.label5.AccessibleName = "Scope";
      this.label5.AutoSize = true;
      this.label5.Font = new System.Drawing.Font("Century Gothic", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.label5.ForeColor = System.Drawing.Color.White;
      this.label5.Location = new System.Drawing.Point(3, 271);
      this.label5.Name = "label5";
      this.label5.Size = new System.Drawing.Size(91, 20);
      this.label5.TabIndex = 15;
      this.label5.Text = "Liniendicke";
      // 
      // PenThicknessControl
      // 
      this.PenThicknessControl.Cursor = System.Windows.Forms.Cursors.Hand;
      this.PenThicknessControl.Location = new System.Drawing.Point(2, 294);
      this.PenThicknessControl.Name = "PenThicknessControl";
      this.PenThicknessControl.Size = new System.Drawing.Size(192, 45);
      this.PenThicknessControl.TabIndex = 2;
      this.PenThicknessControl.TickStyle = System.Windows.Forms.TickStyle.TopLeft;
      this.PenThicknessControl.ValueChanged += new System.EventHandler(this.ThicknessChanged);
      // 
      // CurveBrush
      // 
      this.CurveBrush.AccessibleName = "CurveBrush";
      this.CurveBrush.BackColor = System.Drawing.Color.DarkGray;
      this.CurveBrush.Font = new System.Drawing.Font("Microsoft Sans Serif", 36.25F);
      this.CurveBrush.Location = new System.Drawing.Point(64, 3);
      this.CurveBrush.Name = "CurveBrush";
      this.CurveBrush.Padding = new System.Windows.Forms.Padding(0, 5, 0, 23);
      this.CurveBrush.Size = new System.Drawing.Size(67, 67);
      this.CurveBrush.TabIndex = 1;
      this.CurveBrush.Text = "⌓";
      this.CurveBrush.UseVisualStyleBackColor = false;
      this.CurveBrush.Click += new System.EventHandler(this.CurveBrush_Click);
      // 
      // PenBrush
      // 
      this.PenBrush.AccessibleName = "PenBrush";
      this.PenBrush.BackColor = System.Drawing.Color.DarkGray;
      this.PenBrush.Font = new System.Drawing.Font("Maiandra GD", 33F);
      this.PenBrush.ForeColor = System.Drawing.Color.White;
      this.PenBrush.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
      this.PenBrush.Location = new System.Drawing.Point(2, 3);
      this.PenBrush.Name = "PenBrush";
      this.PenBrush.Size = new System.Drawing.Size(67, 67);
      this.PenBrush.TabIndex = 0;
      this.PenBrush.Text = "+";
      this.PenBrush.UseVisualStyleBackColor = false;
      this.PenBrush.Click += new System.EventHandler(this.PenBrush_Click);
      // 
      // DrawPanelBackGround
      // 
      this.DrawPanelBackGround.AccessibleName = "DrawPanelBackGround";
      this.DrawPanelBackGround.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("DrawPanelBackGround.BackgroundImage")));
      this.DrawPanelBackGround.Location = new System.Drawing.Point(26, 33);
      this.DrawPanelBackGround.Name = "DrawPanelBackGround";
      this.DrawPanelBackGround.Size = new System.Drawing.Size(660, 500);
      this.DrawPanelBackGround.TabIndex = 0;
      // 
      // AntiAliasingButton
      // 
      this.AntiAliasingButton.AccessibleName = "ClearButton";
      this.AntiAliasingButton.BackColor = System.Drawing.Color.DarkGray;
      this.AntiAliasingButton.Font = new System.Drawing.Font("Century Gothic", 13.75F);
      this.AntiAliasingButton.ForeColor = System.Drawing.Color.White;
      this.AntiAliasingButton.Location = new System.Drawing.Point(2, 235);
      this.AntiAliasingButton.Name = "AntiAliasingButton";
      this.AntiAliasingButton.Size = new System.Drawing.Size(192, 33);
      this.AntiAliasingButton.TabIndex = 15;
      this.AntiAliasingButton.Text = "AntiAliasing";
      this.AntiAliasingButton.UseVisualStyleBackColor = false;
      this.AntiAliasingButton.Click += new System.EventHandler(this.AntiAliasingClick);
      // 
      // MainWindow
      // 
      this.AccessibleName = "ScaleOption";
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.BackColor = System.Drawing.Color.DarkGray;
      this.ClientSize = new System.Drawing.Size(919, 542);
      this.Controls.Add(this.label4);
      this.Controls.Add(this.DrawPanel);
      this.Controls.Add(this.DrawPanelBackGround);
      this.Controls.Add(this.ScaleOption);
      this.Controls.Add(this.label3);
      this.Controls.Add(this.label2);
      this.Controls.Add(this.label1);
      this.Controls.Add(this.panel1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.Name = "MainWindow";
      this.Padding = new System.Windows.Forms.Padding(2, 0, 0, 0);
      this.Text = "Custom Shape Calculator";
      this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.ShortCuts);
      ((System.ComponentModel.ISupportInitialize)(this.ScaleOption)).EndInit();
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      this.ToolBox.ResumeLayout(false);
      this.ToolBox.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.PenThicknessControl)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    #endregion
    private System.Windows.Forms.Button Berechnen;
    private System.Windows.Forms.Panel DrawPanel;
    private System.Windows.Forms.Label Scope;
    private System.Windows.Forms.Label ScopeNumber;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.Label label3;
    private System.Windows.Forms.Label label4;
    private System.Windows.Forms.Button Undo;
    private System.Windows.Forms.Button RedoButton;
    private System.Windows.Forms.Label Surface;
    private System.Windows.Forms.Label SurfaceNumber;
    private System.Windows.Forms.Button ClearButton;
    private System.Windows.Forms.NumericUpDown ScaleOption;
    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Panel DrawPanelBackGround;
    private System.Windows.Forms.Panel ToolBox;
    private System.Windows.Forms.TrackBar PenThicknessControl;
    private System.Windows.Forms.Button CurveBrush;
    private System.Windows.Forms.Button PenBrush;
    private System.Windows.Forms.Label label5;
    private System.Windows.Forms.Button MovePoint;
    private System.Windows.Forms.Button AntiAliasingButton;
  }
}

