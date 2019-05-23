using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class Circle
    {
        public Point Center { get; set; }
        public static int Radius = 25;
        public Color Color { get; set; }
        public int sweepAngle;
        public Circle(Point point,Color color)
        {
            Center = point;
            Color = color;
            sweepAngle = 360;
        }
        public void Draw(Graphics g)
        {


            Brush b = new SolidBrush(Color);
            g.FillPie(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 0,sweepAngle);
            b.Dispose();
        }
      
    }
}
