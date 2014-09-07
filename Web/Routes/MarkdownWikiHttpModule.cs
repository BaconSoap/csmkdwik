using System;
using Nancy;
using Core;
using Nancy.ModelBinding;

namespace Web
{
	public class MarkdownWikiHttpModule: NancyModule
	{
		public MarkdownWikiHttpModule(MarkdownTranslatorService service)
		{

			Get ["/"] = _ => {
				return View["index.html", service.GetPage("index.md")];
			};

			Get["/{name}"] = _ => {
				return View["index.html", service.GetPage(_.name + ".md")];
			};

			Get["/all"] = _ => {
				return View["all.html", service.GetAll()];
			};

			Post["/{name}/checkbox/{id}"] = _ => {
				var checkbox = this.Bind<CheckboxDto>();
				return new {result = true};
			};

			Get["/{name}/checkbox/{id}"] = _ => {
				var checkbox = this.Bind<CheckboxDto>();
				return new {result = true};
			};
		}
	}
}

