using Autofac;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using WcfData;
using WcfRepository;
using WcfRepository.Model;

namespace WcfFacade
{
    public static class AutofacContainerBuilder
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<Service1>().As<IService1>();
            builder.RegisterType<Repository>().As<IRepository>();
            builder.RegisterType<ProjectCrudWcfEntities>().As<DbContext>().AsSelf();

            return builder.Build();
        }
    }
}