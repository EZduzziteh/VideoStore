using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VideoStore.DataModels
{
    public class ReleaseDateData
    {
        public string iso_3166_1 { get; set; }  //this is the country code
        public CertificationData[] release_dates { get; set; }
    }
}
