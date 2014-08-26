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
			var svc = new Kiwi.Markdown.MarkdownService(new MarkdownProvider(Repo, new Markdown.CheckboxTransformer()));
			
			return svc.GetDocument(path).Content;
		}
	}

	public class MarkdownProvider: Kiwi.Markdown.IContentProvider
	{
		private IMarkdownRepository Repo { get; set; }
		private Markdown.CheckboxTransformer Checkbox { get; set; }
		public MarkdownProvider(IMarkdownRepository repo, Markdown.CheckboxTransformer checkboxTransformer)
		{
			Repo = repo;
			Checkbox = checkboxTransformer;
		}

		public string GetContent(string docId)
		{
			return Checkbox.Transform(Repo.GetMarkdownDocument(docId));
		}
	}

}

