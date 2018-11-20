using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceXLaunchpadInformation.Infrastructure
{
    public class ApplicationModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes()
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
