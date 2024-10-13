using Microsoft.AspNetCore.Mvc;
using goldozonmedical_Web_Site.Models;
public class PriceProductController : Controller
{
    public ActionResult Index()
    {
        // Ürün listesini oluşturuyoruz
        var products = new List<ProductPrice>
        {
            new ProductPrice { Id = 1, Name = "Ürün 1", ImageUrl = "~/img/maymun.jpg", Price = 100m, DiscountedPrice = 80m },
            new ProductPrice { Id = 2, Name = "Ürün 2", ImageUrl = "~/img/maymun.jpg", Price = 150m, DiscountedPrice = 120m },
            new ProductPrice { Id = 3, Name = "Ürün 3", ImageUrl = "~/img/maymun.jpg", Price = 200m, DiscountedPrice = 180m }
        };

                // Kullanıcının giriş yapıp yapmadığını kontrol et
            // Retrieve the username from session
        var email = HttpContext.Session.GetString("email");

        if (email == null)
        {
            return RedirectToAction("Index", "Home");
        }        
       
        return View(products);
    }
}
