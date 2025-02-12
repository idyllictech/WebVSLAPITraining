namespace WebVslApiTraining.Features.Domain
{
    public class Product
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public decimal Price { get; set; }
        public Category? Category { get; set; }
        public int CategoryId { get; set; }
    }
}
