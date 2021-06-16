using RestaurantsData;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsData
{
    public class RestaurantDataRepo<T> : IRestaurantData<T> where T : class
    {
        private readonly RestaurantDbContext _db;
        private IDbSet<T> _entities;
        public RestaurantDataRepo(RestaurantDbContext db)
        {
            _db = db;
        }
        private IDbSet<T> Entities
        {
            get
            {
                if (_entities == null)
                {
                    _entities = _db.Set<T>();
                }
                return _entities;
            }
        }
        public void Add(T entity)
        {
            _db.Set<T>().Add(entity);
            _db.SaveChanges();

        }

        public void Remove(T entity)
        {
            _db.Set<T>().Attach(entity);
            _db.Set<T>().Remove(entity);
            _db.SaveChanges();

        }


        public T Get(int Id)
        {
            return _db.Set<T>().Find(Id);
            _db.SaveChanges();
        }

        public IEnumerable<T> GetAll()
        {
            return Entities;
        }

        public void Update(T entity)
        {
            _db.Set<T>().Attach(entity);
            _db.Entry(entity).State = EntityState.Modified;
            _db.SaveChanges();
        }
    }
}
