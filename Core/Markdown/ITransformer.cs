using System;
using Kiwi;

namespace Core
{
	public interface IMarkdownTransformer
	{
		void Transform(IMarkdownPage input);
	}
}

