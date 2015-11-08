using NetProject.Mvc.Infrastructure.Factory;
using NetProject.Mvc.Infrastructure.Ioc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace NetProject.Mvc
{
    public class MvcApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            RouteConfig.RegisterRoutes(RouteTable.Routes);

            var container = Container.WindsorContainer;

            var controllerFactory = new WindsorControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
        }
    }
}
