using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SlidingBalls
{
    [Serializable]
    public class BallsDoc
    {
        public List<Ball> balls { get; set; }
        public Color CurrentColor { get; set; }
        Random random;
        public int r;
        public int flag = 0;
        public int flag1 = 0;

        public BallsDoc()
        {
            balls = new List<Ball>();

        }
        public void Add(int x, int y)
        {
            random = new Random();
            r = random.Next(0, 2);
            if (r == 0)
            {
                CurrentColor = Color.Green;
            }
            else
            {
                CurrentColor = Color.Blue;
            }
            if (flag == 1)
            {
                CurrentColor = Color.Red;

            }
            Ball ball = new Ball(x, y, CurrentColor);
            ball.ColorNumer = r;
            if (flag == 1)
            {
                ball.ColorNumer = 2;
            }
            balls.Add(ball);



        }
        public void Draw(Graphics g)
        {
            foreach (Ball b in balls)
            {
                b.Draw(g);
            }
        }

        public void Move(int w, int h)
        {

            for (int i = balls.Count - 1; i >= 0; --i)
            {
                if (balls[i].ColorNumer == 2)
                {
                    if (balls[i].IsSelect)
                    {
                        balls[i].Move();

                        if (balls[i].X > w || balls[i].X < 0)
                        {
                            balls.RemoveAt(i);

                            flag1 = 0;
                        }
                        else if (balls[i].Y > h || balls[i].Y < 0)
                        {
                            balls.RemoveAt(i);

                            flag1 = 0;
                        }


                    }

                }
            }
        }
        public void Colision()
        {
            for (int i = balls.Count - 1; i >= 0; --i)
            {

                try
                {
                    if (balls[i].ColorNumer == 2)
                    {
                        if (balls[i].IsSelect)
                        {
                            for (int j = balls.Count - 1; j >= 0; --j)
                            {
                                if (balls[j].ColorNumer == 0)
                                {
                                    if ((balls[i].X - balls[j].X) * (balls[i].X - balls[j].X) + (balls[i].Y - balls[j].Y) * (balls[i].Y - balls[j].Y) <= (2 * 30) * (2 * 30))
                                    {
                                        balls.RemoveAt(j);

                                    }
                                }
                            }
                        }
                    }
                }
                catch (Exception Ex)
                {
                    MessageBox.Show("Opaaa");
                }
            }
        }

    }
}


