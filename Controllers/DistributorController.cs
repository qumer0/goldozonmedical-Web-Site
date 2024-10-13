using Microsoft.AspNetCore.Mvc;
using goldozonmedical_Web_Site.Models;
using System.Collections.Generic;
using System.Linq;

namespace goldozonmedical_Web_Site.Controllers
{
    public class DistributorController : Controller
    {
        public IActionResult Index(string city, string district)
        {
            var cities = new List<City>
            {
                new City { Id = 1, Name = "Ankara" },
                new City { Id = 2, Name = "Istanbul" },
                new City { Id = 3, Name = "Izmir" }
            };

            var districts = new List<District>
            {
                new District { Id = 1, Name = "Çankaya", CityId = 1 },
                new District { Id = 2, Name = "Keçiören", CityId = 1 },
                new District { Id = 3, Name = "Kadıköy", CityId = 2 },
                new District { Id = 4, Name = "Üsküdar", CityId = 2 },
                new District { Id = 5, Name = "Konak", CityId = 3 }
            };

            var distributors = new List<Distributors>
            {
                new Distributors { city = "Ankara", district = "Çankaya", adress = "Adres 1", tel = "05555555555", name = "Ömer Doğan" },
                new Distributors { city = "Ankara", district = "Keçiören", adress = "Adres 2", tel = "05555555556", name = "Ahmet Yılmaz" },
                new Distributors { city = "Istanbul", district = "Kadıköy", adress = "Adres 3", tel = "05555555557", name = "Mehmet Demir" },
                new Distributors { city = "Izmir", district = "Konak", adress = "Adres 4", tel = "05555555558", name = "Ayşe Çelik" }
            };

            // Filtreleme işlemi
            if (!string.IsNullOrEmpty(city))
            {
                distributors = distributors.Where(d => d.city == city).ToList();
            }
            if (!string.IsNullOrEmpty(district))
            {
                distributors = distributors.Where(d => d.district == district).ToList();
            }

            // Şehir ve ilçe seçeneklerini ViewBag ile View'a gönderiyoruz
            ViewBag.Cities = cities;
            ViewBag.Districts = !string.IsNullOrEmpty(city) ? districts.Where(d => d.CityId == cities.First(c => c.Name == city).Id).ToList() : new List<District>();


            var email = HttpContext.Session.GetString("email");

            if (email != null)
            {
                ViewBag.layout = "~/Views/Shared/_Layoutafterlogin.cshtml";
            }else
            {
                ViewBag.layout = "~/Views/Shared/_Layout.cshtml";
            }  

            return View(distributors);
        }

        // İl seçildiğinde ilçeleri dönecek action
        public JsonResult GetDistricts(string cityName)
        {
            var cities = new List<City>
            {
                new City { Id = 1, Name = "Ankara" },
                new City { Id = 2, Name = "Istanbul" },
                new City { Id = 3, Name = "Izmir" }
            };

            var districts = new List<District>
            {
                new District { Id = 1, Name = "Çankaya", CityId = 1 },
                new District { Id = 2, Name = "Keçiören", CityId = 1 },
                new District { Id = 3, Name = "Kadıköy", CityId = 2 },
                new District { Id = 4, Name = "Üsküdar", CityId = 2 },
                new District { Id = 5, Name = "Konak", CityId = 3 }
            };

            var selectedCity = cities.FirstOrDefault(c => c.Name == cityName);
            var filteredDistricts = selectedCity != null ? districts.Where(d => d.CityId == selectedCity.Id).ToList() : new List<District>();

            return Json(filteredDistricts);
        }
    }
}
