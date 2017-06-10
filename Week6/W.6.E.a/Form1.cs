using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W._6.E.a
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Random penWidth = new Random();
        Random numCircles = new Random();
        Random xyPos = new Random();
        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button==MouseButtons.Left)
            {
                int i = 1;
                int xPos, yPos;
                //Set drawing paper and pen
                Graphics paper = pictureBoxDisplay.CreateGraphics();
                Pen pen1 = new Pen(Color.Black, penWidth.Next(50));
                SolidBrush br = new SolidBrush(Color.Orange);
                br.Color = Color.FromArgb(12, 125, 233);
                while (i<=(numCircles.Next(8)+2))
                { 
                    //Draw ellipses
                    paper.FillEllipse(br, e.X, e.Y, 50, 50);
                    paper.DrawEllipse(pen1, e.X, e.Y, 50, 50);
                    //Store start point
                    xPos = e.X + xyPos.Next(-10, 10);
                    yPos = e.Y + xyPos.Next(-10, 10);
                    i++;
                }
                
            }
            


        }
    }
}
