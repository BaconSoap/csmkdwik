using System;

namespace Core.Markdown
{
	public class CheckboxTransformer
	{
		public CheckboxTransformer()
		{
		}

		public string Transform(string input)
		{
			return input.Replace("[ ]", @"<input type=""checkbox"" />");
		}
	}
}

