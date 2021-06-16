using System.Web.Mvc;
using Microsoft.Practices.Unity;
/*using RestaurantsData;*/
using Unity.Mvc4;

namespace Restaurant
{
  public static class Bootstrapper
  {
    public static IUnityContainer Initialise()
    {
      var container = BuildUnityContainer();

      DependencyResolver.SetResolver(new UnityDependencyResolver(container));

      return container;
    }

    private static IUnityContainer BuildUnityContainer()
    {
      var container = new UnityContainer();
           /* container.RegisterType<IRestaurantRepo, RestaurantRepo>(new ContainerControlledLifetimeManager());
            container.RegisterType(typeof(IRestaurantData<>), (typeof(RestaurantDataRepo<>)));
            container.RegisterType<RestaurantDbContext>(new ContainerControlledLifetimeManager());*/
      // register all your components with the container here
      // it is NOT necessary to register your controllers

      // e.g. container.RegisterType<ITestService, TestService>();   
      RegisterTypes(container);

      return container;
    }

    public static void RegisterTypes(IUnityContainer container)
    {
    
    }
  }
}