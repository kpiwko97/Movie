using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Movie.Models.RestModels;

namespace Movie.Controllers
{
    public class HomeController : Controller
    {
        private readonly UrlPathRequest _urlPathRequest;

        public HomeController( UrlPathRequest urlPathRequest)
        {
            _urlPathRequest = urlPathRequest;
        }

        public ViewResult Movie()
        {
            _urlPathRequest.SetType(nameof(Movie).ToLower());
            return View("Index", _urlPathRequest);
        }

        public ViewResult Tv()
        {
            _urlPathRequest.SetType(nameof(Tv).ToLower());
            return View("Index", _urlPathRequest);
        }

        public ViewResult ShowAll(string header, int page = 1, string type = "Movie", int genreId = 28)// wyrzucic prezdefiniowane zmienne jako ? i akceptowalne null
        {
            _urlPathRequest.SetType(type);
            _urlPathRequest.SetPage(page);
            _urlPathRequest.ReturnUrlPathWithParameters(new Dictionary<string, string>{["with_genres"] = genreId.ToString()});
            return View("ShowAll", _urlPathRequest);
        }

        public IActionResult ChangeLanguage(string language, string returnUrl)
        {
            _urlPathRequest.SetLanguage(language);
            _urlPathRequest.ReturnUrlPath();
            return Redirect(returnUrl);
        }
        public ViewResult Training()
        {
            return View();
        }
    }
}

