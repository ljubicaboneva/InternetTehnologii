using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
   [Serializable]
    public class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public static int Radius = 30;
        public int broj;


        public Ball(int x , int y , Color color)
        {
            X = x;
            Y = y;
            Color = color;
            

        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }
        public void Move()
        {
            X += 10;
        }
        public bool Selected(int x1, int y1)
        {
            return ((X - x1) * (X- x1) + (Y - y1) * (Y - y1))<=Radius*Radius;
        }



    }
}
