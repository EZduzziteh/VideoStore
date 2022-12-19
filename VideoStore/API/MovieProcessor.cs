using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;
using VideoStore.DataModels;
namespace VideoStore
{
    public class MovieProcessor
    {
        //This class contains functions that use the APIHELPER to issue http requests and get data.
        //All of these functions work basically the same but they return different data objects and use different url for the http request



        //Gets movie based on a name entered
        public static async Task<SearchData> LoadMovieByName(string movieName)
        {
            string url = "https://api.themoviedb.org/3/search/movie?api_key=70615713b1e6a509957308dae2887758&query=";
            url += movieName;

            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {

                    SearchData data = await res.Content.ReadAsAsync<SearchData>();
                    Console.WriteLine("got this many results: " + data.total_results);
                    return data;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }


        }

        //Gets detailed movie info by using the id
        public static async Task<MovieDetailedSearchData> LoadMovieByID(int movieID)
        {

            string url = "https://api.themoviedb.org/3/movie/";
            url += movieID;
            url += "?api_key=70615713b1e6a509957308dae2887758&append_to_response=release_dates";


            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {

                    MovieDetailedSearchData data = await res.Content.ReadAsAsync<MovieDetailedSearchData>();
                    Console.WriteLine("Loading detailed movie details:  ");
                    return data;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }


        }

        //gets a youtube link to trailer
        public static async Task<MovieTrailerResultData> GetMovieTrailerByID(int movieID)
        {
            string url = "http://api.themoviedb.org/3/movie/";
            url += movieID;
            url += "/videos?api_key=70615713b1e6a509957308dae2887758";

            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {

                    MovieTrailerResultData data = await res.Content.ReadAsAsync<MovieTrailerResultData>();
                    Console.WriteLine("getting trailer data " + data.results[0].key);
                    return data;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }
        }

        //get release dates of a movie(this gives us access to rating by country.
        public static async Task<MovieReleaseDateResultData> GetMovieRatingsByID(int movieID)
        {
            string url = "https://api.themoviedb.org/3/movie/";
            url += movieID;
            url += "/release_dates?api_key=70615713b1e6a509957308dae2887758";

            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {

                    MovieReleaseDateResultData data = await res.Content.ReadAsAsync<MovieReleaseDateResultData>();
                    return data;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }
        }

        ///get the most popular movies.
        public static async Task<PopularMoviesResultData> GetPopularMovies()
        {
            string url = "https://api.themoviedb.org/3/movie/popular?api_key=70615713b1e6a509957308dae2887758";

            using (HttpResponseMessage res = await APIHelper.ApiClient.GetAsync(url))
            {
                if (res.IsSuccessStatusCode)
                {

                    PopularMoviesResultData data = await res.Content.ReadAsAsync<PopularMoviesResultData>();
                    return data;
                }
                else
                {
                    throw new Exception(res.ReasonPhrase);
                }
            }

        }
    }
}
