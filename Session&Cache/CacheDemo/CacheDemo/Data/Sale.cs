namespace CacheDemo.Data
{
    public class Sale
    {
        public int Id { get; set; }

        public decimal Discount { get; set; }

        public int CarId { get; set; }
        public Car Car { get; set; }
    }
}
