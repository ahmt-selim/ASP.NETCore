using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HelloWorld.Controllers
{
    public class HomeController : Controller //Controller classından miras alınmış
    {
        public string Index()
        {
            return "Uygulama Çalışıyor";
        }
        public string Test()
        {
            return "Bu test actionudur.";
        }
        public IActionResult Selamla()
        {
            ViewResult result = View();
            return result;
        }
        public IActionResult Selamla2()
        {
            ViewResult result = View("Test2");
            return result;
        }
    }
}
