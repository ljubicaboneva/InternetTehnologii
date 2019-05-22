using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingRectangles
{
    
    public enum Direction
    {
        DOWN,
        RIGHT,
        
    };
    [Serializable]
    public class Rectangle
    {
        public  int Width1 = 100;
        public  int Heigh1 = 50;
        public int X { get; set; }
        public int Y { get; set; }
        public Color Color { get; set; }
        public bool IsSelected { get; set; }
        public Direction direction;
        public int flag1;
        public int flag2;
       

        int tmp;
       

        
        public Rectangle()
        {
         

        }

        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillRectangle(b, X, Y , Width1, Heigh1);
            b.Dispose();
            
          
        }
        public bool Selected(Point End, Point ClickStart)
        {
            return (ClickStart.X >= X  && ClickStart.Y >= Y  && ClickStart.X <= End.X && ClickStart.Y <= End.Y);
        }
        public void MoveDown()
        {
            if (IsSelected)
            {
                Y += 50;
                

            }
        }
        public void MoveRight()
        {
            if (IsSelected)
            {
                
                X = X + Width1;
                Y = Y + (Width1 - Heigh1) * (-1);
               
                tmp = Width1;
                Width1 = Heigh1;
                Heigh1 = tmp;
                
            }
            
        }
      


    }
}
