using System;
using Autofac;
using Nancy;
using Nancy.Bootstrapper;
using Nancy.Bootstrappers.Autofac;

namespace Web
{
	public class AutofacBootstrapper: AutofacNancyBootstrapper
	{
		protected override void ApplicationStartup(ILifetimeScope container, IPipelines pipelines)
		{
			// No registrations should be performed in here, however you may
			// resolve things that are needed during application startup.
			StaticConfiguration.DisableErrorTraces = false;
		}

		protected override void ConfigureApplicationContainer(ILifetimeScope existingContainer)
		{
			// Perform registration that should have an application lifetime
			var builder = new ContainerBuilder();
			builder.RegisterModule<WebLifetimeModule>();
			builder.Update(existingContainer.ComponentRegistry);
		}

		protected override void ConfigureRequestContainer(ILifetimeScope container, NancyContext context)
		{
			var builder = new ContainerBuilder();
			builder.RegisterModule<Core.CoreModule>();
			builder.RegisterModule<WebModule>();
			builder.Update(container.ComponentRegistry);
		}

		protected override void RequestStartup(ILifetimeScope container, IPipelines pipelines, NancyContext context)
		{
			// No registrations should be performed in here, however you may
			// resolve things that are needed during request startup.
		}

	}
}

