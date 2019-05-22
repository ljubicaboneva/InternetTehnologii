using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class Circle
    {
        public int Radius { get; set; }
        public Point Center { get; set; }
        public Color Color1 { get; set; }
        public Color Color2 { get; set; }

        public Circle(Point center,Color color1,Color color2)
        {
            Radius = 50;
            Center = center;
            Color1 = color1;
            Color2 = color2;
        }

        public void Draw(Graphics g)
        {
            Brush b1 = new SolidBrush(Color1);
            Brush b2 = new SolidBrush(Color2);
            g.FillPie(b1, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 0, 180);
            g.FillPie(b2, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius, 180, 180);
        }

    }
}
