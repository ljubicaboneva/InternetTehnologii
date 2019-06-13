using BricksBallCrusher.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BricksBallCrusher
{

    public partial class Form1 : Form
    {
        Ball ball;
        Rectangle rectangle;
        Game game;
        int leftX;
        int topY;
        int width;
        int height;
        int isMoved;
        Timer timer;
        Timer timer1;
        int Misses;
        


        public Form1()
        {
            InitializeComponent();

            this.DoubleBuffered = true;
            rectangle = new Rectangle(this.Width / 2-40, this.Height - 110);
            ball = new Ball(new Point(this.Width/2,this.Height-120));
            game = new Game();
            

            leftX = 20;
            topY = 40;
            width = this.Width - 3 * leftX;
            height = this.Height - (int)(2.5 * topY);
            Misses = 3;

            timer = new Timer();
            timer.Interval = 19;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();

            timer1 = new Timer();
            timer1.Interval = 1;
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Start();



        }
        void timer_tick(object sender, EventArgs e)
        {
            if (isMoved == 1)
            {
                ball.Move(leftX, topY, width, height);
                NewGame();
                rectangle.Rejected(ball);
            }
            Invalidate(true);
        }

        void timer1_tick(object sender, EventArgs e)
        {
                Touched();
                game.Delete();
               // game.Bomb();
                Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            Pen pen = new Pen(Color.White, 2);
            e.Graphics.DrawRectangle(pen, leftX, topY, width, height);
            pen.Dispose();
            ball.Draw(e.Graphics);
            rectangle.Draw(e.Graphics);
            game.Add();
            game.Draw(e.Graphics);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                rectangle.Move(leftX, width ,- 10);
                isMoved = 1;
            }
            else if (e.KeyCode == Keys.Right)
            {
                rectangle.Move(leftX,width,10);
                isMoved = 1;
            }
           
            Invalidate(true);
        }
        void NewGame()
        {
            if (ball.isNewGame)
            {
                
                if (Misses > 1)
                {
                    ball = new Ball(new Point(this.Width / 2, this.Height - 120));
                    rectangle = new Rectangle(this.Width / 2 - 40, this.Height - 110);
                    isMoved = 0;
                    Misses--;
                }
                else
                {
                    timer.Stop();
                    DialogResult result = MessageBox.Show("Do you want to play again?", "GAME OVER", MessageBoxButtons.RetryCancel);
                    if(result == DialogResult.Retry)
                    {
                        ball = new Ball(new Point(this.Width / 2, this.Height - 120));
                        rectangle = new Rectangle(this.Width / 2 - 40, this.Height - 110);
                        game.Add();
                        timer.Start();
                        Misses = 3;
                        isMoved = 0;
                        ball.isNewGame = false;
                        game.flag = 0;
                        game.ShowImage = true;
                        game.random = new Random();
                    }
                }
            }
            lblLivesLeft.Text = Misses.ToString();
        }
        public void Touched()
        {
            foreach(Brick b in game.Bricks)
            {
                b.Select(ball);
            }
        }
       
    }
}
