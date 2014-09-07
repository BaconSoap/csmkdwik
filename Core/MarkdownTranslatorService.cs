using System;
using Data;
using System.Collections.Generic;
using MarkdownSharpPlus;
using MarkdownSharpPlus.Transformers;

namespace Core
{
	public class MarkdownTranslatorService
	{
		private IMarkdownRepository Repo { get; set; }
		public MarkdownTranslatorService(IMarkdownRepository repo)
		{
			Repo = repo;
		}

		public MarkdownPage GetPage(string path)
		{
			var svc = new MarkdownSharpPlus.Transformers.MarkdownService(new MarkdownProvider(Repo));
			
			return svc.GetPage(path);
		}

		public List<KeyValuePair<string, string>> GetAll()
		{
			return Repo.GetAll();
		}
	}

	public class MarkdownProvider: MarkdownSharpPlus.Transformers.IContentProvider
	{
		private IMarkdownRepository Repo { get; set; }
		private List<IMarkdownTransformer> Transformers { get; set;}

		public MarkdownProvider(IMarkdownRepository repo)
		{
			Repo = repo;
			Transformers = new List<IMarkdownTransformer>();
			Add(new CheckboxTransformer());
			Add(new LinkTransformer());
		}

		private void Add(IMarkdownTransformer transformer)
		{
			Transformers.Add(transformer);
		}

		public MarkdownPage GetContent(string docId)
		{
			var data = Repo.GetMarkdownDocument(docId);

			Transformers.ForEach(t => t.Transform(data));

			return data;
		}
	}

}

