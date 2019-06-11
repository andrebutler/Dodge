﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2018_Level2_Dodge
{
    public partial class frmDodge : Form
    {

        bool left, right;
        string move;
        Graphics g; //declare a graphics object called g
        Planet[] planet = new Planet[7]; //create the object, planet1
        Random yspeed = new Random();
        Spaceship spaceship = new Spaceship();

        public frmDodge()
        {
            InitializeComponent();

            for (int i = 0; i < 7; i++)
            {

                int x = 10 + (i * 75);
                planet[i] = new Planet(x);
            }

        }

        private void frmDodge_Load(object sender, EventArgs e)
        {

        }

        private void pnlGame_Paint(object sender, PaintEventArgs e)
        {
            //get the graphics used to paint on the panel control
            g = e.Graphics;
            for (int i = 0; i < 7; i++)


            {


                // generate a random number from 5 to 20 and put it in rndmspeed
                int rndmspeed = yspeed.Next(5, 20);
                planet[i].y += rndmspeed;

                //call the Planet class's drawPlanet method to draw the images
                planet[i].drawPlanet(g);
            }
            spaceship.drawSpaceship(g);
        }

        private void tmrPlanet_Tick(object sender, EventArgs e)
        {
            for (int i = 0; i < 7; i++)
            {
                planet[i].movePlanet();
            }

            pnlGame.Invalidate();//makes the paint event fire to redraw the panel

        }

        private void frmDodge_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == Keys.Left) { left = true; }
            if (e.KeyData == Keys.Right) { right = true; }
        }




        private void frmDodge_KeyUp(object sender, KeyEventArgs e)
        {
            
                if (e.KeyData == Keys.Left) { left = true; }
                if (e.KeyData == Keys.Right) { right = true; }
            }
        



    }
}

