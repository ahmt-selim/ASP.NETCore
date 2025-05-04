using IocContainer.Services;
using IocContainer.Services.Interfaces;
using Microsoft.AspNetCore.Mvc;

namespace IocContainer.Controllers
{
    public class HomeController : Controller
    {
        ILog _log;
        public HomeController(ILog log)
        {
            _log = log;
        }
        public string Index([FromServices] ILog log)
        {
            _log.Info("Action bazlı talep yapılmıştır.");
            return "Service runninng";
        }
    }
}
