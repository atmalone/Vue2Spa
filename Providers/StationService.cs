using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Vue2Spa.Models;
using Vue2Spa.Station;

namespace Vue2Spa.Providers
{
    public class StationService : IStationService
    {
        private readonly IGetStation _getStation;

        public StationService(IGetStation getStation)
        {
            _getStation = getStation;
        }

        public async Task<IEnumerable<StationModel>> GetAllStations()
        {
            return await _getStation.ReturnStationBasedOnTag();
        }
    }
}
