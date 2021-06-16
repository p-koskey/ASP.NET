using RestaurantsData;
using RestaurantsModel;
using RestaurantsServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestaurantsServices
{

    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    [ApplicationErrorHandlerAttribute] // Manage all unhandled exceptions
    [UnityInstanceProviderServiceBehavior] // Create instance and inject dependencies using unity container
    [ServiceBehavior(InstanceContextMode = InstanceContextMode.PerCall)]
    public class Service1 : IService1
    {
        private readonly IRestaurantData<Restaurants> _restaurant;

        public Service1(IRestaurantData<Restaurants> restaurant)
        {
            _restaurant = restaurant;
        }
        public void Add(Restaurants entity)
        {
            _restaurant.Add(entity);
        }

        public Restaurants Get(int Id)
        {
            return _restaurant.Get(Id);
        }

        public IEnumerable<Restaurants> GetAll()
        {
            return _restaurant.GetAll();
        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public void Remove(Restaurants entity)
        {
            _restaurant.Remove(entity);
        }

        public void Update(Restaurants entity)
        {
            _restaurant.Update(entity);
        }
    }
}
