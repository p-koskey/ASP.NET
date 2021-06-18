using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Unity;

namespace RestaurantsServices.AutoMapperConfig
{
class AutoMapperConfig
    {
        public static MapperConfiguration InitializeAutoMapper()
        {
            var config = new MapperConfiguration(cfg =>
            {
                
                cfg.AddProfile(new AutoMapperProfile());

            });

            return config;
        }
    }
}