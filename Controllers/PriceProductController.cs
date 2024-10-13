using Microsoft.AspNetCore.Mvc;
using goldozonmedical_Web_Site.Models;
public class PriceProductController : Controller
{
    public ActionResult Index()
    {
        // Ürün listesini oluşturuyoruz
        var products = new List<ProductPrice>
        {
            new ProductPrice { Id = 1, Name = "Ürün 1", ImageUrl = "/images/product1.jpg", Price = 100m, DiscountedPrice = 80m },
            new ProductPrice { Id = 2, Name = "Ürün 2", ImageUrl = "/images/product2.jpg", Price = 150m, DiscountedPrice = 120m },
            new ProductPrice { Id = 3, Name = "Ürün 3", ImageUrl = "/images/product3.jpg", Price = 200m, DiscountedPrice = 180m }
        };

                // Kullanıcının giriş yapıp yapmadığını kontrol et
       
        return View(products);
    }
}
