using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LettersMaster
{
    public partial class Form1 : Form
    {
        BallsDoc doc;
        Timer timer;
        Timer timer2;
        public string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
        public Form1()
        {
            InitializeComponent();
            doc = new BallsDoc();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            timer2 = new Timer();
            timer2.Interval = 100;
            timer2.Tick += new EventHandler(timer2_Tick);
            timer.Start();
            timer2.Start();
        }
        void timer_Tick(object o, EventArgs e)
        {
            doc.Add();
            Invalidate();
        }
        void timer2_Tick(object o, EventArgs e)
        {
           
            doc.Move(this.Height);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            
            doc.Draw(e.Graphics);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            StringBuilder tekst = new StringBuilder();
            toolStripStatusLabel1.Text = string.Format("Miss: {0}", doc.miss);
            for(int i = 0; i < chars.Length; i++)
            {
                tekst.Append(chars[i] + ":" + doc.charsGenerate[i]+ " "); 
            }
            toolStripStatusLabel3.Text = string.Format("Letters : {0}", tekst);
            toolStripStatusLabel2.Text = string.Format("Hits: {0}", doc.hit);
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            KeysConverter kc = new KeysConverter();

            foreach (Ball b in doc.balls)
            {

                if (Char.ToLower(b.Char) == (e.KeyChar))
                {
                    doc.hit++;
                    b.Hit = true;
                    Invalidate(true);
                    break; //samo edna vo moment da se brishe ako ima poveke isti bukvi;

                }
            }
            


        }
    }
}
