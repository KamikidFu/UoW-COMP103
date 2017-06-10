using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace W._4.E._1.C
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        
       
        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            //Set drawing paper and pen
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 10);
            SolidBrush br = new SolidBrush(Color.Orange);
            //Draw ellipses
            paper.FillEllipse(br, e.X, e.Y, 50, 50);
            paper.DrawEllipse(pen1, e.X, e.Y, 50, 50);
            

        }
    }
}
