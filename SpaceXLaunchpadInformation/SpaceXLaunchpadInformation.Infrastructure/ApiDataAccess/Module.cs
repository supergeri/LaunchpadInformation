using Autofac;
using System;
using System.Collections.Generic;
using System.Text;

namespace SpaceXLaunchpadInformation.Infrastructure.ApiDataAccess
{
    public class Module : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<Context>()
                .As<Context>()
                .SingleInstance();

            builder.RegisterAssemblyTypes()
                .Where(type => type.Namespace.Contains("ApiDataAccess"))
                .AsImplementedInterfaces()
                .InstancePerLifetimeScope();
        }
    }
}
