using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LettersMaster
{
    public class BallsDoc
    {
        public List<Ball> balls { get; set; }
        Random random;
        public int miss = 0;
        public int hit = 0;
        public int[] charsGenerate;
        public BallsDoc()
        {
            balls = new List<Ball>();
            random = new Random();
            charsGenerate = new int[26];
        }
        public void Add()
        {
            Ball ball = new Ball(random);
            charsGenerate[ball.Char - 'A']++;
            balls.Add(ball);
        }
        public void Draw(Graphics g)
        {
            foreach(Ball b in balls)
            {
                b.Draw(g);
            }
        }
        public void Move(int h)
        {
            foreach (Ball b in balls)
            {
                b.Move();
            }
            for(int i = balls.Count-1; i>=0; --i)
            {
                if (balls[i].Delete(h))
                {
                    if (!balls[i].Hit)
                    {
                        miss++;
                    }
                    balls.RemoveAt(i);
                }
            }
        }
        

    }
}
