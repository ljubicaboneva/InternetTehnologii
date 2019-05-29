using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShootingBalls
{
    public class BallDoc
    {
        public List<Ball> balls { get; set; }
        public int poeni;
        public Color CurrentColor;
        Random random;
        Ball blackball;
        Ball ball;
        
        public BallDoc()
        {
            balls = new List<Ball>();
            random = new Random();
            
            poeni = 0;
        }
        public void Add(int width, int height)
        {
            ball = new Ball(width, height, random);
            
            bool touch = false;
            foreach (Ball b in balls)
            {
                if (b.Touch(ball))
                {
                    touch = true;
                }
            }
            if (touch)
            {
                Add(width,height);
            }
            else
            {
                balls.Add(ball);
            }
        }
        public void AddBlack(int x,int y)
        {
            blackball = new Ball(x,y);
           
            foreach (Ball b in balls)
            {
                if (b.Touch(blackball))
                {
                    b.flag = 1;
                }
                
            }
            balls.Add(blackball);

        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void Resize()
        {
            for (int i=balls.Count-1; i >= 0; --i)
            {
                if (balls[i].Radius > 10)
                {
                    
                        if (balls[i].ColorNum <= 2)
                        {
                        if (balls[i].ColorNum != 3)
                        {
                            balls[i].Radius -= 10;
                            
                            balls[i].ColorNum++;
                        }
                        else
                        {
                            balls.RemoveAt(i);
                        }
                        }
                        else
                        {
                        if (balls[i].ColorNum != 3)
                        {
                            balls[i].Radius -= 10;
                        
                            balls[i].ColorNum=0;
                        }
                        else
                        {
                            balls.RemoveAt(i);
                        }
                    }
                    }
                
                else 
                {
                    
                    balls.RemoveAt(i);
                }
                
            }
        }
        public void Hit(int x,int y)
        {
            for (int i = balls.Count - 1; i >= 0; --i)
            {
                balls[i].Hit(x, y);
          }
        }
        public void Delete()
        {
            for (int i = balls.Count - 1; i >= 0; --i)
            {
                if (balls[i].Selected)
                {
                    poeni += balls[i].Poeni;
                    balls.RemoveAt(i);
                }
            }
        }
        public void HitBlack()
        {

            for (int i = balls.Count - 1; i >= 0; --i)
            {
               
                if (balls[i].flag == 1)
                {
                    poeni += balls[i].Poeni;
                    balls.RemoveAt(i);
                }

            }
        }


    }
}
