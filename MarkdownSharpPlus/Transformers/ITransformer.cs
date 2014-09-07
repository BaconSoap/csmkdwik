using System;
using MarkdownSharpPlus;

namespace MarkdownSharpPlus.Transformers
{
	public interface IMarkdownTransformer
	{
		void Transform(IMarkdownPage input);
	}
}

