using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBox
{
    public partial class Form1 : Form
    {
    //Author: Fu, Yunhao
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDrawLine_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 5);
            paper.DrawLine(pen1, 10, 10, 100, 100);
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            //Exit this application
            this.Close();
        }

        private void buttonDrawSquare_Click(object sender, EventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen2 = new Pen(Color.Red, 2);
            paper.DrawLine(pen2, 0, 0, pictureBoxDisplay.Width,0 );
            pen2.Color = Color.Black;
            paper.DrawLine(pen2, pictureBoxDisplay.Width,0,pictureBoxDisplay.Height, pictureBoxDisplay.Width);
            pen2.Color = Color.Black;
            //Draw a line in Black
            paper.DrawLine(pen2, pictureBoxDisplay.Height, pictureBoxDisplay.Width,0, pictureBoxDisplay.Height);
            //Set other pen color to Yellow
            pen2.Color = Color.Yellow;
            paper.DrawLine(pen2,  0, pictureBoxDisplay.Height,0,0);
        }
    }
}
