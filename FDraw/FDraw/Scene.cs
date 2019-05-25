using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class Scene
    {
        public List<Rectangle> rectangles { get; set; }
        public Color CurrentColor { get; set; }
        public Point start;
        public Point end;
        public int width = 0;
        public int height = 0;
        public int x, y;
        public Rectangle rectangle;
        public int flag = 0;
        public Scene()
        {
            rectangles = new List<Rectangle>();
            CurrentColor = Color.Blue;
        }
        public void Add(Rectangle rec)
        {
            int w = Math.Abs(start.X - end.X);
            int h = Math.Abs(start.Y - end.Y);
            rec = new Rectangle(start, w, h, CurrentColor);
            rectangles.Add(rec);
        }
        public void Draw(Graphics g)
        {
            foreach(Rectangle r in rectangles)
            {
                r.Draw(g);
            }
        }
     
        public void Click(Point p)
        {
            
                if (start.IsEmpty)
                {
                    start = p;
                    flag = 1;

                
            }
            
        }
        public void Move(Point p)
        {
            foreach (Rectangle r in rectangles)
            {
                if (r.IsSelect)
                {
                    //flag = 0;
                    start = Point.Empty;
                    r.Move(p);
                  
                   
                }

            }
        }
        public void Up(Point p)
        {
            if (!start.IsEmpty && end.IsEmpty)
            {
                end = p;
            }
            if (!start.IsEmpty && !end.IsEmpty)
            {
                width = Math.Abs(start.Y - end.Y);
                height = Math.Abs(start.X - end.X);
                rectangle = new Rectangle(new Point(x, y), height, width, CurrentColor);
                rectangles.Add(rectangle);
            }
        }
        public void ChangeParametars()
        {
            
                x = start.X;
                y = start.Y;
                if (x > end.X)
                    x = end.X;
                if (y > end.Y)
                    y = end.Y;
                width = Math.Abs(start.X - end.X);
                height = Math.Abs(start.Y - end.Y);
             
        }
    }
}
