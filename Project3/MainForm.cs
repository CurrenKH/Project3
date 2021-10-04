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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            readXMLFile("movies.xml");
        }

        List<Movie> movieList = new List<Movie>();

        private void readXMLFile(string filePath)
        {
            Movie existingMovie;

            if (File.Exists(filePath))
            {
                //  XmlTextReader called
                XmlTextReader xmlReader = new XmlTextReader(filePath);

                // Move the first 'Movie' node in the XML file.
                xmlReader.ReadToFollowing("movie");

                do
                {
                    //  Create new movie object
                    existingMovie = new Movie();


                    //  Place the xmlReader at the first attribute GENRE
                    xmlReader.MoveToFirstAttribute();

                    //  Take genre attribute value and point to existingMovie.Genre
                    existingMovie.Genre = xmlReader.Value;

                    //  Place the xmlReader at the next attribute TITLE
                    xmlReader.ReadToFollowing("title");

                    //  Take title attribute value and point to existingMovie.Title
                    existingMovie.Title = xmlReader.ReadElementContentAsString();

                    //  Place the xmlReader at the next attribute YEAR
                    xmlReader.ReadToFollowing("year");

                    //  Take year attribute value and point to existingMovie.Year
                    existingMovie.Year = Int32.Parse(xmlReader.ReadElementContentAsString());

                    //  Place the xmlReader at the next attribute LENGTH
                    xmlReader.ReadToFollowing("length");

                    //  Take year attribute value and point to existingMovie.Year
                    existingMovie.Length = xmlReader.ReadElementContentAsString();

                    //  Place the xmlReader at the next attribute DIRECTOR
                    xmlReader.ReadToFollowing("director");

                    //  Take director attribute value and point to existingMovie.Director
                    existingMovie.Director = xmlReader.ReadElementContentAsString();

                    //  Place the xmlReader at the next attribute AUDIENCERATING
                    xmlReader.ReadToFollowing("audienceRating");

                    //  Take rating attribute value and point to existingMovie.Rating
                    existingMovie.Rating = decimal.Parse(xmlReader.ReadElementContentAsString());

                    //  Place the xmlReader at the next attribute IMAGEFILEPATH
                    xmlReader.ReadToFollowing("imageFilePath");

                    //  Take imagepath attribute value and point to existingMovie.ImagePath
                    existingMovie.ImagePath = xmlReader.ReadElementContentAsString();


                    //  Add existingMovie to the movieList
                    movieList.Add(existingMovie);

                    //  Create ListViewItem to hold the title and year for each movie
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = existingMovie.Title;
                    lvi.SubItems.Add(existingMovie.Year.ToString());

                    movieListView.Items.Add(lvi);

                    //  Add movie titles to ListView
                    //movieListView.Items.Add(existingMovie.Title);

                    //movieListView.Items[0].SubItems.Add(existingMovie.Year.ToString());

                    /*for (int i = 0; i < movieList.Count; i++)
                    {
                        movieListView.Items[0].SubItems.Add(existingMovie.Year.ToString());
                    }*/

                } while (xmlReader.ReadToFollowing("movie")); // Move to the next 'movie' node in the XML file

                // Close reader
                xmlReader.Close();

            }
            else
            {
                //  Error message
                MessageBox.Show(filePath + " does not exist.");
            }
        }
        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void ConsultMovieButton_Click(object sender, EventArgs e)
        {
            //  If a series is not selected in the ListBox
            if (movieListView.SelectedItems.Count < 0)
            {
                MessageBox.Show("You must select a series from the list.");
            }
            else
            {
                //  Take selected item from from ListBox and provide it to new form
                InfoForm consultMovie = new InfoForm(movieList[movieListView.SelectedIndices[0]]);

                //  Show new form
                consultMovie.ShowDialog();

                //  Method to display updated series list in ListBox
                //  DisplaySeries();
            }
        }

        private void MovieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (movieListView.SelectedItems.Count > 0)
            {
                //  Declare index selected from ListView to variable
                int selectedIndex = movieListView.SelectedIndices[0];
                Movie selectedMovie = new Movie();
                selectedMovie = movieList[selectedIndex];

                //  Show index of selected item
                titleMovieTextBox.Text = selectedMovie.Title;
                genreMovieTextBox.Text = selectedMovie.Genre;
                yearMovieTextBox.Text = selectedMovie.Year.ToString();
                lengthMovieTextBox.Text = selectedMovie.Length;
                directorMovieTextBox.Text = selectedMovie.Director;
                ratingMovieTextBox.Text = selectedMovie.Rating.ToString();
                imageMovieTextBox.Text = selectedMovie.ImagePath;
            }
        }
    }
}
