using System;
using System.Text.RegularExpressions;
using MarkdownSharpPlus;
using Data;

namespace MarkdownSharpPlus.Transformers
{
	public class LinkTransformer: IMarkdownTransformer
	{
		Regex LinkRegex {get;set;}

		#region IMarkdownTransformer implementation

		public void Transform(MarkdownPage input)
		{
			input.Contents = LinkRegex.Replace(input.Contents, @"<a href=""/$1"">$1</a>");
		}

		#endregion

		public LinkTransformer()
		{
			LinkRegex = new Regex(@"\[\[(.+)\]\]");
		}
	}
}

