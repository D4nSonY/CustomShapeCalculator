using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


/*
 * This namespace is created for testing purposes.
 * Please do not use this methods as real functions
 * of the program, instead check the functionality
 * of a method here and create a renamed version of it
 * in the real program, Thanks.
*/
namespace CustomShapeCalculator.Testing
{
  public class TestMethods
  {
    public static void TestMethodCurve(Graphics graphics)
    {
      // Create pens.
      Pen redPen = new Pen(Color.Red, 2);
      Pen greenPen = new Pen(Color.Green, 2);

      // Create points that define curve.
      var point1 = new Point(50, 50);
      var point2 = new Point(230, 75);
      var point4 = new Point(250, 50);

      var point7 = new Point(250, 250);

      Point[] curvePoints = { point1, point4, point2, point7 };

      // Draw lines between original points to screen.
      graphics.DrawLines(redPen, curvePoints);

      // Draw curve to screen.
      graphics.DrawCurve(greenPen, curvePoints);
    }
  }
}
