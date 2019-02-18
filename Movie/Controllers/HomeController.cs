using Microsoft.AspNetCore.Mvc;

namespace Movie.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View("Index");
        }
    }
}

