using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pool_Chemicals_Usage_Calculator_Prototype
{
    //Author: Fu, Yunhao
    public partial class Form1 : Form
    {
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
            textBoxDepth.Text = "";
            textBoxLength.Text = "";
            textBoxWidth.Text = "";
            labelCR.Text = "...";
            labelCBR.Text = "...";
            labelBR.Text = "...";
            labelVW.Text = "...";
        }

        private void buttonCal_Click(object sender, EventArgs e)
        {
            if (this.textBoxDepth.Text == "" && this.textBoxLength.Text=="" && this.textBoxWidth.Text=="")
            {
                MessageBox.Show("Invalid value input","Error:",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                double L, W, D, VW, CR, BRd, CBR;
                int BRi;
                L = Convert.ToDouble(textBoxLength.Text);
                W = Convert.ToDouble(textBoxWidth.Text);
                D = Convert.ToDouble(textBoxDepth.Text);
                VW = L * W * D;
                labelVW.Text = VW.ToString();
                CR = 0.1 * VW;
                labelCR.Text = CR.ToString("0.00");
                BRd = CR / 2;
                BRi = (int)Math.Ceiling((double)BRd);
                labelBR.Text = BRi.ToString();
                CBR = BRi * 5.5;
                labelCBR.Text = CBR.ToString("0.00");
            }

        }

        
    }
}
