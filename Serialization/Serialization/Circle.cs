using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Serialization
{
    [Serializable]
    public class Circle
    {
        
        static readonly float RADIUS = 25;
        public Color c { get; set; }
        public Point p { get; set; }
        //public Brush brush { get; set; }
        float radius;
        public Circle(Point position, Color color)
        {
            radius = RADIUS;
            p = position;
            c = color;
           
            
        }
        public void Draw(Graphics g)
        {
            
            Brush brush = new SolidBrush(c);
            g.FillEllipse(brush, p.X - radius , p.Y - radius,  2 * radius, 2 * radius);
            brush.Dispose();
        }
    }
}
