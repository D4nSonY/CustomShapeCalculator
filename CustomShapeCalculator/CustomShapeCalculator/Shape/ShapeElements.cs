using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomShapeCalculator.Shape
{
  public abstract class ShapeElements
  {
    public abstract void Draw(Pen pen, Graphics graphics, List<Point> vertices, List<ShapeElements> shapeElements);
    public abstract int[] IndexInVertexList { get; set; }
    public abstract Point[] AllPointsOfElement { get; set; }
  }
}
