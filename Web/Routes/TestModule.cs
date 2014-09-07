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

			Get["/{name}"] = _ => {
				return View["index.html", service.GetHtml(_.name + ".md")];
			};

			Get["/all"] = _ => {
				return View["all.html", service.GetAll()];
			};
		}
	}
}

