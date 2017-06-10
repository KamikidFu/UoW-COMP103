using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week6_Ex2A
{
    public partial class Form1 : Form
    {
        //The number of squares in each row
        const int NUM_COLUMNS = 10;
        //The minimum number of rows to draw
        const int MIN_ROWS = 5;
        //The maximum number of rows to draw
        const int MAX_ROWS = 10;

        public Form1()
        {
            InitializeComponent();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxBoard.Refresh();
        }

        private void buttonDrawBoard_Click(object sender, EventArgs e)
        {
           try
            {
                int rowNum = 0, startX = 0, startY = 0, Rectangle_Width = 0, Rectangle_Heigh = 0;
                rowNum = int.Parse(textBoxRow.Text);
                Graphics paper = pictureBoxBoard.CreateGraphics();
                Pen pen = new Pen(Color.Black, 5);
                SolidBrush br = new SolidBrush(Color.LightPink);

                Rectangle_Width = pictureBoxBoard.Width / 10;
                Rectangle_Heigh = pictureBoxBoard.Height / rowNum;
                if (rowNum > 4 && rowNum < 11)
                {
                    for (int i = 0; i < 10; i++)
                    {
                        if ((i > 0 && i < 4) || (i > 5 && i < 9))
                        {
                            br.Color = Color.LightGreen;
                        }
                        else if (i > 3 && i < 6)
                        {
                            br.Color = Color.LightBlue;
                        }
                        else
                        {
                            br.Color = Color.LightPink;
                        }
                        for (int n = 0; n < rowNum; n++)
                        {
                            paper.DrawRectangle(pen, startX, startY, Rectangle_Width, Rectangle_Heigh);
                            paper.FillRectangle(br, startX, startY, Rectangle_Width, Rectangle_Heigh);
                            startY += Rectangle_Heigh;
                        }
                        startX += Rectangle_Width;
                        startY = 0;

                    }
                }
            }
        }
    }
}
