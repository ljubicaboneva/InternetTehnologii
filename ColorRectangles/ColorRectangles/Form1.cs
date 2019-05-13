using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ColorRectangles
{
    public partial class Form1 : Form
    {
        Rectangle rec;
        Point start;
        Point end;
        int flag = 0;
        int flag1 = 0;
       
    
        RectanglesDoc rectanglesDoc;
        RectanglesDoc rectanglesDrawing;
       
        public Form1()
        {
            InitializeComponent();
           
            start = Point.Empty;
            end = Point.Empty;
            this.DoubleBuffered = true;
            rectanglesDoc = new RectanglesDoc();
            rectanglesDrawing = new RectanglesDoc();


        }

    
        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                if (start.IsEmpty)
                {
                    start = new Point(e.X, e.Y);
                }
                else
                {
                    flag = 1;
                    end = new Point(e.X, e.Y);
                   
                }
            }
            else if(e.Button == MouseButtons.Right)
            {
                foreach (Rectangle r in rectanglesDoc.rectangles)
                {

                    if (e.X >= r.pomoshX.X && e.X <= r.pomoshY.X && e.Y >= r.pomoshX.Y && e.Y <= r.pomoshY.Y)
                        r.Selectirana = !r.Selectirana;
                }
            }
            Invalidate(true);


        }
        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (!start.IsEmpty)
            {
                Point p = Point.Empty;
                p.X = e.X;
                p.Y = e.Y;
                rectanglesDrawing.AllRectangles(start, p);
                flag1 = 1;
                Invalidate(true);
            }
       }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
            if (flag==1)
            {
                rectanglesDoc.AddRectangle(start, end);
                start = Point.Empty;
                flag = 0;
                
            }
            else if(flag1==1)
            {
                rectanglesDrawing.MoveRectangles(e.Graphics);
                flag1 = 0;

            }
            for (int i = rectanglesDoc.rectangles.Count - 1; i >= 0; i--)
            {
              
                    if (rectanglesDoc.rectangles[i].Selectirana)
                    {
                        rectanglesDoc.rectangles[i].SelectedDraw(e.Graphics);
                    }
                
            }
           
            rectanglesDoc.DrawRectangles(e.Graphics);

        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            DialogResult result = colorDialog.ShowDialog();
            if(result==DialogResult.OK)
            {
                rectanglesDoc.color = colorDialog.Color;
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Delete)
            {
                try
                {
                    for(int i = rectanglesDoc.rectangles.Count-1; i>=0; i--)
                    {
                        if (rectanglesDoc.rectangles[i].Selectirana)
                        {
                            rectanglesDoc.rectangles.RemoveAt(i);
                        }
                    }
                }
                catch (Exception e1)
                {

                }
                Invalidate();
            }
        }
    }
}
