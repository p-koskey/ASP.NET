using AutoMapper;
using RestaurantsModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsServices
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<Restaurants, RestaurantDTO>();
            CreateMap<RestaurantDTO, Restaurants>();
        }
    }
}
