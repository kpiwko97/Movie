using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.ViewComponents
{
    public class UpcomingViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            var GetUpcoming = await GenericRestRequest<GetUpcoming>.GetDataAsync(UrlPaths.ResourceManager.GetString("GetUpcoming"));
            var results = GetUpcoming.Results;
            return View("Upcoming", results);
        }
    }
}