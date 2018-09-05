using CustomShapeCalculator.Shape;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomShapeCalculator
{
  public class Curve : Shape.ShapeElements
  {
    
    public override Point[] AllPointsOfElement { get; set; }
    public override int[] IndexInVertexList { get; set; }


    public override void Draw(Pen pen, Graphics graphics, List<Point> vertices, List<ShapeElements> shapeElements)
    {
      graphics.DrawCurve(pen, AllPointsOfElement);
    }
  }
}
