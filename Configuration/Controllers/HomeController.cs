using Configuration.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Configuration.Controllers
{
    public class HomeController : Controller
    {
        readonly IConfiguration _configuration;
        public HomeController(IConfiguration configuration)
        {
            _configuration = configuration;
        }
        public IActionResult Index()
        {
            string email = _configuration["Email"];
            string name = _configuration["User:Name"];//User'ın aldından Name'i getirir
            string password = _configuration.GetSection("User:LastName").Value;
            User user = _configuration.GetSection("User").Get(typeof(User)) as User;
            return View();
        }
    }
}
