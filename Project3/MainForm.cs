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
using System.Text.RegularExpressions;

namespace Project3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            readXMLFile("movies.xml");

            UpdateListView();

            GetGenre();

            //  Set imageList1 size to prevent displayed images from being extremely small
            imageList1.ImageSize = new Size(256, 192);

            //  Disable TextBox to prevent any modifications from being done
            imagePathAddMovieTextBox.Enabled = false;
        }

        //  Declare moviePicture as null
        public static Image moviePicture = null;

        //  Declare list for movies
        public List<Movie> movieList = new List<Movie>();

        public void readXMLFile(string filePath)
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

                    try
                    {
                        imageList1.Images.Add(Image.FromFile(existingMovie.ImagePath));
                    }
                    catch
                    {
                        MessageBox.Show("Invalid file path.");
                    }

                    //  Add existingMovie to the movieList
                    movieList.Add(existingMovie);

                    //  Create ListViewItem to hold the title and year for each movie
                    //ListViewItem lvi = new ListViewItem();
                    //lvi.Text = existingMovie.Title;
                    //lvi.SubItems.Add(existingMovie.Year.ToString());

                    //movieListView.Items.Add(lvi);

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

        public void UpdateListView()
        {
            //  Clear ListView
            movieListView.Items.Clear();

            //  For each item name add it to the ListView
            for (int i = 0; i < movieList.Count; i++)
            {
                //  Create ListViewItem to hold the title and year for each movie
                ListViewItem lvi = new ListViewItem();
                lvi.Text = movieList[i].Title;  
                lvi.SubItems.Add(movieList[i].Year.ToString());

                //  Populate ListView with created lvi item
                movieListView.Items.Add(lvi);

                if (movieListView.SelectedItems.Count > 0)
                {
                    //  Set int variable to selected ListView item in array (#0)
                    int intselectedindex = movieListView.SelectedIndices[0];

                    //  String selected ListView item (movie title) as text
                    String text = movieListView.Items[intselectedindex].Text;

                    //  String variable for Regex argument (input, pattern, replacement string data)
                    string replacement = Regex.Replace(text, @"\t|\n|\r", "");

                    //  Find image index for movieList to affiliate the correct image with the selected movie
                    int imageIndex = movieList.FindIndex(a => a.Title == replacement);
                    moviePictureBox.Image = imageList1.Images[imageIndex];
                }
            }
        }

        private void GetGenre()
        {
            //  Clear ListBox
            genreListBox.Items.Clear();

            //  Foreach movie that exists in the movie list
            foreach (Movie movie in movieList)
            {
                //  Check for duplicate entries and add new ones
                if (!genreListBox.Items.Contains(movie.Genre))
                {
                    genreListBox.Items.Add(movie.Genre);
                }
            }
        }

        private void RefreshListViewData()
        {
            //  This method is used for refreshing the ListBox
            //  Whenever a movie is modified from the second form, it creates a duplicate movie
            //  and applies the necessary changes with the new version, then deletes the original copy

            //  Empty movieList
            movieList = new List<Movie>();

            //  Reread XML file
            readXMLFile("movies.xml");

            //  Update the ListView again
            UpdateListView();
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
                //  Movie image points to PictureBox
                moviePicture = moviePictureBox.Image;

                //  Declare index selected from ListView to variable
                int selectedIndex = movieListView.SelectedIndices[0];

                //  Take selected item from from ListView and provide it to new form
                InfoForm consultMovie = new InfoForm(movieList[selectedIndex]);

                //  Show new form
                consultMovie.ShowDialog(this);

                //  Refresh method
                UpdateListView();

                //  TextBox clear method
                ClearDisplayedData();


                //  Refresh data in ListView method
                RefreshListViewData();
            }
        }

        private void MovieListView_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  If an item is selected
            if (movieListView.SelectedItems.Count > 0)
            {
                //  Set int variable to selected ListView item in array (#0)
                int intselectedindex = movieListView.SelectedIndices[0];

                //  String selected ListView item (movie title) as text
                String text = movieListView.Items[intselectedindex].Text;

                //  For each movie that exists in the list
                foreach (Movie selectedMovie in movieList)
                {
                    //  Check if the selected ListView item is equal to any movie title in the list
                    if (selectedMovie.Title == text)
                    {
                        //  Show index of selected item
                        titleMovieTextBox.Text = selectedMovie.Title;
                        genreMovieTextBox.Text = selectedMovie.Genre;
                        yearMovieTextBox.Text = selectedMovie.Year.ToString();
                        lengthMovieTextBox.Text = selectedMovie.Length;
                        directorMovieTextBox.Text = selectedMovie.Director;
                        ratingMovieTextBox.Text = selectedMovie.Rating.ToString();
                        imagePathMovieTextBox.Text = selectedMovie.ImagePath;

                        //  String variable for Regex argument (input, pattern, replacement string data)
                        string replacement = Regex.Replace(text, @"\t|\n|\r", "");

                        //  Find image index for movieList to affiliate the correct image with the selected movie
                        int imageIndex = movieList.FindIndex(a => a.Title == replacement);
                        moviePictureBox.Image = imageList1.Images[imageIndex];
                    }
                }
            }
        }

        private void ClearAddTextBoxes()
        {
            // Clear textboxes
            titleAddMovieTextBox.Text = "";
            genreAddMovieTextBox.Text = "";
            yearAddMovieTextBox.Text = "";
            lengthAddMovieTextBox.Text = "";
            directorAddMovieTextBox.Text = "";
            ratingAddMovieTextBox.Text = "";
            imagePathAddMovieTextBox.Text = "";
        }

        private void ClearDisplayedData()
        {
            // Clear textboxes
            titleMovieTextBox.Text = "";
            genreMovieTextBox.Text = "";
            yearMovieTextBox.Text = "";
            lengthMovieTextBox.Text = "";
            directorMovieTextBox.Text = "";
            ratingMovieTextBox.Text = "";
            imagePathMovieTextBox.Text = "";

            //  Clear pictureBox
            moviePictureBox.Image = null;
        }

        private void AddMovieButton_Click(object sender, EventArgs e)
        {
            //  Check if any entries are empty
            if (genreAddMovieTextBox.Text != "" || titleAddMovieTextBox.Text != "" || yearAddMovieTextBox.Text != "" || lengthAddMovieTextBox.Text != ""
                || directorAddMovieTextBox.Text != "" || ratingAddMovieTextBox.Text != "" || imagePathAddMovieTextBox.Text != "")
            {
                //  Clear ListView to prepare for new added item
                movieListView.Items.Clear();

                //  Method to append all movie nodes to the XML file
                appendNodeToXMLFile("movies.xml");

                //  Empty movieList
                movieList = new List<Movie>();

                //  Indicate what XML file to read
                readXMLFile("movies.xml");

                //  Method to clear TextBoxes
                ClearAddTextBoxes();

                //  Focus genre
                genreAddMovieTextBox.Focus();

                //  Refresh genre method
                GetGenre();

                //  Update ListView method
                UpdateListView();
            }
            else
            {
                MessageBox.Show("Not all entries are filled.");
            }
        }

        private void appendNodeToXMLFile(string filePath)
        {
            //  Create XML document instance
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

                //  Send movie node to main <movies> node
                rootNode.AppendChild(addMovie);

                //  Save file
                xmlDoc.Save(filePath);
            }
            else
            {
                MessageBox.Show("The file " + filePath + " does not exist.");
            }
        }

        private void GenreListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            //  Clear information display method
            ClearDisplayedData();

            // if a ListBox item is not selected
            if (genreListBox.SelectedIndices.Count <= 0)
            {
                MessageBox.Show("Select a genre.");
            }
            else
            {
                //  Clear ListView
                movieListView.Items.Clear();
                //  Empty movieList
                movieList = new List<Movie>();
                //  Indicate what XML file to read
                readXMLFile("movies.xml");

                //  Declare string variable for selected item
                string selection = genreListBox.SelectedItem.ToString();

                foreach (Movie movie in movieList)
                {
                    //  Check if the selected genre matches the any movies with that genre
                    if (movie.Genre == selection)
                    {

                        //  Create ListViewItem to hold the title and year for each movie
                        ListViewItem lvi = new ListViewItem();
                        lvi.Text = movie.Title;
                        lvi.SubItems.Add(movie.Year.ToString());
                        movieListView.Items.Add(lvi);
                    }
                }
            }
        }



        public void DeleteNode(string filePath)
        {
            if (movieListView.SelectedItems.Count > 0)
            {
                //  int variable for selected ListView item
                int intselectedindex = movieListView.SelectedIndices[0];

                //  String ListView selected item as text
                String text = movieListView.Items[intselectedindex].Text;

                //  XML reader to match movie title with selected ListView item
                XElement objElement = XElement.Load(filePath);
                XElement delNode = objElement.Descendants("movie").Where(a => a.Element("title").Value == text).FirstOrDefault();
                delNode.Remove();
                objElement.Save(filePath);

                //  Clear ListView
                movieListView.Items.Clear();

                //  Empty movieList
                movieList = new List<Movie>();

                //  Reread XML file
                readXMLFile("movies.xml");

                //  Update the ListView again
                UpdateListView();
            }
            
        }

        public void DeleteButton_Click(object sender, EventArgs e)
        {
            //  Call method to delete movie
            DeleteNode("movies.xml");

            //  Clear information display method
            ClearDisplayedData();

            //  Refresh genre method
            GetGenre();
        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            //  Closes the form
            this.Close();
        }

        private void ResetFilterButton_Click(object sender, EventArgs e)
        {
            //  Update the ListView again
            UpdateListView();

            //  Refresh genre method
            GetGenre();
        }

        private void SelectImageButton_Click(object sender, EventArgs e)
        {
            //  Use FileDialog to search for an image to select
            OpenFileDialog openFileDialog1 = new OpenFileDialog();

            //  Set filter to only show images to select from
            openFileDialog1.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.tif;...";

            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                //  String variable for the file path and name taken from OpenFileDialog
                string selectedImagePath = openFileDialog1.FileName;

                //  Set image path TextBox by the selected file
                imagePathAddMovieTextBox.Text = selectedImagePath;
            }
        }
    }
}
