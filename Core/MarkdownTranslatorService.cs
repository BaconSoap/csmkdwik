using System;
using Data;
using System.Collections.Generic;

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
			var svc = new Kiwi.Markdown.MarkdownService(new MarkdownProvider(Repo));
			
			return svc.GetDocument(path).Content;
		}

		public List<KeyValuePair<string, string>> GetAll()
		{
			return Repo.GetAll();
		}
	}

	public class MarkdownProvider: Kiwi.Markdown.IContentProvider
	{
		private IMarkdownRepository Repo { get; set; }
		private List<IMarkdownTransformer> Transformers { get; set;}

		public MarkdownProvider(IMarkdownRepository repo)
		{
			Repo = repo;
			Transformers = new List<IMarkdownTransformer>();
			Add(new Markdown.CheckboxTransformer());
		}

		private void Add(IMarkdownTransformer transformer)
		{
			Transformers.Add(transformer);
		}

		public string GetContent(string docId)
		{
			var data = Repo.GetMarkdownDocument(docId);
			foreach (var transformer in Transformers)
			{
				data = transformer.Transform (data);
			}
			return data;
		}
	}

}

