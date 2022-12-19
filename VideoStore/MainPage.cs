using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VideoStore.DataModels;

namespace VideoStore
{
    public partial class MainPage : Form
    {
        public Store store;
        public Account currentlyLoggedInAccount;

        public MainPage()
        {
            InitializeComponent();
            store = new Store();

            store.CreateDemoAccounts();

            movieDetailDisplay1.Visible = false;
            tb_ResultsFound.Visible = false;
            Container_Movie_Search_Details.Visible = false;
            login1.Visible = false;
            storeDetails1.Visible = false;
            employeeTerminal1.Visible = false;
            customerTerminal1.Visible = false;

            cmb_filter_by_genre.Items.Add("Action");
            cmb_filter_by_genre.Items.Add("Horror");
            cmb_filter_by_genre.Items.Add("Comedy");
            cmb_filter_by_genre.Items.Add("Thriller");
            cmb_filter_by_genre.Items.Add("Drama");

            cmb_filter_by_genre.SelectedIndex = 0;
            cmb_filter_by_genre.Visible = false;

            
            cmb_age.Items.Add("G");
            cmb_age.Items.Add("PG");
            cmb_age.Items.Add("14A");
            cmb_age.Items.Add("18A");
            cmb_age.Items.Add("R");
            cmb_age.Items.Add("unrated");
            cmb_age.SelectedIndex = 0;


            cmb_age.Visible = false;
        }

        internal void CloseWindows()
        {
            employeeTerminal1.Visible = false;
            movieDetailDisplay1.Visible = false;
            login1.Visible = false;
            customerTerminal1.Visible = false;
            storeDetails1.Visible = false;
        }

        internal void CreateAccount(string username, string password, bool isEmployee, DateTime birthdate, string position, string name)
        {
            store.CreateAccount(username, password, name, birthdate, isEmployee, position);
        }

        internal void HandleLogin(string username, string password)
        {
            currentlyLoggedInAccount = null;

            for(int i=0; i<store.accounts.Count; i++)
            {
                if (store.accounts[i].ValidateUsername(username))
                {
                    if (store.accounts[i].ValidatePassword(password))
                    {
                        //log in successful
                        currentlyLoggedInAccount = store.accounts[i];
                    }
                    else
                    {
                        //password was incorrect
                    }
                }
            
            }

            if (currentlyLoggedInAccount != null)
            {
                if(currentlyLoggedInAccount is Customer)
                {
                    Customer cust = currentlyLoggedInAccount as Customer;
                    tb_currentlyLoggedin.Text = "Logged in as Customer: " + cust.GetName();
                }
                else
                {
                    Employee emp = currentlyLoggedInAccount as Employee;
                    tb_currentlyLoggedin.Text="Logged in as Employee: " + emp.GetPosition() + " " + emp.GetName();

                }
                //login was succesfull
            }
            else
            {
                //no account wiht that name was found!
            }

        }

        public void SetDisplayedVideo(ResultsData movieInfo)
        {
            
            movieDetailDisplay1.SetInfo(movieInfo);
            movieDetailDisplay1.Visible = true;
            movieDetailDisplay1.Size = new Size(731, 649);
        }

