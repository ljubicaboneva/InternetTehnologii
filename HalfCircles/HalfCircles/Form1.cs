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

namespace HalfCircles
{
    public partial class Form1 : Form
    {
        CirclesDoc doc;
        Timer timer;
        private string FileName;

        public Form1()
        {
            InitializeComponent();
            doc = new CirclesDoc();
            this.DoubleBuffered = true;
            timer = new Timer();
            timer.Interval = 100;
            timer.Tick += new EventHandler(timer_Tick);

        }
        void timer_Tick(object sender, EventArgs e)
        {
            doc.Change();
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            doc.Draw(e.Graphics);
        }

        private void Form1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                doc.Add(e.Location);
                Invalidate(true);
            }

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog color = new ColorDialog();
            DialogResult result = color.ShowDialog();
            if (result == DialogResult.OK)
            {
                doc.CurrentColor1 = color.Color;
                int r = doc.CurrentColor1.R;
                int g = doc.CurrentColor1.G;
                int b = doc.CurrentColor1.B;
               
                doc.CurrentColor2 = Color.FromArgb(255-r,255-g ,255-b);
                
            }
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (Start.Text == "Старт")
            {
                timer.Start();
                Start.Text = "Стоп";
            }
            else
            if (Start.Text == "Стоп")
            {
                timer.Stop();
                Start.Text = "Старт";
            }
            Invalidate();
        }

        private void statusStrip1_Paint(object sender, PaintEventArgs e)
        {
            toolStripStatusLabel1.Text = string.Format("Total:{0}", doc.circles.Count);
        }
        public void Save()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFileDialog = new SaveFileDialog();
                saveFileDialog.Filter = "Cicles doc file (*.plc) | *.plc";
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
                        doc = (CirclesDoc)formatter.Deserialize(filestream);
                    }
                }catch (Exception e)
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
    }
}
