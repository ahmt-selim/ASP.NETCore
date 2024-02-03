using Microsoft.AspNetCore.Mvc;
using PassingData.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PassingData.Controllers
{
    public class UserController : Controller
    {
        List<User> users = new List<User>()
            {
                new User(){firstName="Sefa",lastName="Başdemir"},
                new User(){firstName="Beyza",lastName="Kısa"},
                new User(){firstName="Gülhan",lastName="Kısa"}
            };
        public IActionResult UseViewBag()
        {
            ViewBag.UserName = "Ahmet Selim"; // Burada verilen isim(UserName) önemli değildir. Bu isim ile viewde çağırma işlemi yapılır.
            User user = new User();
            user.firstName = "Ahmet Selim";
            user.lastName = "Kısa";
            ViewBag.User = user; 

            
            ViewBag.users = users;
            return View();
        }
        public IActionResult UseViewData() //ViewData key value mantığında çalışır
        {
            ViewData["UserName"] = "Berkay"; //ViewData içindeki nesneler obje mantığında tutulduğu için kullanılırken stringe dönüştürülür.
            User user = new User();
            user.firstName = "Tolga";
            user.lastName = "Say";
            ViewData["User"] = user;
            ViewData["Users"] = users;

            return View();
        }
        public IActionResult UseTempData()
        {
            TempData["name"] = "Ahmet Selim";
            return RedirectToAction("TempDataTest");//Kendi view ini göstermeden direkt TemDataTest sayfasına yönlendirme işlemi yapar.
        }
        public IActionResult TempDataTest()
        {
            TempData.Keep("name");//TempData key'ini uzatma yöntemi.
            //Normalde TemData["name"] UseTempData() da doldurulup burada 1 kere kullanıldıktan sonra silinir ama bu yöntemle kullanımını uzatmış oluruz.
            string userName = TempData["name"].ToString();
            //TempData oluşturulduğu yerde kullanılmadan başka Actionda çağrıldığında hata verir.
            //ve kullanıldığı actionda 1 kere kullanılır. 2. kez çağrıldığında hata verir.
            return View();
        }
    }
}
