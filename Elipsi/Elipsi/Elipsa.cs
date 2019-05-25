using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
    public class Elipsa
    {
        public Point Point { get; set; }
        public int Width { get; set; }
        public int Heigh { get; set; }
        public Color Color { get; set; }
       // public int Dijametar;
        public Elipsa(Point c,int w,int h,Color color)
        {
            Point = c;
            Width = w;
            Heigh = h;
            Color = color;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Point.X, Point.Y, Width, Heigh);
            b.Dispose();
        }
        
    }
}
