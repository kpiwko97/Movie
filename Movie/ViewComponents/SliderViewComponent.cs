using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Movie.ViewComponents
{
    public class SliderViewComponent : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
           return View("Slider");
        }
    }
}