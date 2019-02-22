using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models.RestModels
{
    public interface ISeriesResults
    {
        string Name { get; set; }
        DateTime First_air_date { get; set; }
    }
}
