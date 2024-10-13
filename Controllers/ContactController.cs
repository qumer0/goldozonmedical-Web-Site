using Microsoft.AspNetCore.Mvc;

namespace goldozonmedical_Web_Site.Controllers
{
public class ContactController : Controller
{

    public ActionResult Index()
    {
        var email = HttpContext.Session.GetString("email");

        if (email != null)
        {
            ViewBag.layout = "~/Views/Shared/_Layoutafterlogin.cshtml";
        }else
        {
            ViewBag.layout = "~/Views/Shared/_Layout.cshtml";
        } 
        return View();
    }
}

}