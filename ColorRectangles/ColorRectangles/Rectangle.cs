using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ColorRectangles
{
    [Serializable]
    public class Rectangle
    {
        public Point Start { get; set; }
        public Point End { get; set; }
        int x, y,flag1,flag2;
        public Color Color = Color.Blue;
        public Point pomoshX;
        public Point pomoshY;
        public bool Selectirana;
        public bool Over;

        public Rectangle()
        {

        }
        public Rectangle(Point start, Point end,Color color)
        {
            Start = start;
            End = end;
            Color = color;
            pomoshX = new Point();
            pomoshY = new Point();
            Selectirana = false;
            Over = false;
          
        }
        
        public double Width(Point start, Point end)
        {
            double reshenie = 0;
            x = start.X;
            if (x > end.X)
            {
                x = end.X;
                reshenie = Math.Sqrt((x - start.X) * (x - start.X));
                flag1 = 1;
            }
            else
            {
                reshenie = Math.Sqrt((start.X - end.X) * (start.X - end.X));
            }
            return reshenie;
        }
        public double Heigh (Point start, Point end)
        {
            double reshenie = 0;
            
            y = start.Y;
            if (y > end.Y)
            {
                y = end.Y;
                reshenie = Math.Sqrt((y - start.Y) * (y - start.Y));
                flag2 = 1;
            }
            else
            {
                reshenie = Math.Sqrt((start.Y - end.Y) * (start.Y - end.Y));
            }
            return reshenie;
        }

        public void Draw(Graphics g)
        {
            float width =(float) Width(Start, End);
            float height =(float) Heigh(Start, End);
            Pen p = new Pen(Color.Black,2);
            Point tmp = Point.Empty;
            p.DashStyle = System.Drawing.Drawing2D.DashStyle.Dot;
            if (flag1 == 1 && flag2==1)
            {
                pomoshX = End;
                pomoshY = Start;
                flag1 = 0;
                flag2 = 0; 

            }
            else if (flag2 == 1)
            {
                tmp = Start;
                pomoshX = new Point(tmp.X, End.Y);
                pomoshY = new Point(End.X, tmp.Y);
                flag2 = 0;

            }
            else if (flag1 == 1)
            {
                tmp = Start;
                pomoshX = new Point(End.X, tmp.Y);
                pomoshY = new Point(tmp.X, End.Y);
                flag1 = 0;
            }
             else
            {
                pomoshX = Start;
                pomoshY = End;
            }
            g.DrawRectangle(p, pomoshX.X, pomoshX.Y, width, height);
        }
        public void SelectedDraw(Graphics g)
        {
            float width = (float)Width(Start, End);
            float height = (float)Heigh(Start, End);
            Pen p = new Pen(Color.Red,4);
            Point tmp = Point.Empty;
            
            if (flag1 == 1 && flag2 == 1)
            {
               
                flag1 = 0;
                flag2 = 0; ;
                pomoshX = End;
                pomoshY = Start;

            }
            else if (flag2 == 1)
            {
                tmp = Start;
                flag2 = 0;
                pomoshX = new Point(tmp.X, End.Y);
                pomoshY = new Point(End.X, tmp.Y);

            }
            else if (flag1 == 1)
            {
                tmp = Start;
                flag1 = 0;
                pomoshX = new Point(End.X, tmp.Y);
                pomoshY = new Point(tmp.X, End.Y);

            }
            else
            {
                pomoshX = Start;
                pomoshY = End;
            }
            g.DrawRectangle(p, pomoshX.X, pomoshX.Y, width + 1, height + 1);

        }
        public void FillDraw(Graphics g)
        {
            float width = (float)Width(Start, End);
            float height = (float)Heigh(Start, End);
            Brush p = new SolidBrush(Color);
            Point tmp = Point.Empty;

            if (flag1 == 1 && flag2 == 1)
            {
                
                flag1 = 0;
                flag2 = 0; ;
                pomoshX = End;
                pomoshY = Start;

            }
            else if (flag2 == 1)
            {
                tmp = Start;
                flag2 = 0;
                pomoshX = new Point(tmp.X, End.Y);
                pomoshY = new Point(End.X, tmp.Y);

            }
            else if (flag1 == 1)
            {
                tmp = Start;
                flag1 = 0;
                pomoshX = new Point(End.X, tmp.Y);
                pomoshY = new Point(tmp.X, End.Y);

            }
            else
            {
                pomoshX = Start;
                pomoshY = End;
            }
            g.FillRectangle(p, pomoshX.X, pomoshX.Y, width, height);
        }
    }
}
