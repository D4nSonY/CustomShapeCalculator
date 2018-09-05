using CustomShapeCalculator.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomShapeCalculator
{
  public class Line : Shape.ShapeElements
  {
    public Line(Point start, Point end)
    {
      if ((end.X - start.X) != 0)
        Slope = (end.Y - start.Y) / (end.X - start.X);

      AllPointsOfElement = new Point[] { start, end };
    }

    public double Slope { get; set; }
    public override int[] IndexInVertexList { get; set; }
    public override Point[] AllPointsOfElement { get; set; }
    public override void Draw(Pen pen, Graphics graphics, List<Point> vertices, List<ShapeElements> shapeElements)
    {
      graphics.DrawLine(pen, AllPointsOfElement[0], AllPointsOfElement[1]);
    }
  }
}
