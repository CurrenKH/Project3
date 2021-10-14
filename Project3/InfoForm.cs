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
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists("movies.xml"))
            {
                // Load the xml file root element in memory
                xmlDoc.Load("movies.xml");

                // Create the XML File root element in memory
                XmlElement rootNode = xmlDoc.DocumentElement;

                // Create one XML for each node representing a new movie entry 
                XmlElement newMovieNode = xmlDoc.CreateElement("movie");
                XmlElement newTitleNode = xmlDoc.CreateElement("title");
                XmlElement newYearNode = xmlDoc.CreateElement("year");
                XmlElement newLengthNode = xmlDoc.CreateElement("length");
                XmlElement newDirectorNode = xmlDoc.CreateElement("director");
                XmlElement newRatingNode = xmlDoc.CreateElement("audienceRating");
                XmlElement newFilePathNode = xmlDoc.CreateElement("imageFilePath");

                // Create a TextNode element to assign the content to each node in the movie entry
                XmlText newTextNode;


                // --- TITLE ---

                // Assign a value for the 'category' attribute of the 'book' node
                newMovieNode.SetAttribute("genre", genreTextBox.Text);

                // Create the content for the 'title' node
                newTextNode = xmlDoc.CreateTextNode(titleTextBox.Text);

                // Add the content to the 'title' node
                newTitleNode.AppendChild(newTextNode);


                // --- YEAR ---

                // Create the content for the 'Year' node
                newTextNode = xmlDoc.CreateTextNode(yearTextBox.Text);

                // Add the content to the 'Year' node
                newYearNode.AppendChild(newTextNode);


                // --- LENGTH ---

                // Create the content for the 'Length' node
                newTextNode = xmlDoc.CreateTextNode(lengthTextBox.Text);

                // Add the content to the 'Length' node
                newLengthNode.AppendChild(newTextNode);


                // --- DIRECTOR ---

                // Create the content for the 'Director' node
                newTextNode = xmlDoc.CreateTextNode(directorTextBox.Text);

                // Add the content to the 'Director' node
                newDirectorNode.AppendChild(newTextNode);


                // --- RATING ---

                // Create the content for the 'Rating' node
                newTextNode = xmlDoc.CreateTextNode(ratingTextBox.Text);

                // Add the content to the 'Rating' node
                newRatingNode.AppendChild(newTextNode);


                // --- PATH ---

                // Create the content for the 'FilePath' node
                newTextNode = xmlDoc.CreateTextNode(imagePathTextBox.Text);

                // Add the content to the 'FilePath' node
                newFilePathNode.AppendChild(newTextNode);


                // Append each 'child' node to the 'movie' node 
                newMovieNode.AppendChild(newTitleNode);
                newMovieNode.AppendChild(newYearNode);
                newMovieNode.AppendChild(newLengthNode);
                newMovieNode.AppendChild(newDirectorNode);
                newMovieNode.AppendChild(newRatingNode);
                newMovieNode.AppendChild(newFilePathNode);

                // Append the 'movie' node to the root ('movies') node
                rootNode.AppendChild(newMovieNode);

                // Save the updated version of the xmlDocument to the file
                xmlDoc.Save("movies.xml");

                var frm2 = (MainForm)this.Owner;
                if (frm2 != null)
                    frm2.deleteButton.PerformClick();
                this.Close();
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //  Click delete button from MainForm
            //  You can delete movies from either the MainForm or InfoForm (your preference)
            var frm = (MainForm)this.Owner;
            if (frm != null)
                frm.deleteButton.PerformClick();


            //  Closes secondary form
            this.Hide();
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            //  Passed selected movie image from MainForm to InfoForm
            consultMoviePictureBox.Image = MainForm.moviePicture;
        }
    }
}
