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
        //  Variable for modified movie info
        public Movie ModifiedMovie { get; set; }
        public InfoForm(Movie selectedMovie)
        {
            InitializeComponent();

            ModifiedMovie = selectedMovie;

            //  Show selected movie info in the TextBoxes
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

            //  Create XML document instance
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists("movies.xml"))
            {
                //  Load indicated XML file (movies.xml)
                xmlDoc.Load("movies.xml");

                //  rootNode to memory
                XmlElement rootNode = xmlDoc.DocumentElement;

                //  XML nodes created for movie and its attributes
                XmlElement addMovie = xmlDoc.CreateElement("movie");
                XmlElement addTitle = xmlDoc.CreateElement("title");
                XmlElement addYear = xmlDoc.CreateElement("year");
                XmlElement addLength = xmlDoc.CreateElement("length");
                XmlElement addDirector = xmlDoc.CreateElement("director");
                XmlElement addRating = xmlDoc.CreateElement("audienceRating");
                XmlElement addImagePath = xmlDoc.CreateElement("imageFilePath");

                //  Create textNode element
                XmlText newTextNode;

                //  Set attribute for genre from (modified) TextBox
                addMovie.SetAttribute("genre", genreTextBox.Text);

                //  Use new node for (modified) title
                newTextNode = xmlDoc.CreateTextNode(titleTextBox.Text);

                //  Add inputted information to text node
                addTitle.AppendChild(newTextNode);

                //  Use new node for (modified) year
                newTextNode = xmlDoc.CreateTextNode(yearTextBox.Text);

                //  Add inputted information to text node
                addYear.AppendChild(newTextNode);

                //  Use new node for (modified) length
                newTextNode = xmlDoc.CreateTextNode(lengthTextBox.Text);

                //  Add inputted information to text node
                addLength.AppendChild(newTextNode);

                //  Use new node for (modified) director
                newTextNode = xmlDoc.CreateTextNode(directorTextBox.Text);

                //  Add inputted information to text node
                addDirector.AppendChild(newTextNode);

                //  Use new node for (modified) rating
                newTextNode = xmlDoc.CreateTextNode(ratingTextBox.Text);

                //  Add inputted information to text node
                addRating.AppendChild(newTextNode);

                //  Use new node for (modified) imagepath
                newTextNode = xmlDoc.CreateTextNode(imagePathTextBox.Text);

                //  Add inputted information to text node
                addImagePath.AppendChild(newTextNode);


                //  Send each movie attribute to addMovie node
                addMovie.AppendChild(addTitle);
                addMovie.AppendChild(addYear);
                addMovie.AppendChild(addLength);
                addMovie.AppendChild(addDirector);
                addMovie.AppendChild(addRating);
                addMovie.AppendChild(addImagePath);

                //  Send movie node to main <movies> node
                rootNode.AppendChild(addMovie);

                //  Save file
                xmlDoc.Save("movies.xml");


                //  Uses delete button function from MainForm
                //  You can delete movies from either the MainForm or InfoForm (your preference)
                var frm2 = (MainForm)this.Owner;
                if (frm2 != null)
                    frm2.deleteButton.PerformClick();

                //  Closes the current form
                this.Close();
            }
        }


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            //  Uses delete button function from MainForm
            //  You can delete movies from either the MainForm or InfoForm (your preference)
            var frm = (MainForm)this.Owner;
            if (frm != null)
                frm.deleteButton.PerformClick();

            //  Closes the current form
            this.Close();
            
        }

        private void InfoForm_Load(object sender, EventArgs e)
        {
            //  Passed selected movie image from MainForm to InfoForm
            consultMoviePictureBox.Image = MainForm.moviePicture;
        }
    }
}
