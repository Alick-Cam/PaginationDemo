namespace Pagination.Demo
{
    public class CarFilters
    {
        public bool? IsSold { get; set; }
        public string? NameLikeString { get; set; }
        public DateTime? SoldBeforeDate { get; set; }
        public DateTime? SoldAfterDate { get; set; }
        public DateTime? PurchasedBeforeDate { get; set; }
        public DateTime? PurchasedAfterDate { get; set; }
    }
}
