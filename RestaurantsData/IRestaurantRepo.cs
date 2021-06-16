using RestaurantsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsData
{
    public interface IRestaurantRepo 
    {
       void Update(Restaurants restaurant);
       
    }
}

