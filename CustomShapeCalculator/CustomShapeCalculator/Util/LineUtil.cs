using CustomShapeCalculator.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomShapeCalculator.Util
{
  public class LineUtil
  {
    private static List<Point> _deletedPoints = new List<Point>();
    private static List<Line> _deletedLines = new List<Line>();

    public static void UndoLine(Pen pen, Panel drawpanel, Graphics gr, List<Point> vertices, List<Line> edges)
    {
      if (vertices.Count > 0)
      {
        gr.Clear(Color.Gainsboro);
        _deletedPoints.Add(vertices[vertices.Count - 1]);
        vertices.RemoveAt(vertices.Count - 1);
        if (edges.Count > 0)
        {
          _deletedLines.Add(edges[edges.Count - 1]);
          edges.RemoveAt(edges.Count - 1);
        }
        for (int i = 0; i < vertices.Count - 1; i++)
        {
          gr.DrawLine(pen, vertices[i], vertices[i + 1]);
        }
      }
    }
    public static void RedoLine(Pen pen, Graphics gr, List<Point> vertices, List<Line> edges)
    {
      if (vertices.Count != 0 && _deletedPoints.Count != 0 && vertices[0] != vertices[vertices.Count - 1])
      {
        if (vertices.Count == 0)
        {
          vertices.Add(_deletedPoints[_deletedPoints.Count - 1]);
          _deletedPoints.RemoveAt(_deletedPoints.Count - 1);
        }
        gr.DrawLine(pen, vertices[vertices.Count - 1], _deletedPoints[_deletedPoints.Count - 1]);
        vertices.Add(_deletedPoints[_deletedPoints.Count - 1]);
        _deletedPoints.RemoveAt(_deletedPoints.Count - 1);
        if (edges.Count > 0 && _deletedLines.Count != 0)
        {
          edges.Add(_deletedLines[_deletedLines.Count - 1]);
          _deletedLines.RemoveAt(_deletedLines.Count - 1);
        }
      }
    }

    /// <summary>
    /// This function determines wether to given lines interesect
    ///  by checking if there is a intersection point, assuming the lines are infinite.
    ///  If there is one the function checks if both lines (finite) contain this intersection point.
    /// </summary>
    public static bool Intersect(Line line1, Line line2)
    {
      Point IntersectionPoint;
      double thisA = line1.AllPointsOfElement[1].Y - line1.AllPointsOfElement[0].Y;
      double thisB = line1.AllPointsOfElement[0].X - line1.AllPointsOfElement[1].X;
      double thisC = line1.AllPointsOfElement[0].X * thisA + line1.AllPointsOfElement[0].Y * thisB;
      double thatA = line2.AllPointsOfElement[1].Y - line2.AllPointsOfElement[0].Y;
      double thatB = line2.AllPointsOfElement[0].X - line2.AllPointsOfElement[1].X;
      double thatC = line2.AllPointsOfElement[0].X * thatA + line2.AllPointsOfElement[0].Y * thatB;
      double det = thisA * thatB - thatA * thisB;

      if (det == 0)
      {
        return false;
      }
      else
      {
        double xNew = (thatB * thisC - thisB * thatC) / det;
        double yNew = (thisA * thatC - thatA * thisC) / det;
        IntersectionPoint = new Point(Convert.ToInt32(xNew), Convert.ToInt32(yNew));
      }

      double LineLength1 = CalculationUtil.GetDistance(line1.AllPointsOfElement[0], line1.AllPointsOfElement[1]);
      double LineLenght2 = CalculationUtil.GetDistance(line2.AllPointsOfElement[0], line2.AllPointsOfElement[1]);
      double proofLineLength1 = CalculationUtil.GetDistance(line1.AllPointsOfElement[0], IntersectionPoint);
      double proofLineLength2 = CalculationUtil.GetDistance(line1.AllPointsOfElement[1], IntersectionPoint);
      double proofLineLength3 = CalculationUtil.GetDistance(line2.AllPointsOfElement[0], IntersectionPoint);
      double proofLineLength4 = CalculationUtil.GetDistance(line2.AllPointsOfElement[1], IntersectionPoint);
      if ((proofLineLength1 < LineLength1 && proofLineLength2 < LineLength1) && (proofLineLength3 < LineLenght2 && proofLineLength4 < LineLenght2))
        return true;
      else
        return false;
    }

    /// <summary>
    /// Determines if a given line intersects with a shape.
    /// edges of the shape.
    /// The shape has to be given in form of a list, containing the
    /// edges of the shape.
    /// </summary>
    /// <param name="errorMessage">The error message for the case of an intercection</param>
    /// <param name="edges">The list of the shapes edges</param>
    /// <param name="line">The line that is checked for intersection</param>
    public static bool ShapeIntersection(string errorMessage, List<Line> edges, Line line)
    {
      bool _shapeIntersect = false;
      for (int i = 0; i < edges.Count - 1; i++)
      {
        if (Intersect(line, edges[i]))
        {
          MessageBox.Show(errorMessage);
          _shapeIntersect = true;
        }
      }
      return _shapeIntersect;
    }
  }
}
