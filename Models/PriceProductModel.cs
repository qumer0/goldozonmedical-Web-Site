namespace goldozonmedical_Web_Site.Models{
    
    public class ProductPrice
{
    public int Id { get; set; }
    public string? Name { get; set; }
    public string? ImageUrl { get; set; }
    public decimal Price { get; set; }
    public decimal DiscountedPrice { get; set; }
        public int Quantity { get; internal set; }
    }
}

