using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonsterBall
{
    public class BallsDoc
    {
        public List<Ball> balls { get; set; }
        public Color CurrentColor { get; set; }
        
        public BallsDoc()
        {
            balls = new List<Ball>();
            CurrentColor = Color.Red;

        }
        public void Add(Point p)
        {
            Ball ball = new Ball(p, CurrentColor);
            balls.Add(ball);
        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void MoveBalls(int left, int top, int width, int height)
        {
            foreach (Ball ball in balls)
            {
                ball.Move(left, top, width, height);
            }
        }
        public void Colisions()
        {
            for (int i = 0; i < balls.Count; ++i)
            {
                for (int j = i + 1; j < balls.Count; ++j)
                {
                    if (balls[i].Distance(balls[j]))
                    {
                        if (balls[i].Radius > balls[j].Radius)
                        {
                            balls[i].Number += 1;
                            balls[j].Number -= 1;
                        }
                        else if (balls[i].Radius < balls[j].Radius)
                        {
                            balls[i].Number -= 1;
                            balls[j].Number += 1;

                        }
                      
                    }
                }
            }
            for (int i = balls.Count - 1; i >= 0; i--)
            {
                if (balls[i].Number < 0)
                {
                    balls.RemoveAt(i);
                }
            }
        }
    }
}
