using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Movie.Models.RestModels
{
    public class UrlPathRequest
    {
        private int Page { get; set; } = 1;
        private string Type { get; set; }
        private string Language { get; set; } = "pl";
        private string Parameters;

        public string ReturnUrlPath() => RequestUrlProperties.baseUrl + Type + RequestUrlProperties.apiKey + "&" + nameof(Page).ToLower() + "=" + Page + Parameters + "&" + nameof(Language).ToLower() + "=" + Language;
        public string ReturnGenreUrlPath() => $"https://api.themoviedb.org/3/genre/{Type}/list" + RequestUrlProperties.apiKey + "&" + nameof(Language).ToLower() + "=" + Language;
        public string ReturnUrlPathWithParameters(Dictionary<string,string> parameters)
        {
            foreach (var parameter in parameters)
            {
                Parameters = "&" + parameter.Key.ToLower() + "=" + parameter.Value;
            }
            return ReturnUrlPath();
        }
        public string ReturnUrlUpgrade(string getString) => "https://api.themoviedb.org/3/" + getString + Type + RequestUrlProperties.apiKey + " & " + nameof(Page).ToLower() + "=" + Page + Parameters + "&" + nameof(Language).ToLower() + "=" + Language;
          
        public void SetLanguage(string language)
        {
            Language = language;
        }
        public void SetType(string type)
        {
            Type = type.ToLower();
        }
        public void SetPage(int page)
        {
            Page = page;
        }

    }
}
