﻿namespace Project3
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.titleLabel = new System.Windows.Forms.Label();
            this.movieListView = new System.Windows.Forms.ListView();
            this.columnTitle = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnYear = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.imageMovieLabel = new System.Windows.Forms.Label();
            this.ratingMovieTextBox = new System.Windows.Forms.TextBox();
            this.ratingMovieLabel = new System.Windows.Forms.Label();
            this.directorMovieTextBox = new System.Windows.Forms.TextBox();
            this.directorMovieLabel = new System.Windows.Forms.Label();
            this.lengthMovieLabel = new System.Windows.Forms.Label();
            this.lengthMovieTextBox = new System.Windows.Forms.TextBox();
            this.yearMovieLabel = new System.Windows.Forms.Label();
            this.yearMovieTextBox = new System.Windows.Forms.TextBox();
            this.titleMovieLabel = new System.Windows.Forms.Label();
            this.titleMovieTextBox = new System.Windows.Forms.TextBox();
            this.genreMovieLabel = new System.Windows.Forms.Label();
            this.movieInfoLabel = new System.Windows.Forms.Label();
            this.genreMovieTextBox = new System.Windows.Forms.TextBox();
            this.imagePathMovieTextBox = new System.Windows.Forms.TextBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.selectGenreLabel = new System.Windows.Forms.Label();
            this.addMovieLabel = new System.Windows.Forms.Label();
            this.genreAddMovieLabel = new System.Windows.Forms.Label();
            this.titleAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.titleAddMovieLabel = new System.Windows.Forms.Label();
            this.yearAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.yearAddMovieLabel = new System.Windows.Forms.Label();
            this.lengthAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.lengthAddMovieLabel = new System.Windows.Forms.Label();
            this.directorAddMovieLabel = new System.Windows.Forms.Label();
            this.directorAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.ratingAddMovieLabel = new System.Windows.Forms.Label();
            this.ratingAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.consultMovieButton = new System.Windows.Forms.Button();
            this.addMovieButton = new System.Windows.Forms.Button();
            this.movieListViewTitleLabel = new System.Windows.Forms.Label();
            this.genreAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.imagePathAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.genreListBox = new System.Windows.Forms.ListBox();
            this.moviePictureBox = new System.Windows.Forms.PictureBox();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.imageAddMovieLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.resetFilterButton = new System.Windows.Forms.Button();
            this.consultInfoLabel = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.selectImageButton = new System.Windows.Forms.Button();
            this.formatInfoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(560, 9);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(292, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "XML Movie Manager";
            // 
            // movieListView
            // 
            this.movieListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnTitle,
            this.columnYear});
            this.movieListView.FullRowSelect = true;
            this.movieListView.HideSelection = false;
            this.movieListView.Location = new System.Drawing.Point(12, 78);
            this.movieListView.Name = "movieListView";
            this.movieListView.Size = new System.Drawing.Size(380, 448);
            this.movieListView.TabIndex = 1;
            this.movieListView.UseCompatibleStateImageBehavior = false;
            this.movieListView.View = System.Windows.Forms.View.Details;
            this.movieListView.SelectedIndexChanged += new System.EventHandler(this.MovieListView_SelectedIndexChanged);
            // 
            // columnTitle
            // 
            this.columnTitle.Text = "Title";
            this.columnTitle.Width = 180;
            // 
            // columnYear
            // 
            this.columnYear.Text = "Year";
            // 
            // imageMovieLabel
            // 
            this.imageMovieLabel.AutoSize = true;
            this.imageMovieLabel.Location = new System.Drawing.Point(406, 343);
            this.imageMovieLabel.Name = "imageMovieLabel";
            this.imageMovieLabel.Size = new System.Drawing.Size(83, 17);
            this.imageMovieLabel.TabIndex = 41;
            this.imageMovieLabel.Text = "Image Path:";
            // 
            // ratingMovieTextBox
            // 
            this.ratingMovieTextBox.Location = new System.Drawing.Point(495, 301);
            this.ratingMovieTextBox.Name = "ratingMovieTextBox";
            this.ratingMovieTextBox.ReadOnly = true;
            this.ratingMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.ratingMovieTextBox.TabIndex = 40;
            // 
            // ratingMovieLabel
            // 
            this.ratingMovieLabel.AutoSize = true;
            this.ratingMovieLabel.Location = new System.Drawing.Point(436, 304);
            this.ratingMovieLabel.Name = "ratingMovieLabel";
            this.ratingMovieLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingMovieLabel.TabIndex = 39;
            this.ratingMovieLabel.Text = "Rating:";
            // 
            // directorMovieTextBox
            // 
            this.directorMovieTextBox.Location = new System.Drawing.Point(495, 264);
            this.directorMovieTextBox.Name = "directorMovieTextBox";
            this.directorMovieTextBox.ReadOnly = true;
            this.directorMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.directorMovieTextBox.TabIndex = 38;
            // 
            // directorMovieLabel
            // 
            this.directorMovieLabel.AutoSize = true;
            this.directorMovieLabel.Location = new System.Drawing.Point(427, 267);
            this.directorMovieLabel.Name = "directorMovieLabel";
            this.directorMovieLabel.Size = new System.Drawing.Size(62, 17);
            this.directorMovieLabel.TabIndex = 37;
            this.directorMovieLabel.Text = "Director:";
            // 
            // lengthMovieLabel
            // 
            this.lengthMovieLabel.AutoSize = true;
            this.lengthMovieLabel.Location = new System.Drawing.Point(433, 229);
            this.lengthMovieLabel.Name = "lengthMovieLabel";
            this.lengthMovieLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthMovieLabel.TabIndex = 36;
            this.lengthMovieLabel.Text = "Length:";
            // 
            // lengthMovieTextBox
            // 
            this.lengthMovieTextBox.Location = new System.Drawing.Point(495, 226);
            this.lengthMovieTextBox.Name = "lengthMovieTextBox";
            this.lengthMovieTextBox.ReadOnly = true;
            this.lengthMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.lengthMovieTextBox.TabIndex = 35;
            // 
            // yearMovieLabel
            // 
            this.yearMovieLabel.AutoSize = true;
            this.yearMovieLabel.Location = new System.Drawing.Point(447, 192);
            this.yearMovieLabel.Name = "yearMovieLabel";
            this.yearMovieLabel.Size = new System.Drawing.Size(42, 17);
            this.yearMovieLabel.TabIndex = 34;
            this.yearMovieLabel.Text = "Year:";
            // 
            // yearMovieTextBox
            // 
            this.yearMovieTextBox.Location = new System.Drawing.Point(495, 189);
            this.yearMovieTextBox.Name = "yearMovieTextBox";
            this.yearMovieTextBox.ReadOnly = true;
            this.yearMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.yearMovieTextBox.TabIndex = 33;
            // 
            // titleMovieLabel
            // 
            this.titleMovieLabel.AutoSize = true;
            this.titleMovieLabel.Location = new System.Drawing.Point(450, 116);
            this.titleMovieLabel.Name = "titleMovieLabel";
            this.titleMovieLabel.Size = new System.Drawing.Size(39, 17);
            this.titleMovieLabel.TabIndex = 32;
            this.titleMovieLabel.Text = "Title:";
            // 
            // titleMovieTextBox
            // 
            this.titleMovieTextBox.Location = new System.Drawing.Point(495, 113);
            this.titleMovieTextBox.Name = "titleMovieTextBox";
            this.titleMovieTextBox.ReadOnly = true;
            this.titleMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.titleMovieTextBox.TabIndex = 31;
            // 
            // genreMovieLabel
            // 
            this.genreMovieLabel.AutoSize = true;
            this.genreMovieLabel.Location = new System.Drawing.Point(437, 153);
            this.genreMovieLabel.Name = "genreMovieLabel";
            this.genreMovieLabel.Size = new System.Drawing.Size(52, 17);
            this.genreMovieLabel.TabIndex = 30;
            this.genreMovieLabel.Text = "Genre:";
            // 
            // movieInfoLabel
            // 
            this.movieInfoLabel.AutoSize = true;
            this.movieInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieInfoLabel.Location = new System.Drawing.Point(545, 78);
            this.movieInfoLabel.Name = "movieInfoLabel";
            this.movieInfoLabel.Size = new System.Drawing.Size(95, 20);
            this.movieInfoLabel.TabIndex = 28;
            this.movieInfoLabel.Text = "Movie Info";
            // 
            // genreMovieTextBox
            // 
            this.genreMovieTextBox.Location = new System.Drawing.Point(495, 150);
            this.genreMovieTextBox.Name = "genreMovieTextBox";
            this.genreMovieTextBox.ReadOnly = true;
            this.genreMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.genreMovieTextBox.TabIndex = 45;
            // 
            // imagePathMovieTextBox
            // 
            this.imagePathMovieTextBox.Location = new System.Drawing.Point(495, 340);
            this.imagePathMovieTextBox.Name = "imagePathMovieTextBox";
            this.imagePathMovieTextBox.ReadOnly = true;
            this.imagePathMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.imagePathMovieTextBox.TabIndex = 46;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(437, 406);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 17);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre:";
            // 
            // selectGenreLabel
            // 
            this.selectGenreLabel.AutoSize = true;
            this.selectGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGenreLabel.Location = new System.Drawing.Point(523, 380);
            this.selectGenreLabel.Name = "selectGenreLabel";
            this.selectGenreLabel.Size = new System.Drawing.Size(131, 20);
            this.selectGenreLabel.TabIndex = 5;
            this.selectGenreLabel.Text = "Select a genre";
            // 
            // addMovieLabel
            // 
            this.addMovieLabel.AutoSize = true;
            this.addMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieLabel.Location = new System.Drawing.Point(1147, 78);
            this.addMovieLabel.Name = "addMovieLabel";
            this.addMovieLabel.Size = new System.Drawing.Size(96, 20);
            this.addMovieLabel.TabIndex = 6;
            this.addMovieLabel.Text = "Add Movie";
            // 
            // genreAddMovieLabel
            // 
            this.genreAddMovieLabel.AutoSize = true;
            this.genreAddMovieLabel.Location = new System.Drawing.Point(1039, 151);
            this.genreAddMovieLabel.Name = "genreAddMovieLabel";
            this.genreAddMovieLabel.Size = new System.Drawing.Size(52, 17);
            this.genreAddMovieLabel.TabIndex = 8;
            this.genreAddMovieLabel.Text = "Genre:";
            // 
            // titleAddMovieTextBox
            // 
            this.titleAddMovieTextBox.Location = new System.Drawing.Point(1097, 111);
            this.titleAddMovieTextBox.Name = "titleAddMovieTextBox";
            this.titleAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.titleAddMovieTextBox.TabIndex = 9;
            // 
            // titleAddMovieLabel
            // 
            this.titleAddMovieLabel.AutoSize = true;
            this.titleAddMovieLabel.Location = new System.Drawing.Point(1052, 114);
            this.titleAddMovieLabel.Name = "titleAddMovieLabel";
            this.titleAddMovieLabel.Size = new System.Drawing.Size(39, 17);
            this.titleAddMovieLabel.TabIndex = 10;
            this.titleAddMovieLabel.Text = "Title:";
            // 
            // yearAddMovieTextBox
            // 
            this.yearAddMovieTextBox.Location = new System.Drawing.Point(1097, 187);
            this.yearAddMovieTextBox.Name = "yearAddMovieTextBox";
            this.yearAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.yearAddMovieTextBox.TabIndex = 11;
            // 
            // yearAddMovieLabel
            // 
            this.yearAddMovieLabel.AutoSize = true;
            this.yearAddMovieLabel.Location = new System.Drawing.Point(1049, 190);
            this.yearAddMovieLabel.Name = "yearAddMovieLabel";
            this.yearAddMovieLabel.Size = new System.Drawing.Size(42, 17);
            this.yearAddMovieLabel.TabIndex = 12;
            this.yearAddMovieLabel.Text = "Year:";
            // 
            // lengthAddMovieTextBox
            // 
            this.lengthAddMovieTextBox.Location = new System.Drawing.Point(1097, 224);
            this.lengthAddMovieTextBox.Name = "lengthAddMovieTextBox";
            this.lengthAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.lengthAddMovieTextBox.TabIndex = 13;
            // 
            // lengthAddMovieLabel
            // 
            this.lengthAddMovieLabel.AutoSize = true;
            this.lengthAddMovieLabel.Location = new System.Drawing.Point(1035, 227);
            this.lengthAddMovieLabel.Name = "lengthAddMovieLabel";
            this.lengthAddMovieLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthAddMovieLabel.TabIndex = 14;
            this.lengthAddMovieLabel.Text = "Length:";
            // 
            // directorAddMovieLabel
            // 
            this.directorAddMovieLabel.AutoSize = true;
            this.directorAddMovieLabel.Location = new System.Drawing.Point(1029, 265);
            this.directorAddMovieLabel.Name = "directorAddMovieLabel";
            this.directorAddMovieLabel.Size = new System.Drawing.Size(62, 17);
            this.directorAddMovieLabel.TabIndex = 15;
            this.directorAddMovieLabel.Text = "Director:";
            // 
            // directorAddMovieTextBox
            // 
            this.directorAddMovieTextBox.Location = new System.Drawing.Point(1097, 262);
            this.directorAddMovieTextBox.Name = "directorAddMovieTextBox";
            this.directorAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.directorAddMovieTextBox.TabIndex = 16;
            // 
            // ratingAddMovieLabel
            // 
            this.ratingAddMovieLabel.AutoSize = true;
            this.ratingAddMovieLabel.Location = new System.Drawing.Point(1035, 302);
            this.ratingAddMovieLabel.Name = "ratingAddMovieLabel";
            this.ratingAddMovieLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingAddMovieLabel.TabIndex = 17;
            this.ratingAddMovieLabel.Text = "Rating:";
            // 
            // ratingAddMovieTextBox
            // 
            this.ratingAddMovieTextBox.Location = new System.Drawing.Point(1097, 299);
            this.ratingAddMovieTextBox.Name = "ratingAddMovieTextBox";
            this.ratingAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.ratingAddMovieTextBox.TabIndex = 18;
            // 
            // consultMovieButton
            // 
            this.consultMovieButton.Location = new System.Drawing.Point(1032, 406);
            this.consultMovieButton.Name = "consultMovieButton";
            this.consultMovieButton.Size = new System.Drawing.Size(139, 63);
            this.consultMovieButton.TabIndex = 22;
            this.consultMovieButton.Text = "Consult Movie";
            this.consultMovieButton.UseVisualStyleBackColor = true;
            this.consultMovieButton.Click += new System.EventHandler(this.ConsultMovieButton_Click);
            // 
            // addMovieButton
            // 
            this.addMovieButton.Location = new System.Drawing.Point(1177, 406);
            this.addMovieButton.Name = "addMovieButton";
            this.addMovieButton.Size = new System.Drawing.Size(139, 63);
            this.addMovieButton.TabIndex = 23;
            this.addMovieButton.Text = "Add Movie";
            this.addMovieButton.UseVisualStyleBackColor = true;
            this.addMovieButton.Click += new System.EventHandler(this.AddMovieButton_Click);
            // 
            // movieListViewTitleLabel
            // 
            this.movieListViewTitleLabel.AutoSize = true;
            this.movieListViewTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieListViewTitleLabel.Location = new System.Drawing.Point(156, 44);
            this.movieListViewTitleLabel.Name = "movieListViewTitleLabel";
            this.movieListViewTitleLabel.Size = new System.Drawing.Size(111, 32);
            this.movieListViewTitleLabel.TabIndex = 47;
            this.movieListViewTitleLabel.Text = "Movies";
            // 
            // genreAddMovieTextBox
            // 
            this.genreAddMovieTextBox.Location = new System.Drawing.Point(1097, 148);
            this.genreAddMovieTextBox.Name = "genreAddMovieTextBox";
            this.genreAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.genreAddMovieTextBox.TabIndex = 48;
            // 
            // imagePathAddMovieTextBox
            // 
            this.imagePathAddMovieTextBox.Location = new System.Drawing.Point(1097, 355);
            this.imagePathAddMovieTextBox.Name = "imagePathAddMovieTextBox";
            this.imagePathAddMovieTextBox.ReadOnly = true;
            this.imagePathAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.imagePathAddMovieTextBox.TabIndex = 49;
            // 
            // genreListBox
            // 
            this.genreListBox.FormattingEnabled = true;
            this.genreListBox.ItemHeight = 16;
            this.genreListBox.Location = new System.Drawing.Point(485, 406);
            this.genreListBox.Name = "genreListBox";
            this.genreListBox.Size = new System.Drawing.Size(205, 132);
            this.genreListBox.TabIndex = 50;
            this.genreListBox.SelectedIndexChanged += new System.EventHandler(this.GenreListBox_SelectedIndexChanged);
            // 
            // moviePictureBox
            // 
            this.moviePictureBox.Location = new System.Drawing.Point(700, 78);
            this.moviePictureBox.Name = "moviePictureBox";
            this.moviePictureBox.Size = new System.Drawing.Size(300, 400);
            this.moviePictureBox.TabIndex = 51;
            this.moviePictureBox.TabStop = false;
            // 
            // imageList1
            // 
            this.imageList1.ColorDepth = System.Windows.Forms.ColorDepth.Depth8Bit;
            this.imageList1.ImageSize = new System.Drawing.Size(16, 16);
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            // 
            // imageAddMovieLabel
            // 
            this.imageAddMovieLabel.AutoSize = true;
            this.imageAddMovieLabel.Location = new System.Drawing.Point(1008, 358);
            this.imageAddMovieLabel.Name = "imageAddMovieLabel";
            this.imageAddMovieLabel.Size = new System.Drawing.Size(83, 17);
            this.imageAddMovieLabel.TabIndex = 52;
            this.imageAddMovieLabel.Text = "Image Path:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(1032, 475);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(139, 63);
            this.deleteButton.TabIndex = 53;
            this.deleteButton.Text = "Delete Movie";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(1177, 475);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(139, 63);
            this.exitButton.TabIndex = 54;
            this.exitButton.Text = "Exit";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // resetFilterButton
            // 
            this.resetFilterButton.Location = new System.Drawing.Point(724, 502);
            this.resetFilterButton.Name = "resetFilterButton";
            this.resetFilterButton.Size = new System.Drawing.Size(117, 36);
            this.resetFilterButton.TabIndex = 55;
            this.resetFilterButton.Text = "Reset Filter";
            this.resetFilterButton.UseVisualStyleBackColor = true;
            this.resetFilterButton.Click += new System.EventHandler(this.ResetFilterButton_Click);
            // 
            // consultInfoLabel
            // 
            this.consultInfoLabel.AutoSize = true;
            this.consultInfoLabel.Location = new System.Drawing.Point(696, 481);
            this.consultInfoLabel.Name = "consultInfoLabel";
            this.consultInfoLabel.Size = new System.Drawing.Size(191, 17);
            this.consultInfoLabel.TabIndex = 56;
            this.consultInfoLabel.Text = "Use before consulting movie.";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // selectImageButton
            // 
            this.selectImageButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectImageButton.Location = new System.Drawing.Point(1298, 340);
            this.selectImageButton.Name = "selectImageButton";
            this.selectImageButton.Size = new System.Drawing.Size(48, 42);
            this.selectImageButton.TabIndex = 58;
            this.selectImageButton.Text = "...";
            this.selectImageButton.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.selectImageButton.UseVisualStyleBackColor = true;
            this.selectImageButton.Click += new System.EventHandler(this.SelectImageButton_Click);
            // 
            // formatInfoLabel
            // 
            this.formatInfoLabel.AutoSize = true;
            this.formatInfoLabel.Location = new System.Drawing.Point(1094, 335);
            this.formatInfoLabel.Name = "formatInfoLabel";
            this.formatInfoLabel.Size = new System.Drawing.Size(211, 17);
            this.formatInfoLabel.TabIndex = 57;
            this.formatInfoLabel.Text = "Click button to browse Directory.";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1350, 564);
            this.Controls.Add(this.selectImageButton);
            this.Controls.Add(this.formatInfoLabel);
            this.Controls.Add(this.consultInfoLabel);
            this.Controls.Add(this.resetFilterButton);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.imageAddMovieLabel);
            this.Controls.Add(this.moviePictureBox);
            this.Controls.Add(this.genreListBox);
            this.Controls.Add(this.imagePathAddMovieTextBox);
            this.Controls.Add(this.genreAddMovieTextBox);
            this.Controls.Add(this.movieListViewTitleLabel);
            this.Controls.Add(this.imagePathMovieTextBox);
            this.Controls.Add(this.genreMovieTextBox);
            this.Controls.Add(this.imageMovieLabel);
            this.Controls.Add(this.ratingMovieTextBox);
            this.Controls.Add(this.ratingMovieLabel);
            this.Controls.Add(this.directorMovieTextBox);
            this.Controls.Add(this.directorMovieLabel);
            this.Controls.Add(this.lengthMovieLabel);
            this.Controls.Add(this.lengthMovieTextBox);
            this.Controls.Add(this.yearMovieLabel);
            this.Controls.Add(this.yearMovieTextBox);
            this.Controls.Add(this.titleMovieLabel);
            this.Controls.Add(this.titleMovieTextBox);
            this.Controls.Add(this.genreMovieLabel);
            this.Controls.Add(this.movieInfoLabel);
            this.Controls.Add(this.addMovieButton);
            this.Controls.Add(this.consultMovieButton);
            this.Controls.Add(this.ratingAddMovieTextBox);
            this.Controls.Add(this.ratingAddMovieLabel);
            this.Controls.Add(this.directorAddMovieTextBox);
            this.Controls.Add(this.directorAddMovieLabel);
            this.Controls.Add(this.lengthAddMovieLabel);
            this.Controls.Add(this.lengthAddMovieTextBox);
            this.Controls.Add(this.yearAddMovieLabel);
            this.Controls.Add(this.yearAddMovieTextBox);
            this.Controls.Add(this.titleAddMovieLabel);
            this.Controls.Add(this.titleAddMovieTextBox);
            this.Controls.Add(this.genreAddMovieLabel);
            this.Controls.Add(this.addMovieLabel);
            this.Controls.Add(this.selectGenreLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.movieListView);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            ((System.ComponentModel.ISupportInitialize)(this.moviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label imageMovieLabel;
        private System.Windows.Forms.TextBox ratingMovieTextBox;
        private System.Windows.Forms.Label ratingMovieLabel;
        private System.Windows.Forms.TextBox directorMovieTextBox;
        private System.Windows.Forms.Label directorMovieLabel;
        private System.Windows.Forms.Label lengthMovieLabel;
        private System.Windows.Forms.TextBox lengthMovieTextBox;
        private System.Windows.Forms.Label yearMovieLabel;
        private System.Windows.Forms.TextBox yearMovieTextBox;
        private System.Windows.Forms.Label titleMovieLabel;
        private System.Windows.Forms.Label genreMovieLabel;
        private System.Windows.Forms.Label movieInfoLabel;
        private System.Windows.Forms.TextBox genreMovieTextBox;
        private System.Windows.Forms.TextBox imagePathMovieTextBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label selectGenreLabel;
        private System.Windows.Forms.Label addMovieLabel;
        private System.Windows.Forms.Label genreAddMovieLabel;
        private System.Windows.Forms.TextBox titleAddMovieTextBox;
        private System.Windows.Forms.Label titleAddMovieLabel;
        private System.Windows.Forms.TextBox yearAddMovieTextBox;
        private System.Windows.Forms.Label yearAddMovieLabel;
        private System.Windows.Forms.TextBox lengthAddMovieTextBox;
        private System.Windows.Forms.Label lengthAddMovieLabel;
        private System.Windows.Forms.Label directorAddMovieLabel;
        private System.Windows.Forms.TextBox directorAddMovieTextBox;
        private System.Windows.Forms.Label ratingAddMovieLabel;
        private System.Windows.Forms.TextBox ratingAddMovieTextBox;
        private System.Windows.Forms.Button consultMovieButton;
        private System.Windows.Forms.Button addMovieButton;
        private System.Windows.Forms.Label movieListViewTitleLabel;
        private System.Windows.Forms.ColumnHeader columnTitle;
        private System.Windows.Forms.ColumnHeader columnYear;
        private System.Windows.Forms.TextBox genreAddMovieTextBox;
        private System.Windows.Forms.TextBox imagePathAddMovieTextBox;
        private System.Windows.Forms.ListBox genreListBox;
        private System.Windows.Forms.PictureBox moviePictureBox;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label imageAddMovieLabel;
        public System.Windows.Forms.ListView movieListView;
        public System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Button resetFilterButton;
        private System.Windows.Forms.Label consultInfoLabel;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button selectImageButton;
        private System.Windows.Forms.Label formatInfoLabel;
        private System.Windows.Forms.TextBox titleMovieTextBox;
    }
}

