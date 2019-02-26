using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Movie.Models;
using Movie.Models.RestModels;

namespace Movie.Controllers
{
    public class HomeController : Controller
    {
        private readonly IResource _repository;
        private readonly UrlPathRequest _urlPathRequest;

        public HomeController(IResource repository, UrlPathRequest urlPathRequest)
        {
            _repository = repository;
            _urlPathRequest = urlPathRequest;
        }

        public ViewResult Movie()
        {
            _repository.SetResource(MovieUrlRequests.ResourceManager); // do wywalenia
            _urlPathRequest.Type = "movie"; //zmienic action na movie zeby zrobic nameof()
            return View("Index", _urlPathRequest);
        }

        public ViewResult Tv()
        {
            _repository.SetResource(SeriesUrlRequest.ResourceManager);//do wywalenia
            _urlPathRequest.Type = "tv";//zmienic action na tv zeby zrobic nameof() zeby logika 
            return View("Index", _urlPathRequest);
        }

        public ViewResult ShowAll(string apiSectionPath, int page, int genreId)
        {
            _urlPathRequest.SetParameters(new Dictionary<string, string>{["with_genres"] = genreId.ToString()});
            return View("ShowAll", _urlPathRequest);
        }
        public ViewResult Training()
        {
            return View();
        }
    }
}

