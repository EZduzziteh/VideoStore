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
    public partial class EmployeeTerminal : UserControl
    {

        public MainPage mainPage;
        public EmployeeTerminal()
        {
            InitializeComponent();
        }


        public void SetInfo()
        {

            string customerDetailString = "\n\n     Customer Info: ";

            foreach(Account account in mainPage.store.accounts)
            {
                if(account is Customer) {
                    Customer customer = (Customer)account;
                    customerDetailString += "\n         Name: " + customer.GetName();
                    customerDetailString += "\n                 ID: " + customer.GetID();
                    customerDetailString += "\n                 Store Points: " + customer.GetStorePoints();
                    customerDetailString += "\n                 Birthday: " + customer.GetBirthdate();
                    customerDetailString += "\n                 Rentals:";

                    foreach (Rental rental in customer.rentals)
                    {

                        customerDetailString += "\n                      Title:"+rental.GetRentedMovie().GetMovieInfo().GetMovieTitle();
                        customerDetailString += "\n                      Return by:" + rental.GetReturnDate();
                        if (rental.GetReturnDate() > DateTime.Now)
                        {

                            customerDetailString += "\n                      Status: Overdue:";
                        }
                        else
                        {
                            customerDetailString += "\n                      Status: Not Due:";
                        }
                    }
                }
            }



            string detailString = "\n\n     Store Inventory:\n";
            int id = 0;
            foreach (Movie movie in mainPage.store.moviesAvailable)
            {

                detailString += "\n         Title: " + movie.GetMovieInfo().GetMovieTitle();
                detailString += "\n                 ID: " + id;
                detailString += "\n                 Length: " + movie.GetMovieInfo().GetLengthInMinutes();

                detailString += "\n                 Release Date: " + movie.GetMovieInfo().GetReleaseDate();

                detailString += "\n                 Rating: " + movie.GetMovieInfo().GetReviewRating();

                detailString += "\n                 Is rented out: " + movie.getIsRentedOut();

                id++;
            }




           rtb_inventory.Text = detailString;
           rtb_customers.Text = customerDetailString;
        }

        private void btn_removeMovie_Click(object sender, EventArgs e)
        {
            if (mainPage.store.RemoveMovie(int.Parse(tb_id_input.Text)))
            {
                ErrorBox errorbox = new ErrorBox();
                errorbox.Location = new Point(btn_removeMovie.Location.X - 75, btn_removeMovie.Location.Y+100);
                errorbox.SetText("Removed Movie", false);
                errorbox.owningCollection = Controls;
                Controls.Add(errorbox);
                errorbox.BringToFront();
                SetInfo();
            }
            else
            {
                ErrorBox errorbox = new ErrorBox();
                errorbox.Location = new Point(btn_removeMovie.Location.X-75, btn_removeMovie.Location.Y+100);
                errorbox.SetText("That movie is rented out right now!", true);
                errorbox.owningCollection = Controls;
                Controls.Add(errorbox);
                errorbox.BringToFront();
                SetInfo();
            }


            
        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }
    }
}
