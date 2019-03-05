using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Movie.Models.RestModels;

namespace Movie.Infrastructure.TagHelpers
{
    [HtmlTargetElement("LanguageTagHelper")]
    public class LanguageTagHelper : TagHelper
    {
        private readonly UrlPathRequest _urlPathRequest;
        private readonly IUrlHelperFactory _urlHelperFactory;

        public LanguageTagHelper(UrlPathRequest urlPathRequest,IUrlHelperFactory urlHelperFactory)
        {
            _urlPathRequest = urlPathRequest;
            _urlHelperFactory = urlHelperFactory;

        }

        [ViewContext]
        public ViewContext ViewContextData { get; set; }


        public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
        {
            List<string> shortLanguage= new List<string>();
            var getGenre = await GenericRestRequest<string[]>.GetDataAsync(RequestUrlProperties.GetTranslations);
            var getGenreList = getGenre.ToList();
            getGenreList.ForEach(g=>
            {
                shortLanguage.Add(g.Substring(g.IndexOf('-') + 1).ToLower());
            });    
            output.TagName = "div";

            foreach (string genre in shortLanguage.Distinct().OrderBy(a => a))
            {
                TagBuilder a = new TagBuilder("a");
                a.InnerHtml.Append(genre);
                a.Attributes.Add("class", "btn navbar-button-language my-2");

                TagBuilder span = new TagBuilder("span");
                span.Attributes["class"] = $"flag-icon flag-icon-{genre}";
                a.InnerHtml.AppendHtml(span);
                output.Content.AppendHtml(a);

                IUrlHelper urlHelper = _urlHelperFactory.GetUrlHelper(ViewContextData);
                a.Attributes.Add("href", urlHelper.Action("ChangeLanguage", "Home", new { language = genre, returnUrl = urlHelper.Action(ViewContextData.RouteData.Values["action"].ToString(), ViewContextData.RouteData.Values["controller"].ToString()) }));
                //add disable button when language content is empty
                //add nice View 
                //add actual language in outside 
            }
        }
    }
}
