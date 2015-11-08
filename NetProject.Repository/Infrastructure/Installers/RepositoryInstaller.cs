using Castle.MicroKernel.Registration;
using Castle.MicroKernel.SubSystems.Configuration;
using Castle.Windsor;
using NetProject.Core;
using NetProject.Domain;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;



namespace NetProject.Repository.Infrastructure.Installers
{
    public class RepositoryInstaller:IWindsorInstaller
    {
        public void Install(IWindsorContainer container, IConfigurationStore store)
        {
            container.Register(Classes.FromAssemblyNamed("NetProject.Repository")
                                    .Where(type => type.Name.EndsWith("Repository"))
                                    .WithService.DefaultInterfaces()
                                    .Configure(c => c.LifeStyle.Transient.LifestyleTransient()));

            container.Register(Classes.FromAssemblyNamed("NetProject.Domain")
                               .BasedOn<BaseEntity>()
                                .Configure(c => c.LifeStyle.Transient.LifestyleTransient()));


            container
              .Register(Component.For(typeof(IRepository<>))
              .ImplementedBy(typeof(Repository.Repository<>))
              .LifestyleTransient());
            
            container
                .Register(Component.For(typeof(DbContext))
                .ImplementedBy(typeof(NetProjectContext))
                .LifestyleTransient());

           


             
            
        }
    }
}