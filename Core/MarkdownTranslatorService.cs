﻿using System;
using Data;
using System.Collections.Generic;
using MarkdownSharpPlus;

namespace Core
{
	public class MarkdownTranslatorService
	{
		private IMarkdownRepository Repo { get; set; }
		public MarkdownTranslatorService(IMarkdownRepository repo)
		{
			Repo = repo;
		}

		public IMarkdownPage GetPage(string path)
		{
			var svc = new MarkdownSharpPlus.Markdown.MarkdownService(new MarkdownProvider(Repo));
			
			return svc.GetPage(path);
		}

		public List<KeyValuePair<string, string>> GetAll()
		{
			return Repo.GetAll();
		}
	}

	public class MarkdownProvider: MarkdownSharpPlus.Markdown.IContentProvider
	{
		private IMarkdownRepository Repo { get; set; }
		private List<IMarkdownTransformer> Transformers { get; set;}

		public MarkdownProvider(IMarkdownRepository repo)
		{
			Repo = repo;
			Transformers = new List<IMarkdownTransformer>();
			Add(new Markdown.CheckboxTransformer());
			Add(new Markdown.LinkTransformer());
		}

		private void Add(IMarkdownTransformer transformer)
		{
			Transformers.Add(transformer);
		}

		public IMarkdownPage GetContent(string docId)
		{
			var data = Repo.GetMarkdownDocument(docId);

			Transformers.ForEach(t => t.Transform(data));

			return data;
		}
	}

}

