using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ex._2.Week2_updated
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBoxLength.Text = "";
            textBoxDepth.Text = "";
            textBoxWidth.Text = "";
            textBoxVolumeWater.Text = "";
            textBoxChlorineRequired.Text = "";
            textBoxBagsChlorineRequired.Text ="";
            textBoxCostTheBagsRequired.Text="";
        }
        //Amount of chlorine per cubic metre of water
        const double CHLORINE_RATE = 0.1;
        //Amount of chlorine in one bag in kg's
        const int BAG_WEIGHT = 2;
        //Cost of a bag of chlorine
        const decimal BAG_COST = 5.5m;
        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                
                //Declare Variables
                int bags;
                double volumeWater, chlorineRequired, width, length, depth;
                decimal cost;
                //Get data of pool
                width = double.Parse(textBoxWidth.Text);
                length = double.Parse(textBoxLength.Text);
                depth = double.Parse(textBoxDepth.Text);
                //Calculation
                volumeWater = width * length * depth;
                chlorineRequired = volumeWater * CHLORINE_RATE;
                bags = Convert.ToInt32((Math.Ceiling(chlorineRequired / BAG_WEIGHT)));
                cost = bags * BAG_COST;
                //Display
                textBoxVolumeWater.Text = volumeWater.ToString();
                textBoxChlorineRequired.Text = chlorineRequired.ToString();
                textBoxBagsChlorineRequired.Text = bags.ToString();
                textBoxCostTheBagsRequired.Text = cost.ToString("c");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
