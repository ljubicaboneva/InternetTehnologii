using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovingBaloons
{
    [Serializable]
    public class BaloonsDoc
    {
        public List <Baloon> baloons { get; set; }
        public Color CurrentColor { get; set; }
        public BaloonsDoc()
        {
            baloons = new List<Baloon>();
            CurrentColor = Color.Blue;
        }
        public void Add(Point point)
        {
            Baloon baloon = new Baloon(point, CurrentColor);
            baloons.Add(baloon);
        }
       public void Draw(Graphics g)
        {
            foreach(Baloon b in baloons)
            {
                b.Draw(g);
            }
        }
        public void Hit(Point p)
        {
            foreach(Baloon b in baloons)
            {
                if (b.IsHit(p))
                {
                    b.IsSelect = true;
                    b.SelectCount++;
                }
            }
            
        }
        public void Move(int height)
        {
            foreach (Baloon b in baloons)
            {
                if (b.SelectCount == 1)
                {
                    if (b.IsSelect)
                    {
                        
                        b.Move();
                        if (b.Center.Y >= height - 75)
                        {
                            b.flag = 0;

                        }
                        else if (b.Center.Y <= 75)
                        {
                            b.flag = 1;
                        }
                    }
                }
                else
                {
                    b.IsSelect = !b.IsSelect;
                    b.SelectCount = 0;
                }
            }

        }
        //public void Move(int height)
        //{
        //   for(int i=baloons.Count-1; i>=0; --i)
        //    {
        //        if (baloons[i].IsSelect)
        //        {
        //            baloons[i].MoveDown();
        //            if (baloons[i].Center.Y >= height)
        //            {
        //                baloons[i].MoveUp();

        //            }
        //            else if (baloons[i].Center.Y <= 0)
        //            {
        //                baloons[i].MoveDown();
        //            }
        //        }

        //    }

        //}
    }
}

