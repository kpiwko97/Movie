using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;

namespace Movie.Models
{
    public interface IResource
    {
        ResourceManager GetResource { get; }
        void SetResource(ResourceManager resourceName);
    }
}
