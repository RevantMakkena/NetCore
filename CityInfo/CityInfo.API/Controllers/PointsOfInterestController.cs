using CityInfo.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace CityInfo.API.Controllers
{
    [Route("api/cities/{cityId}/[controller]")]
    [ApiController]
    public class PointsOfInterestController : ControllerBase
    {
        [HttpGet]
        public ActionResult<IEnumerable<PointsOfInterestDto>> GetPointsOfInterest(int cityId)
        {
            var cities = CitiesDataSTore.current.Cities.FirstOrDefault(x => x.Id == cityId);
            return cities == null ? NotFound() : Ok(cities.PointsOfInterest);
        }

        [HttpGet("{pInterestId}")]
        public ActionResult<PointsOfInterestDto> GetPointOfInterest(int cityId, int pInterestId)
        {
            var city = CitiesDataSTore.current.Cities.FirstOrDefault(x => x.Id == cityId);
            if (city == null) 
                return NotFound();

            var pointsOfInt = city.PointsOfInterest.FirstOrDefault(x => x.Id == pInterestId);
            if (pointsOfInt == null)
                return NotFound();

            return Ok(pointsOfInt);            

        }

    }
}
