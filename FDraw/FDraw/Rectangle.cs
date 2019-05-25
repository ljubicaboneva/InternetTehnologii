using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FDraw
{
    [Serializable]
    public class Rectangle
    {
        public Point Start { get; set; }

        public bool IsSelect;
        public Color Color  { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public Rectangle(Point start,int width, int height,Color color) 
        {
            Start = start;
            Width = width;
            Height = height;
            Color = color;
            IsSelect = false;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, Start.X, Start.Y, Width, Height);
            b.Dispose();
        }
        public bool Selected(Point point)
        {
            return point.X >= Start.X && point.Y >= Start.Y && point.X <= Start.X + Width && point.Y <= Start.Y + Height;
        }
        public void Move(Point point)
        {
            if (IsSelect)
            {
                Start = new Point(Start.X + point.X, Start.Y + point.Y);
            }
        }
      
    }
}
