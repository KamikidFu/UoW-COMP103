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

namespace Week10_Ex2_OpA
{
    /*
    Name: Yunhao Fu
    */
    public partial class Form1 : Form
    {
        //Global string list to save ID and Marks
        List<string> IDList = new List<string>();
        List<int> marksList = new List<int>();

        //Global int for count student number
        int numStudent = 0;
        
        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Close application
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Close application
            this.Close();
        }
        /// <summary>
        /// Load Mark and show in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadMarkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up a reader
            StreamReader reader;
            //Set up filter
            openFileDialog1.Filter = "CSV File|*.csv";
            //Try catch for error
            try
            {
                //IF file is selected
                if(openFileDialog1.ShowDialog()==DialogResult.OK)
                {
                    //Add title to list box
                    listBox1.Items.Add("Student ID"+ "Mark".PadLeft(9));
                    //Declear reader
                    reader = File.OpenText(openFileDialog1.FileName);
                    //While the file is end
                    while (!reader.EndOfStream)
                    {
                        //Set up array to save the value
                        string[] lineData = reader.ReadLine().Split(',');
                        //Add value to list box
                        listBox1.Items.Add(lineData[0].PadRight(15) + lineData[1]);
                        //Send ID value to global list ID
                        IDList.Add(lineData[0]);
                        //Send marks value to global list marksList
                        marksList.Add(int.Parse(lineData[1]));
                        //Total student number counting
                        numStudent++;
                    }
                    //Show a message to say file is loaded and tell the student number
                    MessageBox.Show("There are total "+numStudent.ToString()+" students recorded.");
                    //Close reader
                    reader.Close();
                }
                
            }
            
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Create graph
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void graphMarksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up graphic stuff
            Graphics paper = pictureBoxGraph.CreateGraphics();
            Pen pen1 = new Pen(Color.Black, 3);
            SolidBrush br = new SolidBrush(Color.LightGreen);
            //Declear variables
            int x = 0;
            int y = 0;            
            int barHeight = 0;
            int barWeight = (int)pictureBoxGraph.Width / numStudent;
            //For each marks in list markslist
            foreach(int marks in marksList)
            {
                //Calculate the bar heigh with method
                barHeight = CalculateBarHeight(marks);
                //Update the y value of retangle
                y = pictureBoxGraph.Height - barHeight;                
                //Draw a rectangle
                paper.DrawRectangle(pen1,x,y,barWeight,barHeight);
                //Fill a rectangle
                paper.FillRectangle(br,x,y,barWeight,barHeight);
                //Shift x to next
                x += barWeight;
            }
        }

        /// <summary>
        /// Method for calculate bar height
        /// </summary>
        /// <param name="marks">Student's marks</param>
        /// <returns></returns>
        private int CalculateBarHeight(int marks)
        {
            //Return a bar height value
            return (pictureBoxGraph.Height * marks) / 100;
        }

        /// <summary>
        /// Clear graph and other value
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void clearGraphToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Clear up all stuff
            pictureBoxGraph.Refresh();
            listBox1.Items.Clear();
            IDList.Clear();
            marksList.Clear();
            numStudent = 0;
        }
        /// <summary>
        /// Generate and export marks report
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void generateReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up a writer
            StreamWriter writer;
            //Set up filter of save file dialog
            saveFileDialog1.Filter = "CSV File|*.csv";
            //Try catch for error
            try
            {
                //IF a file is selected
                if (saveFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    //Declear writer
                    writer = File.CreateText(saveFileDialog1.FileName);
                    //Declear varibles
                    string grade;
                    //Write a title to file
                    writer.WriteLine("Student ID".PadRight(15) + "Mark".PadRight(15) + "Grade");
                    //For each ID to write
                    for (int i=0;i<IDList.Count;i++)
                    {
                        //Calculate grade with method
                        grade = CalculateLetterGrade(marksList[i]);
                        //Write things to file
                        writer.WriteLine(IDList[i].PadRight(15) + marksList[i].ToString().PadRight(15) + grade);
                    }
                    //Close writer
                    writer.Close();
                    //Show a message to say the file is saved and the path of file
                    MessageBox.Show("Your exported file is saved at" +"\n"+ saveFileDialog1.FileName.ToString());
                }

            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        /// <summary>
        /// Calculate the Letter Grade
        /// </summary>
        /// <param name="marks">Student's marks</param>
        /// <returns></returns>
        private string CalculateLetterGrade(int marks)
        {
            //IF the mark is in following cases
            if (marks >= 80)
            {
                return "A";
            }
            else if (marks >= 65)
            {
                return "B";
            }
            else if (marks >= 50)
            {
                return "C";
            }
            else if (marks >= 35)
            {
                return "D";
            }
            else
            {
                return "E";
            }
        }
    }
}
