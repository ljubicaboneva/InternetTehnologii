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

namespace Serialization
{
    public partial class Form1 : Form
    {
        Scene scene;
        public string FileName;

        public Form1()
        {
            InitializeComponent();

            scene = new Scene();

            this.DoubleBuffered = true;
        }



        private void Form1_Paint(object sender, PaintEventArgs e)
        {

            e.Graphics.Clear(Color.Aqua);
            scene.Draw(e.Graphics);
        }



        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            scene.AddCircle(e.Location);
            Invalidate();

        }

        private void pickColor(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if (result == DialogResult.OK)
            {
                scene.CurrentColor = colorDialog.Color;
            }
        }

        private void saveFile()
        {
            if (FileName == null)
            {
                SaveFileDialog saveFile = new SaveFileDialog();
                if (saveFile.ShowDialog() == DialogResult.OK)
                {
                    FileName = saveFile.FileName;
                }
            }
            if (FileName != null)
            {
                FileStream fileStream = new FileStream(FileName, FileMode.Create);
                IFormatter formatter = new BinaryFormatter();
                formatter.Serialize(fileStream, scene);
            }
        }

        private void saveFile(object sender, EventArgs e)
        {
            saveFile();
            
        }
        private void openFile()
        {
            OpenFileDialog openFile = new OpenFileDialog();
            if (openFile.ShowDialog() == DialogResult.OK)
            {
                FileName = openFile.FileName;
                try
                {
                    FileStream fileStream = new FileStream(FileName, FileMode.Open);

                    IFormatter formater = new BinaryFormatter();
                    scene = (Scene)formater.Deserialize(fileStream);
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
        private void openFile(object sender, EventArgs e)
        {
            openFile();
        }
    }
}
