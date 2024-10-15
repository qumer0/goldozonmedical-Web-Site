using Microsoft.AspNetCore.Mvc;
using goldozonmedical_Web_Site.Models;
using System.Collections.Generic;

public class BasketController : Controller
{
    private static List<ProductPrice> cart = new List<ProductPrice>();

    public ActionResult AddToCart(int id)
    {
        var product = GetProductById(id); 
        if (product != null)
        {
            cart.Add(product);
            ViewBag.CartItemCount = cart.Count; // Sepetteki ürün sayısını güncelle
        }
        return RedirectToAction("Index", "PriceProduct");
    }

    public ActionResult Buy(int id)
    {
        var product = GetProductById(id);
        if (product != null)
        {
            cart.Add(product);
            ViewBag.CartItemCount = cart.Count; // Sepetteki ürün sayısını güncelle
        }
        return RedirectToAction("Basket");
    }

    public ActionResult Basket()
    {
        ViewBag.CartItemCount = cart.Count; // Sepetteki ürün sayısını ViewBag'e atıyoruz
        return View(cart);
    }

    public ActionResult RemoveFromCart(int id)
    {
        var product = cart.Find(p => p.Id == id);
        if (product != null)
        {
            cart.Remove(product);
            ViewBag.CartItemCount = cart.Count; // Sepetteki ürün sayısını güncelle
        }
        return RedirectToAction("Basket");
    }

    private ProductPrice GetProductById(int id)
    {
        var products = new List<ProductPrice>
        {
            new ProductPrice { Id = 1, Name = "Ürün 1", ImageUrl = "~/img/maymun.jpg", Price = 100m, DiscountedPrice = 80m },
            new ProductPrice { Id = 2, Name = "Ürün 2", ImageUrl = "~/img/maymun.jpg", Price = 150m, DiscountedPrice = 120m },
            new ProductPrice { Id = 3, Name = "Ürün 3", ImageUrl = "~/img/maymun.jpg", Price = 200m, DiscountedPrice = 180m }
        };

        return products.Find(p => p.Id == id);
    }
}
