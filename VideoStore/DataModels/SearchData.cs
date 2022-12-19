using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.DataModels
{
    public class SearchData
    {
        public ResultsData[] results { get; set; }
        public int total_results { get; set; }
    }
}

