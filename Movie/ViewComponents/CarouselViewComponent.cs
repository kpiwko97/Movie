using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Movie.Models.RestModels;

namespace Movie.ViewComponents
{
    public class CarouselViewComponent :ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string request)
        {
            var getImage = await GenericRestRequest<GetPopular>.GetDataAsync(request);
            var results = getImage.Results;
            return View("Carousel",results);
        }
    }
}
