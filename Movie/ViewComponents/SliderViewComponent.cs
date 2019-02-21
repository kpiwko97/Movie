using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           var getGenre = await GenericRestRequest<GetMovieList>.GetDataAsync(UrlPaths.ResourceManager.GetString("GetMovieList"));
           var results = getGenre.Genres;
           return View("Slider", results);
        }
    }
}