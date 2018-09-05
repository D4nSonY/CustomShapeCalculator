using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomShapeCalculator.Util
{
  public class CalculationUtil
  {

    #region public methods
    //
    //returns the scope of Shape with the given corners in List<Point> Corners.
    //value is calculated in m [Meter] and "pixelMeter" gives the Centimeter per Pixel.
    //if the shape isn´t valid the function returns 0 and a error message.
    //
    public static double Scope(List<Point> vertices, List<Line> edges, double pixelMeter)
    {
      double _scope = 0;
      if (vertices[0] == vertices[vertices.Count - 1])
      {
        for (int i = 0; i < vertices.Count - 1; i++)
        {
          _scope += GetDistance(vertices[i], vertices[i + 1]);
        }
        return Math.Round(_scope / 100 * pixelMeter, 2);
      }
      else
      {
        MessageBox.Show("Kein gültiges Polygon.");
        return 0;
      }
    }

    public static double Surface(List<Point> vertices, double pixelMeter)
    {
      double _surface = 0;

      for (int i = 0; i < vertices.Count - 1; i++)
      {
        Point nextPoint = vertices[i + 1];
        _surface += ((nextPoint.X + vertices[i].X) / 2 * pixelMeter) * ((nextPoint.Y - vertices[i].Y) * pixelMeter);
      }
      return Math.Round(Math.Abs(_surface / 10000), 2);
    }

    public static double GetDistance(Point firstPoint, Point secondPoint)
    {
      double distance = Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2));
      return distance;
    }
    #endregion
  }
}
