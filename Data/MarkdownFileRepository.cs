using System;
using System.IO;

namespace Data
{
	public class MarkdownFileRepository: IMarkdownRepository
	{
		string RootPath { get; set; }
		public MarkdownFileRepository()
		{
			RootPath = Environment.GetEnvironmentVariable("WIKI_DATA_ROOT");
			if(RootPath == null)
			{
				RootPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.Personal), "wikiData");
				var filePath = Path.Combine(RootPath, "index.md");

				if(!File.Exists(filePath))
				{
					CreateIndex();
				}
			}

			if(!Directory.Exists(RootPath))
			{
				Directory.CreateDirectory(RootPath);
				CreateIndex();
			}
		}
			
		public void CreateIndex()
		{
			var filePath = Path.Combine(RootPath, "index.md");
			var writer = new StreamWriter(File.Open(filePath, FileMode.CreateNew));
			writer.WriteLine("you need to setup your environment according to `README.md`");

			writer.Flush();
			writer.Dispose();
		}
		public string GetMarkdownDocument(string path)
		{
			var data = String.Empty;
			using(var reader = new StreamReader(new FileStream(Path.Combine(RootPath, path), FileMode.Open)))
			{
				data = reader.ReadToEnd();
			}
			return data;
		}

	}
}

