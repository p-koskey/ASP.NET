using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace RestaurantsModel
{
    [DataContract(Name = "CuisineType")]
    public enum Cuisine
    {
        [EnumMember(Value = "None")]
        None,
        [EnumMember(Value = "Kenyan")]
        Kenyan,
        [EnumMember(Value = "Italian")]
        Italian,
        [EnumMember(Value = "Indian")]
        Indian
    }
}
