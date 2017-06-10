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

namespace Week9_Ex1
{
    //Name: Fu, Yunhao
    public partial class Form1 : Form
    {
        //The width of a bar in the bar graph
        const int BAR_WIDTH = 25;

        //the gap between bars in the bar graph
        const int GAP = 5;

        //the factor to scale the the graph by to make it fit nicely in the the picturebox
        const int SCALE_FACTOR = 25;

        //The filter names
        const string FILTER = "CSV Files|*.csv|All Files|*.*";
        //Padright const
        const int PADRIGHT = 12;
        public Form1()
        {
            InitializeComponent();
            listBoxOutput.Items.Add("Date".PadRight(PADRIGHT) + "TCal".PadRight(PADRIGHT) + "Step".PadRight(PADRIGHT) + "Dist".PadRight(PADRIGHT) +
                                             "Sede".PadRight(PADRIGHT) + "Ligh".PadRight(PADRIGHT) + "Fair".PadRight(PADRIGHT) + "Very".PadRight(PADRIGHT) +
                                             "ACal".PadRight(PADRIGHT) + "StPM");
        }

        /// <summary>
        /// Draws a vertical bar that is part of a bar graph.
        /// i.e. It fills a rectangle at position (x,y) with the specified colour.
        /// Then draws a black outline for the rectangle.
        /// Uses the BAR_WIDTH constant for the size of the rectangle.
        /// </summary>
        /// <param name="paper">The Graphics object to draw on.</param>
        /// <param name="x">The x position of the top left corner of the rectangle.</param>
        /// <param name="y">The y position of the top left corner of the rectangle.</param>
        /// <param name="colour">The colour to fill the background of the rectangle with.</param>
        private void DrawABar(Graphics paper, int x, int y, int length, Color colour)
        {
            //create a brush of specified colour and fill background with this colour 
            SolidBrush brush = new SolidBrush(colour);
            paper.FillRectangle(brush, x, y, BAR_WIDTH, length);

            //draw outline in black
            paper.DrawRectangle(Pens.Black, x, y, BAR_WIDTH, length);
        }
        /// <summary>
        /// Close the application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clear aimed controls
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
            listBoxOutput.Items.Clear();
            pictureBoxTop.Refresh();
        }
        /// <summary>
        /// Main application does
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up reader
            StreamReader reader;
            //Set up filter
            openFileDialog1.Filter = FILTER;
            //Try..catch
            try
            {
                //if file is selected
                if(openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Set up graph stuff
                    Color cr = Color.LightGreen;
                    Pen pen1 = new Pen(Color.Black, 3);
                    SolidBrush br = new SolidBrush(cr);
                    Graphics paper = pictureBoxTop.CreateGraphics();
                    //Declear varibles
                    int barHeight = 0;
                    int barWeight = (int)pictureBoxTop.Width / 31;
                    int x = 0, y = 0;
                    int totalSteps = 0;
                    int steps = 0;
                    double distance = 0, StPM = 0;                 
                    //Reader starts doing thing
                    reader = File.OpenText(openFileDialog1.FileName);
                    //While it is end
                    while(!reader.EndOfStream)
                    {
                        //Declear varible
                        string oneLineData = reader.ReadLine();
                        string[] csvDataArray= oneLineData.Split(',');
                        //Calculate stuff
                        steps = int.Parse(csvDataArray[2]);
                        totalSteps += steps;
                        distance = double.Parse(csvDataArray[3]);
                        StPM = CalculateStepsPerMetre(steps, distance);
                        barHeight = Convert.ToInt32(CalculateBarHeight(distance));
                        //List data
                        listBoxOutput.Items.Add(csvDataArray[0].PadRight(PADRIGHT) + csvDataArray[1].PadRight(PADRIGHT) + csvDataArray[2].PadRight(PADRIGHT) + 
                                                csvDataArray[3].PadRight(PADRIGHT) + csvDataArray[4].PadRight(PADRIGHT) + csvDataArray[5].PadRight(PADRIGHT) + 
                                                csvDataArray[6].PadRight(PADRIGHT) + csvDataArray[7].PadRight(PADRIGHT) + csvDataArray[8].PadRight(PADRIGHT)+StPM.ToString("f3"));     
                        //Draw graph                                         
                        y = (int)pictureBoxTop.Height - barHeight;
                        paper.DrawRectangle(pen1, x, y, barWeight, barHeight);
                        paper.FillRectangle(br, x, y, barWeight, barHeight);
                        x += barWeight;
                                                             
                    }
                    //Show message
                    MessageBox.Show("Total steps recorded: " + totalSteps.ToString());
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Method for calculating steps per metre
        /// </summary>
        /// <param name="steps">the number of steps</param>
        /// <param name="distance">the distance walked in kilometres</param>
        /// <returns></returns>
        private double CalculateStepsPerMetre(int steps,double distance)
        {
            return steps / (distance * 1000);
        }
        /// <summary>
        /// Method for calculating height of bar
        /// </summary>
        /// <param name="distance">Distance walked</param>
        /// <returns></returns>
        private double CalculateBarHeight(double distance)
        {           
            return distance * SCALE_FACTOR;
        }
    }
}
