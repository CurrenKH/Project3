﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project3
{
    ///  <summary>
    /// 
    ///  Movie class for holding data from each movie in the XML file
    /// 
    ///  </summary>
    public class Movie
    {
        //  Property for genre
        public string Genre { get; set; }

        //  Property for title
        public string Title { get; set; }

        //  Property for year
        public int Year { get; set; }

        //  Property for length
        public string Length { get; set; }

        //  Property for director
        public string Director { get; set; }

        //  Property for rating
        public decimal Rating { get; set; }

        //  Property for image path
        public string ImagePath { get; set; }

        ///  <summary>
        /// 
        ///  Constructor for movie
        /// 
        ///  </summary>

        //  Constructor
        public Movie()
        {
            Genre = "";
            Title = "";
            Year = 0;
            Length = "";
            Director = "";
            Rating = 0;
            ImagePath = "";
        }

        ///  <summary>
        /// 
        ///  Overload cnstructor for movie
        /// 
        ///  </summary>

        //  Overload constructor
        public Movie(string genre, string title, int year, string length, string director, int rating, string imagepath)
        {
            Genre = genre;
            Title = title;
            Year = year;
            Length = length;
            Director = director;
            Rating = rating;
            ImagePath = imagepath;
        }
    }
}
