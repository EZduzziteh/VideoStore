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
    public partial class CustomerTerminal : UserControl
    {

        public MainPage mainPage;
        public CustomerTerminal()
        {
            InitializeComponent();
        }

        public void SetInfo()
        {
            Customer cust = mainPage.currentlyLoggedInAccount as Customer;
            string detailString = "\n\nCustomer:"+cust.GetName();
            detailString += "\n\n     Rentals:\n";
            int id = 0;
            foreach (Rental rental in cust.rentals)
            {
                detailString += "\n         Title: "+ rental.GetRentedMovie().GetMovieInfo().GetMovieTitle() ;
                detailString += "\n                 Return by: "+rental.GetReturnDate();
                detailString += "\n                 Rented on: " + rental.GetRentalDate();
                detailString += "\n                 ID: " + id+"\n";


                id++;
            }
                
            




            rtb_rentals.Text = detailString;
        }


        private void btn_return_Click(object sender, EventArgs e)
        {
            Customer cust = mainPage.currentlyLoggedInAccount as Customer;
            Movie movie = cust.rentals[int.Parse(tb_return_input.Text)].GetRentedMovie();

            if (cust.Return(cust.rentals[int.Parse(tb_return_input.Text)]))
            {
                ErrorBox errorbox = new ErrorBox();
                errorbox.Location = new Point(btn_return.Location.X - 75, btn_return.Location.Y+100);
                errorbox.SetText("Returned movie: " + movie.GetMovieInfo().GetMovieTitle(), false);
                errorbox.owningCollection = Controls;
                Controls.Add(errorbox);
                errorbox.BringToFront();
                SetInfo();
            }
            else
            {
                ErrorBox errorbox = new ErrorBox();
                errorbox.Location = new Point(btn_return.Location.X - 75, btn_return.Location.Y+100);
                errorbox.SetText("Returned movie: " + movie.GetMovieInfo().GetMovieTitle()+", But you were late!", false);
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
