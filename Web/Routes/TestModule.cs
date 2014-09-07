using System;
using Nancy;
using Core;

namespace Web
{
	public class TestModule: NancyModule
	{
		public TestModule(MarkdownTranslatorService service)
		{

			Get ["/"] = _ => {
				return View["index.html", service.GetHtml("index.md")];
			};
		}
	}
}

