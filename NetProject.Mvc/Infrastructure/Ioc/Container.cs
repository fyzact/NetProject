using Castle.Windsor;
using Castle.Windsor.Installer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace NetProject.Mvc.Infrastructure.Ioc
{
    public class Container
    {
        private static WindsorContainer _windsorContainer;

        public static WindsorContainer WindsorContainer
        {
            get
            {
                if (_windsorContainer == null)
                {
                    _windsorContainer = new WindsorContainer();
                    _windsorContainer.Install(FromAssembly.InThisApplication());
                }

                return _windsorContainer;
            }
        }
    }
}