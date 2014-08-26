using System;

namespace Data
{
	public class MarkdownFileRepository: IMarkdownRepository
	{
		public MarkdownFileRepository()
		{
		}
			
		public string GetMarkdownDocument(string path)
		{
			return @"
##Hello

This is a markdown document
";
		}

	}
}

