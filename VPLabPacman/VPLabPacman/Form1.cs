using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Resources;

namespace VPLabPacman
{
    public partial class Form1 : Form
    {
        Timer timer;
        Pacman pacman;
        static readonly int TIME_INTERVAL = 250;
        static readonly int WORLD_WIDTH =  15;
        static readonly int WORLD_HEIGHT = 10;
        Image foodImage;
        bool[][] foodWorld;

        public Form1()
        {
            InitializeComponent();
            foodImage = VPLabPacman.Properties.Resources.food;
            this.DoubleBuffered = true;
            newGame();
        }

        public void newGame()
        {
            pacman = new Pacman();
            this.Width = Pacman.RADIUS * 2 * (WORLD_WIDTH + 1);
            this.Height = Pacman.RADIUS * 2 * (WORLD_HEIGHT + 1);

            foodWorld = new bool[WORLD_HEIGHT][];
            for(int i=0;i< WORLD_HEIGHT; i++)
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
            timer.Interval = TIME_INTERVAL;
            timer.Tick += new EventHandler(Timer_Tick);
            timer.Start();
        }

        private void Timer_Tick(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
            for (int i = 0; i < WORLD_HEIGHT; i++)
            {
                for (int j = 0; j < WORLD_WIDTH; j++)
                {

                    foodWorld[pacman.Y][pacman.X] = false;

                }
            }

            pacman.dvizi(WORLD_WIDTH, WORLD_HEIGHT);

            Invalidate();
        }


        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Up)
            {
                pacman.nasoka = Pacman.Nasoka.gore;
            }
            if (e.KeyCode == Keys.Down)
            {
                pacman.nasoka = Pacman.Nasoka.dole;
            }
            if (e.KeyCode == Keys.Left)
            {
                pacman.nasoka = Pacman.Nasoka.levo;
            }
            if (e.KeyCode == Keys.Right)
            {
                pacman.nasoka = Pacman.Nasoka.desno;
            }
            Invalidate();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.White);
            for (int i = 0; i < foodWorld.Length; i++)
            {
                for (int j = 0; j < foodWorld[i].Length; j++)
                {
                    if (foodWorld[i][j])
                    {
                        g.DrawImageUnscaled(foodImage, j * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Height) / 2 +20, i * Pacman.RADIUS * 2 + (Pacman.RADIUS * 2 - foodImage.Width) / 2 +10);
                    }
                }
            }
            pacman.iscrtaj(g);
        }
    }
}
