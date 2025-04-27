using Interfaces.Models;
using Microsoft.AspNetCore.Mvc;

namespace Interfaces.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            MsSqlOperations mssql =new MsSqlOperations();
            mssql.Connection();

            ISqlOperations sql = new MsSqlOperations();
            sql.Connection();

            ISqlOperations mysql = new MySqlOperation();
            mysql.Connection();

            return View();
        }
    }
}
