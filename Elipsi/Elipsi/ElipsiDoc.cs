using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Elipsi
{
   public  class ElipsiDoc
    {
        public List<Elipsa> elipsi { get; set; }
        public Color CurrentColor { get; set; }
        Random random;
        int R,G,B;
        
        public ElipsiDoc()
        {
            elipsi = new List<Elipsa>();
           
           
        }
        public void RandomColor()
        {
            random = new Random();
            R = random.Next(0, 256);
            G = random.Next(0, 256);
            B = random.Next(0, 256);
            CurrentColor = Color.FromArgb(R, G, B);

        }
        public void Add(Point p,int w,int h)
        {
            RandomColor();
            Elipsa elipsa = new Elipsa(p, w, h, CurrentColor);
            elipsi.Add(elipsa);
        }
        public void Draw(Graphics g)
        {
            foreach(Elipsa e in elipsi)
            {
                e.Draw(g);
            }
        }
     

    }
}
