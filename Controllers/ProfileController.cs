using Microsoft.AspNetCore.Mvc;

public class ProfileController : Controller
{
    public IActionResult Index()
    {
        return View("Profile"); 
    }
}
