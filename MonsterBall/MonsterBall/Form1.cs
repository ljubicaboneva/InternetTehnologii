using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MonsterBall
{
    public partial class Form1 : Form
    {
        BallsDoc doc;
        Timer timer;
        int leftX;
        int topY;
        int width;
        int height;
        public Form1()
        {
            InitializeComponent();
            doc = new BallsDoc();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 50;
            timer.Tick += new EventHandler(timer_Tick);
            timer.Start();
            leftX = 20;
            topY = 60;
            width = this.Width - 3*leftX;
            height = this.Height - (int)(2 * topY);
        }
        void timer_Tick(object sender, EventArgs e)
        {
            doc.MoveBalls(leftX, topY, width, height);
            doc.Colisions();
            foreach(Ball b in doc.balls)
            {
                if(b.Number > 5)
                {
                    b.Color = Color.Blue;
                }
                if(b.Number > 10)
                {
                    b.Color = Color.Black;
                }
            }
            Invalidate(true);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            doc.Add(e.Location);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
            Pen pen = new Pen(Color.Black, 2);
            e.Graphics.DrawRectangle(pen, 20, 60, width+10, height);
            pen.Dispose();

        }
    }
}
