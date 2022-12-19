using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VideoStore.UserControls
{
    public partial class StoreDetails : UserControl
    {
        public MainPage mainPage;
        public StoreDetails()
        {
            InitializeComponent();
        }


        public void SetInfo()
        {
            string detailString = "Store Details:\n";
            detailString += "        Accounts:\n";
            foreach (Account account in mainPage.store.accounts)
            {
                detailString += "\n                      Name: " + account.GetName();
                
                if (account is Customer)
                {
                    Customer customer = (Customer)account;
                    detailString += "\n                            Account Type: Customer";
                    detailString += "\n                            Store Points: " + customer.GetStorePoints();
                    detailString += "\n                            Rentals: ";

                    foreach(Rental rental in customer.rentals)
                    {

                        detailString += "\n                                Title: " + rental.GetRentedMovie().GetMovieInfo().GetMovieTitle();
                        detailString += "\n                                     Rental ID:" + rental.getID();
                        detailString += "\n                                     Rental Date: " + rental.GetRentalDate();
                        detailString += "\n                                     Return Date: " + rental.GetReturnDate();
                        detailString += "\n                                     Movie ID: " + rental.GetRentedMovie().GetID();
                        detailString += "\n                                     Length: " + rental.GetRentedMovie().GetMovieInfo().GetLengthInMinutes();
                        detailString += "\n                                     review rating: " + rental.GetRentedMovie().GetMovieInfo().GetReviewRating();
                        detailString += "\n                                     release date: " + rental.GetRentedMovie().GetMovieInfo().GetReleaseDate();
                        detailString += "\n";

                    }

                }

                if (account is Employee)
                {
                    Employee employee = (Employee)account;

                        detailString += "\n                           Account Type: Employee";
                        detailString += "\n                           Position: " + employee.GetPosition();

                }

                detailString += "\n                            ID: " + account.GetID();
                detailString += "\n                            Username: " + account.GetUserName();
                detailString += "\n                            Birthday: " + account.GetBirthdate();
                detailString += "\n";

            }


            detailString += "\n\n     Store Inventory:\n";
            foreach (Movie movie in mainPage.store.moviesAvailable)
            {

                detailString += "\n         Title: " + movie.GetMovieInfo().GetMovieTitle();

                detailString += "\n                 Length: " + movie.GetMovieInfo().GetLengthInMinutes();

                detailString += "\n                 Release Date: " + movie.GetMovieInfo().GetReleaseDate();

                detailString += "\n                 Rating: " + movie.GetMovieInfo().GetReviewRating();

                detailString += "\n                 Is rented out: " + movie.getIsRentedOut();
                detailString += "\n";  
            }




            rtb_details.Text = detailString;
        }

      

        private void btn_Close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

      

       
    }
}
