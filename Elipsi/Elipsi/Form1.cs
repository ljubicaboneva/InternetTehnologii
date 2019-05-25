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

namespace Elipsi
{
    public partial class Form1 : Form
    {
        ElipsiDoc doc;
        Point start;
        Point end;
        Elipsa elipsa;
        int width,height,x,y,r,g,b,tmp;
        string FileName;

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("{0}", doc.elipsi.Count);
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open();
        }
        public void Save()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Circle doc file (*.cir) | *.cir";
                saveFileDialog.Title = "SaveFile";


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
        }
        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Circle doc file (*.cir) | *.cir";
            openFileDialog.Title = "OpenFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                FileName = openFileDialog.FileName;
                try
                {

                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        doc = (ElipsiDoc)formatter.Deserialize(filestream);
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

        Timer timer;
        public Form1()
        {
            InitializeComponent();
            doc = new ElipsiDoc();
            this.DoubleBuffered = true;
            start = Point.Empty;
            end = Point.Empty;
            timer = new Timer();
            timer.Interval = 200;
            timer.Tick += new EventHandler(timer_tick);
            timer.Start();
        }
        void timer_tick(object sender, EventArgs e)
        {
            //doc.RandomColor();
            foreach(Elipsa i in doc.elipsi)
            {
                r = i.Color.R+5;
                g = i.Color.G+10;
                b = i.Color.B+15;
                if (r >= 256)
                {
                    tmp = r - 255;
                    r = 0 + tmp;
                }
                if (g >= 256)
                {
                    tmp = g - 255;
                    g = 0 + tmp;
                }
                if(b >= 256)
                {
                    tmp = b - 255;
                    b = 0 + tmp;
                }
                i.Color = Color.FromArgb(r, g, b);
            }
            Invalidate(true);
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
            if (!start.IsEmpty)
            {
                Pen pen = new Pen(Color.Black, 2);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawEllipse(pen, x,y, width, height);
                pen.Dispose();
            }
           
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (start.IsEmpty)
            {
                start = e.Location;
            }
            else  {

                doc.Add(new Point(x,y), width, height);
                start = Point.Empty;
                end = Point.Empty;
                }
            Invalidate(true);


        }
        //public void Distance(Point point1, Point point2)
        //{
        //    dijametar = (point1.X - point2.X) * (point1.X - point2.X) + (point1.Y - point2.Y) * (point1.Y - point2.Y);
        //}

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            end = e.Location;
            x = start.X;
            y = start.Y;
            if (x > end.X)
                x = end.X;
            if (y > end.Y)
                y = end.Y;
            width = Math.Abs(start.X - end.X);
            height = Math.Abs(start.Y - end.Y);
            Invalidate(true);
        }
    }
}
