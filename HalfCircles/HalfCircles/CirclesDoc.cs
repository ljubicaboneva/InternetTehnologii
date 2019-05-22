using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfCircles
{
    [Serializable]
    public class CirclesDoc
    {
        public List <Circle>  circles{ get; set; }
        public Color CurrentColor1 { get; set; }
        public Color CurrentColor2 { get; set; }

        Color tmp;
        public CirclesDoc()
        {
            circles = new List<Circle>();
            CurrentColor1 = Color.Blue;
            CurrentColor2 = Color.Red;

        }
        public void Add(Point p)
        {
            Circle circle = new Circle(p,CurrentColor1,CurrentColor2);
            circles.Add(circle);
         }
        public void Draw(Graphics g)
        {
            foreach(Circle c in circles)
            {
                c.Draw(g);
            }
        }
        public void Change()
        {
           foreach(Circle c in circles)
            {
                tmp = c.Color1;
                c.Color1 = c.Color2;
                c.Color2 = tmp;
            }
        }
       
    }
}
