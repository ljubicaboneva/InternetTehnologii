using Pacman.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Pacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIMER_INTERVAL = 250;
        static readonly int WORLD_WIDTH = 15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;

        string x = "0,40,200,240,320,320,520,520";
        string y = "40,0,240,40,240,80,240,240";
        string[] xx = new string[8];
        string[] yy = new string[8];

        int Poeni = 0;
        Brush brush = new SolidBrush(Color.Black);
        

        public Form1()
        {
            InitializeComponent();
            
            foodImage = Resources.ooooo;
            DoubleBuffered = true;
            

            newGame();
        }
       
        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.Radius * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.Radius * 2 * (WORLD_HEIGHT + 1);
            // овде кодот за иницијализација на матрицата foodWorld
            foodWorld = new bool[WORLD_HEIGHT][];
            for(int i = 0; i < WORLD_HEIGHT; i++)
            {
                foodWorld[i] = new bool[WORLD_WIDTH];
            }
            
            for(int i = 0; i < WORLD_HEIGHT; i++)
            {
                for(int j = 0; j < WORLD_WIDTH; j++)
                {
                    foodWorld[i][j] = true;
                }
            }

            timer = new Timer();
            timer.Interval = TIMER_INTERVAL;
            timer.Tick += timer_Tick;
            timer.Start();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }
        private void Form1_Paint(object sender, PaintEventArgs e)
        {
          
            //for (int i = 0; i < 8; i++)
            //{
            //    xx[i] = x.Split(',')[i];
            //    yy[i] =y.Split(',')[i];
            //}
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                   
                    
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Height) / 2, i * Pacman.Radius * 2 + (Pacman.Radius * 2 - foodImage.Width) / 2);
                    }
                }
            }
            g.FillRectangle(brush, 40, 40, 40, 120);
            g.FillRectangle(brush, 0, 240, 40, 120);
            g.FillRectangle(brush, 200, 0, 40, 120);
            g.FillRectangle(brush, 320, 40, 40, 120);
            g.FillRectangle(brush, 240, 240, 40, 120);
            g.FillRectangle(brush, 520, 80, 40, 120);
            g.FillRectangle(brush, 320, 200, 40, 120);
            g.FillRectangle(brush, 520, 240, 40, 120);
            pacman.Draw(g);
            if (Poeni == 149)
            {
                timer.Stop();
            }
        }
      

        private void timer_Tick(object sender, EventArgs e)
        {
            for(int i = 0; i < WORLD_HEIGHT; i++)
            {
                for(int j = 0; j< WORLD_WIDTH; j++)
                {
                    if (pacman.X == j*Pacman.Radius *2  && pacman.Y == i *Pacman.Radius*2)
                    {
                        
                        if (foodWorld[i][j] == true)
                        {
                            textBox1.Text = Poeni++.ToString();
                            PB1.PerformStep();
                            if (Poeni == 149)
                            {
                                DialogResult rez=MessageBox.Show("Nova igra?", "Kraj", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                                if (rez==DialogResult.No)
                                {
                                    this.Close();
                                }
                                else
                                {
                                    newGame();
                                    Poeni = 0;
                                    PB1.Value = 0;
                                    
                                }
                            }
                        }
                        foodWorld[i][j] = false;


                    }
                }
            }

            pacman.Move(this.Width, this.Height);
            Invalidate();
        }

        private void Form1_KeyUp_1(object sender, KeyEventArgs e)
        {
            // не заборавајте да го додадете настанот на самата форма
            // вашиот код овде
            Keys key = new Keys();
            if (e.KeyCode == Keys.Up)
            {
                pacman.ChangeDirection(Pacman.PRAVEC.Gore);
            }
            else if (e.KeyCode == Keys.Down)
            {
                pacman.ChangeDirection(Pacman.PRAVEC.Dole);
            }
            else if (e.KeyCode == Keys.Left)
            {
                pacman.ChangeDirection(Pacman.PRAVEC.Levo);
            }
            else if (e.KeyCode == Keys.Right)
            {
                pacman.ChangeDirection(Pacman.PRAVEC.Desno);
            }

            Invalidate();
        }
    }
}
