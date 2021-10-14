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
using System.Xml;
using System.Xml.Linq;

namespace Project3
{
    public partial class InfoForm : Form
    {

        public Movie ModifiedMovie { get; set; }
        public InfoForm(Movie selectedMovie)
        {
            InitializeComponent();

            ModifiedMovie = selectedMovie;


            DisplayInfo();
        }
        MainForm test = new MainForm();
        private void DisplayInfo()
        {
            //  Display information from the selected ListView item

            titleTextBox.Text = ModifiedMovie.Title;
            genreTextBox.Text = ModifiedMovie.Genre;
            yearTextBox.Text = ModifiedMovie.Year.ToString();
            lengthTextBox.Text = ModifiedMovie.Length;
            directorTextBox.Text = ModifiedMovie.Director;
            ratingTextBox.Text = ModifiedMovie.Rating.ToString();
            imagePathTextBox.Text = ModifiedMovie.ImagePath;
        }

        private void ChangeInfo()
        {
            //  Associate the new changes to the selected item coming from the TextBoxes
            ModifiedMovie.Title = titleTextBox.Text;
            ModifiedMovie.Genre = genreTextBox.Text;
            ModifiedMovie.Year = int.Parse(yearTextBox.Text);
            ModifiedMovie.Length = lengthTextBox.Text;
            ModifiedMovie.Director = directorTextBox.Text;
            ModifiedMovie.Rating = decimal.Parse(ratingTextBox.Text);
            ModifiedMovie.ImagePath = imagePathTextBox.Text;
        }

        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //  Method to update info
            ChangeInfo();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //  Click delete button from MainForm
            //  You can delete movies from either the MainForm or InfoForm (your preference)
            var frm = (MainForm)this.Owner;
            if (frm != null)
                frm.deleteButton.PerformClick();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            //  Passed selected movie image from MainForm to InfoForm
            consultMoviePictureBox.Image = MainForm.moviePicture;
        }
    }
}
