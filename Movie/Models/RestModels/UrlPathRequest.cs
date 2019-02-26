using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Movie.Models.RestModels
{
    public class UrlPathRequest
    {
        public int Page { get; set; } = 1; //domyslnie page 1
        public string Type { get; set; }
        public string Language { get; set; } = "pl-PL"; // dla zmiany jezyka zwroc obiekt ktory ma wszystko takie same ale jezyk sie zmienia
        public string Parameters;// dla reszty paramterow
        public string ReturnUrl { get; set; }

        //logika calkowitej zmiany 
        public string GenerateUrl(string language, int page, string apiSectionPath) // po probach zmienic na private!! //przychodzacy parametr language umozliwi wepchniecie logiki zmiany jezyka ^^
        {
            Page = page;
            Language = language;;
            // wyjebac to do innej metody 

            
            //foreach (var parameter in Parameters)
            //{
            //    allParameters = allParameters + "&" + parameter.Key.ToLower() + "=" + parameter.Value;
            //}

            ReturnUrl = RequestUrlProperties.baseUrl + Type + RequestUrlProperties.apiKey + "&"+nameof(Page)+"="+Page+Parameters;

            return ReturnUrl;

        }
        public string ReturnUrlPath() => RequestUrlProperties.baseUrl + Type + RequestUrlProperties.apiKey + "&" + nameof(Page) + "=" + Page + Parameters;

        public void SetParameters(Dictionary<string,string> parameters)
        {
            foreach (var parameter in parameters)
            {
                Parameters = "&" + parameter.Key.ToLower() + "=" + parameter.Value;
            }
        }
    }
}
