using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomShapeCalculator.Util
{
  public class ShortCutUtil
  {
    public static void Escape(List<Point> corners,List<Line> edges, Graphics graph, Pen pen)
    {
      corners.Add(corners[0]);
      Line Edge = new Line(corners[corners.Count - 2], corners[corners.Count - 1]);
      bool shapeValid = LineUtil.ShapeIntersection("Das Polygon kann nicht vollendet werden. Überprüfen Sie ob der letzte Punkt den ersten Punkt erreicht.", edges, Edge);
      if (shapeValid)
      {
        graph.DrawLine(pen, corners[corners.Count - 2], corners[corners.Count - 1]);
      }
      else
      {
        corners.RemoveAt(corners.Count - 1);
      }
    }
    public static void StrgZ(List<Point> corners, List<Line> edges, Panel drawPanel, Graphics graph, Pen pen)
    {
      LineUtil.UndoLine(pen, drawPanel, graph, corners, edges);
    }
    public static void StrgY(List<Point> corners, List<Line> edges, Panel drawPanel, Graphics graph, Pen pen)
    {
      LineUtil.RedoLine(pen, graph, corners, edges);
    }
  }
}
