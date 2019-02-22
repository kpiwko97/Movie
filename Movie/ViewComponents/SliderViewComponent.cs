using System.Resources;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        private readonly IResource _resource;
        public SliderViewComponent(IResource resource) => _resource = resource;
        public async Task<IViewComponentResult> InvokeAsync(string request)
        {         
           var getGenre = await GenericRestRequest<GetMovieList>.GetDataAsync(_resource.GetResource.GetString(request));
           var results = getGenre.Genres;
           return View("Slider", results);
        }
    }
}