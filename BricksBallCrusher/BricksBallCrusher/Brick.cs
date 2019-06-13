using BricksBallCrusher.Properties;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricksBallCrusher
{
     public class Brick
    {
        public static int Width = 60;
        public static int Height = 15;
        public Color Color { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public bool IsTouched { get; set; }
        Image Bomba;

        public Brick(int x, int y)
        {
            X = x;
            Y = y;
            Color = Color;
            IsTouched = false;
            Bomba = Resources.Bomba;
        }
        public void Draw(Graphics g)
        {
            Brush brush = new SolidBrush(Color);
            g.FillRectangle(brush, X, Y, Width, Height);
            brush.Dispose();
        }
        public void DrawImage(Graphics g)
        {
            g.DrawImageUnscaled(Bomba,X,Y,Width,Height);
        }
        public void Select(Ball ball)
        {
            if (ball.Center.X+ball.Radius >= X && ball.Center.X+ ball.Radius <= X + Width && ball.Center.Y+ ball.Radius >= Y && ball.Center.Y+ ball.Radius <= Y + Height)
            {
                IsTouched = !IsTouched;
                //ball.velocityY = -ball.velocityY;
                
            }
        }
    }
}
