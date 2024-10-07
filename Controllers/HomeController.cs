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
            
            
            return View(sliderItems);
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