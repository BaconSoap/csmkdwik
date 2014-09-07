using System;
using System.Text.RegularExpressions;

namespace Core.Markdown
{
	public class CheckboxTransformer: IMarkdownTransformer
	{
		Regex UncheckedReplacer { get; set;}
		Regex CheckedReplacer { get; set;}

		private const string UncheckedCheckbox = @"<input type=""checkbox"" />";
		private const string CheckedCheckbox = @"<input type=""checkbox"" checked=""checked"" />";

		public CheckboxTransformer()
		{
			UncheckedReplacer = new Regex(@"\[ \]");
			CheckedReplacer = new Regex(@"\[[xX]\]", RegexOptions.Compiled);
		}

		public string Transform(string input)
		{
			return CheckedReplacer.Replace(UncheckedReplacer.Replace(input, UncheckedCheckbox), CheckedCheckbox);
		}
	}
}

