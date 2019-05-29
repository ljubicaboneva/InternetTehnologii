using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NumbersMaster
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
            timer.Interval = 1500;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
            timer1 = new Timer();
            timer1.Interval = 100;
            timer1.Tick += new EventHandler(timer1_tick);
            timer1.Start();


        }
        void timer_tick(object sender, EventArgs e)
        {

            foreach (Ball b in doc.balls)
            {
                b.myTime++;
            }
            
            doc.Add(this.Width, this.Height);
            Invalidate(true);
        }
        void timer1_tick(object sender, EventArgs e)
        {
            doc.Delete();
           
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            foreach (Ball b in doc.balls)
            {

                if (b.myNum == e.KeyChar - (int)'0')
                {
                   
                    b.Hit = true;
                    Invalidate(true);
                    break; //samo edna vo moment da se brishe ako ima poveke isti bukvi;

                }
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Miss: {0}, Hits: {1}",doc.miss,doc.hits);
        }
    }
}
