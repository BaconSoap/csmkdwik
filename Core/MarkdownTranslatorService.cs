using System;
using Data;

namespace Core
{
	public class MarkdownTranslatorService
	{
		private IMarkdownRepository Repo { get; set; }
		public MarkdownTranslatorService(IMarkdownRepository repo)
		{
			Repo = repo;
		}

		public string GetHtml(string path)
		{

			var translator = new MarkdownSharp.Markdown();

			return translator.Transform(Repo.GetMarkdownDocument(path));
		}
	}
}

