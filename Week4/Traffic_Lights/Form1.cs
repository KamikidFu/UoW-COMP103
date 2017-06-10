using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Traffic_lights
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Exit the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        /// <summary>
        /// Clear picturebox and textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonClear_Click(object sender, EventArgs e)
        {
            pictureBoxDisplay.Refresh();
            textBoxRadius.Clear();
            textBoxRadius.Focus();
        }
        /// <summary>
        /// Draw lights
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDrawLights_Click(object sender, EventArgs e)
        {
            try
            {
                //Set loop i, color-changing marker colorMarker and graphic paper , pen and brush
                int i, colorMarker;
                float radius, startPoint;
                Pen pen1 = new Pen(Color.Black, 3);
                SolidBrush br = new SolidBrush(Color.Red);
                Graphics paper = pictureBoxDisplay.CreateGraphics();

                //Get value of radius and set value to colorMarker
                radius = float.Parse(textBoxRadius.Text);
                startPoint = 20;
                colorMarker = 0;

                //Draw circlrs with loop
                for (i = 0; i < 3; i++)
                {
                    //Set start point of circle in Y axis
                    if (i != 0)
                    {
                        startPoint = 20 + startPoint + 2 * radius;
                    }

                    //Draw the circle and fill in different color
                    paper.DrawEllipse(pen1, pictureBoxDisplay.Width / 2, startPoint, 2 * radius, 2 * radius);
                    if (colorMarker == 0)
                    {
                        br.Color = Color.Red;
                        paper.FillEllipse(br, pictureBoxDisplay.Width / 2, startPoint, 2 * radius, 2 * radius);
                        colorMarker++;
                    }
                    else if (colorMarker == 1)
                    {
                        br.Color = Color.Yellow;
                        paper.FillEllipse(br, pictureBoxDisplay.Width / 2, startPoint, 2 * radius, 2 * radius);
                        colorMarker++;
                    }
                    else if (colorMarker == 2)
                    {
                        br.Color = Color.Green;
                        paper.FillEllipse(br, pictureBoxDisplay.Width / 2, startPoint, 2 * radius, 2 * radius);
                        colorMarker++;
                    }
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
