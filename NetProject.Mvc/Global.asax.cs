<<<<<<< HEAD
﻿using NetProject.Mvc.Infrastructure.Factory;
using NetProject.Mvc.Infrastructure.Ioc;
using System;
=======
﻿using System;
>>>>>>> dccc99685e4292ffa4d3a031e87be19b68dfbf6b
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
<<<<<<< HEAD

            var container = Container.WindsorContainer;

            var controllerFactory = new WindsorControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
=======
>>>>>>> dccc99685e4292ffa4d3a031e87be19b68dfbf6b
        }
    }
}
