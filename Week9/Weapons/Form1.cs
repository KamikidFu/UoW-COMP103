using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Weapons
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            columnHeaderNumber.Width = 30;
            columnHeaderName.Width = 100;
            columnHeaderDamage.Width = 100;
            columnHeaderDPS.Width = 100;
            columnHeaderSpeed.Width = 100;
            columnHeaderType.Width = 100;
        }
        /// <summary>
        /// Method_Calculate DPS
        /// </summary>
        /// <param name="damage"></param>
        /// <param name="speed"></param>
        /// <param name=""></param>
        /// <returns></returns>
        private double CalculateDPS(int damage,double speed)
        {
            double DPS;
            DPS = (double)damage / speed;
            return DPS;
        }
        //Global varible for DPS calculation
        int damage;
        double speed, DPS;

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        /// <summary>
        /// Open file and show on the list view
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGo_Click(object sender, EventArgs e)
        {
            //Try
            try
            {          
              //Declear Varibles   
              string lineData;            
              StreamReader reader;            
                //Set filter
              openFileDialog1.Filter = "*.txt files|*.txt";
                //IF the file selected
              if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Open the file and read
                    reader = File.OpenText(openFileDialog1.FileName);
                    textBoxPath.Text = openFileDialog1.FileName.ToString();
                    int i = 1;
                    while (!reader.EndOfStream)
                    {
                        //Set up a list to show
                        ListViewItem lvNumber = new ListViewItem(i.ToString());
                        //4 lines a group to loop
                        for (int j = 0; j < 5; j++)
                        {
                            //Add name and type information to list
                            if (j < 2)
                            {
                                lineData = reader.ReadLine();
                                lvNumber.SubItems.Add(lineData);
                            }
                            //Add damage information to list
                            else if (j == 2)
                            {
                                lineData = reader.ReadLine();
                                damage = int.Parse(lineData);
                                lvNumber.SubItems.Add(lineData);
                            }
                            //Add speed information to list
                            else if (j == 3)
                            {
                                lineData = reader.ReadLine();
                                speed = double.Parse(lineData);
                                lvNumber.SubItems.Add(lineData);
                            }
                            //Calculate DPS and add to list
                            else
                            {
                                DPS = CalculateDPS(damage, speed);
                                lvNumber.SubItems.Add(DPS.ToString("f2"));
                            }
                        }
                        //Show the list
                        listView1.Items.Add(lvNumber);
                        //Add number of weapon
                        i++;
                    }
                    reader.Close();
                }
                
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }      

        
       
    }
}
