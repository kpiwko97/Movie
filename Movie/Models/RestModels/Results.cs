using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie.Models.RestModels;
using Newtonsoft.Json;

namespace Movie.Models.RestModels
{
    public class Results:IMoviesResults,ISeriesResults
    {       
        public string Title { get; set; }
        public string Name
        {
            get => Title;
            set => Title = value;
        }
        public DateTime Release_date { get; set; }
        public DateTime First_air_date  
        {
            get => Release_date;
            set => Release_date = value;
        } 
        
        public float Vote_average { get; set; }
        public string Backdrop_path { get; set; }
        public string Poster_path { get; set; }
        public string Overview { get; set; }
        public int TotalPages { get; set; }
    }
}
