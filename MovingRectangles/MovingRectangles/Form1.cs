using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MovingRectangles
{
    public partial class Form1 : Form
    {
        RectanglesDoc doc;
        int x=0;
        int y=0;
        public string FileName;
       
       
        
        public Form1()
        {
            InitializeComponent();
            doc = new RectanglesDoc();
            this.DoubleBuffered = true;
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Aqua);
            doc.Draw(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            x = e.Location.X;
            y = e.Location.Y;
            doc.AddRectangle(x, y);
            Invalidate();
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            Point p1;
            Point p2;

            foreach (Rectangle r in doc.rectangles)
            {
               
                    p1 = Point.Empty;
                    p2 = Point.Empty;
                    p1.X = r.X + 100;
                    p1.Y = r.Y + 50;
                    p2.X = e.Location.X;
                    p2.Y = e.Location.Y;
                    if (r.Selected(p1, p2))
                    {
                        r.IsSelected = true;
                    }
                
            }

            foreach (Rectangle r in doc.rectangles)
            {
               
                    if (e.Button == MouseButtons.Left)
                    {
                    if (r.IsSelected)
                    {
                        if (r.flag2 != 1)
                        {
                            r.direction = Direction.DOWN;
                            r.flag1 = 1;
                        }
                    }
                        
                    }
                    else if (e.Button == MouseButtons.Right)
                    {
                    if (r.IsSelected)
                    {
                        if (r.flag1 != 1)
                        {
                            r.direction = Direction.RIGHT;
                            r.flag2 = 1;
                        }
                    }
                       
                    }
            }
            Invalidate(true);
        }

        

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            DialogResult result = color.ShowDialog();
            if (result == DialogResult.OK)
            {
                doc.currentColor = color.Color;
            }
        }
    
        private void timer2_Tick(object sender, EventArgs e)
        {
                    doc.Delete(this.Width,this.Height);
                    doc.Move();
                
                    Invalidate(true);

        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("{0}", doc.rectangles.Count);
            
        }

        public void Save()
        {
            {
                if (FileName == null)
                {
                    SaveFileDialog saveFileDialog = new SaveFileDialog();
                    saveFileDialog.Filter = "Lines doc file (*.lin)|*.lin";
                    saveFileDialog.Title = "Save lines doc";
                    if (saveFileDialog.ShowDialog() == DialogResult.OK)
                    {
                        FileName = saveFileDialog.FileName;
                    }
                }
                if (FileName != null)
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Create))
                    {
                        IFormatter formatter = new BinaryFormatter();
                        formatter.Serialize(fileStream, doc);
                    }
                }
            }

        }
        public void Open()
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Scene file (*.lin)|*.lin";
            openFileDialog.Title = "Rectangles scene";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FileName = openFileDialog.FileName;
                try
                {
                    using (FileStream fileStream = new FileStream(FileName, FileMode.Open))
                    {
                        IFormatter formater = new BinaryFormatter();
                        doc = (RectanglesDoc)formater.Deserialize(fileStream);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Could not read file: " + FileName);
                    FileName = null;
                    return;
                }
                Invalidate(true);
            }

        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Open();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            Save();
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            Open(); 
        }
    }
}
