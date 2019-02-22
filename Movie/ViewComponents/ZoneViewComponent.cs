using System.Globalization;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.ViewComponents
{
    public class ZoneViewComponent : ViewComponent
    {
        private readonly IResource _resource;
        public ZoneViewComponent(IResource resource) => _resource = resource;
        public async Task<IViewComponentResult> InvokeAsync(string request)
        {
            var getTopRated = await GenericRestRequest<GetTopRated>.GetDataAsync(_resource.GetResource.GetString(request));
            var results = getTopRated.Results;
            return View("Zone", results);
        }
    }
}