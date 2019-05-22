using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SlidingBalls
{

    [Serializable]
    public class Ball
    {
        public static int Radius = 30;
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public int ColorNumer;
        Random random;
        public int r;
        public bool IsSelect;

        public Ball(int x, int y,Color color)
        {
            X = x;
            Y = y;
            Color = color;
            random = new Random();
            r = random.Next(0, 5);

        }
        public void Draw(Graphics g)
        {
           
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }
        public bool Hit(Point p)
        {
            return ((X-p.X) * (X - p.X) + (Y - p.Y) * (Y - p.Y) <= Radius * Radius);
        }
        public void Move()
        {
            if (r == 0)
            {
               X += 10;
                
            }
            else if (r == 1)
            {
                X -= 10;
            }
            else if (r == 2)
            {
                Y += 10;
            }
            else
            {
                Y -= 10;
            }
        }
       
    }
}
