using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.DataModels
{
    public class MovieDetailedSearchData
    {


        public int runtime { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }
        public int id { get; set; }
        public double popularity { get; set; }
        public string tagline { get; set; }
        public string overview { get; set; }
        public string budget { get; set; }
        public GenreData[] genres { get; set; }

    }

  
}
