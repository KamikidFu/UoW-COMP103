using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week5Ex1
{
    //Fu, Yunhao
    public partial class Form1 : Form
    {
        //The day number that Saturday falls on
        const int SATURDAY = 6;
        //The number of days to display in the planner
        const int NUM_DAYS = 7;
        //The minimum number of hours to display
        const int MIN_HOURS = 1;
        //The maximum number of hours to display
        const int MAX_HOURS = 24;
        //the colour of a weekday appointment (a variable since Color datatype cannot be a const)
        Color WEEK_DAY_COLOR = Color.White;
        //the colour of a weekend appointment (a variable since Color datatype cannot be a const)
        Color WEEK_END_COLOR = Color.LightBlue;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Refresh display picturebox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
        }
        /// <summary>
        /// Draw planner
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDraw_Click(object sender, EventArgs e)
        {
            //Declare variables
            float apptWidth = 0, apptHeigh = 0, xStart = 0, yStart = 0;
            int hours = 0, i, n;
            //Set paper and pen to draw
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Black,3);
            SolidBrush br = new SolidBrush(WEEK_DAY_COLOR);

            try
            {
                //Get the number of hours
                hours = int.Parse(textBoxHours.Text);

                //Valid hours
                if(hours>=MIN_HOURS&&hours<=MAX_HOURS)
                {
                    //Calculate width and heigh of appointment
                    apptWidth = pictureBoxDisplay.Width / NUM_DAYS;
                    apptHeigh = pictureBoxDisplay.Height / hours;
                    //Draw Rows
                    for(i=0; i<hours; i++)
                    {
                        //Draw colomns
                        for(n=1;n<8;n++)
                        {
                            //If it is saturday or sunday, back color is light blue
                            if(n>=SATURDAY)
                            {
                                //Change brush color
                                br.Color = WEEK_END_COLOR;
                            }
                            // Draw rectangle of a appointment
                            paper.DrawRectangle(pen1, xStart, yStart, apptWidth, apptHeigh);
                            paper.FillRectangle(br, xStart,yStart,apptWidth,apptHeigh);
                            xStart += apptWidth;
                            br.Color = Color.White;                            
                        }                       
                        xStart = 0;
                        yStart += apptHeigh;
                        
                        
                    }
                }
                else
                {
                    //Error message and reset application
                    MessageBox.Show("Invalid hours input!");
                    textBoxHours.Clear();
                    textBoxHours.Focus();
                    pictureBoxDisplay.Refresh();
                }

            }
            catch(Exception ex)
            {
                //Error message and reset application
                MessageBox.Show(ex.Message);
                textBoxHours.Clear();
                textBoxHours.Focus();
                pictureBoxDisplay.Refresh();
            }
        }
    }
}
