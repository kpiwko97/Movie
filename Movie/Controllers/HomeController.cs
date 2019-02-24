using Microsoft.AspNetCore.Mvc;
using Movie.Models;

namespace Movie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResource _repository;
        public HomeController(IResource repository) => _repository = repository;

        public ViewResult Movies()
        {
            _repository.SetResource(MovieUrlRequests.ResourceManager);
            return View("Index");
        }

        public ViewResult Series()
        {
            _repository.SetResource(SeriesUrlRequest.ResourceManager);
            return View("Index");
        }

        public ViewResult Training()
        {
            return View();
        }
    }
}

