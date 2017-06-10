using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace PracTest2
{
    public partial class Form1 : Form
    {
        //Name:
        //ID  :

        //size of a lotto ball
        const int BALL_SIZE = 40;
        //size of the gap between lotto balls
        const int GAP_SIZE = 10;
        // the coordinates of the top, left corner of the display of the phone
        const int DISPLAY_LEFT = 40;
        const int DISPLAY_TOP = 140;
        //the width and height of the display area of the phone
        const int DISPLAY_WIDTH = 320; 
        const int DISPLAY_HEIGHT = 460;
        //random number for change color
        Random balls = new Random();

        //NOTE: If the display looks wrong in your screen resolution, 
        //please check that the picture box is 400 x 730 pixels in size
        //and adjust the form to be slightly larger than that.
        //Stupid Visual Studio changes the form size based on your screen resolution - gah!

        public Form1()
        {
            InitializeComponent();
        }
        //Clear funvtion
        private void RefreshUP()
        {
            pictureBoxDisplay.Refresh();
            textBoxBallsinRow.Clear();
            textBoxBallsinRow.Focus();
        }
        /// <summary>
        /// Draw phone background
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawPhone_Click(object sender, EventArgs e)
        {
            //set the background image of the picture box to display the phone
            pictureBoxDisplay.BackgroundImage = PracTest2.Properties.Resources.iPhone;
        }
        /// <summary>
        /// close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Refresh picturebox and clear and focus textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            RefreshUP();
        }
        /// <summary>
        /// Set up timer and start
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            timer1.Interval = 100;
            timer1.Start();
        }
        /// <summary>
        /// Timer does methods
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void timer1_Tick(object sender, EventArgs e)
        {    
            //Declear varibles        
            int rowNum = 0, ballNum = 0, ballsINRow = 0, startX = DISPLAY_LEFT, startY = DISPLAY_TOP;
            try
            {
                //Get the varible value
                ballsINRow = int.Parse(textBoxBallsinRow.Text);
                //Calculate rows number
                rowNum = DISPLAY_HEIGHT / (BALL_SIZE + GAP_SIZE);
                //Set up graphic stuff
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                Pen pen = new Pen(Color.Black, 3);
                SolidBrush br = new SolidBrush(Color.Red);
                //IF the picturebox can draw
                if (((BALL_SIZE + GAP_SIZE) * ballsINRow) < DISPLAY_WIDTH)
                {
                    //For each rows to shift
                    for (int i = 0; i < rowNum; i++)
                    {
                        //For each circles to draw
                        for (int n = 0; n < ballsINRow; n++)
                        {
                            //Get a new random number for color
                            ballNum = balls.Next(1, 40);
                            //Draw circles
                            paper.DrawEllipse(pen, startX, startY, BALL_SIZE, BALL_SIZE);
                            //Change brush color
                            if (ballNum > 0 && ballNum < 10)
                            {
                                br.Color = Color.Blue;
                            }
                            else if (ballNum > 9 && ballNum < 20)
                            {
                                br.Color = Color.Orange;
                            }
                            else if (ballNum > 29 && ballNum < 30)
                            {
                                br.Color = Color.Green;
                            }
                            else if (ballNum == 40)
                            {
                                br.Color = Color.Purple;
                            }
                            //Fill circles with colors
                            paper.FillEllipse(br, startX, startY, BALL_SIZE, BALL_SIZE);
                            //Set startX to next circle
                            startX += GAP_SIZE + BALL_SIZE;
                        }
                        //Adjust startX and startY
                        startY += GAP_SIZE + BALL_SIZE;
                        startX = DISPLAY_LEFT;
                    }
                }
                else
                {
                    timer1.Stop();
                    MessageBox.Show("Please input valid number!");
                    RefreshUP();
                    

                }
            }
            catch (Exception ex)
            {
                timer1.Stop();
                MessageBox.Show(ex.Message);
                RefreshUP();
                
            }
        }
        
        /// <summary>
        /// Timer Stop
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click_1(object sender, EventArgs e)
        {
            
            timer1.Stop();
        }
    }
}
