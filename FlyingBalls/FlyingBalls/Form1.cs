using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FlyingBalls
{
    public partial class Form1 : Form
    {
        BallDoc doc;
        Timer timer;
        int r = 0;
        Random random;
        int tmp = 0;
        int hitts = 0;
        string FileName;

        public Form1()
        {
            InitializeComponent();
            doc = new BallDoc();
            random = new Random();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);
           
        }
         void timer_Tick(object sender, EventArgs e)
        {
                GenereteBalls();
                
                Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
        }
        public void GenereteBalls()
        {
            if (tmp % 5 == 0)
            {
                r = random.Next(0, this.Height - 30);
                doc.Add(0, r);
            }
            tmp++;
            doc.Move(this.Width);

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           for(int i = doc.balls.Count-1; i>=0; --i)
            {
                if (doc.balls[i].Selected(e.Location.X, e.Location.Y))
                {
                    if(doc.balls[i].broj == 0)
                    {
                        doc.balls[i].Color = Color.Green;
                        doc.balls[i].broj = 1;
                    }
                    else if (doc.balls[i].broj == 1)
                    {
                        doc.balls[i].Color = Color.Blue;
                        doc.balls[i].broj = 2;
                    }
                    else
                    {
                        doc.balls.RemoveAt(i);
                        hitts++;
                    }
                }
            }
            Invalidate(true);
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Hitts: {0} | Miss: {1}", hitts,doc.miss);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if (toolStripButton1.Text == "Start")
            {
                timer.Start();
                toolStripButton1.Text = "Stop";
            }
            else
            {
                timer.Stop();
                toolStripButton1.Text = "Start";
            }
            Invalidate();

        }
        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Cicles doc file (*.plc) | *.plc";
            openFileDialog.Title = "OpenFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                FileName = openFileDialog.FileName;
                try
                {

                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        doc = (BallDoc)formatter.Deserialize(filestream);
                    }
                }
                catch (Exception e)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }

        }

        public void Save()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Cicles doc file (*.plc) | *.plc";
                saveFileDialog.Title = "SaveFile";
                saveFileDialog.FileName = FileName;

                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFileDialog.FileName;
                }
            }
            if (FileName != null)
            {
                using (FileStream filestream = new FileStream(FileName, FileMode.Create))
                {
                    IFormatter formatter = new BinaryFormatter();
                    formatter.Serialize(filestream, doc);
                }
            }
            //FileName = null; da zachuvuva odnovo
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new BallDoc();
            Invalidate(true);
        }
    }
}
