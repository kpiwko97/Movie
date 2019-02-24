using System;
using System.Collections.Generic;
using System.Linq;
using System.Resources;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Movie.Models.RestModels;

namespace Movie.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly IResource _resource;
        public SliderViewComponent(IResource resource) => _resource = resource;
        public async Task<IViewComponentResult> InvokeAsync(string[] request)
        {         
           var getGenre = await GenericRestRequest<GetGenres>.GetDataAsync(_resource.GetResource.GetString(request[0]));
           var getImages = await GenericRestRequest<GetPopular>.GetDataAsync(_resource.GetResource.GetString(request[1]));// powinno byc GetResult zamiast GetPopular aby uniknac redundaancji kodu; nalezy umiescic interface;

            for (int genre = 0; genre < getGenre.Genres.Count(); genre++)
            {
                getGenre.Genres[genre].Image = getImages.Results[genre].Backdrop_path;
            }
           
           var results = getGenre.Genres.OrderBy(g=>g.Name).ToList();
           return View("Slider", results);
        }

       
    }
}