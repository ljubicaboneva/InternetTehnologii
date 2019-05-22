using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FlyingBalls
{
    [Serializable]
    public class BallDoc
    {
        public List <Ball> balls { get; set; }
        public  Color CurrentColor { get; set; }
        public int miss = 0;
        Random random;
        int r;
        
        public BallDoc()
        {
            balls = new List<Ball>();
            
        }
        public void Add(int x,int y)
        {
            random = new Random();
           
            r = random.Next(0, 3);
            if (r == 0)
            {
                CurrentColor= Color.Red;
            }
            else if (r == 1)
            {
                CurrentColor= Color.Green;
            }
            else
            {
                CurrentColor= Color.Blue;
            }
            Ball ball = new Ball(x, y, CurrentColor);
            ball.broj = r;
            balls.Add(ball);
        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {

                b.Draw(g);
            }
        }
        
        public void Move(int width)
        {
            for(int i = balls.Count-1; i>=0; --i)
            {
                balls[i].Move();
                if (balls[i].X > width)
                {
                    balls.RemoveAt(i);
                    miss++;
                }
                
            }
        }
      
    }
}
