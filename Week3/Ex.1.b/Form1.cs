using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._1.b
{
    public partial class Form1 : Form
    {
    //Author: Fu, Yunhao
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonDrawTriangle_Click(object sender, EventArgs e)
        {
            //Set three points
            Point p1, p2, p3;
            p1 = new Point(1, 1);
            p2 = new Point(128, 20);
            p3 = new Point(72, 48);
            //Set a new pen
            Pen pen1 = new Pen(Color.Red, 3);
            //Set paper to be drawn
            Graphics paper = this.CreateGraphics();
            //Use the pen to draw on the paper
            paper.DrawLine(pen1, p1, p2);
            paper.DrawLine(pen1, p2, p3);
            paper.DrawLine(pen1, p3, p1);

        }

        private void buttonDrawPattern_Click(object sender, EventArgs e)
        {
            //Set paper to be drawn
            Graphics paper = this.CreateGraphics();
            //Set points
            Point p4, p5, p6, p7, p8, p9, p10, p11;
            p4 = new Point(100, 100);
            p5 = new Point(200, 100);
            p6 = new Point(100, 150);
            p7 = new Point(300, 150);
            p8 = new Point(200, 200);
            p9 = new Point(400, 200);
            p10 = new Point(300, 250);
            p11 = new Point(400, 250);
            //Set paper to be drawn and use pen to do it
            Pen pen1 = new Pen(Color.Yellow, 3);
            paper.DrawLine(pen1, p4, p5);
            paper.DrawLine(pen1, p4, p6);
            paper.DrawLine(pen1, p6, p7);
            paper.DrawLine(pen1, p5, p8);
            paper.DrawLine(pen1, p8, p9);
            paper.DrawLine(pen1, p7, p10);
            paper.DrawLine(pen1, p10, p11);
            paper.DrawLine(pen1, p9, p11);
        }

        private void buttonErase_Click_1(object sender, EventArgs e)
        {
            this.Refresh();
        }

       
    }
}
