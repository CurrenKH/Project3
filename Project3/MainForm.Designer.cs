namespace Project3
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
            this.titleLabel = new System.Windows.Forms.Label();
            this.movieListView = new System.Windows.Forms.ListView();
            this.genreComboBox = new System.Windows.Forms.ComboBox();
            this.genreLabel = new System.Windows.Forms.Label();
            this.selectGenreLabel = new System.Windows.Forms.Label();
            this.addMovieLabel = new System.Windows.Forms.Label();
            this.genreAddMovieComboBox = new System.Windows.Forms.ComboBox();
            this.genreAddMovieLabel = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.titleAddMovieLabel = new System.Windows.Forms.Label();
            this.yearAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.yearAddMovieLabel = new System.Windows.Forms.Label();
            this.lengthAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.lengthAddMovieLabel = new System.Windows.Forms.Label();
            this.directorAddMovieLabel = new System.Windows.Forms.Label();
            this.directorAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.ratingAddMovieLabel = new System.Windows.Forms.Label();
            this.ratingAddMovieTextBox = new System.Windows.Forms.TextBox();
            this.imageAddMovieLabel = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.Location = new System.Drawing.Point(271, 20);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(210, 32);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "XMM Manager";
            // 
            // movieListView
            // 
            this.movieListView.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2});
            this.movieListView.HideSelection = false;
            this.movieListView.Location = new System.Drawing.Point(27, 79);
            this.movieListView.Name = "movieListView";
            this.movieListView.Size = new System.Drawing.Size(380, 448);
            this.movieListView.TabIndex = 1;
            this.movieListView.UseCompatibleStateImageBehavior = false;
            // 
            // genreComboBox
            // 
            this.genreComboBox.FormattingEnabled = true;
            this.genreComboBox.Location = new System.Drawing.Point(499, 482);
            this.genreComboBox.Name = "genreComboBox";
            this.genreComboBox.Size = new System.Drawing.Size(195, 24);
            this.genreComboBox.TabIndex = 3;
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(441, 485);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 17);
            this.genreLabel.TabIndex = 4;
            this.genreLabel.Text = "Genre:";
            // 
            // selectGenreLabel
            // 
            this.selectGenreLabel.AutoSize = true;
            this.selectGenreLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectGenreLabel.Location = new System.Drawing.Point(527, 459);
            this.selectGenreLabel.Name = "selectGenreLabel";
            this.selectGenreLabel.Size = new System.Drawing.Size(131, 20);
            this.selectGenreLabel.TabIndex = 5;
            this.selectGenreLabel.Text = "Select a genre";
            // 
            // addMovieLabel
            // 
            this.addMovieLabel.AutoSize = true;
            this.addMovieLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addMovieLabel.Location = new System.Drawing.Point(549, 64);
            this.addMovieLabel.Name = "addMovieLabel";
            this.addMovieLabel.Size = new System.Drawing.Size(96, 20);
            this.addMovieLabel.TabIndex = 6;
            this.addMovieLabel.Text = "Add Movie";
            // 
            // genreAddMovieComboBox
            // 
            this.genreAddMovieComboBox.FormattingEnabled = true;
            this.genreAddMovieComboBox.Location = new System.Drawing.Point(499, 136);
            this.genreAddMovieComboBox.Name = "genreAddMovieComboBox";
            this.genreAddMovieComboBox.Size = new System.Drawing.Size(195, 24);
            this.genreAddMovieComboBox.TabIndex = 7;
            // 
            // genreAddMovieLabel
            // 
            this.genreAddMovieLabel.AutoSize = true;
            this.genreAddMovieLabel.Location = new System.Drawing.Point(441, 139);
            this.genreAddMovieLabel.Name = "genreAddMovieLabel";
            this.genreAddMovieLabel.Size = new System.Drawing.Size(52, 17);
            this.genreAddMovieLabel.TabIndex = 8;
            this.genreAddMovieLabel.Text = "Genre:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(499, 99);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(195, 22);
            this.textBox1.TabIndex = 9;
            // 
            // titleAddMovieLabel
            // 
            this.titleAddMovieLabel.AutoSize = true;
            this.titleAddMovieLabel.Location = new System.Drawing.Point(454, 102);
            this.titleAddMovieLabel.Name = "titleAddMovieLabel";
            this.titleAddMovieLabel.Size = new System.Drawing.Size(39, 17);
            this.titleAddMovieLabel.TabIndex = 10;
            this.titleAddMovieLabel.Text = "Title:";
            // 
            // yearAddMovieTextBox
            // 
            this.yearAddMovieTextBox.Location = new System.Drawing.Point(499, 175);
            this.yearAddMovieTextBox.Name = "yearAddMovieTextBox";
            this.yearAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.yearAddMovieTextBox.TabIndex = 11;
            // 
            // yearAddMovieLabel
            // 
            this.yearAddMovieLabel.AutoSize = true;
            this.yearAddMovieLabel.Location = new System.Drawing.Point(451, 178);
            this.yearAddMovieLabel.Name = "yearAddMovieLabel";
            this.yearAddMovieLabel.Size = new System.Drawing.Size(42, 17);
            this.yearAddMovieLabel.TabIndex = 12;
            this.yearAddMovieLabel.Text = "Year:";
            // 
            // lengthAddMovieTextBox
            // 
            this.lengthAddMovieTextBox.Location = new System.Drawing.Point(499, 212);
            this.lengthAddMovieTextBox.Name = "lengthAddMovieTextBox";
            this.lengthAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.lengthAddMovieTextBox.TabIndex = 13;
            // 
            // lengthAddMovieLabel
            // 
            this.lengthAddMovieLabel.AutoSize = true;
            this.lengthAddMovieLabel.Location = new System.Drawing.Point(437, 215);
            this.lengthAddMovieLabel.Name = "lengthAddMovieLabel";
            this.lengthAddMovieLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthAddMovieLabel.TabIndex = 14;
            this.lengthAddMovieLabel.Text = "Length:";
            // 
            // directorAddMovieLabel
            // 
            this.directorAddMovieLabel.AutoSize = true;
            this.directorAddMovieLabel.Location = new System.Drawing.Point(431, 253);
            this.directorAddMovieLabel.Name = "directorAddMovieLabel";
            this.directorAddMovieLabel.Size = new System.Drawing.Size(62, 17);
            this.directorAddMovieLabel.TabIndex = 15;
            this.directorAddMovieLabel.Text = "Director:";
            // 
            // directorAddMovieTextBox
            // 
            this.directorAddMovieTextBox.Location = new System.Drawing.Point(499, 250);
            this.directorAddMovieTextBox.Name = "directorAddMovieTextBox";
            this.directorAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.directorAddMovieTextBox.TabIndex = 16;
            // 
            // ratingAddMovieLabel
            // 
            this.ratingAddMovieLabel.AutoSize = true;
            this.ratingAddMovieLabel.Location = new System.Drawing.Point(437, 290);
            this.ratingAddMovieLabel.Name = "ratingAddMovieLabel";
            this.ratingAddMovieLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingAddMovieLabel.TabIndex = 17;
            this.ratingAddMovieLabel.Text = "Rating:";
            // 
            // ratingAddMovieTextBox
            // 
            this.ratingAddMovieTextBox.Location = new System.Drawing.Point(499, 287);
            this.ratingAddMovieTextBox.Name = "ratingAddMovieTextBox";
            this.ratingAddMovieTextBox.Size = new System.Drawing.Size(195, 22);
            this.ratingAddMovieTextBox.TabIndex = 18;
            // 
            // imageAddMovieLabel
            // 
            this.imageAddMovieLabel.AutoSize = true;
            this.imageAddMovieLabel.Location = new System.Drawing.Point(443, 329);
            this.imageAddMovieLabel.Name = "imageAddMovieLabel";
            this.imageAddMovieLabel.Size = new System.Drawing.Size(50, 17);
            this.imageAddMovieLabel.TabIndex = 20;
            this.imageAddMovieLabel.Text = "Image:";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(434, 361);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 63);
            this.button1.TabIndex = 22;
            this.button1.Text = "Consult Movie";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(579, 361);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(139, 63);
            this.button2.TabIndex = 23;
            this.button2.Text = "Add Movie";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(499, 315);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(195, 40);
            this.button3.TabIndex = 24;
            this.button3.Text = "select image";
            this.button3.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(730, 558);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.imageAddMovieLabel);
            this.Controls.Add(this.ratingAddMovieTextBox);
            this.Controls.Add(this.ratingAddMovieLabel);
            this.Controls.Add(this.directorAddMovieTextBox);
            this.Controls.Add(this.directorAddMovieLabel);
            this.Controls.Add(this.lengthAddMovieLabel);
            this.Controls.Add(this.lengthAddMovieTextBox);
            this.Controls.Add(this.yearAddMovieLabel);
            this.Controls.Add(this.yearAddMovieTextBox);
            this.Controls.Add(this.titleAddMovieLabel);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.genreAddMovieLabel);
            this.Controls.Add(this.genreAddMovieComboBox);
            this.Controls.Add(this.addMovieLabel);
            this.Controls.Add(this.selectGenreLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.genreComboBox);
            this.Controls.Add(this.movieListView);
            this.Controls.Add(this.titleLabel);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.ListView movieListView;
        private System.Windows.Forms.ComboBox genreComboBox;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label selectGenreLabel;
        private System.Windows.Forms.Label addMovieLabel;
        private System.Windows.Forms.ComboBox genreAddMovieComboBox;
        private System.Windows.Forms.Label genreAddMovieLabel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label titleAddMovieLabel;
        private System.Windows.Forms.TextBox yearAddMovieTextBox;
        private System.Windows.Forms.Label yearAddMovieLabel;
        private System.Windows.Forms.TextBox lengthAddMovieTextBox;
        private System.Windows.Forms.Label lengthAddMovieLabel;
        private System.Windows.Forms.Label directorAddMovieLabel;
        private System.Windows.Forms.TextBox directorAddMovieTextBox;
        private System.Windows.Forms.Label ratingAddMovieLabel;
        private System.Windows.Forms.TextBox ratingAddMovieTextBox;
        private System.Windows.Forms.Label imageAddMovieLabel;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
    }
}

