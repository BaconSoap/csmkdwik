using System;
using Autofac;

namespace Core
{
	public class CoreModule: Autofac.Module
	{
		protected override void Load(Autofac.ContainerBuilder builder)
		{
			builder.RegisterType<MarkdownTranslatorService>().AsSelf().InstancePerDependency();
		}
	}
}

