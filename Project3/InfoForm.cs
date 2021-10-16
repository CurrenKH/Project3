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

        ///  <summary>
        /// 
        ///  Builds form
        /// 
        ///  </summary>
        public InfoForm(Movie selectedMovie)
        {
            InitializeComponent();

            ModifiedMovie = selectedMovie;

            //  Show selected movie info in the TextBoxes
            DisplayInfo();

            //  Disable TextBox to prevent any modifications from being done
            imagePathTextBox.Enabled = false;
        }

        ///  <summary>
        /// 
        ///  Method that displays selected movie info from the MainForm to
        ///  the proper TextBoxes on this form
        ///  
        ///  </summary>
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

        /// <summary>
        /// 
        ///  Method that rewrites selected movie info according to
        ///  the data entered in each TextBox
        ///  
        /// </summary>
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

        ///  <summary>
        /// 
        ///  Method that undos TextBoxes in case of any inproper entry
        ///  
        ///  </summary>
        private void UndoTextBoxes()
        {
            //  Revert TextBoxes to it's original value in case of an input error
            titleTextBox.Undo();
            genreTextBox.Undo();
            yearTextBox.Undo();
            lengthTextBox.Undo();
            directorTextBox.Undo();
            ratingTextBox.Undo();
            imagePathTextBox.Undo();
        }


        ///  <summary>
        ///  
        ///  Checks user inputs then saves modifications made and closes the form
        ///  
        ///  </summary>
        ///  <param name="sender"></param>
        ///  <param name="e"></param>
        private void ModifyButton_Click(object sender, EventArgs e)
        {
            //  Declare int variable for integer checking
            int num = -1;

            //  Create array of TextBoxes
            var textBoxCollection = new[] { genreTextBox, titleTextBox, yearTextBox, lengthTextBox,
            directorTextBox, ratingTextBox, imagePathTextBox};

            //  Declare boolean value to use for array
            bool atleastOneTextboxEmpty;

            //  Check if any TextBoxes are empty within the array
            if (atleastOneTextboxEmpty = textBoxCollection.Any(t => String.IsNullOrWhiteSpace(t.Text)))
            {
                //  Show error message
                MessageBox.Show("Not all entries are filled. Reconsult movie and use proper inputs if you wish to make any changes.");

                //  Revert TextBox method
                UndoTextBoxes();

            }
            if (!int.TryParse(yearTextBox.Text, out num))
            {
                //  Show error message
                MessageBox.Show("Invalid year input, use an integer instead. Reconsult movie and use proper inputs if you wish to make any changes.");

                //  Undo TextBox
                yearTextBox.Undo();
            }
            if (!int.TryParse(ratingTextBox.Text, out num))
            {
                //  Show error message
                MessageBox.Show("Invalid rating input, use an integer instead. Reconsult movie and use proper inputs if you wish to make any changes.");

                //  Undo TextBox
                ratingTextBox.Undo();
            }
            try
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
            catch (Exception ex)
            {
                //  Display an error message.
                MessageBox.Show(ex.Message);
            }
        }

        ///  <summary>
        ///  
        ///  Deletes selected movie and closes the form
        ///  
        ///  </summary>
        ///  <param name="sender"></param>
        ///  <param name="e"></param>
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

        ///  <summary>
        ///  
        ///  Takes current image displayed from MainForm and displays it here too
        ///  
        ///  </summary>
        ///  <param name="sender"></param>
        ///  <param name="e"></param>
        private void InfoForm_Load(object sender, EventArgs e)
        {
            //  Passed selected movie image from MainForm to InfoForm
            consultMoviePictureBox.Image = MainForm.moviePicture;
        }

        ///  <summary>
        /// 
        ///  Uses OpenFileDialog to select an image file from your PC
        /// 
        ///  </summary>
        ///  <param name="sender"></param>
        ///  <param name="e"></param>
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
                imagePathTextBox.Text = selectedImagePath;
            }
        }
    }
}
