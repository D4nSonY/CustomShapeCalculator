using System;
using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CustomShapeCalculator.Shape;

namespace CustomShapeCalculator.Util
{
  public class DrawPanelUtil
  {
    #region local variables
    private static double _distanceToFirstPoint;
    private static Point MousePos;
    private static int _startToleranceRatio = 30;
    private static Pen curvePen = new Pen(Color.DarkBlue, 3);
    #endregion

    #region public methods
    public static void MouseMovement(List<Point> vertices, Point mousePos, Graphics graphics, Pen pen)
    {
      MousePos = mousePos;
      var penForTemLine = new Pen(Color.DarkGray, pen.Width);
      if (vertices.Count > 0)
      {
        _distanceToFirstPoint = CalculationUtil.GetDistance(vertices[0], MousePos);
      }
    }

    public static void CleanPanel(List<Point> vertices, List<Line> lines, List<ShapeElements> shapeElements, Graphics gr, Color clearColor)
    {
      lines.Clear();
      gr.Clear(clearColor);
      vertices.Clear();
      shapeElements.Clear();
    }

    public static void PenBrushTool(List<Point> vertices, List<Line> edges, List<ShapeElements> shapeElements, Graphics graph, Pen pen, Panel panel, SenderMethod sender)
    {
      if (sender == SenderMethod.PenButtonClick)
      {
        RedrawShape(graph, shapeElements, vertices, pen);
      }
      if (sender == SenderMethod.DrawPanelClick)
      {
        PlacePoint(vertices, graph, panel);
        if (vertices.Count > 1)
        {
          Line line = new Line(vertices[vertices.Count - 2], vertices[vertices.Count - 1]);
          line.IndexInVertexList = new int[] { vertices.Count - 2, vertices.Count - 1 };

          if (!LineUtil.ShapeIntersection("Es können keine schneidenen Kanten eingefügt werden", edges, line))
          {
            line.Draw(pen, graph, vertices, shapeElements);
            edges.Add(line);
            shapeElements.Add(line);
          }
          else
          {
            vertices.Remove(vertices[vertices.Count - 1]);
          }
        }
      }
    }

    private static int _curveCount = 0;
    private static int _start = 0;
    private static int _end = 0;
    private static int _direc = 0;
    /// <summary>
    /// This function enables the user to choose two vertices, which will be the start
    /// and the end of a curve. After that he has to pick a third one to give the curves
    /// side on the shape.
    /// </summary>
    public static void CurveBrushTool(List<Point> vertices, List<ShapeElements> shapeElements, List<Line> edges, Graphics graph, Pen blackPen, SenderMethod sender)
    {
      if (sender == SenderMethod.CurveButtonClick)
      {
        MarkAllVertices(vertices, graph);
      }
      else if (sender == SenderMethod.DrawPanelClick)
      {
        if (_curveCount == 0) // first Click
        {
          _start = ChooseVertex(vertices, 15);
          MarkAllVertices(vertices, graph, _start);
        }
        else if (_curveCount == 1) // second Click
        {
          _end = ChooseVertex(vertices, 15);
          MarkAllVertices(vertices, graph, _start, _end);
        }
        else if (_curveCount == 2) // third Click
        {
          _curveCount = -1;
          _direc = ChooseVertex(vertices, 15);

          List<Point> _curvePoints = new List<Point>();

          Curve curve = new Curve();
          curve.IndexInVertexList = CreateCurveArray(vertices, _start, _end, _direc);
          for (int i = 0; i < curve.IndexInVertexList.Length; i++)
          {
            _curvePoints.Add(vertices[curve.IndexInVertexList[i]]);
          }
          curve.AllPointsOfElement = _curvePoints.ToArray();


          for (int j = 0; j < shapeElements.Count; j++)
          {
            if (curve.AllPointsOfElement.Contains(shapeElements[j].AllPointsOfElement[1]) && curve.AllPointsOfElement.Contains(shapeElements[j].AllPointsOfElement[0]))
            {
              shapeElements.Remove(shapeElements[j--]);
            }
          }

          shapeElements.Add(curve);
          _curvePoints.Clear();
          RedrawShape(graph, shapeElements, vertices, blackPen);
        }
        _curveCount++;
      }
    }

    private static bool _choiseValid = false;
    private static Point _tempPoint;
    private static int chosenPoint;
    /// <summary>
    /// Marks all vertices when the SenderMethod is the click on the tool Button.
    /// After that the function enables the user to change the position of a chosen vertex.
    /// The whole shape is redrawn automatically after such an action.
    /// </summary>
    public static void MovePointTool(List<Point> vertices, List<ShapeElements> shapeElements, Graphics graph, Pen pen, SenderMethod sender)
    {
      if (vertices.Count > 0)
      {
        if (sender == SenderMethod.DragButtonClick)
          MarkAllVertices(vertices, graph);

        else if (sender == SenderMethod.DrawPanelMouseDown)
        {
          chosenPoint = ChooseVertex(vertices, 15);
          if (vertices.Count > chosenPoint)
          {
            MarkAllVertices(vertices, graph, chosenPoint);
            _choiseValid = true;
          }
        }
        else if (sender == SenderMethod.DrawPanelClick)
        {
          if (_choiseValid)
          {
            _tempPoint = vertices[chosenPoint];
            if (chosenPoint != 0 && chosenPoint != vertices.Count - 1)
            {
              vertices[chosenPoint] = MousePos;
            }
            else
            {
              vertices[0] = MousePos;
              vertices[vertices.Count - 1] = MousePos;
            }
            _choiseValid = false;

            for (int i = 0; i < shapeElements.Count; i++)
            {
              for (int j = 0; j < shapeElements[i].IndexInVertexList.Length; j++)
              {
                shapeElements[i].AllPointsOfElement[j] = vertices[shapeElements[i].IndexInVertexList[j]];
              }
            }
          }

          RedrawShape(graph, shapeElements, vertices, pen);
          MarkAllVertices(vertices, graph, chosenPoint);
        }
      }
    }

