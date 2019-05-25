using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    public class Ball
    {
        public static int Radius = 30;
        public Color color = Color.LightGreen;
        public int X { get; set; }
        public int Y { get; set; }
        public char Char { get; set; }
        public string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public bool Hit { get; set; }
        
        Font font = new Font("Arial", 24);
        public Ball(Random random)
        {
            X = random.Next(Radius, 840 - (2 * Radius));
            Y = random.Next(Radius);
            Char = chars[random.Next(0, 26)];
            Hit = false;
        }
        public void Draw(Graphics g)
        {
            if (!Hit)
            {
                Brush b1 = new SolidBrush(color);
                Brush b2 = new SolidBrush(Color.Black);
                g.FillEllipse(b1, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
                g.DrawString(string.Format("{0}", Char), font, b2, X - 15, Y - 15);
            }
            else
            {
                Brush b1 = new SolidBrush(Color.Red);
                g.FillEllipse(b1, X - Radius, Y - Radius, 2 * Radius, 2 * Radius);
            }
        }
        public void Move()
        {
            Y += 10;
        }
        public bool Delete(int height)
        {
            if (Y > height - 30)
            {
                return true;
            }
            if (Hit)
            {
                return true;
            }
            return false;
        }
    }
}
