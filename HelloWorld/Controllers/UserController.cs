using HelloWorld.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            User user = new User();
            user.ID = 1;
            user.firstName = "Ahmet Selim";
            user.lastName = "Kısa";
            return View();
        }
        [NonAction]
        public string GetFullName(User user)
        {
            return user.firstName + " " + user.lastName;
            //Controller katmanında action haricinde metot yazılmaz.
            //Program burada yazılmış her metodu action olarak görür.
            //Yazılmak istenirse de bu metot [NonAction] olarak belrtilmelidir.
        }
    }
}
