using CaseExtensions;
using Pagination.Demo.Helpers;
using Swashbuckle.AspNetCore.Annotations;
using System.ComponentModel.DataAnnotations;

namespace Pagination.Demo
{
    public class CarFilters: IValidatableObject
    {
        public bool? IsSold { get; set; }
        public string? NameLikeString { get; set; }
        public DateTime? SoldBeforeDate { get; set; }
        public DateTime? SoldAfterDate { get; set; }
        public DateTime? PurchasedBeforeDate { get; set; }
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
