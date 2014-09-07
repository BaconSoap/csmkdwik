using System;
using MarkdownSharpPlus;
using Data;

namespace MarkdownSharpPlus.Transformers
{
	public interface IMarkdownTransformer
	{
		void Transform(MarkdownPage input);
	}
}

