using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Vue2Spa.Providers;

namespace Vue2Spa.Controllers
{
    public class StationController : Controller
    {
        private readonly IStationService _stationService;

        public StationController(IStationService stationService)
        {
            _stationService = stationService;
        }


        [HttpGet]
        [Route("api/[controller]/[action]")]
        public async Task<IActionResult> GetAllStations([FromQuery(Name = "from")] int from = 0, [FromQuery(Name = "to")] int to = 4)
        {
            //System.Threading.Thread.Sleep(500); // Fake latency
            var quantity = to - from;

            // We should also avoid going too far in the list.
            if (quantity <= 0)
            {
                return BadRequest("You cannot have the 'to' parameter higher than 'from' parameter.");
            }
            else if (from < 0)
            {
                return BadRequest("You cannot go in the negative with the 'from' parameter");
            }

            var allStations = await _stationService.GetAllStations();
            var result = new
            {
                Total = allStations.Count(),
                Stations = allStations.Skip(from).Take(quantity).ToArray()
            };

            return Ok(result);
        }

//        [HttpGet]
//        [Route("api/[controller]/[action]")]
//        public async Task<IActionResult> GetAllStations()
//        {
//            var result = await _stationService.GetAllStations();
//            return Ok(result);
//        }
    }
}
