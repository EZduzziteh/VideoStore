using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VideoStore.DataModels;

namespace VideoStore
{
    public class Store
    {
        //variables
        public List<Account> accounts = new List<Account>();
        public List<Movie> moviesAvailable = new List<Movie>();
      

        //Functions
        public void CreateDemoAccounts()
        {
            Customer customer = new Customer(0, "Serjei Moneybags", "c", "p", new DateTime(1992, 07, 03));
            AddNewCustomer(customer);


            Employee employee = new Employee(1, "Sasha Greene", "u", "p", new DateTime(1996, 06, 15),"Manager");

            AddNewEmployee(employee);
        }

        public void AddNewCustomer(Customer customer)
        {
            Console.WriteLine("added new account: " + customer.GetName());
            accounts.Add(customer);
        }
        public void AddNewEmployee(Employee employee)
        {
            Console.WriteLine("added new account: " + employee.GetName());
            accounts.Add(employee);
        }

        public void AddNewMovie(MovieInfo info)
        {
            
            Movie movie = new Movie(false, moviesAvailable.Count, info);
            moviesAvailable.Add(movie);
            Console.WriteLine("Added new movie: " + movie.GetMovieInfo().GetMovieTitle());
        }

        public void CreateAccount(string username, string password, string name, DateTime birthdate, bool isEmployee, string position)
        {
            bool isOK = true;
            for(int i = 0; i < accounts.Count; i++)
            {
                if (accounts[i].ValidateUsername(username))
                {
                    isOK = false;
                    //username already exists
                }
                
            }

            if (isOK) {
                // no user exists, we can create the account
                if (isEmployee)
                {
                    Employee employee = new Employee(accounts.Count, name, username, password, birthdate, position);
                    AddNewEmployee(employee);
                }
                else
                {
                    Customer customer = new Customer(accounts.Count, name, username, password, birthdate);
                    AddNewCustomer(customer);
                }
            }

        }
        public bool CheckIfAnyLateFees(Customer account)
        {
            bool hasAnyLateFees = false;

            foreach(Rental rental in account.rentals)
            {
                if (DateTime.Now > rental.GetReturnDate())
                {
                    hasAnyLateFees = true;

                }
            }

            if (hasAnyLateFees)
            {
                return true;
            }
            else
            {

                return false;
            }
        }

        public bool RemoveMovie(int index)
        {
            //if movie is not rented out
            if (moviesAvailable[index].getIsRentedOut() == false)
            {
                //remove the movie
                moviesAvailable.RemoveAt(index);
                return true;
            }
            else
            {
                return false;
            }
        }

        public int FindAvailableCopyOfMovieIndex(ResultsData movieInfo)
        {
            
            for(int i=0; i<moviesAvailable.Count; i++)
            {
                //if we find a movie with a matching title
                if (movieInfo.title == moviesAvailable[i].GetMovieInfo().GetMovieTitle())
                {
                    if (moviesAvailable[i].getIsRentedOut())
                    {
                        continue;
                    }
                    else
                    {
                        return i;
                    }
                    
                }
            }

            return -1;
        }
    }
}
