using System;
using Kiwi;

namespace Data
{
	public class MarkdownPage: IMarkdownPage
	{
		public string Title {get;set;}
		public string Contents { get; set;}
		public MarkdownPage()
		{
		}
	}
}

