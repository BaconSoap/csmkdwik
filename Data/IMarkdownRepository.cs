using System;

namespace Data
{
	public interface IMarkdownRepository
	{
		string GetMarkdownDocument(string path);
	}
}

