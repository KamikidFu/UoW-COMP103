using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Week8_Ex1
{//Name: Yunhao Fu
    public partial class Form1 : Form
    {
        //Direction values
        const int NORTH = 0;
        const int EAST = 90;
        const int SOUTH = 180;
        const int WEST = 270;

        //Amount to move the turtle 1 step
        const int STEP_AMOUNT = 50;

        //Amount to add to direction when turning
        const int TURN_AMOUNT = EAST;

        //Set direction of turtle to East
        int direction = 90;
        //Status of the tail
        bool isTailUp = true;
        //Current x and y position of the turtle
        Point tutlePos = new Point(0, 0);

        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Turns the direction of the turtle 90 degrees to the left.
        /// </summary>
        private void Left()
        {
            //If direction is north then set to west, otherwise just subtract 
            //the turn amount from the current direction
            if (direction == NORTH)
            {
                direction = WEST;
            }
            else
            {
                direction -= TURN_AMOUNT;
            }
        }

        /// <summary>
        /// Turns the direction of the turtle 90 degrees to the right
        /// </summary>
        private void Right()
        {
            //If direction is west then set to north, otherwise just add 
            //the turn amount to the current direction
            if (direction == WEST)
            {
                direction = NORTH;
            }
            else
            {
                direction += TURN_AMOUNT;
            }
        }

        /// <summary>
        /// Toggles the state of the tail.
        /// </summary>
        private void Tail()
        {
            isTailUp = !isTailUp;
        }

        /// <summary>
        /// Works out the new position of the turtle when doing a step
        /// based on the current direction of the turtle.
        /// </summary>
        /// <returns>The new position of the turtle after doing a step</returns>
        private Point NewTurtlePos()
        {
            //Create the new position at the current turtle position
            Point newPos = new Point(tutlePos.X, tutlePos.Y);

            //Change the x or y position based on the direction
            if (direction == NORTH)
            {
                newPos.Y -= STEP_AMOUNT;
            }
            else if (direction == SOUTH)
            {
                newPos.Y += STEP_AMOUNT;
            }
            else if (direction == WEST)
            {
                newPos.X -= STEP_AMOUNT;
            }
            else
            {
                newPos.X += STEP_AMOUNT;
            }

            return newPos;
        }

        /// <summary>
        /// Make the turtle move by 1 step in the current direction.
        /// </summary>
        /// <param name="paper">Where to draw the graphics</param>
        private void Step(Graphics paper)
        {
            Pen pen1 = new Pen(Color.Black, 5);

            //Get the new position of the turtle after doing the step
            Point newPos = NewTurtlePos();

            if (isTailUp == true)
            {
                //If the tail is up then just move the turtle to the new position
                tutlePos = newPos;
            }
            else
            {
                //If the tail is down then draw a line to the new position and then
                //move the turtle to the new position.
                paper.DrawLine(pen1, tutlePos, newPos);
                tutlePos = newPos;
            }
        }
        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Refresh picture box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
        /// <summary>
        /// LOGO COMMAND
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openLogoProgramToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string fileData;
            StreamReader reader;
            openFileDialog1.Filter = "Logo Program|*.lgo";           
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                //Open the selected file
                reader = File.OpenText(openFileDialog1.FileName); //FileName saves the path of the selected file.
                //Repeat while it is not the end of file
                while(!reader.EndOfStream)
                {
                    //Read line from the file
                    fileData = reader.ReadLine();
                    //Command from the file
                    if(fileData=="Left")
                    {
                        Left();
                    }
                    else if(fileData=="Right")
                    {
                        Right();
                    }
                    else if(fileData=="Tail")
                    {
                        Tail();
                    }
                    else if(fileData=="Step")
                    {
                        Step(paper);
                    }
                    else
                    {
                        MessageBox.Show("Errors occur!");
                    }

                }
                //Close the file
                reader.Close();
            }
        }

       
    }
}
