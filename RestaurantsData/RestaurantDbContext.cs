using RestaurantsModel;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsData
{
    public class RestaurantDbContext : DbContext, IDbContext
    {
        public RestaurantDbContext(): base("RestaurantDbContext")
        {

        }
    public DbSet<Restaurants> Restaurants { get; set; }

        IDbSet<TEntity> IDbContext.Set<TEntity>()
        {
            return base.Set<TEntity>();
        }
    }
}