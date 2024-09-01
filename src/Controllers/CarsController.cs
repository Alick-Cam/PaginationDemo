using Microsoft.AspNetCore.Mvc;
using Pagination.Demo.Data;
using Pagination.Demo.Models;

namespace Pagination.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController: ControllerBase
    {
        private readonly ILogger<CarsController> _logger;
        private readonly CarDbContext _carDbContext;

        public CarsController(ILogger<CarsController> logger, CarDbContext carDbContext)
        {
            _logger = logger;
            _carDbContext = carDbContext;
        }

        [HttpGet("get-cars")]
        public ActionResult<IEnumerable<Car>> GetCars([FromQuery(Name = "page-number")] int pageNumber, [FromQuery(Name = "page-size")] int pageSize, [FromQuery] CarFilters filter)
        {

            throw new NotImplementedException();
        }
    }
}
