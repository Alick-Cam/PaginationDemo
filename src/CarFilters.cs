using CaseExtensions;
using Pagination.Demo.Helpers;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Pagination.Demo
{
    public class CarFilters: IValidatableObject
    {
        public string? NameLikeString { get; set; }

        [SwaggerSchema(Description = "17 cars sold in total. 100 cars in the database.")]
        public bool? IsSold { get; set; }

        [SwaggerSchema(Description = "Min DateSold is 2023-07-19T00:00:00Z")]
        public DateTime? SoldBeforeDate { get; set; }

        [SwaggerSchema(Description = "Max DateSold is 2023-08-21T00:00:00Z")]
        public DateTime? SoldAfterDate { get; set; }

        [SwaggerSchema(Description = "Min DatePurchased is 2018-04-21T00:00:00Z")]
        public DateTime? PurchasedBeforeDate { get; set; }

        [SwaggerSchema(Description = "Max DatePurchased is 2023-07-09T00:00:00Z")]
        public DateTime? PurchasedAfterDate { get; set; }

        [SwaggerSchema(Description = "The condition of the car. Possible values: New, Like New, Used, Mint.")]
        public string[]? Condition { get; set; }

        public IEnumerable<ValidationResult> Validate(ValidationContext validationContext)
        {
            if(Condition != null)
            {
                foreach(var condition in Condition)
                {
                    var success = Enum.TryParse<CarConditionKind>(condition.ToTrainCase().Replace("-", "").Trim(), false, out _);
                    if (!success)
                        yield return new ValidationResult($"{condition} is invalid.");
                }
            }
        }
    }
}
