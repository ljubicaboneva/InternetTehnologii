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

namespace Polygons
{
    public partial class Form1 : Form
    {
        PolygonDoc doc;
        Point start;
        Point end;
        Polygon p;
        Point START;
        String FileName;
        public bool closed;
        public Form1()
        {
            InitializeComponent();
            doc = new PolygonDoc();
            start = Point.Empty;
            end = Point.Empty;
           // points = new Point[50];
            this.DoubleBuffered = true;

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
           
            if (e.Button == MouseButtons.Left)
            {

                if (start == Point.Empty)
                {
                    start = e.Location;
                    p = new Polygon(Color.Black);
                    START = new Point(e.Location.X, e.Location.Y);
                    p.AddPoints(start);
                }
                else if (start != Point.Empty)
                {
                    p.AddPoints(e.Location);
                    end = e.Location;
                    start = e.Location;
                }
                if (closed)
                {
                    p.Closed = true;
                    START = Point.Empty;
                    start = Point.Empty;
                    
                        doc.Add(p);
                    
                    closed = false;

                }
            }
            Invalidate(true);
           
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen pen = new Pen(Color.Black, 1);
            pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
            
            if (p != null)
            {
                p.Draw(e.Graphics);
            }
            doc.Draw(e.Graphics);
            
            if (!START.IsEmpty && !end.IsEmpty) //Za da se vlechat liniite
            {
                e.Graphics.DrawLine(pen, start, end); 
            }
            if (closed && !START.IsEmpty) //za kocka
            {
                e.Graphics.DrawRectangle(pen, START.X - 5, START.Y - 5, 10, 10);
            }


        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!START.IsEmpty)
            {
                closed = doc.distance(START, e.Location) <= 5;
                
            }
           
            end = e.Location;
            Invalidate(true);
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Left)
            {
                doc.Move(-5, 0);
            }
            else if (e.KeyCode == Keys.Right)
            {
                doc.Move(5, 0);
            }
            else if (e.KeyCode == Keys.Down)
            {
                doc.Move(0, 5);
            }
            else if (e.KeyCode == Keys.Up)
            {
                doc.Move(0, -5);
            }
            Invalidate(true);
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

        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            doc = new PolygonDoc();
            start = Point.Empty;
            end = Point.Empty;
            p = null;
            Invalidate(true);
            
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            doc = new PolygonDoc();
            start = Point.Empty;
            end = Point.Empty;
            p = null;
            Invalidate(true);
        }
        public void Save()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Polygon doc file (*.pol) | *.pol";
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
            openFileDialog.Filter = "Polygon doc file (*.pol) | *.pol";
            openFileDialog.Title = "OpenFile";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {

                FileName = openFileDialog.FileName;
                try
                {

                    using (FileStream filestream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        doc = (PolygonDoc)formatter.Deserialize(filestream);
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

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Polygons: {0} -> {1}, {2}",doc.polygons.Count,end.X,end.Y);
        }
        private void ask()
        {
            DialogResult result = MessageBox.Show("Save?", "Save?", MessageBoxButtons.YesNo);
            if (result == DialogResult.Yes)
            {
                Save();
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            ask();
        }
    }
}
