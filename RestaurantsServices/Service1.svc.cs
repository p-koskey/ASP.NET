using AutoMapper;
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
        private readonly IMapper _mapper;

        public Service1(IRestaurantData<Restaurants> restaurant, IMapper mapper)
        {
            _mapper = mapper;
            _restaurant = restaurant;

        }
        public void Add(RestaurantDTO entity)
        {
            _restaurant.Add(_mapper.Map<Restaurants>(entity));            

        }

        public RestaurantDTO Get(int Id)
        {
           var data =  _restaurant.Get(Id);
            return _mapper.Map<RestaurantDTO>(data);
        }


        public IEnumerable<RestaurantDTO> GetAll()
        {

          var data =  _restaurant.GetAll();

           return _mapper.Map<IEnumerable<RestaurantDTO>>(data);



        }

        public string GetData(int value)
        {
            return string.Format("You entered: {0}", value);
        }


        public void Remove(RestaurantDTO entity)
        {
            _restaurant.Remove(_mapper.Map<Restaurants>(entity));
        }

        public void Update(RestaurantDTO entity)
        {
            _restaurant.Update(_mapper.Map<Restaurants>(entity));
        }
    }
}
