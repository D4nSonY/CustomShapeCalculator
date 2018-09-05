using CustomShapeCalculator.Testing;
using CustomShapeCalculator.Util;
using CustomShapeCalculator.Shape;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomShapeCalculator
{
  public partial class MainWindow : Form
  {
    public MainWindow()
    {
      InitializeComponent();
      graphicsDrawPanel = DrawPanel.CreateGraphics();
      Tools = new List<Button>();
      Tools.Add(PenBrush);
      ShapeCalcToolBox._oldButton = Tools[0];

      Tools.Add(CurveBrush);
      Tools.Add(MovePoint);
    }


    Pen blackPen = new Pen(Color.Black, penThickness);
    private double pixelMeter;
    private List<Point> Vertices = new List<Point>();
    private Graphics graphicsDrawPanel;
    private List<Line> Edges = new List<Line>();
    private List<ShapeElements> ElementsOfShape = new List<ShapeElements>();
    private List<Button> Tools;
    private static int penThickness = 1;


    private void ShortCuts(object sender, KeyEventArgs e)
    {
      if (e.KeyData == Keys.Escape && Vertices.Count != 0)
      {
        ShortCutUtil.Escape(Vertices, Edges, graphicsDrawPanel, blackPen);
      }
      if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Z)
      {
        ShortCutUtil.StrgZ(Vertices, Edges, DrawPanel, graphicsDrawPanel, blackPen);
      }
      if (e.Modifiers == Keys.Control && e.KeyCode == Keys.Y)
      {
        ShortCutUtil.StrgY(Vertices, Edges, DrawPanel, graphicsDrawPanel, blackPen);
      }
      if (e.Modifiers == Keys.Control && e.KeyCode == Keys.J)
      {
        TestMethods.TestMethodCurve(graphicsDrawPanel);
      }
    }

    //
    //Berechnen Button
    //
    private void button1_Click(object sender, EventArgs e)
    {
      double scope = CalculationUtil.Scope(Vertices, Edges, pixelMeter);
      double surface = CalculationUtil.Surface(Vertices, pixelMeter);
      if (scope != 0)
      {
        ScopeNumber.Text = Convert.ToString(scope) + " m";
        SurfaceNumber.Text = Convert.ToString(surface) + " m²";
      }
    }

    private void DrawPanelMouseMove(object sender, MouseEventArgs e)
    {
      DrawPanelUtil.MouseMovement(Vertices, new Point(e.X, e.Y), graphicsDrawPanel, blackPen);
    }

    private void DrawPanelMouseDown(object sender, MouseEventArgs e)
    {
      if(ShapeCalcToolBox.CurrentTool == DrawTools.Drag)
        DrawPanelUtil.MovePointTool(Vertices, ElementsOfShape, graphicsDrawPanel, blackPen, SenderMethod.DrawPanelMouseDown);
    }

    private void DrawPanelClick(object sender, EventArgs e)
    {
      if (ShapeCalcToolBox.CurrentTool == DrawTools.Pen)
        DrawPanelUtil.PenBrushTool(Vertices, Edges, ElementsOfShape, graphicsDrawPanel, blackPen, DrawPanel, SenderMethod.DrawPanelClick);
      if (ShapeCalcToolBox.CurrentTool == DrawTools.Curve)
        DrawPanelUtil.CurveBrushTool(Vertices, ElementsOfShape, Edges, graphicsDrawPanel, blackPen, SenderMethod.DrawPanelClick);
      if (ShapeCalcToolBox.CurrentTool == DrawTools.Drag)
        DrawPanelUtil.MovePointTool(Vertices, ElementsOfShape, graphicsDrawPanel, blackPen, SenderMethod.DrawPanelClick);
    }

    //
    //Undo-Button
    //
    private void Undo_Click(object sender, EventArgs e)
    {

    }

    //
    //Redo-Button
    //
    private void RedoLine(object sender, EventArgs e)
    {

    }

    //
    //Clear-Button
    //
    private void Clear(object sender, EventArgs e)
    {
      DrawPanelUtil.CleanPanel(Vertices, Edges, ElementsOfShape, graphicsDrawPanel, Color.Gainsboro);
    }

    //
    //Scale-NumericUpDown
    //
    private void ScaleChange(object sender, EventArgs e)
    {
      pixelMeter = Convert.ToDouble(ScaleOption.Value) * 100 / DrawPanel.Width;
      label4.Text = Convert.ToString(Math.Round((pixelMeter * DrawPanel.Height / 100), 2) + "m");
    }

    //
    //Thickness-TrackBar
    //
    private void ThicknessChanged(object sender, EventArgs e)
    {
      DrawPanelUtil.PenThicknessTrackBar(Vertices, ElementsOfShape, graphicsDrawPanel, (TrackBar)sender, blackPen);
    }

    //
    //PenBrush-Tool
    //
    private void PenBrush_Click(object sender, EventArgs e)
    {
      DrawPanel.Cursor = Cursors.Cross;
      DrawPanelUtil.PenBrushTool(Vertices, Edges, ElementsOfShape, graphicsDrawPanel, blackPen, DrawPanel, SenderMethod.PenButtonClick);
      ShapeCalcToolBox.SetCurrentTool((Button)sender, DrawTools.Pen);
    }

    //
    //CurveBrush-Tool
    //
    private void CurveBrush_Click(object sender, EventArgs e)
    {
      DrawPanel.Cursor = Cursors.Hand;
      ShapeCalcToolBox.SetCurrentTool((Button)sender, DrawTools.Curve);
      DrawPanelUtil.CurveBrushTool(Vertices, ElementsOfShape, Edges, graphicsDrawPanel, blackPen, SenderMethod.CurveButtonClick);
    }

    //
    //MovePoint-Tool
    //
    private void MovePoint_Click(object sender, EventArgs e)
    {
      DrawPanel.Cursor = Cursors.Hand;
      ShapeCalcToolBox.SetCurrentTool((Button)sender, DrawTools.Drag);
      DrawPanelUtil.MovePointTool(Vertices, ElementsOfShape, graphicsDrawPanel, blackPen, SenderMethod.DragButtonClick);
    }

    private bool _antiAliaActive = false;
    private void AntiAliasingClick(object sender, EventArgs e)
    {
      if (!_antiAliaActive)
      {
        graphicsDrawPanel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
        AntiAliasingButton.BackColor = Color.DarkSlateGray;
        _antiAliaActive = true;
      }
      else
      {
        graphicsDrawPanel.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.Default;
        AntiAliasingButton.BackColor = Color.DarkGray;
        _antiAliaActive = false;
      }

      DrawPanelUtil.RedrawShape(graphicsDrawPanel, ElementsOfShape, Vertices, blackPen);
    }
  }

  public enum SenderMethod
  {
    DrawPanelMouseDown,
    DrawPanelClick,
    DragButtonClick,
    CurveButtonClick,
    PenButtonClick
  }
}

