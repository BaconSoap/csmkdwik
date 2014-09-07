﻿namespace MarkdownSharpPlus.Transformers
{
	internal static class CoreExtensions
	{
		internal static string Apply(this string format, params string[] formattingArgs)
		{
			return string.Format(format, formattingArgs);
		}
	}
}