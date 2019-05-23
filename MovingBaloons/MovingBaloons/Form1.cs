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

namespace MovingBaloons
{
    public partial class Form1 : Form
    {
        BaloonsDoc doc;
        Point p;
        private int x = 25;
        Timer timer;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            doc = new BaloonsDoc();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }
        void timer_tick(object sender, EventArgs e)
        {
            doc.Move(this.Height);
            Invalidate(true);
        }
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            doc.Hit(e.Location);
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        { 
                p = new Point(x, this.Height / 2);
                doc.Add(p);
                Invalidate(true);
                x += 75;
       }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Ballons: {0}", doc.baloons.Count);
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            DialogResult result = color.ShowDialog();
            if(result == DialogResult.OK)
            {
                doc.CurrentColor = color.Color;
            }
        }
        public void Save()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Baloons doc file (*.bal) | *.bal";
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
        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Baloons doc file (*.bal) | *.bal";
            openFileDialog.Title = "OpenFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                FileName = openFileDialog.FileName;
                try
                {

                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        doc = (BaloonsDoc)formatter.Deserialize(filestream);
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

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new BaloonsDoc();
            x = 25;
            
        }
    }
}
