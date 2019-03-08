using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.TagHelpers;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using Microsoft.CodeAnalysis.CSharp;
using RestSharp.Extensions;

namespace Movie.Infrastructure.TagHelpers
{
    [HtmlTargetElement("Pagination")]
    public class PaginationTagHelper : TagHelper
    {
        public int TotalPages { get; set; }
        [ViewContext]
        public ViewContext ViewContext { get; set; }

        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            TotalPages = TotalPages < 1000 ? TotalPages : 1000;
            output.TagName = "div";
            output.Attributes.Add("class","nav-links");

            TagBuilder dots = new TagBuilder("span");
            dots.Attributes.Add("class", "page-numbers dots");
            dots.InnerHtml.Append("...");

            TagBuilder actualIndex;

            var actualPage = int.Parse(ViewContext.RouteData.Values["page"].ToString());
            actualIndex = new TagBuilder("a");
            actualIndex.Attributes.Add("class", "page-numbers");
            actualIndex.InnerHtml.SetContent("1");
            output.Content.AppendHtml(actualIndex);

            for (int i = 0; i <= 4; i++)
            {
                if (i.Equals(0) && actualPage>4) output.Content.AppendHtml(dots);

                if (((actualPage - 2) + i) >= 2 && ((actualPage -2)+i) < TotalPages  )
                {
                    actualIndex = new TagBuilder("a");
                    actualIndex.Attributes.Add("class", "page-numbers");
                    actualIndex.InnerHtml.SetContent(((actualPage - 2) + i).ToString());
                    output.Content.AppendHtml(actualIndex);
                }

                if (i.Equals(4) && actualPage<TotalPages-3) output.Content.AppendHtml(dots);
            }

            actualIndex = new TagBuilder("a");
            actualIndex.Attributes.Add("class", "page-numbers");
            actualIndex.InnerHtml.SetContent(TotalPages.ToString());
            output.Content.AppendHtml(actualIndex);
        }
    }
}
