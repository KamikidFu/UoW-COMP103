using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pictureBox2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        //Set a new pen to draw
        Pen pen1 = new Pen(Color.Blue, 2);
        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //Set paper to be drawn
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            //Use the pen to draw on the paper
            paper.DrawLine(pen1, pictureBoxDisplay.Width / 2, pictureBoxDisplay.Height / 2, e.X, e.Y);
            
        }

        private void buttonSetColor_Click(object sender, EventArgs e)
        {
            //Show color dialog
            colorDialog1.ShowDialog();
            //Change the pen's color to draw
            pen1.Color = colorDialog1.Color;
        }
    }
}
