using RestaurantsData;
using RestaurantsModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsData
{
    public class RestaurantRepo : RestaurantDataRepo<Restaurants>, IRestaurantRepo
    {
        private readonly IRestaurantData<Restaurants> _restaurantData;
        private readonly RestaurantDbContext _db;
        public RestaurantRepo(RestaurantDbContext db, IRestaurantData<Restaurants> restaurantData) : base (db)
        {
            _restaurantData = restaurantData;
            _db = db;
        }
        

        public new void Update(Restaurants restaurant)
        {

            var entry = _db.Entry(restaurant);
            entry.State = EntityState.Modified;
            _db.SaveChanges();

            _restaurantData.Add(restaurant);
        }
    }
}
