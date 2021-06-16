using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsModel
{
    public class RestaurantDTO
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember(IsRequired = true)]
        public string Name { get; set; }
        [DataMember(IsRequired = true)]
        public string CuisineType
        {
            get { return CuisineEnum.ToString(); }
            private set { /* NOOP */ }
        }

        [DataMember(IsRequired = true)]
        [JsonIgnore]
        public CuisineDTO CuisineEnum { get; set; }
    }
}
