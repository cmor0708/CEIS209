using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Morse_CourseProject_Part1
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(outputText.Text);
            string nl = "\r\n";

           if(string.IsNullOrEmpty(titleText.Text))
            {
                // Title is blank
                MessageBox.Show("The song title cannot be blank.");
            }
           else if(string.IsNullOrEmpty(artistText.Text))
            {
                // Artist is blank
                MessageBox.Show("The artist cannot be blank.");
            }
            else if (string.IsNullOrEmpty(genreText.Text))
            {
                // Genre is blank
                MessageBox.Show("The genre cannot be blank.");
            }
            else if (string.IsNullOrEmpty(yearText.Text))
            {
                // Year is blank
                MessageBox.Show("The year cannot be blank.");
            }
            else if (string.IsNullOrEmpty(urlText.Text))
            {
                // URL is blank
                MessageBox.Show("The url cannot be blank.");
            }
            else
            {
                // Add title to ListBox
                songList.Items.Add(titleText.Text);
                // Build the output text
                 sb.Append(titleText.Text);
                 sb.Append(nl);
                 sb.Append(artistText.Text);
                sb.Append(nl);
                sb.Append(genreText.Text);
                sb.Append(nl);
                sb.Append(yearText.Text);
                sb.Append(nl);
                sb.Append(urlText.Text);
                sb.Append(nl);
                sb.Append(nl);   

            outputText.Text = sb.ToString();
            }

           
        }

        private void titleText_TextChanged(object sender, EventArgs e)
        {

        }

        private void allSongsButton_Click(object sender, EventArgs e)
        {
            StringBuilder sb = new StringBuilder(string.Empty);
            string nl = "\r\n";

            // Build the output text
            foreach (var item in songList.Items)
            {
                sb.Append(item.ToString());
                sb.Append(nl);
            }
         //Put the output text into the output textbox
         outputText.Text = sb.ToString();
        }


    }
}
