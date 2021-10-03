using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    class Movie
    {
        //  Property for title
        public string Title { get; set; }

        //  Property for year
        public int Year { get; set; }

        //  Property for length
        public TimeSpan Length { get; set; }

        //  Property for director
        public string Director { get; set; }

        //  Property for rating
        public decimal Rating { get; set; }

        //  Property for image path
        public string ImagePath { get; set; }

        //  Constructor
        public Movie()
        {
            Title = "";
            Year = 0;
            Length = new TimeSpan(0);
            Director = "";
            Rating = 0;
            ImagePath = "";
        }

        //  Overload constructor
        public Movie(string title, int year, TimeSpan length, string director, int rating, string imagepath)
        {
            Title = title;
            Year = year;
            Length = length;
            Director = director;
            Rating = rating;
            ImagePath = imagepath;
        }
    }
}
