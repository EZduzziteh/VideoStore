using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore
{
    public class Customer:Account
    {
        
        //variables
        private int storePoints { get; set; }

        public List<Rental> rentals = new List<Rental>();

        
        //constructor
        public Customer(int iD, string name, string username, string password, DateTime birthDate) : base(iD, name, username, password, birthDate)
        {

        }

        //Getters
        public int GetStorePoints()
        {
            return storePoints;
        }

        //Functions

        //adds store loyalty points
        public void AddStorePoints(int pointsToAdd)
        {
            storePoints += pointsToAdd;
        }

        //removes store loyalty points
        public bool RemoveStorePoints(int pointsToRemove)
        {
            if (storePoints - pointsToRemove >= 0)
            {
                storePoints -= pointsToRemove;
                //operation was succesful
                return true;
            }
            else
            {
                //operation unsuccessful
                return false;
            }
        }

        //Rents a movie and creates a rental object containing data about the rental agreement and adds it to the customers list of rentals
        public void Rent(Movie movie, int rentalPeriod)
        {
            Console.WriteLine("Reting for customer" + name);
            movie.SetIsRentedOut(true);
            Rental rental = new Rental(movie, rentalPeriod);
            storePoints += 100*rentalPeriod;
            rentals.Add(rental);
        }
        
        //Returns a movie 
        //returns true if no late fees are due, returns false if late fees are due.
        public bool Return(Rental rental)
        {

            rental.GetRentedMovie().SetIsRentedOut(false);
            rentals.Remove(rental);

            if (rental.GetReturnDate() < DateTime.Now)
            {
                Console.WriteLine("Aply Late FEees");
                return false;
            }
            else
            {
                Console.WriteLine("thanks for returning on time!");
                return true;
            }

           
        }
    }
}
