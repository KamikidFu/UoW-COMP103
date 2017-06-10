using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week7_Ex1
{
    public partial class Form1 : Form
    {
        //The minimum size of the board
        const int MIN_BOARD_SIZE = 2;
        //The maximum size of the board
        const int MAX_BOARD_SIZE = 10;
        //The width of a square
        const int SQUARE_WIDTH = 40;
        //The height of a square
        const int SQUARE_HEIGHT = 40;

        //the colour of a Dark square (a variable since Color cannot be a const)
        Color DarkBrown = Color.SaddleBrown;
        //the colour of a Light square (a variable since Color cannot be a const)
        Color LightBrown = Color.SandyBrown;

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clear
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
            textBoxSize.Clear();
            textBoxSize.Focus();
        }
        /// <summary>
        /// Draw Board
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void drawBoardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up graphic and other variables
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            int yPos = 0;
            //Try..Catch
            try
            {
                //Get the board size
                int size = int.Parse(textBoxSize.Text);
                //Judge the size
                if(size>MIN_BOARD_SIZE && size<MAX_BOARD_SIZE)
                {
                    //For each row to draw
                    for(int j=1;j<=size;j++)
                    {
                        //draw a row
                        drawRow(paper,size,j,yPos);
                        //shift y position to next row
                        yPos += SQUARE_HEIGHT;
                    }
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                pictureBoxDisplay.Refresh();
                textBoxSize.Clear();
                textBoxSize.Focus();
            }
        }
        /// <summary>
        /// Draw Square
        /// Method drawSquare (paper, x Position, y Position, Color)
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="color"></param>
        private void drawSquare(Graphics paper, int x, int y,Color color)
        {
            //For the outline, set up a pen
            Pen pen1 = new Pen(Color.Black,3);
            //For the fill, set up a solidbrush
            SolidBrush br = new SolidBrush(color);
            //Draw rectangle
            paper.DrawRectangle(pen1, x, y, SQUARE_WIDTH, SQUARE_HEIGHT);
            //Fill rectangle with color
            paper.FillRectangle(br, x, y, SQUARE_WIDTH, SQUARE_HEIGHT);
            //Draw the outline
            paper.DrawLine(pen1, x, y, x, y + SQUARE_HEIGHT);
            paper.DrawLine(pen1, x, y, x + SQUARE_WIDTH, y);
        }
        /// <summary>
        /// draw Row
        /// Method drawRow(paper, board size, row number,y position)
        /// </summary>
        /// <param name="paper"></param>
        /// <param name="size"></param>
        /// <param name="rowNum"></param>
        /// <param name="yCurrentPosition"></param>
        private void drawRow(Graphics paper, int size, int rowNum, int yCurrentPosition)
        {
            //For the outline, set up a pen
            Pen pen1 = new Pen(Color.Black, 3);
            //For shift, set up x position variable
            int xPos = 0;
            //For each column to draw
            for(int i=1;i <= size;i++)
            {
                //Judge to change color
                if((i+rowNum)%2 == 0)
                {
                    //Change color and draw square
                    Color fillColor = Color.SandyBrown;
                    drawSquare(paper, xPos, yCurrentPosition, fillColor);
                }
                else
                {
                    //Change color and draw square
                    Color fillColor = Color.SaddleBrown;
                    drawSquare(paper, xPos, yCurrentPosition, fillColor);
                }
                //Shift x position to next column
                xPos += SQUARE_WIDTH;
            }
        }
    }
}
