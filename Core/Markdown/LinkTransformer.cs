using System;
using System.Text.RegularExpressions;

namespace Core.Markdown
{
	public class LinkTransformer: IMarkdownTransformer
	{
		Regex LinkRegex {get;set;}

		#region IMarkdownTransformer implementation

		public string Transform(string input)
		{
			return LinkRegex.Replace(input, @"<a href=""/$1"">$1</a>");
		}

		#endregion

		public LinkTransformer()
		{
			LinkRegex = new Regex(@"\[\[(.+)\]\]");
		}
	}
}

