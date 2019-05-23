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

namespace TickingPies
{
    public partial class Form1 : Form
    {
        CircleDoc doc;
        Timer timer;
        string FileName;
        public Form1()
        {
            InitializeComponent();
            doc = new CircleDoc();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 1000;
            timer.Tick += new EventHandler(timer_Tick);
            
        }

        void timer_Tick(object sender, EventArgs e)
        {
            doc.Smaller();
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
                doc.Add(e.Location);
                Invalidate(true);
            }
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            lbl1.Text = string.Format("{0}", doc.circles.Count);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            if(toolStripButton1.Text == "Start")
            {
                timer.Start();
                toolStripButton1.Text = "Stop";
            }
            else
            {
                timer.Stop();
                toolStripButton1.Text = "Start";
            }
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

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new CircleDoc();
            Invalidate();
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
                        doc = (CircleDoc)formatter.Deserialize(filestream);
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
    }
}
