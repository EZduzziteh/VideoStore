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
    public partial class MovieDisplay : UserControl
    {
        ResultsData movieInfo;
        public MovieDisplay(ResultsData results)
        {
            InitializeComponent();

            movieInfo = results;

            //set image
            string urlToLoad= "https://image.tmdb.org/t/p/w500";

            if (movieInfo.poster_path != null)
            {
                urlToLoad += movieInfo.poster_path;
                pictureBox_movie_poster.Load(urlToLoad);
            }
            //set title
            if (movieInfo.title != null)
            {
                lbl_movieName.Text = movieInfo.title;
            }
        }

        //this happens when any panel component is clicked
        private void HandleClick()
        {
            //pictureBox_movie_poster.Image = null;


            // Console.WriteLine(mainForm);
            //lbl_movieName.Text = mainForm.ToString();
            MainPage mainPage = (MainPage)Application.OpenForms[0];
            mainPage.SetDisplayedVideo(movieInfo);

            
        }

        //Click Eevnts for all of the panel components
        private void label1_Click(object sender, EventArgs e)
        {
            HandleClick();
        }

        private void panel1_Click(object sender, EventArgs e)
        {
            HandleClick();
        }

        private void pictureBox_movie_poster_Click(object sender, EventArgs e)
        {
            HandleClick();
        }

        private void lbl_movieName_Click(object sender, EventArgs e)
        {
            HandleClick();
        }

      
    }
}
