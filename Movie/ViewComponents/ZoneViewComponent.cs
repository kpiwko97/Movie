using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.ViewComponents
{
    public class ZoneViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync(string request)
        {
            var GetUpcoming = await GenericRestRequest<GetUpcoming>.GetDataAsync(UrlPaths.ResourceManager.GetString(request));
            var results = GetUpcoming.Results;
            return View("Zone", results);
        }
    }
}