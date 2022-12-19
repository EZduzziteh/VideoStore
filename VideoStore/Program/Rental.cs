using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Rental
    {
        //Variables
        int rentalID { get; set; }
        Movie rentedMovie { get; set; }
        DateTime rentalDate { get; set; }
        DateTime returnDate { get; set; }

        //constructor
        public Rental(Movie movie, int rentalPeriod)
        {
            rentalDate = DateTime.Now;
            returnDate = rentalDate.AddDays(rentalPeriod);
            rentedMovie = movie;
        }


        //Getters
        public int getID()
        {
            return rentalID;
        }

        public Movie GetRentedMovie()
        {
            return rentedMovie;
        }
        public DateTime GetRentalDate()
        {
            return rentalDate;
        }
        public DateTime GetReturnDate()
        {
            return returnDate;
        }



    }
}
