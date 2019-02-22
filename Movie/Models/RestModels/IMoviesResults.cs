using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models.RestModels
{
    public interface IMoviesResults
    {
        string Title{ get; set; }
        DateTime Release_date { get; set; }
    }
}
