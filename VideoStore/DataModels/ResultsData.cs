using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.DataModels
{ 
    public class ResultsData
    {
        public string release_date { get; set; }
        public int runtime { get; set; }
        public string overview { get; set; }
        public string title { get; set; }
        public double vote_average { get; set; }
        public string poster_path { get; set; }
        public string backdrop_path { get; set; }
        public int id { get; set; }
        public string key { get; set; }

    }

    
}

