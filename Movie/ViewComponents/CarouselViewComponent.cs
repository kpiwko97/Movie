using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.ViewComponents
{
    public class CarouselViewComponent :ViewComponent
    {
        private readonly IResource _resource;
        public CarouselViewComponent(IResource resource) => _resource = resource;

        public async Task<IViewComponentResult> InvokeAsync(string request)
        {
            var getImage = await GenericRestRequest<GetPopular>.GetDataAsync(_resource.GetResource.GetString(request));
            var results = getImage.Results;
            return View("Carousel",results);
        }
    }
}
