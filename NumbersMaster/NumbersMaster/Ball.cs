using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersMaster
{
    public class Ball
    {
        //public Point Center { get; set; }
        public int X { get; set; }
        public int Y { get; set; }
        public static int Radius = 25;
       
        public int myTime { get; set; }
        public int myNum { get; set; }
        public Font font { get; set; }
        public bool Hit;
        public Ball(int width,int height)
        {
            Random random = new Random();
            myNum = random.Next(0, 10);
            font = new Font("Arial", 20);
            X = random.Next(25,width-50);
            Y = random.Next(25,height-50);
            Hit = false;
           
            myTime = 0;
        }
        public void Draw(Graphics g)
        {
            Brush brush1 = new SolidBrush(Color.Black);
            if (myTime == 0)
            {
                Brush brush = new SolidBrush(Color.Aqua);
                g.FillEllipse(brush, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
                g.DrawString(string.Format("{0}", myNum), font, brush1, X-15 , Y-15 );
                brush.Dispose();
            }
            else
            {
                Brush brush = new SolidBrush(Color.Red);
                g.FillEllipse(brush, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
                g.DrawString(string.Format("{0}", myNum), font, brush1, X - 15, Y - 15);
                brush.Dispose();
            }
        }
    }
}
