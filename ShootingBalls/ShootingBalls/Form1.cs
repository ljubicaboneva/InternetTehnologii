using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShootingBalls
{
    public partial class Form1 : Form
    {
        BallDoc doc;
        Timer timer;
        Timer timer1;
        public Form1()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            doc = new BallDoc();
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
            timer1 = new Timer();
            timer1.Interval = 500;
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Start();
        }

        void timer_tick(object sender, EventArgs e)
        {
            doc.Add(this.Width, this.Height);
            
            Invalidate(true);
        }
        void timer1_tick(object sender, EventArgs e)
        {
            doc.Resize();
            doc.Delete();
            Invalidate(true);
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
          
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                doc.Hit(e.Location.X, e.Location.Y);
            }
            else if(e.Button == MouseButtons.Right)
            {
                doc.AddBlack(e.Location.X, e.Location.Y);
                doc.HitBlack();
               
            }
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("{0}", doc.poeni);
        }
    }
}
