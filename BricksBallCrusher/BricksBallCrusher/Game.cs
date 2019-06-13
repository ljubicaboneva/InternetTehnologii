using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BricksBallCrusher
{
    public class Game
    {
        public List<Brick> Bricks { get; set; }
        public Color CurrentColor { get; set; }
        public int flag = 0;
        public bool ShowImage;
        public int flag1 = 0;
        
        public Random random=new Random();
        public int r;
        public int tmp = 0;
        public Game()
        {
            Bricks = new List<Brick>();
            ShowImage = true;
            
            //r = random.Next(1, 56);
             r=53;
        }
        public void Add()
        {
            int x = 42;
            int y = 60;
            
            while (flag < 5)
            {

                if (flag == 0)
                {
                    CurrentColor = Color.Blue;
                }
                else if (flag == 1)
                {
                    CurrentColor = Color.Aqua;
                }
                else if (flag == 2)
                {
                    CurrentColor = Color.Red;
                }
                else if (flag == 3)
                {
                    CurrentColor = Color.Yellow;
                }
                else if (flag == 4)
                {
                    CurrentColor = Color.Green;
                }

                for (int i = 0; i <= 10; i++)
                {
                    Brick brick = new Brick(x, y);
                    brick.Color = CurrentColor;
                    Bricks.Add(brick);
                    x += 65;
                }
                x = 42;
                y += 25;
                flag++;
            }
            

        }
        public void Draw(Graphics g)
        {
            for(int i = Bricks.Count-1; i>=0; --i)
            {
                if (i == r)
                {
                    if (ShowImage)
                    {
                        Bricks[i].DrawImage(g);
                    }
                    else if (!ShowImage)
                    {
                        Bricks[i].Draw(g);
                       
                    }
                }
                else
                {
                    Bricks[i].Draw(g);
                    
                }
            }
        }

        public void Delete()
        {
            for (int i = Bricks.Count - 1; i >= 0; --i)
            {
                if (Bricks[i].IsTouched)
                {
                    Bricks.RemoveAt(i);

                    if (r > i)
                    {
                        r--;
                    }
                    else if (r == i)
                    {

                        if (ShowImage)
                        {
                            if (i >= 0)
                            {
                                Bricks[i++].Color = Color.White;
                            }
                            if (i <= 54)
                            {
                                Bricks[i--].Color = Color.Orchid;
                            }
                            ShowImage = false;
                        }

                    }
                }
            }
        }
    }
}
