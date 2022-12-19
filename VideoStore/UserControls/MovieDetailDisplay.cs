using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoStore.UserControls;

using VideoStore.DataModels;

namespace VideoStore
{
  

    public partial class MovieDetailDisplay : UserControl
    {
        ResultsData movieInfo;
        MovieDetailedSearchData detailedMovieInfo;
        int rentalPeriod;
        MainPage mainPage;

        public MovieDetailDisplay()
        {
            InitializeComponent();
            webBrowser1.Visible = false;
        }

        
        public async void SetInfo(ResultsData movieInfo)
        {
            webBrowser1.Visible = false;
            //get reference to main page
            mainPage = (MainPage)Application.OpenForms[0];



            //update the ui controls based on who is logged in
            if(mainPage.currentlyLoggedInAccount is Customer)
            {
                btn_AddToLibrary.Visible = false;
                btn_RentNow.Visible = true;
                lbl_rental.Visible = true;
                tb_rentalPeriod.Visible = true;
                btn_Increase.Visible = true;
                btn_Decrease.Visible = true;
            }
            else if(mainPage.currentlyLoggedInAccount is Employee)
            {
                btn_AddToLibrary.Visible = true;
                btn_RentNow.Visible = false;
                btn_AddToLibrary.Text = "Add a copy to store inventory";
                lbl_rental.Visible = false;
                tb_rentalPeriod.Visible = false;
                btn_Increase.Visible = false;
                btn_Decrease.Visible = false;
            }
            else
            {
                btn_AddToLibrary.Visible = false;
                btn_RentNow.Visible = false;
                lbl_rental.Visible = false;
                tb_rentalPeriod.Visible = false;
                btn_Increase.Visible = false;
                btn_Decrease.Visible = false;
            }



            //set our movie info reference
            this.movieInfo = movieInfo;


            //Handle Getting more detailed info
            APIHelper.InitializeClient();

            detailedMovieInfo = await MovieProcessor.LoadMovieByID(movieInfo.id);

            

            //load in the backdrop image if possible
            if (movieInfo.backdrop_path != null)
            {
                picture_backdrop.Load("https://image.tmdb.org/t/p/w500" + detailedMovieInfo.backdrop_path);
            }
            else
            {
                //if no backdrop image, try loading poster instead.
                if (movieInfo.poster_path != null)
                {
                    picture_backdrop.Load("https://image.tmdb.org/t/p/w500" + detailedMovieInfo.poster_path);
                }
                else
                {
                    //do nothing, no images found!
                }
            }
            tb_rating.Text = detailedMovieInfo.vote_average.ToString()+"/10";
            tb_release_date.Text = movieInfo.release_date;
            tb_run_time.Text = detailedMovieInfo.runtime+ " minutes!";
            rtb_desc.Text = detailedMovieInfo.overview;
            rtb_tagline.Text = detailedMovieInfo.tagline;
            tb_budget.Text=detailedMovieInfo.budget;
            tb_popularity.Text=detailedMovieInfo.popularity.ToString()+"%";



        }

        private void btn_RentNow_Click(object sender, EventArgs e)
        {
            MainPage mainPage = (MainPage)Application.OpenForms[0];
            if (mainPage.currentlyLoggedInAccount is Customer)
            {
                int index = mainPage.store.FindAvailableCopyOfMovieIndex(movieInfo);
                Console.WriteLine("index: "+index);
                if (index!=-1)
                {
                    if (mainPage.store.CheckIfAnyLateFees((Customer)mainPage.currentlyLoggedInAccount))
                    {
                        ErrorBox errorbox = new ErrorBox();
                        errorbox.Location = new Point(btn_RentNow.Location.X - 75, btn_RentNow.Location.Y);
                        errorbox.SetText("You have late fees! we cant rent you another movie!", true);
                        errorbox.owningCollection = Controls;
                        Controls.Add(errorbox);
                        errorbox.BringToFront();
                    }
                    else
                    {
                        ((Customer)mainPage.currentlyLoggedInAccount).Rent(mainPage.store.moviesAvailable[index], rentalPeriod);
                    }
                 
                }
                else
                {
                    ErrorBox errorbox = new ErrorBox();
                    errorbox.Location = new Point(btn_RentNow.Location.X-75,btn_RentNow.Location.Y);
                    errorbox.SetText("Sorry! we dont have that movie available right now! try requesting it to be added.", true);
                    errorbox.owningCollection = Controls;
                    Controls.Add(errorbox);
                    errorbox.BringToFront();
                }
            }
            else
            {
                ErrorBox errorbox = new ErrorBox();
                errorbox.Location = new Point(btn_RentNow.Location.X - 75, btn_RentNow.Location.Y);
                errorbox.SetText("Sorry! You are logged into an employee account, please log in as a customer!", true);
                errorbox.owningCollection = Controls;
                Controls.Add(errorbox);
                errorbox.BringToFront();
            }
        }

        private void btn_AddToLibrary_Click(object sender, EventArgs e)
        {
           
            if (mainPage.currentlyLoggedInAccount is Employee)
            {
                MovieInfo mi = new MovieInfo(detailedMovieInfo.popularity, detailedMovieInfo.runtime, movieInfo.release_date, detailedMovieInfo.title);
                mainPage.store.AddNewMovie(mi);
            }
            else
            {
                
                //
            }
        }

        private void btn_Increase_Click(object sender, EventArgs e)
        {
            if (rentalPeriod < 7)
            {
                rentalPeriod++;
                UpdateRentalPeriodText();
            }
            else
            {
                //maximum rental of 1 weeks!
                ErrorBox errorbox = new ErrorBox();
                errorbox.Location = new Point(btn_Decrease.Location.X-75, btn_Decrease.Location.Y);
                errorbox.SetText("maximum rental period is 1 week!", true );
                errorbox.owningCollection = Controls;
                Controls.Add(errorbox);
                errorbox.BringToFront();
            }
        }

        private void UpdateRentalPeriodText()
        {
            if (rentalPeriod == 7)
            {

                tb_rentalPeriod.Text = "1 week!";
            }else if(rentalPeriod == 1)
            {
                tb_rentalPeriod.Text = "1 day!";
            }
            else
            {
                tb_rentalPeriod.Text = rentalPeriod.ToString() + " days!";

            }

        }

        private void btn_Decrease_Click(object sender, EventArgs e)
        {
            if (rentalPeriod > 1)
            {
                rentalPeriod--;
                UpdateRentalPeriodText();
            }
            else
            {
                //minimum rental of 1 day!
                ErrorBox errorbox = new ErrorBox();
                errorbox.Location = new Point(btn_Decrease.Location.X - 75, btn_Decrease.Location.Y);
                errorbox.SetText("Minimum rental period is 1 day!", true );
                errorbox.owningCollection = Controls;
                Controls.Add(errorbox);
                errorbox.BringToFront();
            }
        }


        private async void btn_trailer_Click_1(object sender, EventArgs e)
        {
            this.webBrowser1.Visible = true;
            var trailerData= await MovieProcessor.GetMovieTrailerByID(movieInfo.id);
            Console.WriteLine(trailerData.results[0].key);

            string txtUrl = "https://www.youtube.com/watch?v=";
            txtUrl+= trailerData.results[0].key;


            string html = "<html><head>";
            html += "<meta content='IE=Edge' http-equiv='X-UA-Compatible'/>";
            html += "<iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='420' height='250' frameborder='0' allowfullscreen></iframe>";
            html += "</body></html>";
            this.webBrowser1.DocumentText = string.Format(html, txtUrl.Split('=')[1]);


        }

    }
}
