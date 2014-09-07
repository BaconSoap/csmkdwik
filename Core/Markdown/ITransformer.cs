using System;

namespace Core
{
	public interface IMarkdownTransformer
	{
		string Transform(string input);
	}
}

