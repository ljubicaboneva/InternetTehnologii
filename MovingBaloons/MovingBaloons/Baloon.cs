using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBaloons
{
    [Serializable]
    public class Baloon
    {
       
        public Point  Center { get; set; }
        public Color Color { get; set; }
        public static int Radius = 25;
        public bool IsSelect;
        public int flag;
        public int SelectCount;
        public Baloon(Point center, Color color)
        {
           
            Center = center;
            Color = color;
            IsSelect = false;
            flag = 1;
            SelectCount = 0;
        }
        public void Draw(Graphics g)
        {
            Brush b = new SolidBrush(Color);
            g.FillEllipse(b, Center.X - Radius, Center.Y - Radius, 2 * Radius, 2 * Radius);
            b.Dispose();
        }
        //public void MoveDown()
        //{
        //Center = new Point(Center.X,Center.Y + 10);
        //}
        //public void MoveUp()
        //{
        //    Center = new Point(Center.X, Center.Y - 10);
        //}
        public void Move()
        {
            if (flag==1)
            {
                Center = new Point(Center.X, Center.Y + 10);
            }
            else
            {
                Center = new Point(Center.X, Center.Y - 10);
            }
        }

        public bool IsHit(Point p)
        {
            return (((Center.X-p.X)* (Center.X - p.X)+(Center.Y -p.Y)* (Center.Y - p.Y))<=Radius*Radius);
        }
    }
}
