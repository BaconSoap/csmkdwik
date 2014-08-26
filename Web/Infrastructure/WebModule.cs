using System;
using Autofac;
using Data;

namespace Web
{
	public class WebModule: Autofac.Module
	{
		protected override void Load(Autofac.ContainerBuilder builder)
		{
			builder.RegisterType<MarkdownFileRepository>().AsImplementedInterfaces().InstancePerDependency();
		}
	}
}

