namespace Project3
{
    partial class InfoForm
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
            this.consultMoviePictureBox = new System.Windows.Forms.PictureBox();
            this.movieInfoLabel = new System.Windows.Forms.Label();
            this.titleLabel = new System.Windows.Forms.Label();
            this.genreLabel = new System.Windows.Forms.Label();
            this.yearLabel = new System.Windows.Forms.Label();
            this.lengthLabel = new System.Windows.Forms.Label();
            this.directorLabel = new System.Windows.Forms.Label();
            this.ratingLabel = new System.Windows.Forms.Label();
            this.titleTextBox = new System.Windows.Forms.TextBox();
            this.yearTextBox = new System.Windows.Forms.TextBox();
            this.lengthTextBox = new System.Windows.Forms.TextBox();
            this.directorTextBox = new System.Windows.Forms.TextBox();
            this.ratingTextBox = new System.Windows.Forms.TextBox();
            this.modifyButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.imageAddMovieLabel = new System.Windows.Forms.Label();
            this.genreTextBox = new System.Windows.Forms.TextBox();
            this.imagePathTextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.consultMoviePictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // consultMoviePictureBox
            // 
            this.consultMoviePictureBox.Location = new System.Drawing.Point(12, 62);
            this.consultMoviePictureBox.Name = "consultMoviePictureBox";
            this.consultMoviePictureBox.Size = new System.Drawing.Size(300, 400);
            this.consultMoviePictureBox.TabIndex = 0;
            this.consultMoviePictureBox.TabStop = false;
            // 
            // movieInfoLabel
            // 
            this.movieInfoLabel.AutoSize = true;
            this.movieInfoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.movieInfoLabel.Location = new System.Drawing.Point(233, 9);
            this.movieInfoLabel.Name = "movieInfoLabel";
            this.movieInfoLabel.Size = new System.Drawing.Size(133, 29);
            this.movieInfoLabel.TabIndex = 1;
            this.movieInfoLabel.Text = "Movie Info";
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Location = new System.Drawing.Point(342, 76);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(39, 17);
            this.titleLabel.TabIndex = 2;
            this.titleLabel.Text = "Title:";
            // 
            // genreLabel
            // 
            this.genreLabel.AutoSize = true;
            this.genreLabel.Location = new System.Drawing.Point(329, 115);
            this.genreLabel.Name = "genreLabel";
            this.genreLabel.Size = new System.Drawing.Size(52, 17);
            this.genreLabel.TabIndex = 3;
            this.genreLabel.Text = "Genre:";
            // 
            // yearLabel
            // 
            this.yearLabel.AutoSize = true;
            this.yearLabel.Location = new System.Drawing.Point(339, 154);
            this.yearLabel.Name = "yearLabel";
            this.yearLabel.Size = new System.Drawing.Size(42, 17);
            this.yearLabel.TabIndex = 4;
            this.yearLabel.Text = "Year:";
            // 
            // lengthLabel
            // 
            this.lengthLabel.AutoSize = true;
            this.lengthLabel.Location = new System.Drawing.Point(325, 192);
            this.lengthLabel.Name = "lengthLabel";
            this.lengthLabel.Size = new System.Drawing.Size(56, 17);
            this.lengthLabel.TabIndex = 5;
            this.lengthLabel.Text = "Length:";
            // 
            // directorLabel
            // 
            this.directorLabel.AutoSize = true;
            this.directorLabel.Location = new System.Drawing.Point(319, 232);
            this.directorLabel.Name = "directorLabel";
            this.directorLabel.Size = new System.Drawing.Size(62, 17);
            this.directorLabel.TabIndex = 6;
            this.directorLabel.Text = "Director:";
            // 
            // ratingLabel
            // 
            this.ratingLabel.AutoSize = true;
            this.ratingLabel.Location = new System.Drawing.Point(328, 270);
            this.ratingLabel.Name = "ratingLabel";
            this.ratingLabel.Size = new System.Drawing.Size(53, 17);
            this.ratingLabel.TabIndex = 7;
            this.ratingLabel.Text = "Rating:";
            // 
            // titleTextBox
            // 
            this.titleTextBox.Location = new System.Drawing.Point(387, 73);
            this.titleTextBox.Name = "titleTextBox";
            this.titleTextBox.Size = new System.Drawing.Size(159, 22);
            this.titleTextBox.TabIndex = 8;
            // 
            // yearTextBox
            // 
            this.yearTextBox.Location = new System.Drawing.Point(387, 151);
            this.yearTextBox.Name = "yearTextBox";
            this.yearTextBox.Size = new System.Drawing.Size(159, 22);
            this.yearTextBox.TabIndex = 9;
            // 
            // lengthTextBox
            // 
            this.lengthTextBox.Location = new System.Drawing.Point(387, 189);
            this.lengthTextBox.Name = "lengthTextBox";
            this.lengthTextBox.Size = new System.Drawing.Size(159, 22);
            this.lengthTextBox.TabIndex = 11;
            // 
            // directorTextBox
            // 
            this.directorTextBox.Location = new System.Drawing.Point(387, 229);
            this.directorTextBox.Name = "directorTextBox";
            this.directorTextBox.Size = new System.Drawing.Size(159, 22);
            this.directorTextBox.TabIndex = 12;
            // 
            // ratingTextBox
            // 
            this.ratingTextBox.Location = new System.Drawing.Point(387, 267);
            this.ratingTextBox.Name = "ratingTextBox";
            this.ratingTextBox.Size = new System.Drawing.Size(159, 22);
            this.ratingTextBox.TabIndex = 13;
            // 
            // modifyButton
            // 
            this.modifyButton.Location = new System.Drawing.Point(336, 358);
            this.modifyButton.Name = "modifyButton";
            this.modifyButton.Size = new System.Drawing.Size(128, 67);
            this.modifyButton.TabIndex = 14;
            this.modifyButton.Text = "Modify and Save";
            this.modifyButton.UseVisualStyleBackColor = true;
            this.modifyButton.Click += new System.EventHandler(this.ModifyButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(470, 358);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(128, 67);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete and Save";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // imageAddMovieLabel
            // 
            this.imageAddMovieLabel.AutoSize = true;
            this.imageAddMovieLabel.Location = new System.Drawing.Point(331, 307);
            this.imageAddMovieLabel.Name = "imageAddMovieLabel";
            this.imageAddMovieLabel.Size = new System.Drawing.Size(50, 17);
            this.imageAddMovieLabel.TabIndex = 21;
            this.imageAddMovieLabel.Text = "Image:";
            // 
            // genreTextBox
            // 
            this.genreTextBox.Location = new System.Drawing.Point(387, 112);
            this.genreTextBox.Name = "genreTextBox";
            this.genreTextBox.Size = new System.Drawing.Size(159, 22);
            this.genreTextBox.TabIndex = 26;
            // 
            // imagePathTextBox
            // 
            this.imagePathTextBox.Location = new System.Drawing.Point(387, 304);
            this.imagePathTextBox.Name = "imagePathTextBox";
            this.imagePathTextBox.Size = new System.Drawing.Size(159, 22);
            this.imagePathTextBox.TabIndex = 27;
            // 
            // InfoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 474);
            this.Controls.Add(this.imagePathTextBox);
            this.Controls.Add(this.genreTextBox);
            this.Controls.Add(this.imageAddMovieLabel);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.modifyButton);
            this.Controls.Add(this.ratingTextBox);
            this.Controls.Add(this.directorTextBox);
            this.Controls.Add(this.lengthTextBox);
            this.Controls.Add(this.yearTextBox);
            this.Controls.Add(this.titleTextBox);
            this.Controls.Add(this.ratingLabel);
            this.Controls.Add(this.directorLabel);
            this.Controls.Add(this.lengthLabel);
            this.Controls.Add(this.yearLabel);
            this.Controls.Add(this.genreLabel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.movieInfoLabel);
            this.Controls.Add(this.consultMoviePictureBox);
            this.Name = "InfoForm";
            this.Text = "InfoForm";
            this.Load += new System.EventHandler(this.InfoForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.consultMoviePictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox consultMoviePictureBox;
        private System.Windows.Forms.Label movieInfoLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label genreLabel;
        private System.Windows.Forms.Label yearLabel;
        private System.Windows.Forms.Label lengthLabel;
        private System.Windows.Forms.Label directorLabel;
        private System.Windows.Forms.Label ratingLabel;
        private System.Windows.Forms.TextBox titleTextBox;
        private System.Windows.Forms.TextBox yearTextBox;
        private System.Windows.Forms.TextBox lengthTextBox;
        private System.Windows.Forms.TextBox directorTextBox;
        private System.Windows.Forms.TextBox ratingTextBox;
        private System.Windows.Forms.Button modifyButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label imageAddMovieLabel;
        private System.Windows.Forms.TextBox genreTextBox;
        private System.Windows.Forms.TextBox imagePathTextBox;
    }
}