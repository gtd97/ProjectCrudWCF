using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wcf.Common.Module
{
    public static class ModuleWcf
    {
        public static IContainer BuildContainer()
        {
            var builder = new ContainerBuilder();
            
            builder.RegisterType<Service>().As<IService>();
            
            return builder.Build();
        }
    }
}
