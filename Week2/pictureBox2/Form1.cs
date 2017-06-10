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
    //Author: Fu, Yunhao
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        
        private void pictureBoxDisplay_MouseMove(object sender, MouseEventArgs e)
        {
            Graphics paper = pictureBoxDisplay.CreateGraphics();
            Pen pen1 = new Pen(Color.Blue, 2);
            paper.DrawLine(pen1, pictureBoxDisplay.Width/2, pictureBoxDisplay.Height/2, e.X, e.Y);
        }

       
    }
}
