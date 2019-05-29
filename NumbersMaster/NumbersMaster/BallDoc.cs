using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumbersMaster
{
    public class BallDoc
    {
        public List<Ball> balls { get; set; }
        public int miss;
        public int hits;
        public BallDoc()
        {
            balls = new List<Ball>();
            miss = 0;
            hits = 0;
        }
        public void Add(int w,int h)
        {
            Ball ball = new Ball(w,h);
            balls.Add(ball);
        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void Delete()
        {
            for(int i = balls.Count-1; i >= 0; --i)
            {
                if(balls[i].myTime >= 2)
                {
                    balls.RemoveAt(i);
                    miss++;
                }
            }
            for (int i = balls.Count - 1; i >= 0; --i)
            {
                if (balls[i].Hit)
                {
                    balls.RemoveAt(i);
                    hits++;
                }
            }

        }
    }
}
