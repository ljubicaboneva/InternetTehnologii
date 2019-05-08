using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace Pacman
{
    class Pacman
    {
        public float X { get; set; }
        public float Y { get; set; }
        public enum PRAVEC { Gore,Dole,Levo,Desno }
        public PRAVEC Pravec { get; set; }
        public static int Radius = 20;
        public int Brzina { get; set; }
        public bool Usta { get; set; }

        public Brush Chetka  { get; set; }

        public Pacman() {
            X = 0;
            Y = 0;
            Pravec = PRAVEC.Desno;
            Brzina = Radius;
            Usta = false;
            Chetka = new SolidBrush(Color.Yellow);

        }
        public void ChangeDirection(PRAVEC pravec)
        {
            Pravec = pravec;
        }
        public void Move(int width,int height)
        {
            if (Pravec == PRAVEC.Desno)
            {
                if (X > width)
                {
                    X = 0;
                }
                else
                {
                    X += 2 * Radius;
                }
                
             }
            else if (Pravec == PRAVEC.Levo)
            { 
                if (X < 0)
                {
                    X = width;
                }
                else
                {
                    X -= 2*Radius;
                }
               
            }
            else if (Pravec == PRAVEC.Gore)
            {
               if (Y < 0)
                {
                    Y = height;
                }
                else
                {
                    Y -= 2 * Radius;
                }
                
            }
            else if (Pravec == PRAVEC.Dole)
            {
                if (Y > height)
                {
                    Y= 0;
                }
                else
                {
                    Y += 2 * Radius;
                }
               

            }
            if (Usta == false)
            {
                Usta = true;
            }
            else
            {
                Usta = false;
            }
            
        }

        public void Draw(Graphics g)
        {
            if (Usta)
            {
                if (Pravec == PRAVEC.Desno)
                {
                    g.FillPie(Chetka, X, Y, 2 * Radius, 2 * Radius,45,270);
                }
                else if(Pravec == PRAVEC.Levo)
                {
                    g.FillPie(Chetka, X, Y, 2 * Radius, 2 * Radius,225,270);
                }
                else if (Pravec == PRAVEC.Gore)
                {
                    g.FillPie(Chetka, X, Y, 2 * Radius, 2 * Radius,315,270);
                }
                else if (Pravec == PRAVEC.Dole)
                {
                    g.FillPie(Chetka, X, Y, 2 * Radius, 2 * Radius,135,270);
                }
            }
            else
            {
                g.FillEllipse(Chetka, X, Y, 2 * Radius, 2 * Radius);
            }
        }

    }
}
