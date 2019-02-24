using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Movie.Models.RestModels;

namespace Movie.Models.RestModels
{
    public class GetPopular
    {
        public List<Results> Results { get; set; }
    }
}
