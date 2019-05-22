using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PulsingCircles
{
    [Serializable]
    public class CirclesDoc
    {
        public List <Circle>  circles{ get; set; }
        public Color CurrentColor { get; set; }
        public CirclesDoc()
        {
            circles = new List<Circle>();
            CurrentColor = Color.Black;
        }
        public void Add(Point p)
        {
            Circle circle = new Circle(p,CurrentColor);
            circles.Add(circle);
         }
        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }
        public void Resize()
        {
            foreach(Circle c in circles)
            {
                if (c.Radius <= 60)
                {
                    c.Radius += (int)(c.Radius * 0.1);
                }
                else
                {
                    c.Radius = 30;
                }
            }
        }
    }
}
