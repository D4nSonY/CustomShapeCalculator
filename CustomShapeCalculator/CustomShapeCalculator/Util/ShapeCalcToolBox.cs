using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CustomShapeCalculator.Util
{
  public class ShapeCalcToolBox
  {
    public static DrawTools CurrentTool { get; set; } = DrawTools.Pen;
    public static Button _oldButton { get; set; }

    public static void SetCurrentTool(Button currentButton, DrawTools tool)
    {
      if (_oldButton != null)
        _oldButton.ForeColor = Color.Black;

      _oldButton = currentButton;
      currentButton.ForeColor = Color.White;

      CurrentTool = tool;
    }
  }

  public enum DrawTools
  {
    Pen,
    Curve,
    Drag
  }
}
