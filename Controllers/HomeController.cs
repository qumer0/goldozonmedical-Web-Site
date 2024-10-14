using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using goldozonmedical_Web_Site.Models;


namespace goldozonmedical_Web_Site.Controllers
{
public class HomeController : Controller
{
    private readonly ILogger<HomeController> _logger;

    public HomeController(ILogger<HomeController> logger)
    {
        _logger = logger;
    }

    public IActionResult Index()
    {
        var sliderItems = new List<SliderItem>
            {
                
                new SliderItem { ImageUrl = "~/img/slider1.png", Caption = "Slide 1" },
                new SliderItem { ImageUrl = "~/img/slider2.png", Caption = "Slide 2" },
                new SliderItem { ImageUrl = "~/img/slider3.png", Caption = "Slide 3" } 
            };
            
            ViewBag.SliderItems=sliderItems;//hepsini toparladık. 

             var products = new List<Product>
            {
                new Product { Id = 1, Name = "Ürün 1", Description = "Ürün 1 açıklaması", ImageUrl = "~/img/maymun.jpg"},
                new Product { Id = 2, Name = "Ürün 2", Description = "Ürün 2 açıklaması", ImageUrl = "~/img/maymun.jpg"},
                new Product { Id = 3, Name = "Ürün 3", Description = "Ürün 3 açıklaması", ImageUrl = "~/img/maymun.jpg"}
            };

            var email = HttpContext.Session.GetString("email");

            if (email != null)
            {
            ViewBag.layout = "~/Views/Shared/_Layoutafterlogin.cshtml";
            }else
            {
            ViewBag.layout = "~/Views/Shared/_Layout.cshtml";
            } 
            return View(products);// ürünler view a gelsin.
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel{ RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
}