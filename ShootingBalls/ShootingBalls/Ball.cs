using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingBalls
{
    public class Ball
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int Radius { get; set; }
        public Color color { get; set; }
        public int ColorNum { get; set; }
        public int Poeni { get; set; }
        public bool Selected;
        public int flag;

        public Ball(int width, int height, Random random)
        {
            Radius = random.Next(30, 80);
            X = random.Next(100, width - 100);
            Y = random.Next(100, height - 100);
           
            ColorNum = random.Next(0, 3);
            Poeni = 0;
            Selected = false;
            flag = 0;
        }
        public Ball(int x,int y)
        {
            Radius = 50;
            X = x;
            Y = y;
            color = Color.Black;
            ColorNum = 3;
        }
        public void Draw(Graphics g)
        {
            if (ColorNum == 0)
            {
                color = Color.Blue;
                Poeni = 15;
            }
            else if (ColorNum == 1)
            {
                color = Color.Green;
                Poeni = 10;
            }
            else if (ColorNum == 2)
            {
                color = Color.Orange;
                Poeni = 5;
            }
           
            Brush brush = new SolidBrush(color);
            g.FillEllipse(brush, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            brush.Dispose();

        
        }
        private int distance(int x1, int y1,int x2,int y2)
        {
            return (x1 - x2) * (x1 - x2) + (y1 - y2) * (y1 - y2);
        }
        public void Hit(int x,int y)
        {
            Selected = distance(X,Y,x,y) <= Radius * Radius;
            if (Selected)
            {
                color = Color.Red;
            }
            
       }
        public bool Touch(Ball b)
        {
            int dist = distance(X,Y, b.X,b.Y);
            return (Radius + b.Radius) * (Radius + b.Radius) >= dist;
        }
    }
}