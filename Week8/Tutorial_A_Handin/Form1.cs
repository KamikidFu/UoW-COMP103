using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace drawSquare
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void buttonGo_Click(object sender, EventArgs e)
        {
            int X = 40;
            int Y = 80;
            int sideLength = 100;
            Color cr = Color.Blue;
            Graphics paper = pictureBox.CreateGraphics();
            DrawSquare(X, Y, sideLength, cr, paper);
            X += sideLength;
            cr = Color.Red;
            DrawSquare(X, Y, sideLength, cr, paper);
        }

        private void DrawSquare(int X, int Y, int Length, Color color, Graphics paper)
        {
            SolidBrush br = new SolidBrush(color);
            paper.FillRectangle(br, X, Y, Length, Length);
        }
    }
}
