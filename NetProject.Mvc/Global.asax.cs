<<<<<<< HEAD
﻿using NetProject.Mvc.Infrastructure.Factory;
using NetProject.Mvc.Infrastructure.IoC;
using System;
=======
<<<<<<< HEAD
<<<<<<< HEAD
﻿using NetProject.Mvc.Infrastructure.Factory;
using NetProject.Mvc.Infrastructure.Ioc;
using System;
=======
﻿using System;
>>>>>>> dccc99685e4292ffa4d3a031e87be19b68dfbf6b
=======
﻿using System;
>>>>>>> parent of eae2cc6... Imlemented Castle windsor
>>>>>>> origin/master
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
=======
<<<<<<< HEAD
<<<<<<< HEAD
>>>>>>> origin/master

            var container = Container.WindsorContainer;

            var controllerFactory = new WindsorControllerFactory(container);
            ControllerBuilder.Current.SetControllerFactory(controllerFactory);
<<<<<<< HEAD
=======
=======
>>>>>>> dccc99685e4292ffa4d3a031e87be19b68dfbf6b
=======
>>>>>>> parent of eae2cc6... Imlemented Castle windsor
>>>>>>> origin/master
        }
    }
}
