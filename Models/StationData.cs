using System.Collections.Generic;
using System.Runtime.Serialization;
using Newtonsoft.Json;

namespace Vue2Spa.Models
{
    [DataContract]
    public class StationData
    {
//        [JsonArrayAttribute]
        //[DataMember(Name = "number")]
        public List<StationModel> stations { get; set; }
    }
}
