using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Movie
    {
        public string title;
        public string director;
        private string rating; // this means that only code in movie class cant access is rating cause of private


        public Movie(string aTitle, string aDirector, string aRating)
        {
           title = aTitle;
            director = aDirector;
            rating = aRating;
        }
        public string Rating
        {
            get { return rating; } //get rating attirbute
            set
            {
                if ( value == "G" || value == "PG" || value = "PG-13" || value = "R" || value == "NR")
                {
                    rating = value; 
                }
                else
                {
                    rating = " NR";
                }
            }//allow us to set rating
        }
    }
}
