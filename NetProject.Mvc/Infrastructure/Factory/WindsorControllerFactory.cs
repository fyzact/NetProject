using Castle.Windsor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NetProject.Mvc.Infrastructure.Factory
{
    public class WindsorControllerFactory : DefaultControllerFactory
    {
        private readonly IWindsorContainer _container;

        public WindsorControllerFactory(IWindsorContainer container)
        {
            this._container = container;
        }

        public override void ReleaseController(IController controller)
        {
            _container.Release(controller.GetType());
        }

        protected override IController GetControllerInstance(System.Web.Routing.RequestContext requestContext, Type controllerType)
        {
            if (controllerType == null)
            {
                HttpContext.Current.Response.Redirect("/Error/PageNotFound");
            }

            return (IController)_container.Resolve(controllerType);
        }
    }
}