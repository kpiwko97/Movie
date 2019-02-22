using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;

namespace Movie.Models
{
    public class Resource:IResource
    {
        private ResourceManager _resource;
        public Resource() => _resource = MovieUrlRequests.ResourceManager;

        public ResourceManager GetResource => _resource;
        public void SetResource(ResourceManager resourceName) => _resource = resourceName;
    }
}
