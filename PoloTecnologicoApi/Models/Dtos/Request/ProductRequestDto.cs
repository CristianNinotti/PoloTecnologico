namespace Web.Models.Dtos.Request
{
    public class ProductRequestDto
    {
        public string? Name { get; set; }
        public double Price { get; set; }
        public string? Category { get; set; }
        public int Quantity { get; set; }
    }
}
