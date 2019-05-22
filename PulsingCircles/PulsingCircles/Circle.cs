using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingCircles
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }

        public Color Color { get; set; }

        public Circle(Point center,Color color)
        {
            Radius = 30;
            Center = center;
            Color = color;
        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X-Radius, Center.Y-Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }

    }
}