        private async void btn_search_go_Click(object sender, EventArgs e)
        {
            Container_Movie_Search_Details.Clear();

            APIHelper.InitializeClient();

            var movieInfo = await MovieProcessor.LoadMovieByName(input_search.Text);
            tb_ResultsFound.Visible = true;
            Container_Movie_Search_Details.Visible = true;


            int totalResults = 0;
            for(int i = 0; i <movieInfo.results.Length; i++)
            {
                if (checkBox_filter_genre.Checked||checkBox_restrict_Age.Checked)
                {
                    bool includeInSearchResults = false;

                    var detailedMovieInfo = await MovieProcessor.LoadMovieByID(movieInfo.results[i].id);

                    bool passedAgeFilter = false;
                    bool PassedGenreFilter = false;
                    //make sure not to include it unless it specifically fits our filters.


                    //genre filter
                    if (checkBox_filter_genre.Checked)
                    {
                        //check to make sure its genre matches our genre filter
                        foreach (GenreData genre in detailedMovieInfo.genres)
                        {

                            if (genre.name == cmb_filter_by_genre.SelectedItem.ToString())
                            {
                                //if it does, include it in results
                                PassedGenreFilter = true;
                            }
                        }
                    }

                    if (checkBox_restrict_Age.Checked)
                    {
                        var ratingToUse = "";
                        if (cmb_age.SelectedIndex.ToString() == "unrated")
                        {
                            ratingToUse = "";
                        }
                        else
                        {
                            ratingToUse = cmb_age.SelectedItem.ToString();
                        }

                        var ratingInfo =  await MovieProcessor.GetMovieRatingsByID(movieInfo.results[i].id);
                        foreach(var rating in ratingInfo.results)
                        {
                            if (rating.iso_3166_1 == "CA" )
                            {
                                Console.WriteLine("Release: " + rating.iso_3166_1 + ", Cert: " + rating.release_dates[0].certification);
                                if (rating.release_dates[0].certification == ratingToUse)
                                {
                                    passedAgeFilter = true;
                                }
                            }
                            else
                            {

                            }
                                
                            
                        }

                    }

                    //if both
                    if (checkBox_restrict_Age.Checked && checkBox_filter_genre.Checked)
                    {
                        if (passedAgeFilter && PassedGenreFilter)
                        {
                            includeInSearchResults = true;
                        }
                        else
                        {
                            includeInSearchResults = false;
                        }
                    }else if (checkBox_restrict_Age.Checked) //if just age
                    {

                        if (passedAgeFilter)
                        {
                            includeInSearchResults = true;
                        }
                        else
                        {
                            includeInSearchResults = false;
                        }

                    }else if (checkBox_filter_genre.Checked)//if just genre
                    {
                        if (PassedGenreFilter)
                        {
                            includeInSearchResults = true;
                        }
                        else
                        {
                            includeInSearchResults = false;
                        }
                    }
                    else
                    {
                        includeInSearchResults = true;
                    }



                    if (includeInSearchResults)
                    {
                        totalResults++;
                        Container_Movie_Search_Details.AddMovie(movieInfo.results[i]);
                    }
                    
                }
                else
                {
                    totalResults++;
                    Container_Movie_Search_Details.AddMovie(movieInfo.results[i]);
                }
            }
            tb_ResultsFound.Text = "Found" + totalResults + " Results";


        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            login1.ClearInfo();
            login1.Visible = true;
            if (login1.isSetToRegister)
            {
                login1.SwitchRegister();
            }
            else
            {
                login1.isSetToRegister = true;
                login1.SwitchRegister();
            }

            login1.BringToFront();
            
        }
       

        private void registerToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            login1.ClearInfo();
            login1.Visible = true;
            if (login1.isSetToRegister)
            {
                login1.isSetToRegister = false;
                login1.SwitchRegister();
            }
            else
            {
                
                login1.SwitchRegister();
            }

            login1.BringToFront();

        }

        private void storeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            storeDetails1.Visible = true;
            storeDetails1.mainPage = this;
            storeDetails1.SetInfo();
            storeDetails1.BringToFront();
        }

     

        private void checkBox_restrict_Age_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_restrict_Age.Checked)
            {
                cmb_age.Visible = true;
            }
            else
            {
                cmb_age.Visible = false;
            }
        }

        private void checkBox_filter_genre_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_filter_genre.Checked)
            {
                cmb_filter_by_genre.Visible = true;
            }
            else
            {
                cmb_filter_by_genre.Visible = false;

            }
        }

        private void employeeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            employeeTerminal1.Visible = true;
            employeeTerminal1.mainPage = this;
            employeeTerminal1.SetInfo();
            employeeTerminal1.BringToFront();
        }


        private async void btn_Get_Popular_Click(object sender, EventArgs e)
        {
            Container_Movie_Search_Details.Clear();

            APIHelper.InitializeClient();

            var movieInfo = await MovieProcessor.GetPopularMovies();
            tb_ResultsFound.Visible = true;
            Container_Movie_Search_Details.Visible = true;


            for(int i=0; i<10; i++)
            {
                Container_Movie_Search_Details.AddMovie(movieInfo.results[i]);
            }

        }

        private void customerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            customerTerminal1.Visible = true;
            customerTerminal1.mainPage = this;
            customerTerminal1.SetInfo();
            customerTerminal1.BringToFront();
        }

        private void customerTerminal1_Load(object sender, EventArgs e)
        {

        }
    }
}