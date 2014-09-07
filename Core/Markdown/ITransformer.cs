using System;
using MarkdownSharpPlus;

namespace Core
{
	public interface IMarkdownTransformer
	{
		void Transform(IMarkdownPage input);
	}
}

