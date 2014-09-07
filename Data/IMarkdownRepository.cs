using System;
using System.Collections.Generic;

namespace Data
{
	public interface IMarkdownRepository
	{
		MarkdownPage GetMarkdownDocument(string path);
		List<KeyValuePair<string, string>> GetAll();
	}
}

