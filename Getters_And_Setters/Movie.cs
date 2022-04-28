using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_And_Setters
{
    internal class Movie
    {
        public string Title { get; set; };
        public string Director { get; set; };
        public string Rating { get; set; };

        public Movie(string aTitle, string aDirector, string aRating)
        {
            Title = aTitle;
            Director = aDirector;
            Rating = aRating;

        }
    }
}
