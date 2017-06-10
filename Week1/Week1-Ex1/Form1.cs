using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Week1_Ex1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// button to change the text of the output label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeText_Click(object sender, EventArgs e)
        {
            labelOutput.Text = labelOutput.Text + " " + "Kami";
        }
        /// <summary>
        /// button to change the colour of the output label
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChangeColour_Click(object sender, EventArgs e)
        {
            labelOutput.ForeColor = Color.Red;
            this.BackColor = Color.MistyRose;
        }
        /// <summary>
        /// button to make the form bigger
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBigger_Click(object sender, EventArgs e)
        {
            this.Width = this.Width + 15;
            this.Height = this.Height + 10;
            labelOutput.Left = (this.Width-labelOutput.Width)/ 2;
        }
        /// <summary>
        /// button to make the form smaller
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSmaller_Click(object sender, EventArgs e)
        {
            this.Width = this.Width - 15;
            this.Height = this.Height - 10;
            labelOutput.Left = (this.Width - labelOutput.Width) / 2;
        }
        /// <summary>
        /// button to exit(close) the form
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
