using System;
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
        bool left, right;
        string move;
        int score, lives;

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

        private void FrmAlien_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }

        private void FrmAlien_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyData == Keys.Left) { left = false; }
            if (e.KeyData == Keys.Right) { right = false; }
        }

        private void TmrPlayer_Tick(object sender, EventArgs e)
        {
            if (right) // if right arrow key pressed
            {
                move = "right";
                player.MovePlayer(move);
            }
            if (left) // if left arrow key pressed
            {
                move = "left";
                player.MovePlayer(move);
            }

        }

        private void FrmAlien_Load(object sender, EventArgs e)
        {
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);
        }

        private void MnuStart_Click(object sender, EventArgs e)
        {
            score = 0;
            LblScore.Text = score.ToString();
            // pass lives from LblLives Text property to lives variable
            lives = int.Parse(LblLives.Text);

            TmrAlien.Enabled = true;
            TmrPlayer.Enabled = true;
        }

        private void MnuStop_Click(object sender, EventArgs e)
        {
            TmrPlayer.Enabled = false;
            TmrAlien.Enabled = false;
        }

        private void TmrAlien_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                alien1[i].MoveEnemy();

                if (player.playerRec.IntersectsWith(alien1[i].alienRec))
                {
                    //reset planet[i] back to top of panel
                    alien1[i].y = 30; // set  y value of planetRec
                    lives -= 1;// lose a life
                    LblLives.Text = lives.ToString();// display number of lives
                    CheckLives();
                }


                //if a planet reaches the bottom of the Game Area reposition it at the top
                if (alien1[i].y >= PnlGame.Height)
                {
                    score += 1;//update the score
                    LblScore.Text = score.ToString();// display score
                    alien1[i].y = 10;
                }

            }
            PnlGame.Invalidate();//makes the paint event fire to redraw the panel
     
        }

        private void CheckLives()
        {
            if (lives == 0)
            {
                TmrAlien.Enabled = false;
                TmrPlayer.Enabled = false;
                MessageBox.Show("Game Over");

            }
        }

    }


}
