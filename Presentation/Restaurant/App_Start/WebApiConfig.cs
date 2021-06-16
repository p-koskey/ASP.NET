using Microsoft.Practices.Unity;
using Unity;
using Unity.Mvc4;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
/*using RestaurantsData;
*/
namespace Restaurant.App_Start
{
    public static class WebApiConfig
    {
        public static void Register(HttpConfiguration config)
        {
            var container = new UnityContainer();
           
        
          /*  container.RegisterType<IRestaurantRepo, RestaurantRepo>(new ContainerControlledLifetimeManager());
            container.RegisterType<RestaurantDbContext>(new ContainerControlledLifetimeManager());*/
            config.DependencyResolver = new UnityResolver(container);
            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "api/{controller}/{id}",
                defaults: new { id = RouteParameter.Optional }
            );
        }
    }
}