using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Vue2Spa.Models
{
    [DataContract]
    public class Position
    {
        [JsonProperty("lat")]
//        [DataMember(Name = "lat")]
        public double StationLat { get; set; }

        [JsonProperty("lng")]
//        [DataMember(Name = "lng")]
        public double StationLng { get; set; }
    }
}
