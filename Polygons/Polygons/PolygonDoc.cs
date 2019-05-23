using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polygons
{
    [Serializable]
    public class PolygonDoc
    {
        
        public List  <Polygon> polygons { get; set; }
        //public List<Point> points { get; set; }
        public Color CurrentColor { get; set; }
        public PolygonDoc()
        {
            polygons = new List<Polygon>();
            CurrentColor = Color.Blue;
           // points = new List<Point>();
        }
     
        public void Add(Polygon polygon)
        {
            polygon.Color = CurrentColor;
            polygons.Add(polygon);
        }
        public void Draw(Graphics g)
        {
            foreach(Polygon p in polygons)
            {
                p.Draw(g);
            }
        }
        public double distance(Point p1, Point p2)
        {
            return (p1.X - p2.X) * (p1.X - p2.X) + (p1.Y - p2.Y) * (p1.Y - p2.Y);

        }
        public void Move(int x,int y)
        {
            foreach(Polygon p in polygons)
            {
                p.Move(x,y);
            }
            
           
        }
       
    }
}
