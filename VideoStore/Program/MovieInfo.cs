using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class MovieInfo
    {
        //Variables
        double reviewRating { get; set; }   
        int lengthInMinutes { get; set; }   
        string releaseDate { get; set; }
        string movieTitle { get; set; }

        public MovieInfo( double reviewRating, int lengthInMinutes, string releaseDate, string movieTitle)
        {
            // this.genres = genres;
            this.reviewRating = reviewRating;
            this.lengthInMinutes = lengthInMinutes;
            this.releaseDate = releaseDate;
            this.movieTitle = movieTitle;
        }


        //getters
        public string GetMovieTitle()
        {
            return movieTitle;
        }

        public string GetReleaseDate()
        {
            return releaseDate;
        }
        public int GetLengthInMinutes()
        {
            return lengthInMinutes;
        }

        public double GetReviewRating()
        {
            return reviewRating;
        }

    }
}
