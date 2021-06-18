using RestaurantsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace RestaurantsServices
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        IEnumerable<RestaurantDTO> GetAll();
        [OperationContract]
        RestaurantDTO Get(int Id);
        [OperationContract]
        void Add(RestaurantDTO entity);
        [OperationContract]
        void Remove(RestaurantDTO entity);
        [OperationContract]
        void Update(RestaurantDTO entity);
    }
}
