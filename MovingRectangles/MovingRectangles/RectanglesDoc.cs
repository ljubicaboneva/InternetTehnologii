using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingRectangles
{
    [Serializable]
    public class RectanglesDoc
    {
        public List<Rectangle> rectangles { get; set; }
        public Color currentColor { get; set; }
       

        public RectanglesDoc()
        {
            rectangles = new List<Rectangle>();
            currentColor = Color.Red;
        }

        public void AddRectangle(int x, int y)
        {
            Rectangle rectangle = new Rectangle();
            rectangle.X = x - 50;
            rectangle.Y = y - 25;
            rectangle.Color = currentColor;
            rectangles.Add(rectangle);
        }

        
        public void Draw(Graphics g)
        {
            foreach(Rectangle r in rectangles)
            {
                r.Draw(g);
            }
        }
        public void Move()
        {
            
            foreach (Rectangle r in rectangles)
            {
                {
                        if (r.direction == Direction.DOWN)
                        {
                            r.MoveDown();
                        }
                        else if (r.direction == Direction.RIGHT)
                        {
                            r.MoveRight();
                        }
                    }
            }
           
        }
        public void Delete(int w,int h)
        {
            if (rectangles.Count > 0)
            {
                for (int i = rectangles.Count-1; i >= 0; i--)
                {
                    if (rectangles[i].X  > w || rectangles[i].Y   > h)
                    {
                        rectangles.RemoveAt(i);
                    }
                }
            }
        }

    }
}
