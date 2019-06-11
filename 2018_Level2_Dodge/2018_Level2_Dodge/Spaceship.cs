using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace _2018_Level2_Dodge
{
    class Spaceship
    {
        // declare fields to use in the class

        public int x, y, width, height;//variables for the rectangle
        public Image spaceship;//variable for the planet's image

        public Rectangle spaceRec;//variable for a rectangle to place our image in

        //Create a constructor (initialises the values of the fields)
        public Spaceship()
        {
            x = 10;
            y = 360;
            width = 40;
            height = 40;
            spaceship = Image.FromFile("alien1.png");
            spaceRec = new Rectangle(x, y, width, height);
        }

        //methods
        //this method draws the spaceship
        public void drawSpaceship(Graphics g)
        {

            g.DrawImage(spaceship, spaceRec);
        }



    }
}
