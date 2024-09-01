namespace Pagination.Demo.Models
{
    public class Car
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Brand { get; set; }
        public string Condition { get; set; }
        public DateTime DatePurchased { get; set; }
        public bool IsSold{ get; set; }
        public DateTime? DateSold { get; set; }
    }
}
