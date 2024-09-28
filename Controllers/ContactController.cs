using Microsoft.AspNetCore.Mvc;

namespace goldozonmedical_Web_Site.Controllers
{
public class ContactController : Controller
{
    public IActionResult Index()
    {
         return View();
    }
    public ActionResult Contact()
    {
        return View();
    }
}

}