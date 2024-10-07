using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpPost]
    public ActionResult Login(string email, string password)
    {
        // Login logic here (e.g., authenticate user)
        if (/*login successful*/true)
        {
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Add error message to ViewBag or TempData
            return RedirectToAction("Index", "Home");
        }
    }

    [HttpPost]
    public ActionResult Register(string name, string surname, string email, string password, string phone, string tckn, string referral)
    {
        // Registration logic here (e.g., save user data)
        if (/*registration successful*/ true)
        {
            return RedirectToAction("Index", "Home");
        }
        else
        {
            // Add error message to ViewBag or TempData
            return RedirectToAction("Index", "Home");
        }
    }
}
