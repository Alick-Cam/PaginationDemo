using CaseExtensions;
using Microsoft.AspNetCore.Mvc;
using Pagination.Demo.Data;
using Pagination.Demo.Helpers;
using Pagination.Demo.Models;
using Swashbuckle.AspNetCore.Annotations;
using System.Linq.Expressions;

namespace Pagination.Demo.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CarsController: ControllerBase
    {
        private readonly CarDbContext _carDbContext;

        public CarsController(CarDbContext carDbContext)
        {
            _carDbContext = carDbContext;
        }

        [HttpGet]
        [SwaggerOperation(Summary = "Retrieves cars in a paginated manner")]
        public ActionResult<IEnumerable<Car>> GetCars([FromQuery(Name = "page-number")] int pageNumber, [FromQuery(Name = "page-size")] int pageSize, [FromQuery] CarFilters filter)
        {
            if(pageSize <= 0)
            {
                return StatusCode(400, "Page Size needs to be greater than 0.");
            }

            if(pageNumber <= 0)
            {
                return StatusCode(400, "Page Number needs to be greater than 0.");
            }

            int skip = (pageNumber - 1) * pageSize;

            try
            {
                Expression<Func<Car, bool>> filterPredicate = c => true;

                if(filter.NameLikeString != null)
                {
                    filterPredicate = filterPredicate.And(c => c.Name.Trim().ToLower().Contains(filter.NameLikeString.Trim().ToLower()));
                }

                if(filter.IsSold != null)
                {
                    filterPredicate = filterPredicate.And(c => c.IsSold == filter.IsSold);
                }

                if(filter.SoldBeforeDate!= null)
                {
                    filterPredicate = filterPredicate.And(c => c.DateSold < filter.SoldBeforeDate);
                }

                if(filter.SoldAfterDate != null)
                {
                    filterPredicate = filterPredicate.And(c => c.DateSold > filter.SoldAfterDate);
                }

                if(filter.PurchasedBeforeDate != null)
                {
                    filterPredicate = filterPredicate.And(c => c.DatePurchased < filter.PurchasedBeforeDate);
                }

                if(filter.PurchasedAfterDate != null)
                {
                    filterPredicate = filterPredicate.And(c => c.DatePurchased > filter.PurchasedAfterDate);
                }

                if(filter.Condition != null)
                {
                    var conditions = new List<string>();

                    foreach(var condition in filter.Condition)
                    {
                        conditions.Add(condition.ToTrainCase().Replace("-", " ").Trim().ToLower());
                    }
                    
                    filterPredicate = filterPredicate.And(c => conditions.Contains(c.Condition.Trim().ToLower()));

                }

                var cars = _carDbContext.Set<Car>()
                    .Skip(skip)
                    .Take(pageSize)
                    .Where(filterPredicate)
                    .OrderBy(c => c.DatePurchased)
                    .ToList();

                return cars;

            }
            catch(Exception e)
            {
                return StatusCode(500, e.Message);
            }
        }
    }
}
