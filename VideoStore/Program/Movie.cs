using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Movie
    {
        //variables 
        bool isRentedOut;
        int ID;
        MovieInfo movieInfo;

        //constructor
        public Movie(bool isRentedOut, int iD, MovieInfo movieInfo)
        {
            this.isRentedOut = isRentedOut;
            ID = iD;
            this.movieInfo = movieInfo;
        }



        //Setters

        public void SetIsRentedOut(bool status)
        {
            isRentedOut = status;
        }


        //Getters
        
        public bool getIsRentedOut()
        {
            return isRentedOut;
        }

        public int GetID()
        {
            return ID;
        }

        public MovieInfo GetMovieInfo()
        {
            return movieInfo;
        }
    }
}
