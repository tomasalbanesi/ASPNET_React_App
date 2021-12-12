using Microsoft.AspNetCore.Mvc;
using Trips.Data.Models;
using Trips.Data.Services;

namespace Trips.Controllers
{
    [Route("api/[controller]")]
    public class TripsController : Controller
    {
        private ITripService _tripService;
        public TripsController(ITripService tripService)
        {
            this._tripService = tripService;
        }

        [HttpGet("[action]")]
        public IActionResult GetTrips()
        {
            var allTrips = _tripService.GetAllTrips();

            return Ok(allTrips);
        }

        [HttpGet("SingleTrip/{id}")]
        public IActionResult GetTripById(int id)
        {
            var trip = _tripService.GetTripById(id);
            return Ok(trip);
        }


        [HttpPost("AddTrip")]
        public IActionResult AddTrip([FromBody]Trip trip)
        {
            if(trip != null)
            {
                _tripService.AddTrip(trip);
            }

            return Ok();
        }

        [HttpPut("UpdateTrip/{id}")]
        public IActionResult UpdateTrip(int id, [FromBody]Trip trip)
        {
            _tripService.UpdateTrip(id, trip);  
            return Ok(trip);
        }

        [HttpDelete("DeleteTrip/{id}")]
        public IActionResult DeleteTrip(int id)
        {
            _tripService.DeleteTrip(id);
            return Ok();
        }
    }
}
