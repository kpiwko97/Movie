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
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var getImage = await GenericRestRequest<GetPopular>.GetDataAsync(UrlPaths.ResourceManager.GetString("GetPopular"));
            var results = getImage.Results;
            return View("Carousel",results);
        }
    }
}
