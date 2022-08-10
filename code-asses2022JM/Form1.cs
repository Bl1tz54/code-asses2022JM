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

            for (int i = 0; i < 7; i++)
            {
                //call the Planet class's drawPlanet method to draw the images
                alien1[i].DrawEnemy(g);
            }

        }
    }
}
