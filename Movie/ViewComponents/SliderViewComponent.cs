using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Movie.Models.RestModels;

namespace Movie.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string[] request)
        {         
           var getGenre = await GenericRestRequest<GetGenres>.GetDataAsync(request[0]);
           var getImages = await GenericRestRequest<GetPopular>.GetDataAsync(request[1]);// powinno byc GetResult zamiast GetPopular aby uniknac redundaancji kodu; nalezy umiescic interface;

            for (int genre = 0; genre < getGenre.Genres.Count(); genre++)
            {
                getGenre.Genres[genre].Image = getImages.Results[genre].Backdrop_path;
            }
           
           var results = getGenre.Genres.OrderBy(g=>g.Name).ToList();
           return View("Slider", results);
        }

       
    }
}