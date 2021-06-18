using AutoMapper;
using RestaurantsData;
using RestaurantsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;
using Unity.Injection;
using Unity.Lifetime;

namespace RestaurantsServices
{
    public static class Container
    {
        #region Properties

        /// <summary>
        /// Get the current configured container
        /// </summary>
        /// <returns>Configured container</returns>
        public static IUnityContainer Current { get; private set; }

        #endregion

        #region Constructor

        static Container()
        {
            ConfigureContainer();
        }

        #endregion

        #region Methods

        private static void ConfigureContainer()
        {
            /*
            * Add here the code configuration or the call to configure the container
            * using the application configuration file
            */

            Current = new UnityContainer();

            //-> Repositories
            Current.RegisterType(typeof(IRestaurantData<>), typeof(RestaurantDataRepo<>));
            //DbContext
            Current.RegisterType<IDbContext, RestaurantDbContext>();
            var mapperConfig = AutoMapperConfig.AutoMapperConfig.InitializeAutoMapper();
            var mapper = mapperConfig.CreateMapper();
            Current.RegisterType<IMapper, Mapper>(new InjectionConstructor(mapperConfig));
            Current.RegisterInstance(mapper);
            Current.RegisterType<IMapper, Mapper>(new InjectionConstructor(mapperConfig));
           /* Current.RegisterInstance("Mapper", config.CreateMapper(), new ContainerControlledLifetimeManager());*/
        }

        #endregion
    }
}