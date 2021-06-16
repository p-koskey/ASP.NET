/*using RestaurantData.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Restaurant.API
{
    public class RestaurantsController : ApiController
    {
        private readonly IRestaurantData db;
        public RestaurantsController(IRestaurantData db)
        {
            this.db = db;
        }
        public IEnumerable<RestaurantData.Models.Restaurant> Get()
        {

            var model = db.GetAll();
            return model;
        }
    }
}
*/