using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetProject.Mvc.Infrastructure.Installers
{
    public class ServiceInstaller:IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed("NetProject.Service")
                                  .Where(type => type.Name.EndsWith("Service"))
                                  .WithService
                                  .DefaultInterfaces()
                                  .Configure(c => c.LifeStyle.Transient.LifestyleSingleton()));

        

            container.Register(Classes.FromAssemblyNamed("NetProject.Mvc")
                               .BasedOn<IController>()
                               .LifestyleTransient().LifestyleSingleton());
        }
    }
}