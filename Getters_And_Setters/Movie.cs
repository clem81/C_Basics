using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Getters_And_Setters
{
    internal class Movie
    {
        //public means it is accessible for modification everywhere whereas private can only be set in this class.
        public string title;
        public string director;
        private string rating;

        public Movie(string aTitle, string aDirector, string aRating)
        {
            title = aTitle;
            director = aDirector;
            // This means it is now set via the setter which is secure
            Rating = aRating;

        }
        public string Rating { 
            get { return  rating}; 
            //set specifies the valid values to compare to
            set
            {
                if (value == "PG" || value == "12A" || value == "12" || value == "15" || value == "18")
                {
                    rating = value;
                }
                else
                {
                    rating = "NR";
                }
            }; 
        };
    }
}
