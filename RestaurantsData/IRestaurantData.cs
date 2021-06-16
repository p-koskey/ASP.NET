using System;
using System.Collections.Generic;
using System.Text;

namespace RestaurantsData
{
    public interface IRestaurantData<T> where T : class
    {
        IEnumerable<T> GetAll();
        T Get(int Id);
       void Add(T entity);
        void Remove(T entity);
        void Update(T entity);
       
    }
}
