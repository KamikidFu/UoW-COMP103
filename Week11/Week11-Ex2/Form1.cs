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

namespace Week11_Ex2
{
    public partial class Form1 : Form
    {
        //List to store bookmarks
        List<string> bookMarkers = new List<string>();
        //Set up FILTTER
        const string FILTTER = "TXT Files|*.txt";

        public Form1()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Back visit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            //Go back
            webBrowser1.GoBack();
        }
        /// <summary>
        /// Forward visit
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonForward_Click(object sender, EventArgs e)
        {
            //Go forward
            webBrowser1.GoForward();
        }
        /// <summary>
        /// Go navigating
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonGO_Click(object sender, EventArgs e)
        {
            //Navigate URL
            webBrowser1.Navigate(textBoxURL.Text);
        }
        /// <summary>
        /// Nacigating status bar
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_Navigating(object sender, WebBrowserNavigatingEventArgs e)
        {
            //Show status
            textBoxStatus.Text ="Status: "+" Waiting for " + textBoxURL.Text;
        }
        /// <summary>
        /// When loaded website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void webBrowser1_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            //clear status
            textBoxStatus.Clear();
            //textboxURL text reset
            textBoxURL.Text = webBrowser1.Document.Url.ToString();
            //Form title reset
            this.Text = webBrowser1.DocumentTitle;
        }
        /// <summary>
        /// Update list box
        /// </summary>
        private void UpdateListbox()
        {
            //Clear listbox items
            listBox1.Items.Clear();
            //For each bookmarker list to add
            for(int i=0;i<bookMarkers.Count;i++)
            {
                //Add item to listbox
                listBox1.Items.Add(bookMarkers[i]);
            }
        }
        /// <summary>
        /// Initialise bookmarkers list, listbox, textbox
        /// </summary>
        private void Initialise()
        {
            //Clear bookmarker list
            bookMarkers.Clear();
            //Clear listbox
            listBox1.Items.Clear();
            //Clear textbox
            textBoxURL.Clear();
        }
        /// <summary>
        /// Initialise bookmark system
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void newBookmarkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Initialise application
            Initialise();
        }
        /// <summary>
        /// Add new bookmarker
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addBookmarkToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //IF textbox URL is empty
            if(textBoxURL.Text!="")
            {
                //Add URL to bookmarker list
                bookMarkers.Add(webBrowser1.Document.Url.ToString());
                //Update list box
                UpdateListbox();
            }
            else
            {
                //Show error
                MessageBox.Show("There is no URL need to be marked as bookmarkers!");
            }
        }
        /// <summary>
        /// When selected an item in listbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Set up index number
            int index = listBox1.SelectedIndex;
            //Turn the string to textboxURL
            textBoxURL.Text = bookMarkers[index];
            //GO navigate
            webBrowser1.Navigate(textBoxURL.Text);
        }
        /// <summary>
        /// Save a bookmark to list
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void saveBookmarkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up writer
            StreamWriter writer;
            //Set dialog filtter
            saveFileDialog1.Filter = FILTTER;
            //IF a path is selected
            if(saveFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //Writer the text
                writer = File.CreateText(saveFileDialog1.FileName);
                //FOR each bookmarker list index to add in txt file
                for(int i=0; i<bookMarkers.Count;i++)
                {
                    //Add to file
                    writer.WriteLine(bookMarkers[i]);
                }
                //Close writer
                writer.Close();
            }
        }
        /// <summary>
        /// Load a bookmark file
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void loadBookmarkFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //Set up reader
            StreamReader reader;
            //Declear varible
            string line;
            //Set up filtter
            openFileDialog1.Filter = FILTTER;
            //IF a file is selected
            if(openFileDialog1.ShowDialog()==DialogResult.OK)
            {
                //Open reader to read
                reader = File.OpenText(openFileDialog1.FileName);
                //Initialise application
                Initialise();
                //WHILE it is not the end of file
                while(!reader.EndOfStream)
                {
                    //Read one line data
                    line = reader.ReadLine();
                    //Add to bookmarkers list
                    bookMarkers.Add(line);
                }
                //Close reader
                reader.Close();
                //Update List box
                UpdateListbox();
            }
        }
        /// <summary>
        /// Delete a bookmark in list box
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            //Declear index
            int index = listBox1.SelectedIndex;
            //Remove an item from bookmarker list
            bookMarkers.RemoveAt(index);
            //Update list box
            UpdateListbox();
        }
        /// <summary>
        /// Refresh website
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonRefresh_Click(object sender, EventArgs e)
        {
            //Refresh website
            webBrowser1.Refresh();
        }
    }
}
