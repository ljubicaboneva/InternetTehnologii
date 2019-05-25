using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FDraw
{
    public partial class Form1 : Form
    {
        Scene scene;
        Point start;
        Point end;
        Point tmp;
       
       
        public Form1()
        {
            InitializeComponent();
            scene = new Scene();
            start = Point.Empty;
            end = Point.Empty;
            
            this.DoubleBuffered = true;
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

            foreach (Rectangle r in scene.rectangles)
            {
                if (r.Selected(e.Location))
                {
                    r.IsSelect = true;
                    scene.flag = 1;
                }
                r.IsSelect = false;
            }
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            scene.Draw(e.Graphics);
            if (scene.start != Point.Empty )
            {
                Pen pen = new Pen(Color.Black);
                pen.DashStyle = System.Drawing.Drawing2D.DashStyle.Dash;
                e.Graphics.DrawRectangle(pen, scene.x, scene.y, scene.width, scene.height);
                pen.Dispose();
                
                
            }
            foreach(Rectangle r in scene.rectangles)
            {
                if (r.IsSelect)
                {
                    Brush b = new SolidBrush(Color.Black);
                    e.Graphics.FillRectangle(b, r.Start.X, r.Start.Y, r.Width+5, r.Height+5);
                    b.Dispose();
                }
            }
            

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            //scene.Move(e.Location);
            if (!scene.start.IsEmpty)
            {
                scene.ChangeParametars();
            }
            scene.end = e.Location;
            Invalidate(true);
        }
        
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
           
           // tmp = e.Location;
            scene.Click(e.Location);
            Invalidate(true);
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            scene.Up(e.Location);
            scene.start = Point.Empty;
            Invalidate(true);
        }
    }
}
