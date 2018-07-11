using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
using System.Threading.Tasks;
using Vue2Spa.Models;

namespace Vue2Spa.Station
{
    public class GetStation : IGetStation
    {
        public async Task<IEnumerable<StationModel>> ReturnStationBasedOnTag()
        {
            const string dublinBikesApiKey = "bd691853cab2e508f00c0fea04bd3599d1ba42e5";

            using (var client = new HttpClient())
            {
                var url = new Uri($"https://api.jcdecaux.com/vls/v1/stations?contract=dublin&apiKey=" + dublinBikesApiKey);

                var respone = await client.GetAsync(url);

                string json;
                //Using async, this reads out the response and deserializes from a json object to the station model
                using(var content = respone.Content)
                {
                    json = await content.ReadAsStringAsync();
                }


                var result = JsonConvert.DeserializeObject<IEnumerable<StationModel>>(json);

                Debug.Write(result);
                var orderedResults = result.OrderBy(o=>o.StationName);
                return orderedResults;
            }
        }
    }
}
