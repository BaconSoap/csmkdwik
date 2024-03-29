﻿using System;
using Nancy;
using Core;
using Nancy.ModelBinding;
using Nancy.Extensions;
using Nancy.Responses.Negotiation;
using MarkdownSharpPlus;
using Data;


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
				MarkdownPage model = service.GetPage(_.name + ".md");
				return Negotiate
					.WithModel(model)
					.WithView("index.html");
			};

			Get["/all"] = _ => {
				return View["all.html", service.GetAll()];
			};

			Post["/{name}/checkbox/{id}"] = _ => {
				var checkbox = this.Bind<CheckboxDto>();
				MarkdownPage page = service.GetPage(_.name);
				return new {result = true};
			};

			Get["/{name}/checkbox/{id}"] = _ => {
				var checkbox = this.Bind<CheckboxDto>();
				return new {result = true};
			};


		}
	}
}

