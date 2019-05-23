using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TickingPies
{
    [Serializable]
    public class CircleDoc
    {
        public List<Circle> circles { get; set; }
        public Color CurrentColor { get; set; }
        public CircleDoc()
        {
            circles = new List<Circle>();
            CurrentColor = Color.Blue;
        }
        public void Add(Point p)
        {
            Circle circle = new Circle(p, CurrentColor);
            circles.Add(circle);
        }
        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                
                c.Draw(g);
            }
        }
        public void Smaller()
        {
            for(int i = circles.Count-1;i>=0;--i)
            {
                circles[i].sweepAngle -= 90;
                if (circles[i].sweepAngle == 0)
                {
                    circles.RemoveAt(i);
                }
            }
        }
    }
}
