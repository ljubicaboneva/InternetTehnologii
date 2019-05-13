using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    public class RectanglesDoc
    {
        public List<Rectangle> rectangles { get; set; }
        public List<Rectangle> allRectangles { get; set; }
        public Rectangle rectangle  { get; set; }
        public Color color { get; set; }
        public RectanglesDoc()
        {
            rectangles = new List<Rectangle>();
            allRectangles = new List<Rectangle>();
            color = Color.Blue;
            
        }


        public void AddRectangle(Point start, Point end)
        {

            Rectangle rect = new Rectangle(start, end,color);

            rectangles.Add(rect);
        }
        public void AllRectangles(Point start,Point end)
        {
             rectangle = new Rectangle(start, end,Color.Black);
          
        }
            
        public void DrawRectangles(Graphics g)
        {
            
            foreach (Rectangle r in rectangles)
            {
                r.FillDraw(g);
            }
        }
        public void MoveRectangles(Graphics g)
        {
            rectangle.Draw(g);
        }
        public void Selected(Graphics g)
        {
            
        }

    }
}
