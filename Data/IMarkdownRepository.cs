using System;
using System.Collections.Generic;

namespace Data
{
	public interface IMarkdownRepository
	{
		string GetMarkdownDocument(string path);
		List<KeyValuePair<string, string>> GetAll();
	}
}

