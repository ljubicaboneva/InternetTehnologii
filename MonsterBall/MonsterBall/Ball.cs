using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    public class Ball
    {
        public Point Center { get; set; }
        public int Number { get; set; }
        public Color Color { get; set; }
        public int Radius { get; set; }
        public Random random;
        public int i;
        public int pravec;
        public Font font;
        public double Velocity { get; set; }
        public double Angle { get; set; }

        private float velocityX;
        private float velocityY;
        public Ball(Point center, Color color)
        {
            Center = center;
            Number = 0;
            Color = color;
            random = new Random();
            font = new Font("Arial", 20);
            i = random.Next(0,3);
            Velocity = 10;
            Random r = new Random();
            Angle = r.NextDouble() * 2 * Math.PI;
            velocityX = (float)(Math.Cos(Angle) * Velocity);
            velocityY = (float)(Math.Sin(Angle) * Velocity);

        }
        public void Draw(Graphics g)
        {
            if (i == 0)
            {
                Radius = 25;
            }
            else if (i == 1)
            {
                Radius = 30;
            }
            else
            {
                Radius = 40;
            }
            Brush b = new SolidBrush(Color);
            Brush b1 = new SolidBrush(Color.White);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            g.DrawString(string.Format("{0}", Number),font, b1, Center.X - Radius / 2, Center.Y - Radius / 2);
            b.Dispose();
        }
        public bool Distance(Ball ball)
        {
            return ((Center.X - ball.Center.X) * (Center.X - ball.Center.X) + (Center.Y - ball.Center.Y) * (Center.Y - ball.Center.Y) <= (Radius+ball.Radius) * (Radius + ball.Radius));
        }
        public void Move(int left, int top, int width, int height)
        {
            int nextX = (int)(Center.X + velocityX);
            int nextY = (int)(Center.Y + velocityY);
            int lft = left + Radius;
            int rgt = left + width - Radius;
            int tp = top + Radius;
            int btm = top + height - Radius;

            if (nextX <= lft)
            {
                nextX = lft + (lft - nextX);
                velocityX = -velocityX;
            }
            if (nextX >= rgt)
            {
                nextX = rgt - (nextX - rgt);
                velocityX = -velocityX;

            }
            if (nextY <= tp)
            {
                nextY = tp + (tp - nextY);
                velocityY = -velocityY;
            }

            if (nextY >= btm)
            {
                nextY = btm - (nextY - btm);
                velocityY = -velocityY;
            }
            Center = new Point(nextX, nextY);
        }
    }
}
