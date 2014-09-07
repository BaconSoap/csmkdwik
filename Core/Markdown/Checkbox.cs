using System;
using System.Text.RegularExpressions;
using MarkdownSharpPlus;

namespace Core.Markdown
{
	public class CheckboxTransformer: IMarkdownTransformer
	{
		Regex CheckedReplacer { get; set;}

		private const string UncheckedCheckbox = @"<input type=""checkbox"" data-mkdwiki data-mkdwiki-id=""{0}"" />";
		private const string CheckedCheckbox = @"<input type=""checkbox"" checked=""checked"" data-mkdwiki data-mkdwiki-id=""{0}"" />";

		public CheckboxTransformer()
		{
			CheckedReplacer = new Regex(@"\[([xX\x20])\]", RegexOptions.Compiled);
		}

		public void Transform(IMarkdownPage input)
		{
			int id = 0;
			input.Contents = CheckedReplacer.Replace(input.Contents, (m) => {
				var html = "";
				switch (m.Groups[1].Value) {
				case "x":
				case "X":
					{
						html = CheckedCheckbox;
						break;
					}
				case " ":
					{
						html = UncheckedCheckbox;
						break;
					}
				default:
					throw new NotImplementedException();
				}
				html = String.Format(html, id++);
				return html;
			});
		}

	}
}