    public static void PenThicknessTrackBar(List<Point> vertices, List<ShapeElements> shapeElements, Graphics graphics, TrackBar penThicknessTrack, Pen pen)
    {
      pen.Width = penThicknessTrack.Value + 1;

      RedrawShape(graphics, shapeElements, vertices, pen);
    }

    /// <summary>
    /// Marks all vertices given in form of a list with datatype "Point"
    /// on a graphics element of a control.
    /// You can give a specialPoint array with vertices that are marked in a
    /// different color.
    /// </summary>
    public static void MarkAllVertices(List<Point> vertices, Graphics graph, params int[] specialPoint)
    {
      if (vertices.Count > 0)
      {
        foreach (var item in vertices)
        {
          if (specialPoint.Contains(vertices.IndexOf(item)))
          {
            MarkVertex(item, graph, Color.Blue);
          }
          else
          {
            MarkVertex(item, graph, Color.Red);
          }
        }
      }
    }
    public static void RedrawShape(Graphics graphics, List<ShapeElements> shapeElements, List<Point> vertices, Pen pen)
    {
      {
        graphics.Clear(Color.Gainsboro);
        for (int i = 0; i < shapeElements.Count; i++)
        {
          shapeElements[i].Draw(pen, graphics, vertices, shapeElements);
        }
      }
    }
    #endregion



    #region private methods
    /// <summary>
    /// If executed, this method simply places a "Point" with the coordinates
    /// of the mouse position on the current control and adds it to the given
    /// list.
    /// </summary>
    private static void PlacePoint(List<Point> vertices, Graphics graph, Panel panel)
    {
      if (vertices.Count < 2 || vertices[0] != vertices[vertices.Count - 1])
      {
        if (_distanceToFirstPoint > _startToleranceRatio || vertices.Count == 0)
        {
          vertices.Add(MousePos);
        }
        else
        {
          vertices.Add(new Point(vertices[0].X, vertices[0].Y));
          //  automatically switch to Drag-Tool
          if (vertices.Count > 1)
          {
            ShapeCalcToolBox.SetCurrentTool(ShapeCalcToolBox._oldButton, DrawTools.Drag);
            panel.Cursor = Cursors.Hand;
            MarkAllVertices(vertices, graph);
          }
        }
      }
    }

    /// <summary>
    /// Marks one vertex on a given graphics element in a given color.
    /// </summary>
    private static void MarkVertex(Point middle, Graphics graph, Color color)
    {
      var pen = new Pen(color, 6);
      var rectPoint = new Point(middle.X - 2, middle.Y - 2);
      var rectSize = new Size(7, 7);
      var rectangle = new Rectangle(rectPoint, rectSize);
      graph.DrawEllipse(pen, rectangle);
    }

    /// <summary>
    /// Returns a point that equals a point in a given list,
    /// if the points distance to the point in the list is smaller
    /// than the given tolerated ratio.
    /// </summary>
    private static int ChooseVertex(List<Point> vertices, int toleratedRatio)
    {
      int indexOfChosenPoint = vertices.Count;
      foreach (var vertex in vertices)
      {
        if (CalculationUtil.GetDistance(MousePos, vertex) < toleratedRatio)
        {
          indexOfChosenPoint = vertices.IndexOf(vertex);
        }
      }
      return indexOfChosenPoint;
    }

    private static int[] CreateCurveArray(List<Point> vertices, int firstIndexPick, int secondIndexPick, int directionalIndexPick)
    {
      int[] FixedPoints = new int[] { firstIndexPick, secondIndexPick };
      Array.Sort(FixedPoints);
      firstIndexPick = FixedPoints[0];
      secondIndexPick = FixedPoints[1];

      List<int> _indeces = new List<int>();
      bool _countingDirection = false;
      for (int i = firstIndexPick; i <= secondIndexPick; i++)
      {
        _indeces.Add(i);
        if (i == directionalIndexPick)
          _countingDirection = true;
      }
      if (_countingDirection == false)
      {
        _indeces.Clear();
        for (int i = 0; i < firstIndexPick; i++)
        {
          _indeces.Add(i);
        }
        for (int i = vertices.Count - 1; i >= secondIndexPick; i--)
        {
          _indeces.Add(i);
        }
      }

      return _indeces.ToArray();
    }
    #endregion 
  }
}
