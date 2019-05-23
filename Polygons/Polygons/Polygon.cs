using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class Polygon
    {
       
        public Color Color { get; set; }
        public List <Point> Points { get; set; }
        public bool Closed;

        

        public Polygon(Color c)
        {
            Closed = false;
            Color = c;
            Points = new List<Point>();
          
        }
        public void AddPoints(Point point)
        {
            
            Points.Add(point);
        }
        public void Draw(Graphics g)
        {

            if (Points.Count > 1)
            {
                Pen p = new Pen(Color, 1);
                p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                g.DrawLines(p, Points.ToArray());
            }
            if (Closed)
            {
                Brush b = new SolidBrush(Color);
                g.FillPolygon(b, Points.ToArray());
            }
           }

        public void Move(int x,int y)
        {
            for (int i = Points.Count-1; i>=0; --i) { 
                Points[i] = new Point(Points[i].X + x, Points[i].Y + y);
            }
        }
            
        }
        
    }

