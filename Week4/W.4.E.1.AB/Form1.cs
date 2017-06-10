using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W4.E._1.A
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Pen pen1 = new Pen(Color.Blue, 2);
        Random rand = new Random();
        private void buttonCC_Click(object sender, EventArgs e)
        {
            //Show color dialog
            colorDialog1.ShowDialog();
            //Change the pen's color to draw
            pen1.Color = colorDialog1.Color;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            

        }

        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button==MouseButtons.Left)
            {
                //Set paper to be drawn
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                //Use the pen to draw on the paper
                paper.DrawLine(pen1,rand.Next(pictureBoxDisplay.Width+1), rand.Next(pictureBoxDisplay.Height + 1), e.X, e.Y);
            }
            
        }
    }
}
