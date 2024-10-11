using Microsoft.AspNetCore.Mvc;

public class AccountController : Controller
{
    [HttpPost]
    public ActionResult Login(string email, string password)
    {
        // Login logic (örneğin: kullanıcıyı doğrulama)
        if (/*login successful*/ true)
        {
            // Kullanıcı bilgilerini session'da tut
            HttpContext.Session.SetString("UserLoggedIn", "true");
            HttpContext.Session.SetString("UserEmail", email);

            return RedirectToAction("Index", "Home");
        }
        else
        {
            TempData["ErrorMessage"] = "Giriş bilgileri hatalı.";
            return RedirectToAction("Index", "Home");
        }
    }

    [HttpPost]
    public ActionResult Register(string name, string surname, string email, string password, string phone, string tckn, string referral)
    {
        // Registration logic (örneğin: kullanıcıyı kaydetme)
        if (/*registration successful*/ true)
        {
            HttpContext.Session.SetString("UserLoggedIn", "true");
            HttpContext.Session.SetString("UserEmail", email);

            return RedirectToAction("Index", "Home");
        }
        else
        {
            TempData["ErrorMessage"] = "Kayıt işlemi başarısız.";
            return RedirectToAction("Index", "Home");
        }
    }

    public ActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index", "Home");
    }
}
