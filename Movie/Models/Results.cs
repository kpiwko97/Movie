using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class Results
    {
        public string Title { get; set; }
        public float Vote_average { get; set; }
        public int Vote_count { get; set; }
        public string Backdrop_path { get; set; }
        public string Overview { get; set; }
        public DateTime Release_date { get; set; }
        public string Poster_path { get; set; }
    }
}
