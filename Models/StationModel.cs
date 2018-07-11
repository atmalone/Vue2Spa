using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Threading.Tasks;

namespace Vue2Spa.Models
{
    //[DataContract]
    public class StationModel
    {
        [JsonProperty("number")]
        //[DataMember(Name = "number")]
        public int StationId { get; set; }

        [JsonProperty("name")]
        //[DataMember(Name = "name")]
        public string StationName { get; set; }

        [JsonProperty("address")]
        //[DataMember(Name = "address")]
        public string StationAddress { get; set; }

        [JsonProperty("position")]
        //[DataMember(Name = "position")]
        public Position Position { get; set; }

        [JsonProperty("available_bikes")]
        //[DataMember(Name = "available_bikes")]
        public int StationBikes { get; set; }

        [JsonProperty("available_bike_stands")]
        //[DataMember(Name = "available_bike_stands")]
        public int StationParking { get; set; }
    }
}
