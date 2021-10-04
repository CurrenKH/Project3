using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project3
{
    public partial class InfoForm : Form
    {
        public Movie ModifiedMovie { get; set; }
        public InfoForm(Movie selectedMovie)
        {
            InitializeComponent();

            ModifiedMovie = selectedMovie;
        }

        private void DisplayInfo()
        {
            //  Display information from the selected ListBox item
            //nameTextBox.Text = ModifiedMovie.Title;
            // subjectComboBox.Text = ModifiedSeries.Subject;

            //  Counting the subjects from the selected item
            /*for (int i = 0; i < ModifiedMovie.Genre.Count; i++)
            {
                subjectComboBox.Text += ModifiedMovie.Genre[i];

                //  If there is more than one entry, add a "," inbetween them
                if (i + 1 < ModifiedMovie.Subjects.Count)
                {
                    subjectComboBox.Text += ",";
                }
            }*/

            //amountTextBox.Text = ModifiedMovie.Amount.ToString();
            //publisherTextBox.Text = ModifiedMovie.Publisher;
        }
    }
}
