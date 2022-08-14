﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace code_asses2022JM
{
    public partial class FrmAlien : Form
    {
        Graphics g; //declare a graphics object called g
        Enemy[] alien1 = new Enemy[7]; //create the object, planet1
        Random yspeed = new Random();
        Player player = new Player();

        public FrmAlien()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {
                int x = 10 + (i * 75);
                alien1[i] = new Enemy(x);
            }

        }

        private void PnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            player.DrawPlayer(g);

            for (int i = 0; i < 7; i++)
            {
                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                alien1[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                alien1[i].DrawEnemy(g);

            }

        }

        private void TmrAlien_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                alien1[i].MoveEnemy();

                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (alien1[i].y >= PnlGame.Height)
                {
                    alien1[i].y = 10;
                }

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
        }
    }
}
