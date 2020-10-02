using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using CommonMark;
using Microsoft.AspNetCore.Razor.Runtime.TagHelpers;
using Microsoft.AspNetCore.Razor.TagHelpers;

namespace IssueTracker.TagHelpers
{
	// You may need to install the Microsoft.AspNetCore.Razor.Runtime package into your project
	[HtmlTargetElement("pgr-markdown")]
	public class MarkdownTagHelper : TagHelper
	{
		public override async Task ProcessAsync(TagHelperContext context, TagHelperOutput output)
		{
			var childContent = await output.GetChildContentAsync();
			var decodedContent = HttpUtility.HtmlDecode(childContent.GetContent());
			var transformContent = CommonMarkConverter.Convert(decodedContent);
			output.TagName = null;
			output.Content.SetHtmlContent(transformContent);
		}
	}
}
