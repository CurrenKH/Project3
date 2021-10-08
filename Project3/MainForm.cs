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

            GetGenre();
            movieListView.Refresh();
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

                    //imageList1.Images.Add(Image.FromFile(existingMovie.ImagePath));


                    //  Add existingMovie to the movieList
                    movieList.Add(existingMovie);

                    //  Create ListViewItem to hold the title and year for each movie
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = existingMovie.Title;
                    lvi.SubItems.Add(existingMovie.Year.ToString());

                    movieListView.Items.Add(lvi);

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
            //  Call genre method to populate genreListBox
            GetGenre();
        }

        private void GetGenre()
        {
            //  Clear ListBox
            genreListBox.Items.Clear();

            //  
            foreach (Movie movie in movieList)
            {
                if (!genreListBox.Items.Contains(movie.Genre))
                {
                    genreListBox.Items.Add(movie.Genre);
                }
            }
        }

        private void ConsultMovieButton_Click(object sender, EventArgs e)
        {
            //  If a series is not selected in the ListBox
            if (movieListView.SelectedItems.Count == 0)
            {
                MessageBox.Show("You must select a movie from the list.");
            }
            else
            {
                //  Declare index selected from ListView to variable
                int selectedIndex = movieListView.SelectedIndices[0];

                //  Take selected item from from ListView and provide it to new form
                InfoForm consultMovie = new InfoForm(movieList[selectedIndex]);

                //  Show new form
                consultMovie.ShowDialog();
            }
        }

        private void MovieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  If an item is selected
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

                //int imageIndex = movieList.FindIndex(a => a.Title == selectedMovie);
                //moviePictureBox.Image = moviePictureBox.Images[imageIndex];
            }
        }

        private void ClearTextBoxes()
        {
            // Clear textboxes
            genreAddMovieTextBox.Text = "";
            titleAddMovieTextBox.Text = "";
            yearAddMovieTextBox.Text = "";
            lengthAddMovieTextBox.Text = "";
            directorAddMovieTextBox.Text = "";
            ratingAddMovieTextBox.Text = "";
            imagePathAddMovieTextBox.Text = "";
        }
        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            if (genreAddMovieTextBox.Text != "" || titleAddMovieTextBox.Text != "" || yearAddMovieTextBox.Text != "" || lengthAddMovieTextBox.Text != ""
                || directorAddMovieTextBox.Text != "" || ratingAddMovieTextBox.Text != "" || imagePathAddMovieTextBox.Text != "")
            {
                //  Clear ListView to prepare for new added item
                movieListView.Items.Clear();

                //  Method to append all movie nodes to the XML file
                appendNodeToXMLFile("movies.xml");

                //  Indicate what XML file to read
                readXMLFile("movies.xml");

                //  Method to clear TextBoxes
                ClearTextBoxes();

                // Set focus
                genreAddMovieTextBox.Focus();

                // Refresh genre
                GetGenre();
                //movieListView.Refresh();
            }
            else
            {
                MessageBox.Show("Not all entries are filled.");
            }
        }

        private void appendNodeToXMLFile(string filePath)
        {
            XmlDocument xmlDoc = new XmlDocument();

            if (File.Exists(filePath))
            {
                //  XML file loaded
                xmlDoc.Load(filePath);

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

                //  Set attribute for genre from TextBox
                addMovie.SetAttribute("genre", genreAddMovieTextBox.Text);

                //  Use new node for title
                newTextNode = xmlDoc.CreateTextNode(titleAddMovieTextBox.Text);

                //  Add inputted information to text node
                addTitle.AppendChild(newTextNode);

                //  Use new node for year
                newTextNode = xmlDoc.CreateTextNode(yearAddMovieTextBox.Text);

                //  Add inputted information to text node
                addYear.AppendChild(newTextNode);

                //  Use new node for length
                newTextNode = xmlDoc.CreateTextNode(lengthAddMovieTextBox.Text);

                //  Add inputted information to text node
                addLength.AppendChild(newTextNode);

                //  Use new node for director
                newTextNode = xmlDoc.CreateTextNode(directorAddMovieTextBox.Text);

                //  Add inputted information to text node
                addDirector.AppendChild(newTextNode);

                //  Use new node for director
                newTextNode = xmlDoc.CreateTextNode(ratingAddMovieTextBox.Text);

                //  Add inputted information to text node
                addRating.AppendChild(newTextNode);

                //  Use new node for director
                newTextNode = xmlDoc.CreateTextNode(imagePathAddMovieTextBox.Text);

                //  Add inputted information to text node
                addImagePath.AppendChild(newTextNode);


                //  Send each movie attribute to addMovie node
                addMovie.AppendChild(addTitle);
                addMovie.AppendChild(addYear);
                addMovie.AppendChild(addLength);
                addMovie.AppendChild(addDirector);
                addMovie.AppendChild(addRating);
                addMovie.AppendChild(addImagePath);

                //  Send movie node to main movies node
                rootNode.AppendChild(addMovie);

                //  Save file
                xmlDoc.Save(filePath);
            }
            else
            {
                MessageBox.Show("The file " + filePath + " does not exists.");
            }
        }

        private void GenreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Exeption when clicking outside ot the ListBox's index
            if (genreListBox.SelectedIndices.Count <= 0)
            {
                return;
            }

            movieListView.Items.Clear();

            string selection = genreListBox.SelectedItem.ToString();

            foreach (Movie movie in movieList)
            {
                if (movie.Genre == selection)
                {
                    movieListView.Items.Add(movie.Title);
                }

            }
        }


    }
}
